using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltm_lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        //textbox1 = url;
        private string GetHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e) //button Xem noi dung
        {
            webView21.Source = new Uri(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e) //button Download HTML 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            WebClient webClient = new WebClient();
            Stream response = webClient.OpenRead(textBox1.Text);
            webClient.DownloadFile(textBox1.Text, saveFileDialog.FileName);
        }

        private void button3_Click(object sender, EventArgs e) //button xem source
        {
            var html = GetHTML(textBox1.Text);

            Bai4_ViewSource viewSource = new Bai4_ViewSource(html);
            viewSource.Show();
        }
    }
}
