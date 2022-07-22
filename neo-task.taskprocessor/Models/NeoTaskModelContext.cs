﻿using Microsoft.EntityFrameworkCore;

namespace neo_task.taskprocessor.Models
{
    public class NeoTaskModelContext: DbContext
    {
        public NeoTaskModelContext(DbContextOptions<NeoTaskModelContext> options) : base(options) { }
        public DbSet<NeoTaskModel> NeoTasks { get; set; } = null!;
    }
}
