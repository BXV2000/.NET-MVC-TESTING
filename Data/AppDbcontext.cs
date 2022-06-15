using Microsoft.EntityFrameworkCore;

namespace Test_Project.Data
{
    public class AppDbcontext:DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options):base(options)
        {

        }
    }
}
