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
using static System.Net.WebRequestMethods;

namespace ltm_lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            //textBox1.Text = "http://www.contoso.com/PostAccepter.aspx";
        }

        //textbox1 = url; textbox2 = content
        private void button1_Click(object sender, EventArgs e)// button post
        {
            try
            {
                string url = textBox1.Text;
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";

                string post_data = textBox2.Text;
                byte[] data = Encoding.UTF8.GetBytes(post_data);

                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();

                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                richTextBox1.Text = responseFromServer;
                response.Close();
                //dataStream.Close();
                //reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }
    }
}
