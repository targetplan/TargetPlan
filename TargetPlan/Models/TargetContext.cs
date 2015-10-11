using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TargetPlan.Models
{
    public class TargetContext : DbContext
    {
        public DbSet<TargetPlan.Models.Target> Targets { get; set; }
    }
}