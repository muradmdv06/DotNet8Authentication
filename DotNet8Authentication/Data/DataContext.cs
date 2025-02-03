

using Microsoft.EntityFrameworkCore;

namespace DotNet8Authentication.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }
    }

    
}
