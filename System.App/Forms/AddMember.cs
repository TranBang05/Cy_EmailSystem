using System;
using System.App.UserControls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.App.Forms
{
    public partial class AddMember : Form
    {
        public string MemberName => txt_name.Text;
        public string Email => txt_email.Text;
        public string Phone => txt_phone.Text;
        public string Position => txt_position.Text;
        private UC_Employee _employee;
        public AddMember(UC_Employee employee)
        {
            _employee = employee;
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MemberName) || string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
