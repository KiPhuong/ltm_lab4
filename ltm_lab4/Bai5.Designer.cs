namespace ltm_lab4
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_page = new System.Windows.Forms.Label();
            this.label_usr_page = new System.Windows.Forms.Label();
            this.label_tol_page = new System.Windows.Forms.Label();
            this.label_tol_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 362);
            this.panel1.TabIndex = 0;
            // 
            // label_page
            // 
            this.label_page.AutoSize = true;
            this.label_page.Location = new System.Drawing.Point(12, 10);
            this.label_page.Name = "label_page";
            this.label_page.Size = new System.Drawing.Size(46, 19);
            this.label_page.TabIndex = 1;
            this.label_page.Text = "Page: ";
            // 
            // label_usr_page
            // 
            this.label_usr_page.AutoSize = true;
            this.label_usr_page.Location = new System.Drawing.Point(12, 39);
            this.label_usr_page.Name = "label_usr_page";
            this.label_usr_page.Size = new System.Drawing.Size(83, 19);
            this.label_usr_page.TabIndex = 2;
            this.label_usr_page.Text = "User/ Page: ";
            // 
            // label_tol_page
            // 
            this.label_tol_page.AutoSize = true;
            this.label_tol_page.Location = new System.Drawing.Point(166, 10);
            this.label_tol_page.Name = "label_tol_page";
            this.label_tol_page.Size = new System.Drawing.Size(79, 19);
            this.label_tol_page.TabIndex = 3;
            this.label_tol_page.Text = "Total Page: ";
            // 
            // label_tol_user
            // 
            this.label_tol_user.AutoSize = true;
            this.label_tol_user.Location = new System.Drawing.Point(166, 39);
            this.label_tol_user.Name = "label_tol_user";
            this.label_tol_user.Size = new System.Drawing.Size(83, 19);
            this.label_tol_user.TabIndex = 4;
            this.label_tol_user.Text = "Total Users: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "User List";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(349, 22);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(40, 26);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "<<";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(463, 22);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(40, 26);
            this.button_next.TabIndex = 7;
            this.button_next.Text = ">>";
            this.button_next.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 447);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_tol_user);
            this.Controls.Add(this.label_tol_page);
            this.Controls.Add(this.label_usr_page);
            this.Controls.Add(this.label_page);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label_page;
        private Label label_usr_page;
        private Label label_tol_page;
        private Label label_tol_user;
        private Label label1;
        private Button button_back;
        private Button button_next;
    }
}