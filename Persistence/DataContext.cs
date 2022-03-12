using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<AccountInformation> AccountInformation { get; set; }
        public DbSet<Attendance> Attandences { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StaffInfo> StaffInfos  { get; set; }
        public DbSet<StaffWorkingHistory> StaffWorkingHistories { get; set; }
        public DbSet<ParentInfo> ParentInfos { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}