using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp.net_milestone_final.Models;

namespace asp.net_milestone_final.Data
{
    public class aspnet_milestone_finalContext : DbContext
    {
        public aspnet_milestone_finalContext (DbContextOptions<aspnet_milestone_finalContext> options)
            : base(options)
        {
        }

        public DbSet<asp.net_milestone_final.Models.Student> Student { get; set; }

        public DbSet<asp.net_milestone_final.Models.Course> Course { get; set; }

        public DbSet<asp.net_milestone_final.Models.Enrollment> Enrollment { get; set; }
    }
}
