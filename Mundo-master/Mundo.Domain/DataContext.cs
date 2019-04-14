using System.Data.Entity;

namespace Mundo.Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                        
        }
    }
}
