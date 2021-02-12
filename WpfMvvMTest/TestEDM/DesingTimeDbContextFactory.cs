using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestEDM
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<TestDBContext>
    {
        public TestDBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<TestDBContext>();
            options.UseSqlServer("Data Source=TutePc\\SQLEXPRESS;Initial Catalog=BD_WpfMvvMTest;Integrated Security=True");

            return new TestDBContext(options.Options);
        }
    }
}
