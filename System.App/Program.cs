using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Database.Entity; // ??m b?o ?úng namespace cho CyDbContext
using System.DataAccess.Repository;
using System.DataAccess.Repository.Impl;
using System.BusinessAccess.Service;
using System.BusinessAccess.Service.Impl;
using System.BusinessAccess.Dto.Mapper;

namespace System.App
{
    internal static class Program
    {
        private static ServiceProvider? _serviceProvider;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
            var mainForm = _serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<CyDbContext>(options =>
                     options.UseMySql("Server=localhost;Database=cy_emailSystem;User=root;Password=bang0501@b;",
                     new MySqlServerVersion(new Version(8, 0, 21)))); 
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IDepartmentRepository, DepartmentRespository>();
            services.AddScoped<IEmailHistoryRepository, EmailHistoryRespository>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddAutoMapper(typeof(MyMapper));
            services.AddScoped<Form1>();
        }
    }
}
