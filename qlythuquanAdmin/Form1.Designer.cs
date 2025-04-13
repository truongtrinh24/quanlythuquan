namespace qlythuquanAdmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelMenu = new Panel();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnViPham = new Button();
            btnThietBi = new Button();
            btnThanhVien = new Button();
            logopicture = new PictureBox();
            PanelContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logopicture).BeginInit();
            PanelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = SystemColors.ActiveCaption;
            PanelMenu.Controls.Add(btnDangXuat);
            PanelMenu.Controls.Add(btnThongKe);
            PanelMenu.Controls.Add(btnViPham);
            PanelMenu.Controls.Add(btnThietBi);
            PanelMenu.Controls.Add(btnThanhVien);
            PanelMenu.Controls.Add(logopicture);
            PanelMenu.Location = new Point(1, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(224, 636);
            PanelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = SystemColors.ButtonFace;
            btnDangXuat.Location = new Point(0, 564);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(222, 72);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Thống kê";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += button5_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(0, 388);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(222, 72);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnViPham
            // 
            btnViPham.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViPham.Location = new Point(0, 310);
            btnViPham.Name = "btnViPham";
            btnViPham.Size = new Size(222, 72);
            btnViPham.TabIndex = 3;
            btnViPham.Text = "Vi phạm";
            btnViPham.UseVisualStyleBackColor = true;
            btnViPham.Click += btnViPham_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThietBi.Location = new Point(0, 232);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(222, 72);
            btnThietBi.TabIndex = 2;
            btnThietBi.Text = "Thiết bị";
            btnThietBi.UseVisualStyleBackColor = true;
            btnThietBi.Click += btnThietBi_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhVien.Location = new Point(0, 154);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(222, 72);
            btnThanhVien.TabIndex = 1;
            btnThanhVien.Text = "Thành viên";
            btnThanhVien.UseVisualStyleBackColor = true;
            btnThanhVien.Click += bthThanhVien_Click;
            // 
            // logopicture
            // 
            logopicture.Image = Properties.Resources.logo;
            logopicture.Location = new Point(0, 0);
            logopicture.Name = "logopicture";
            logopicture.Size = new Size(222, 110);
            logopicture.SizeMode = PictureBoxSizeMode.StretchImage;
            logopicture.TabIndex = 0;
            logopicture.TabStop = false;
            // 
            // PanelContent
            // 
            PanelContent.BackColor = SystemColors.ControlLight;
            PanelContent.Controls.Add(label1);
            PanelContent.Controls.Add(pictureBox1);
            PanelContent.Location = new Point(223, 0);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(838, 636);
            PanelContent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 134);
            label1.Name = "label1";
            label1.Size = new Size(389, 25);
            label1.TabIndex = 1;
            label1.Text = "Xin chào đến với hệ thống quản lý thư quán";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(207, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 637);
            Controls.Add(PanelContent);
            Controls.Add(PanelMenu);
            Name = "Form1";
            Text = "Form1";
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logopicture).EndInit();
            PanelContent.ResumeLayout(false);
            PanelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Button btnThanhVien;
        private PictureBox logopicture;
        private Panel PanelContent;
        private Button btnDangXuat;
        private Button btnThongKe;
        private Button btnViPham;
        private Button btnThietBi;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
