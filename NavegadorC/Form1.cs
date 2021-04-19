using System;
using System.Windows.Forms;

namespace NavegadorC
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate($"www.{Busqueda.Text}.com");
        }
        private void webBrowser1_StatusTextChanged(object sender, EventArgs e)
        {
            Estado2.Text = webBrowser1.StatusText;
        }
    }
}
