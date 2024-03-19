using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace WinAppTracNghiem.Models
{
    public partial class WinAppTracNghiemContext : DbContext
    {
        public WinAppTracNghiemContext()
        {
        }

        public WinAppTracNghiemContext(DbContextOptions<WinAppTracNghiemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Answer> Answers { get; set; } = null!;
        public virtual DbSet<AnswersOfQuestion> AnswersOfQuestions { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Enroll> Enrolls { get; set; } = null!;
        public virtual DbSet<ExamCode> ExamCodes { get; set; } = null!;
        public virtual DbSet<Practice> Practices { get; set; } = null!;
        public virtual DbSet<Question> Questions { get; set; } = null!;
        public virtual DbSet<QuestionOfCode> QuestionOfCodes { get; set; } = null!;
        public virtual DbSet<Semester> Semesters { get; set; } = null!;
        public virtual DbSet<TypeOfQuestion> TypeOfQuestions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:MyDatabase"];
            optionsBuilder.UseSqlServer(strConn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Accounts__F3DBC5732A3B60E8");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasMaxLength(10);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnswersOfQuestion>(entity =>
            {
                entity.HasKey(e => new { e.Question, e.Answer })
                    .HasName("PK__AnswersO__E2477DD744D47C0B");

                entity.ToTable("AnswersOfQuestion");

                entity.HasOne(d => d.AnswerNavigation)
                    .WithMany(p => p.AnswersOfQuestions)
                    .HasForeignKey(d => d.Answer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AnswersOf__Answe__49C3F6B7");

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.AnswersOfQuestions)
                    .HasForeignKey(d => d.Question)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AnswersOf__Quest__4AB81AF0");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Courses__A25C5AA6221593CB");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Enroll>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Semester, e.Course })
                    .HasName("PK__Enroll__25139B4F1C57E37C");

                entity.ToTable("Enroll");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Semester)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Course)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Enroll__Course__4BAC3F29");

                entity.HasOne(d => d.SemesterNavigation)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Semester)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Enroll__Semester__4CA06362");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Enroll__Username__4D94879B");
            });
            modelBuilder.Entity<QuestionOfCode>(entity =>
            {
                entity.HasKey(e => new { e.ExamCode, e.Question })
                    .HasName("PK__Question__790A716807776560");

                entity.ToTable("QuestionOfCode");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.QuestionOfCodes)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionO__ExamC__628FA481");

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.QuestionOfCodes)
                    .HasForeignKey(d => d.Question)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__QuestionO__Quest__6383C8BA");
            });

            modelBuilder.Entity<ExamCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__ExamCode__A25C5AA66EC62E8E");

                entity.ToTable("ExamCode");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Course)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateBegin).HasColumnType("date");

                entity.Property(e => e.Semester)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.ExamCodes)
                    .HasForeignKey(d => d.Course)
                    .HasConstraintName("FK__ExamCode__Course__5FB337D6");

                entity.HasOne(d => d.SemesterNavigation)
                    .WithMany(p => p.ExamCodes)
                    .HasForeignKey(d => d.Semester)
                    .HasConstraintName("FK__ExamCode__Semest__5EBF139D");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.ExamCode })
                    .HasName("PK__Practice__0C205A1FA4BFC02D");

                entity.ToTable("Practice");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TimeBegin).HasColumnType("datetime");

                entity.HasOne(d => d.ExamCodeNavigation)
                    .WithMany(p => p.Practices)
                    .HasForeignKey(d => d.ExamCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Practice__ExamCo__5070F446");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Practices)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Practice__userna__5165187F");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Course)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.Course)
                    .HasConstraintName("FK__Questions__Cours__5441852A");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK__Questions__Type__5535A963");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Semester__A25C5AA6F19B4B8F");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BeginDate)
                    .HasColumnType("date")
                    .HasColumnName("beginDate");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");
            });

            modelBuilder.Entity<TypeOfQuestion>(entity =>
            {
                entity.ToTable("TypeOfQuestion");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
