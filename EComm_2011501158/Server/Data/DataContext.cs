using Microsoft.Extensions.Options;

namespace EComm_2011501158.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {

        }
        

        
    }
}
