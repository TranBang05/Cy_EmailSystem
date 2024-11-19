using System.App.Forms;
using System.App.UserControls;
using System.BusinessAccess.Service;
using System.BusinessAccess.Service.Impl;
using System.Data;
using System.Net.Mail;
using Microsoft.Extensions.DependencyInjection;

namespace System.App
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private List<Attachment> emailAttachments = new List<Attachment>();
        public Form1(IEmployeeService employeeService, IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
            InitializeComponent();
            UC_ListMonth emailControls = new UC_ListMonth(_employeeService);
            addUserControl(emailControls);

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Employee_Click(object sender, EventArgs e)
        {
            UC_Employee employeeControl = new UC_Employee(_employeeService, _departmentService);
            addUserControl(employeeControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            UC_SendEmail emailControls = new UC_SendEmail(_employeeService);
            addUserControl(emailControls);
        }


        private void btn_SendMail_Click(object sender, EventArgs e)
        {
            UC_SendEmail emailControls = new UC_SendEmail(_employeeService);
            addUserControl(emailControls);
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            UC_ListMonth emailControls = new UC_ListMonth(_employeeService);
            addUserControl(emailControls);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            UC_SendEmail emailControls = new UC_SendEmail(_employeeService);
            addUserControl(emailControls);
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kkkkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            UC_SendEmail emailControls = new UC_SendEmail(_employeeService);
            addUserControl(emailControls);
        }
    }
}
