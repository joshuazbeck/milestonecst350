using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone.Models;

    public class Create : DbContext
    {
        public Create (DbContextOptions<Create> options)
            : base(options)
        {
        }

        public DbSet<Milestone.Models.UserModel> UserModel { get; set; }

        public DbSet<Milestone.Models.CellModel> CellModel { get; set; }

        public DbSet<Milestone.Models.BoardModel> BoardModel { get; set; }
    }
