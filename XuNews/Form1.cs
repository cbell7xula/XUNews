using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace XuNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You clicked the button!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello";
            var getHtmlWeb = new HtmlWeb();
            var document = getHtmlWeb.Load("http://www.xula.edu/mediarelations/ebulletin.php");
            var aTags = document.DocumentNode.SelectNodes("//strong");
            int counter = 1;
            if (aTags != null)
            {
                foreach (var aTag in aTags) //dsda
                {
                    label1.Text += counter + ". " + aTag.InnerHtml +  "\t" + "<br />";
                    counter++;
                }
            }
        }
    }
}
