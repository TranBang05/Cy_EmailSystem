using System;
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
        }

        DataTable dt = new DataTable();

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            var departments = await _departmentService.GetAllAsync();
            var bindingList = new BindingList<EmployeeResponse>((IList<EmployeeResponse>)employees);
            dataGridView1.DataSource = bindingList;
            if (departments != null && departments.Any())
            {
                cbx_department.DataSource = departments;
                cbx_department.DisplayMember = "DepartmentName"; 
                cbx_department.ValueMember = "DepartmentID";
            }
            else
            {
                MessageBox.Show("Không có dữ liệu phòng.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_Id.Text = row.Cells["EmployeeID"].Value.ToString();
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                text_phone.Text = row.Cells["Phone"].Value.ToString();
                var departmentName = row.Cells["DepartmentName"].Value.ToString();
                cbx_department.SelectedItem = departmentName;
              
            }
        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(text_phone.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            var newEmployee = new EmployeeRequest
            {
                Name = txt_name.Text,
                Email = txt_email.Text,
                Phone = text_phone.Text,
                DepartmentID = (int)cbx_department.SelectedValue
            };
            var result = await _employeeService.AddEmployeeAsync(newEmployee);
            if (result != null)
            {
                MessageBox.Show("Thêm mới thành công.");
                await LoadData();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại.");
            }
        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var employeeId = (int)dataGridView1.CurrentRow.Cells["EmployeeID"].Value;

                var updatedEmployee = new EmployeeRequest
                {
                    EmployeeID = employeeId,
                    Name = txt_name.Text,
                    Email = txt_email.Text,
                    Phone = text_phone.Text,
                    DepartmentID = (int)cbx_department.SelectedValue
                };
                var result = await _employeeService.UpdateEmployeeAsync(updatedEmployee);
                if (result !=null)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    await LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Chọn một nhân viên để cập nhật.");
            }
        }
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var employeeId = (int)dataGridView1.CurrentRow.Cells["EmployeeID"].Value;

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo
                );

                if (confirmResult == DialogResult.Yes)
                {
                    var result = await _employeeService.DeleteEmployeeAsync(employeeId);
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
            else
            {
                MessageBox.Show("Chọn một nhân viên để xóa.");
            }
        }
        void showHide(bool check)
        {
            btn_insert.Enabled = check;
            btn_delete.Enabled = check;
            btn_update.Enabled = check;
        }

        private async Task LoadData()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            var departments = await _departmentService.GetAllAsync();
            dataGridView1.DataSource = new BindingList<EmployeeResponse>((IList<EmployeeResponse>)employees);

            if (departments != null && departments.Any())
            {
                cbx_department.DataSource = departments;
                cbx_department.DisplayMember = "DepartmentName";
                cbx_department.ValueMember = "DepartmentID";
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

    }
}
