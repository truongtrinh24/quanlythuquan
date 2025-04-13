using qlythuquanAdmin.UI;
using qlythuquanAdmin.database;
namespace qlythuquanAdmin
{
    public partial class Form1 : Form
    {
        // Định nghĩa màu cho các trạng thái nút
        private Color normalColor = Color.White;
        private Color highlightColor = Color.LightSkyBlue;
        private Color textNormal = Color.Black;
        private Color textSelected = Color.DarkBlue;

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bthThanhVien_Click(object sender, EventArgs e)
        {
            ResetMenuButtons();
            btnThanhVien.BackColor = highlightColor;
            btnThanhVien.ForeColor = textSelected;

            PanelContent.Controls.Clear();
            UC_ThanhVIen uc = new UC_ThanhVIen();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            ResetMenuButtons();
            btnThietBi.BackColor = highlightColor;
            btnThietBi.ForeColor = textSelected;

            PanelContent.Controls.Clear();
            UC_ThietBi uc = new UC_ThietBi();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void btnViPham_Click(object sender, EventArgs e)
        {
            ResetMenuButtons();
            btnViPham.BackColor = highlightColor;
            btnViPham.ForeColor = textSelected;

            PanelContent.Controls.Clear();
            UC_ViPham uc = new UC_ViPham();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ResetMenuButtons();
            btnThongKe.BackColor = highlightColor;
            btnThongKe.ForeColor = textSelected;

            PanelContent.Controls.Clear();
            UC_ThongKe uc = new UC_ThongKe();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }
        private void ResetMenuButtons()
        {
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is Button btn && btn != btnDangXuat)
                {
                    btn.BackColor = normalColor;
                    btn.ForeColor = textNormal;
                }
            }
        }

        private void Form1_Load()
        {
            if (database.DatabaseHelper.TestConnection())
            {
                MessageBox.Show("✅ Kết nối cơ sở dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("❌ Kết nối thất bại. Vui lòng kiểm tra MySQL, phpMyAdmin hoặc chuỗi kết nối.");
            }
        }


    }
}
