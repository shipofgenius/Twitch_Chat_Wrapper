using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using HtmlAgilityPack;


namespace Twitch_Chat_Wrapper
{
    public partial class Form1 : Form
    {
        
        
         

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            setBits();
            timer.Enabled = true;
            timer.Interval = (Convert.ToInt32(txtFrequency.Text) * 1000);
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.AutoReset = true;
            Console.WriteLine("timer ticked");
            sendBits();
        }

        private void onDocLoad(object sender, EventArgs e)
        {
            //try
            //{
            //    string html = webTwitch.Document.Body.OuterHtml;
            //    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //    doc.LoadHtml(html);
            //    HtmlNode textarea = doc.DocumentNode.SelectSingleNode("//div//textarea");

            //    HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//div");

            //    Console.WriteLine(textarea.OriginalName);

            //    foreach (HtmlNode node in nodes)
            //    {
            //        Console.WriteLine(node.Name);
            //    }
            //    Console.WriteLine("Document Loaded");
            //    webTwitch.Stop();
            //}
            //catch
            //{
            //    Console.WriteLine("Document not ready");
            //}


        }
    
        private void element_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void btnGetStreamer_Click(object sender, EventArgs e)
        {
            string streamer = txtStreamer.Text;
            
            webTwitch.Navigate("https://twitch.tv/" + streamer + "/chat?popout=");

            //string html = webTwitch.Document.Body.OuterHtml;
            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(html);
            Console.WriteLine("Opening document");
 
            //webTwitch.Navigate("https://twitch.tv/" + streamer + "/chat?popout=");
            webTwitch.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(onDocLoad);
        }

        private void btnSetBits_Click(object sender, EventArgs e)
        {
            setBits();
        }

        private void setBits()
        {
            elements = webTwitch.Document.All;
            foreach (HtmlElement element in elements)
            {
                if (element.TagName.ToLower() == "textarea")
                {
                    int cheerCount = 0;
                    string cheer = "";
                    int bitAmount = Convert.ToInt32(txtBitAmount.Text);

                    while (cheerCount < bitAmount)
                    {
                        cheer += "Cheer1 ";
                        cheerCount++;
                    }

                    element.InnerText = cheer;
                    element.Focus();

                }
            }
        }

        private void sendBits()
        {
            Form1.ActiveForm.Focus();
            Form1.ActiveForm.ActiveControl = webTwitch;
            SendKeys.Send("{ENTER}");
            setBits();
        }

        private void btnThrowBits_Click(object sender, EventArgs e)
        {
            sendBits();
        }
    }
}

