using System.App.Forms;
using System.BusinessAccess.Service;
using System.Data;
using System.Net.Mail;

namespace System.App.UserControls
{
    public partial class UC_ListMonth : UserControl
    {
        private readonly IEmployeeService _employeeService;
        private List<Attachment> emailAttachments = new List<Attachment>();
        public UC_ListMonth(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
            LoadData();
            Loaddate();
        }
        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_employee.Columns["Select"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = dgv_employee.Rows[e.RowIndex].Cells["Select"] as DataGridViewCheckBoxCell;
                bool isChecked = checkBoxCell.Value != null && (bool)checkBoxCell.Value;
                checkBoxCell.Value = !isChecked;
                dgv_employee.EndEdit();
            }
        }
        DataTable dt = new DataTable();
        private async Task LoadData()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Select", typeof(bool));
            foreach (var emp in employees)
            {
                dt.Rows.Add(emp.EmployeeID, emp.Name, emp.Email, emp.DepartmentName, emp.Phone, false);
            }
            dgv_employee.DataSource = dt;
            dgv_employee.Columns["Select"].HeaderText = "";
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(key))
            {
                dgv_employee.DataSource = dt;
                return;
            }
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CONVERT(Name, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Email, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Department, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Phone, 'System.String') LIKE '%{0}%'", key);

            dgv_employee.DataSource = dv;
        }
        public void DisplayErrors(List<string> errors)
        {
            lbx_error.Items.Clear();
            foreach (string error in errors)
            {
                lbx_error.Items.Add(error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbx_header_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cbx_header.Checked;
            foreach (DataGridViewRow row in dgv_employee.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                checkBoxCell.Value = isChecked;
            }
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            var selectedEmails = new List<string>();
            var selectedName = new List<string>();
            foreach (DataGridViewRow row in dgv_employee.Rows)
            {
                var checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                bool isChecked = checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value;
                if (isChecked)
                {
                    selectedEmails.Add(row.Cells["Email"].Value.ToString());
                }
            }
            foreach (DataGridViewRow row in dgv_employee.Rows)
            {
                var checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                bool isChecked = checkBoxCell != null && checkBoxCell.Value != null && (bool)checkBoxCell.Value;
                if (isChecked)
                {
                    selectedName.Add(row.Cells["Name"].Value.ToString());
                }
            }
            if (!selectedEmails.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một nhân viên để gửi email.");
                return;
            }
            using (EmailDialog emailDialog = new EmailDialog(this, _employeeService))
            {
                emailDialog.listName = selectedName;
                emailDialog.RecipientEmails = selectedEmails;
                emailDialog.CcEmails = selectedEmails;
                emailDialog.EmailAttachments = emailAttachments;
                emailDialog.ShowDialog();
            }
        }

        private void txt_File_Click(object sender, EventArgs e)
        {
            
        }

        private async Task Loaddate()
        {
            if (txt_File != null)
            {
                string currentDate = DateTime.Now.ToString("dd-MM-yyyy", new System.Globalization.CultureInfo("vi-VN"));
                txt_File.Text = currentDate;
            }
        }
    }
}
