using EF_DbContext.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DbContext.Infrastructure.Data
{
    public class EfDbContext: DbContext
    {

        public DbSet<Student> Student { get; set; }
    }
}
