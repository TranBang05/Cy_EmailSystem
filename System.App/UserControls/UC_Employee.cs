using System;
using System.App.Forms;
using System.BusinessAccess.Dto.Request;
using System.BusinessAccess.Dto.Response;
using System.BusinessAccess.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.App.UserControls
{
    public partial class UC_Employee : UserControl
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;

        public UC_Employee(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
            Loaddate();
            LoadData();
        }

        DataTable dt = new DataTable();
        private async Task LoadData()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            dt.Clear();
            dt.Columns.Clear();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            foreach (var emp in employees)
            {
                dt.Rows.Add(emp.EmployeeID, emp.Name, emp.Email, emp.DepartmentName, emp.Phone);
            }
            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns.Contains("Edit") || dataGridView1.Columns.Contains("Delete"))
            {
                dataGridView1.Columns.Remove("Edit");
                dataGridView1.Columns.Remove("Delete");
            }
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButtonColumn);
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButtonColumn);
        }
       

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(key))
            {
                dataGridView1.DataSource = dt;
                return;
            }
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CONVERT(Name, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Email, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Department, 'System.String') LIKE '%{0}%' OR " +
                                         "CONVERT(Phone, 'System.String') LIKE '%{0}%'", key);
            dataGridView1.DataSource = dv;
        }
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            var departments = await _departmentService.GetAllAsync();
            var bindingList = new BindingList<EmployeeResponse>((IList<EmployeeResponse>)employees);
            dataGridView1.DataSource = bindingList;
        }
       
      
        private async Task Loaddate()
        {
            if (txt_date != null)
            {
                string currentDate = DateTime.Now.ToString("dd-MM-yyyy", new System.Globalization.CultureInfo("vi-VN"));
                txt_date.Text = currentDate;
            }
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int employeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                UpdateEmployee(employeeID);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteEmployee(employeeID);
            }
        }
        private async void UpdateEmployee(int employeeID)
        {
            var row = dataGridView1.Rows.Cast<DataGridViewRow>()
                         .FirstOrDefault(r => Convert.ToInt32(r.Cells["ID"].Value) == employeeID);

            if (row == null)
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string currentName = row.Cells["Name"].Value.ToString();
            string currentEmail = row.Cells["Email"].Value.ToString();
            string currentPhone = row.Cells["Phone"].Value.ToString();
            using (UpdateMember updateMember = new UpdateMember(this, currentName, currentEmail, currentPhone))
            {
                var result = updateMember.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var update = new EmployeeRequest
                    {
                        EmployeeID = employeeID,
                        Name = updateMember.MemberName,
                        Email = updateMember.Email,
                        Phone = updateMember.Phone,
                        DepartmentID = 1,
                        Position = null
                    };
                    try
                    {
                        await _employeeService.UpdateEmployeeAsync(update);

                        MessageBox.Show("Thành viên đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi cập nhật thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private async void btn_add_Click(object sender, EventArgs e)
        {
            using (AddMember addmember = new AddMember(this))
            {
                var result = addmember.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var newEmployee = new EmployeeRequest
                    {
                        Name = addmember.MemberName,
                        Email = addmember.Email,
                        Phone = addmember.Phone,
                        DepartmentID = 1,
                        Position = addmember.Position
                    };
                    try
                    {
                        await _employeeService.AddEmployeeAsync(newEmployee);
                        MessageBox.Show("Thành viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //await LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi thêm thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private async void DeleteEmployee(int employeeID)
        {

            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo
            );
            if (confirmResult == DialogResult.Yes)
            {
                var result = await _employeeService.DeleteEmployeeAsync(employeeID);
                if (result)
                {
                    MessageBox.Show("Xóa thành công.");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.");
                }
            }
        }
    }
}
