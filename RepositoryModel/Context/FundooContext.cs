using RepositoryModel.Entity;
using Microsoft.EntityFrameworkCore;

namespace RepositoryModel.Context
{
    public class FundooContext:DbContext
    {

        public FundooContext(DbContextOptions options)
                 : base(options)
        {
        }
        public DbSet<UserEntity> UserTable { get; set; }
    }
}
