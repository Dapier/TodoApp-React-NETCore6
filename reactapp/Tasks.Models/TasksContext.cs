using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace reactapp.Tasks.Models
{
    public partial class TasksContext : DbContext
    {
        public TasksContext()
        {
        }

        public TasksContext(DbContextOptions<TasksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Rasci> Rascis { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<Todo> Todos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Tasks;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rasci>(entity =>
            {
                entity.HasKey(e => e.IdJobCode)
                    .HasName("PK__Rasci__D57A660333454241");

                entity.ToTable("Rasci");

                entity.Property(e => e.IdJobCode).HasColumnName("idJobCode");

                entity.Property(e => e.AdvanceManufacturing)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Advance_Manufacturing");

                entity.Property(e => e.CategoryTeams)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Category_Teams");

                entity.Property(e => e.CentraolTeamProductivity)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Centraol_Team_Productivity");

                entity.Property(e => e.ClusterTeams)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cluster_Teams");

                entity.Property(e => e.DescriptionJobCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descriptionJobCode");

                entity.Property(e => e.Finance)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlantScPlanning)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Plant_SC_Planning");

                entity.Property(e => e.PlantSupplierLeader)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Plant_Supplier_Leader");

                entity.Property(e => e.ProcessArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResilienceTeams)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Resilience_Teams");

                entity.Property(e => e.Sqe)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SQE");

                entity.Property(e => e.TechnicalProductivity)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Technical_Productivity");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.IdTask)
                    .HasName("PK__Task__C3E0F4DA16173014");

                entity.ToTable("Task");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registerDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("taskDescription");
            });

            modelBuilder.Entity<Todo>(entity =>
            {
                entity.HasKey(e => e.IdTask)
                    .HasName("PK__Todos__C3E0F4DA8AB8186C");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registerDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("taskDescription");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
