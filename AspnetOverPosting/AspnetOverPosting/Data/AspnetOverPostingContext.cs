using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspnetOverPosting.Models
{
    public class AspnetOverPostingContext : DbContext
    {
        public AspnetOverPostingContext (DbContextOptions<AspnetOverPostingContext> options)
            : base(options)
        {
        }

        public DbSet<AspnetOverPosting.Models.User> UserModel { get; set; }
    }
}
