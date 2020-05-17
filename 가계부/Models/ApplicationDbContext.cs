using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 가계부.Models
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// 트레이드에 대한 데이터 집합
        /// </summary>
        public DbSet<Trade> Trades { get; set; }

        public ApplicationDbContext(DbContextOptions options)
    : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
