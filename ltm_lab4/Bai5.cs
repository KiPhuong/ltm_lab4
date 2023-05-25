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
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            panel1.Width = flowLayoutPanel.ClientSize.Width;
            string api = $"{url}?page={numpage}";
            string html = GetHTML(api);
            info = JsonSerializer.Deserialize<UserPagination>(html);
            label_page.Text += info.Page.ToString(); 
            label_usr_page.Text += info.PerPage.ToString();
            label_tol_user.Text += info.Total.ToString();
            label_tol_page.Text += info.TotalPages.ToString();
            flowLayoutPanel.Controls.Clear();
            int i = 1;

            foreach (User user in info.Data)
            {   
                Label mail = new Label();
                mail.Text = user.Email;
                tableLayoutPanel1.Controls.Add(mail,1,i);
                Label name = new Label();
                name.Text = user.FirstName + " " + user.LastName;
                tableLayoutPanel1.Controls.Add(name,1,i);
                

                PictureBox pictureBox = new PictureBox();
                pictureBox.Load(user.Avatar);
                tableLayoutPanel1.Controls.Add(pictureBox, 2, i);
                tableLayoutPanel1.SetRowSpan(pictureBox, 2);
                
                i++;
            }
        }

    }
}

