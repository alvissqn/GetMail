using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;
using System.IO;
namespace Getmail
{
    public partial class Form1 : Form
    {
        public MailClient oClient = new MailClient("TEAM BEAN 2014-00666-a8fa1baf7e92e8e38c737232cd1a81ff");
        public MailServer oServer;
        string curpath = Directory.GetCurrentDirectory();
        string mailbox;
        public Form1()
        {
            InitializeComponent();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.connect();           
        }

        private void btnGetMail_Click(object sender, EventArgs e)
        {
            txtTrangthai.Text = "Đang Get Mail....";
            mailbox = String.Format("{0}\\inbox", curpath);
            try
            {
                oClient.Connect(oServer);
                
                MailInfo[] infos = oClient.GetMailInfos();
                for (int i = 0; i < 5; i++)
                {
                    MailInfo info = infos[i];
                   /* Console.WriteLine("Index: {0}; Size: {1}; UIDL: {2}",
                        info.Index, info.Size, info.UIDL);*/

                    // Download email from GMail IMAP4 server
                    Mail oMail = oClient.GetMail(info);
                    

                  /*  Console.WriteLine("From: {0}", oMail.From.ToString());
                    Console.WriteLine("Subject: {0}\r\n", oMail.Subject);
                    Console.WriteLine("Body Text: {0}\r\n", oMail.TextBody);
                  */

                    ListViewItem lstinfo = new ListViewItem();
                    lstinfo.Text = oMail.Subject;
                    lstEmail.Items.Add(lstinfo);

                    // Generate an email file name based on date time.
                    System.DateTime d = System.DateTime.Now;
                    System.Globalization.CultureInfo cur = new
                        System.Globalization.CultureInfo("en-US");
                    string sdate = d.ToString("yyyyMMddHHmmss", cur);
                    string fileName = String.Format("{0}\\{1}{2}{3}.eml",
                        mailbox, sdate, d.Millisecond.ToString("d3"), i);

                    // Save email to local disk
                    oMail.SaveAs(fileName, true);

                    // Mark email as deleted in GMail account.
                    //oClient.Delete(info);
                    oClient.MarkAsRead(info, true);
                }
                txtTrangthai.Text = "Get mail Thành Công...";
                // Quit and pure emails marked as deleted from Gmail IMAP4 server.
                oClient.Quit();
            }
            catch (Exception ep)
            {
                txtTrangthai.Text = ep.Message;
            }
        }

        private void lstEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListView.SelectedListViewItemCollection items;
            items = lstEmail.SelectedItems;

            try
            {
                oClient.Connect(oServer);
                MailInfo[] infos = oClient.GetMailInfos();
                if (items.Count > 0)
                {
                    int index = lstEmail.SelectedItems[0].Index;
                   // MessageBox.Show("" + items[0].Text + " vi tri: " + index);
                    MailInfo info = infos[index];
                    Mail oMail = oClient.GetMail(info);
                    rtxtbody.Text = oMail.HtmlBody;
                }
            }
            catch { }
            
           
        }
        private void connect()
        {
            // Gmail IMAP4 server is "imap.gmail.com"
             oServer = new MailServer("imap.gmail.com","nasic.vn@gmail.com", "jingerqn@1234", ServerProtocol.Imap4);
            //oServer = new MailServer("imap.mail.yahoo.com", "thuanthienkiemqn@yahoo.com.vn", "Jingerqn@147159", ServerProtocol.Imap4);

            // Set SSL connection,
            oServer.SSLConnection = true;

            // Set 993 IMAP4 port
            oServer.Port = 993;
            try
            {
                oClient.Connect(oServer);
                if (oClient.Connected == true)
                    txtTrangthai.Text = "Kết Nối Thành Công";
                //Console.WriteLine("Ket noi thanh cong");
            }
            catch
            {
                txtTrangthai.Text = "Ket Noi khong thanh cong";
            }
        }
    }
}
