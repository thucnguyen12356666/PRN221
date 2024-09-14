using System;
using System.Collections.Generic;
using Candidate_BusinessObjects.Entities;
using Microsoft.EntityFrameworkCore;

namespace Candidate_BusinessObjects;

public partial class CandidateManagementContext : DbContext
{
    public CandidateManagementContext()
    {
    }

    public CandidateManagementContext(DbContextOptions<CandidateManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CandidateProfile> CandidateProfiles { get; set; }

    public virtual DbSet<Hraccount> Hraccounts { get; set; }

    public virtual DbSet<JobPosting> JobPostings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-7705AIH\\THUC;Database= CandidateManagement;UID=sa;PWD=12345;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CandidateProfile>(entity =>
        {
            entity.HasKey(e => e.CandidateId).HasName("PK__Candidat__DF539BFCDA7B91FF");

            entity.ToTable("CandidateProfile");

            entity.Property(e => e.CandidateId)
                .HasMaxLength(20)
                .HasColumnName("CandidateID");
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.Fullname).HasMaxLength(100);
            entity.Property(e => e.PostingId)
                .HasMaxLength(20)
                .HasColumnName("PostingID");
            entity.Property(e => e.ProfileShortDescription).HasMaxLength(250);
            entity.Property(e => e.ProfileUrl)
                .HasMaxLength(150)
                .HasColumnName("ProfileURL");

            entity.HasOne(d => d.Posting).WithMany(p => p.CandidateProfiles)
                .HasForeignKey(d => d.PostingId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Candidate__Posti__398D8EEE");
        });

        modelBuilder.Entity<Hraccount>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__HRAccoun__A9D1053555DC5A2B");

            entity.ToTable("HRAccount");

            entity.Property(e => e.Email).HasMaxLength(20);
            entity.Property(e => e.FullName).HasMaxLength(30);
            entity.Property(e => e.Password).HasMaxLength(40);
        });

        modelBuilder.Entity<JobPosting>(entity =>
        {
            entity.HasKey(e => e.PostingId).HasName("PK__JobPosti__C31796A555D76A6C");

            entity.ToTable("JobPosting");

            entity.Property(e => e.PostingId)
                .HasMaxLength(20)
                .HasColumnName("PostingID");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.JobPostingTitle).HasMaxLength(100);
            entity.Property(e => e.PostedDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
