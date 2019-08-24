using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StroopApi.Models
{
    public class StroopApiContext : DbContext
    {
        public StroopApiContext(DbContextOptions<StroopApiContext> options)
            : base(options)
        {
        }

        public DbSet<RecordActivity> RecordActivities { get; set; }
    }
}
