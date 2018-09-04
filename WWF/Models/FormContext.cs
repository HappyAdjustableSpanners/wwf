using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WWF.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) 
            : base(options)
        { }

        public DbSet<FormData> FormSubmissions { get; set; }
    }
}
