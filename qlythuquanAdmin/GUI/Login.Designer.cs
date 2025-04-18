namespace qlythuquanAdmin.UI
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAcc = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            ghinho = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 57);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 141);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(181, 196);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu:";
            // 
            // txtAcc
            // 
            txtAcc.Location = new Point(284, 141);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(224, 23);
            txtAcc.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(284, 194);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(224, 23);
            txtPwd.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(332, 308);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += this.btnLogin_click;
            // 
            // ghinho
            // 
            ghinho.AutoSize = true;
            ghinho.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ghinho.Location = new Point(208, 254);
            ghinho.Name = "ghinho";
            ghinho.Size = new Size(135, 21);
            ghinho.TabIndex = 6;
            ghinho.Text = "ghi nhớ tài khoản";
            ghinho.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ghinho);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtAcc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAcc;
        private TextBox txtPwd;
        private Button btnLogin;
        private CheckBox ghinho;
    }
}