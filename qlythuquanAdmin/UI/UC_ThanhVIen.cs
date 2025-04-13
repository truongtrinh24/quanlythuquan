using qlythuquanAdmin.database;
using qlythuquanAdmin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlythuquanAdmin.Model;

namespace qlythuquanAdmin.UI
{
    public partial class UC_ThanhVIen : UserControl
    {
        public UC_ThanhVIen()
        {
            InitializeComponent();
            this.Load += new EventHandler(UC_ThanhVien_Load);
            dgvThanhVien.RowPostPaint += dgvThanhVien_RowPostPaint;

        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            dgvThanhVien = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            bthAddThanhVien = new Button();
            btnEditThanhVien = new Button();
            bthDeleteThanhVien = new Button();
            inputExel = new Button();
            ((ISupportInitialize)dgvThanhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(310, 42);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thành viên";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dgvThanhVien
            // 
            dgvThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhVien.Dock = DockStyle.Bottom;
            dgvThanhVien.Location = new Point(0, 354);
            dgvThanhVien.Name = "dgvThanhVien";
            dgvThanhVien.ReadOnly = true;
            dgvThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhVien.Size = new Size(838, 282);
            dgvThanhVien.TabIndex = 1;
            dgvThanhVien.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(273, 105);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 23);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 3;
            label2.Text = "Tìm kiếm:";
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources._211817_search_strong_icon;
            btnSearch.Location = new Point(530, 98);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 35);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // bthAddThanhVien
            // 
            bthAddThanhVien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthAddThanhVien.Image = Properties.Resources._4115237_add_plus_icon;
            bthAddThanhVien.ImageAlign = ContentAlignment.MiddleLeft;
            bthAddThanhVien.Location = new Point(99, 217);
            bthAddThanhVien.Name = "bthAddThanhVien";
            bthAddThanhVien.Size = new Size(69, 44);
            bthAddThanhVien.TabIndex = 5;
            bthAddThanhVien.Text = "Thêm";
            bthAddThanhVien.TextAlign = ContentAlignment.MiddleRight;
            bthAddThanhVien.UseVisualStyleBackColor = true;
            bthAddThanhVien.Click += button1_Click;
            // 
            // btnEditThanhVien
            // 
            btnEditThanhVien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditThanhVien.Image = Properties.Resources._8666681_edit_icon;
            btnEditThanhVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditThanhVien.Location = new Point(273, 217);
            btnEditThanhVien.Name = "btnEditThanhVien";
            btnEditThanhVien.Size = new Size(69, 44);
            btnEditThanhVien.TabIndex = 6;
            btnEditThanhVien.Text = "Sửa";
            btnEditThanhVien.TextAlign = ContentAlignment.MiddleRight;
            btnEditThanhVien.UseVisualStyleBackColor = true;
            // 
            // bthDeleteThanhVien
            // 
            bthDeleteThanhVien.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bthDeleteThanhVien.Image = Properties.Resources._185090_delete_garbage_icon;
            bthDeleteThanhVien.ImageAlign = ContentAlignment.MiddleLeft;
            bthDeleteThanhVien.Location = new Point(449, 217);
            bthDeleteThanhVien.Name = "bthDeleteThanhVien";
            bthDeleteThanhVien.Size = new Size(69, 44);
            bthDeleteThanhVien.TabIndex = 7;
            bthDeleteThanhVien.Text = "Xóa";
            bthDeleteThanhVien.TextAlign = ContentAlignment.MiddleRight;
            bthDeleteThanhVien.UseVisualStyleBackColor = true;
            // 
            // inputExel
            // 
            inputExel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputExel.Image = Properties.Resources._7422413_exel_spreadsheet_sheets_table_icon__1_;
            inputExel.ImageAlign = ContentAlignment.MiddleLeft;
            inputExel.Location = new Point(619, 217);
            inputExel.Name = "inputExel";
            inputExel.Size = new Size(75, 44);
            inputExel.TabIndex = 8;
            inputExel.Text = "Nhập";
            inputExel.TextAlign = ContentAlignment.MiddleRight;
            inputExel.UseVisualStyleBackColor = true;
            // 
            // UC_ThanhVIen
            // 
            Controls.Add(inputExel);
            Controls.Add(bthDeleteThanhVien);
            Controls.Add(btnEditThanhVien);
            Controls.Add(bthAddThanhVien);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dgvThanhVien);
            Controls.Add(label1);
            Name = "UC_ThanhVIen";
            Size = new Size(838, 636);
            Load += UC_ThanhVIen_Load_1;
            ((ISupportInitialize)dgvThanhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataGridView dgvThanhVien;

        private void UC_ThanhVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT full_name, address, birthday, phone  FROM users WHERE role_id = 2";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvThanhVien.DataSource = dt;
            dgvThanhVien.AllowUserToAddRows = false;
            dgvThanhVien.RowHeadersVisible = false;

            if (!dgvThanhVien.Columns.Contains("stt"))
            {
                DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
                sttColumn.Name = "stt";
                sttColumn.HeaderText = "STT";
                sttColumn.Width = 50;
                dgvThanhVien.Columns.Insert(0, sttColumn);
            }

            dgvThanhVien.Columns["full_name"].HeaderText = "Họ tên";
            dgvThanhVien.Columns["address"].HeaderText = "Địa chỉ";
            dgvThanhVien.Columns["birthday"].HeaderText = "Ngày sinh";
            dgvThanhVien.Columns["phone"].HeaderText = "Số điện thoại";
        }
        private void dgvThanhVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvThanhVien.Rows[e.RowIndex].Cells["stt"].Value = (e.RowIndex + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            var result = UserService.SearchUsers(keyword);

            dgvThanhVien.DataSource = null;
            dgvThanhVien.DataSource = result;
            dgvThanhVien.Columns["FullName"].HeaderText = "Họ tên";
            dgvThanhVien.Columns["Address"].HeaderText = "Địa chỉ";
            dgvThanhVien.Columns["Birthday"].HeaderText = "Ngày sinh";
            dgvThanhVien.Columns["Phone"].HeaderText = "Số điện thoại";

        }


        private TextBox txtSearch;
        private Label label2;
        private Button btnSearch;
        private Button bthAddThanhVien;
        private Button btnEditThanhVien;
        private Button bthDeleteThanhVien;
        private Button inputExel;

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();  // Giả lập click nút "Tìm kiếm"
                e.Handled = true;
                e.SuppressKeyPress = true; // Chặn tiếng 'beep' khi nhấn Enter
            }
        }

        private void UC_ThanhVIen_Load_1(object sender, EventArgs e)
        {

        }
    }

}
