using ModelsLibrary;
using System.Data.Entity;

namespace DataAccessLibrary
{
    public partial class UserDataModel : DbContext
    {
        public UserDataModel()
            : base("name=UserDataModel")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
