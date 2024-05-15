using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DetailedCleaningCompanyMVC.Models;

namespace DetailedCleaningCompanyMVC.Data;

public class DCCContext : DbContext
{
    public DCCContext(DbContextOptions<DCCContext> options) : base(options)
    {
        
    }
        public DbSet<DetailedCleaningCompanyMVC.Models.Appointment> Appointments { get; set; }
}
