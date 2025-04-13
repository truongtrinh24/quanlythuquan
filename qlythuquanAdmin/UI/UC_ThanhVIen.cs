using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlythuquanAdmin.UI
{
    public partial class UC_ThanhVIen : UserControl
    {
        public UC_ThanhVIen()
        {
            InitializeComponent();
        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 204);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "thành viên";
            label1.Click += label1_Click;
            // 
            // UC_ThanhVIen
            // 
            Controls.Add(label1);
            Name = "UC_ThanhVIen";
            Size = new Size(619, 498);
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
