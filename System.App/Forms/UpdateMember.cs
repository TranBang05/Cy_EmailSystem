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
using System.Xml.Linq;

namespace System.App.Forms
{
    public partial class UpdateMember : Form
    {
        private UC_Employee _employee;
        public string MemberName => txt_name.Text;
        public string Email => txt_email.Text;
        public string Phone => txt_phone.Text;
        public string Position => txt_position.Text;
        public UpdateMember(UC_Employee employee, string currentName, string currentEmail, string currentPhone)
        {
            _employee = employee;
            InitializeComponent();
            txt_name.Text = currentName;
            txt_email.Text = currentEmail;
            txt_phone.Text = currentPhone;
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

    }
}
