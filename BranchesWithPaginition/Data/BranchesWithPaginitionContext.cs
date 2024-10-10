using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BranchesWithPaginition.Models;

namespace BranchesWithPaginition.Data
{
    public class BranchesWithPaginitionContext : DbContext
    {
        public BranchesWithPaginitionContext (DbContextOptions<BranchesWithPaginitionContext> options)
            : base(options)
        {
        }

        public DbSet<BranchesWithPaginition.Models.Branch> Branch { get; set; } = default!;
    }
}
