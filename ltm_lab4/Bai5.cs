using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ltm_lab4
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            Load(page);
        }

        private string url = "https://reqres.in/api/users";
        int page = 1;
        

        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }

        class UserPagination
        {
            [JsonPropertyName("page")]
            public int Page { get; set; }
            [JsonPropertyName("total")]
            public int Total { get; set; }
            [JsonPropertyName("per_page")]
            public int PerPage { get; set; }
            [JsonPropertyName("total_pages")]
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }

        private string GetHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }


        UserPagination info;
        //label_page = Pafe; label_usr_page = user/page; label_tol_page = total page; label_tol_user = total user
        void Load(int numpage)
        {
            string api = $"{url}?page={numpage}";
            string html = GetHTML(api);
            info = JsonSerializer.Deserialize<UserPagination>(html);
            label_page.Text = "Page: " + info.Page.ToString(); 
            label_usr_page.Text = "User/ Page: " + info.PerPage.ToString();
            label_tol_user.Text = "Total Users: " +  info.Total.ToString();
            label_tol_page.Text = "Total Page: " + info.TotalPages.ToString();
            flowLayoutPanel1.Controls.Clear();
            int i = 1;

            foreach (User user in info.Data)
            {
                Panel panel = new Panel();
                panel.Width = flowLayoutPanel1.ClientSize.Width;
                panel.Height = 120;

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 2;
                tableLayoutPanel.Width = panel.ClientSize.Width;
                tableLayoutPanel.Height = panel.ClientSize.Height;
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

                Label mail = new Label();
                mail.Text = user.Email;
                mail.Dock = DockStyle.Fill;
                tableLayoutPanel.Controls.Add(mail,0,1);
                Label name = new Label();
                name.Text = user.FirstName + " " + user.LastName;
                name.Dock = DockStyle.Fill;
                tableLayoutPanel.Controls.Add(name,0,0);
                
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Load(user.Avatar);
                tableLayoutPanel.Controls.Add(pictureBox, 1, 0);
                tableLayoutPanel.SetRowSpan(pictureBox, 2);
                tableLayoutPanel.Dock = DockStyle.Fill;


                tableLayoutPanel.Height = pictureBox.Height;
                panel.Controls.Add(tableLayoutPanel);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                Load(page);
            }
            else MessageBox.Show("Không thể back, đây là trang 1");
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (page != 2)
            {
                page++;
                Load(page);
            }
            else MessageBox.Show("Không thể next, đây là trang cuối");
        }
    }
}

