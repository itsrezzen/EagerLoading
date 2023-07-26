using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EagerLoading
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionBuilder.UseSqlServer("Server=.; Database=MyDB; User Id=sa; Password=test@123");

            MyDbContext ctx = new MyDbContext(optionBuilder.Options);
            return ctx;
        }
    }
}
