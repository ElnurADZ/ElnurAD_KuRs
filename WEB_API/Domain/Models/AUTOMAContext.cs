using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Models
{
    public partial class AUTOMAContext : DbContext
    {
        public AUTOMAContext()
        {
        }

        public AUTOMAContext(DbContextOptions<AUTOMAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ad> Ads { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<MethodConnection> MethodConnections { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<OfficeAd> OfficeAds { get; set; } = null!;
        public virtual DbSet<OfficeCapital> OfficeCapitals { get; set; } = null!;
        public virtual DbSet<OrderClient> OrderClients { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<PaymentsClient> PaymentsClients { get; set; } = null!;
        public virtual DbSet<ReportClient> ReportClients { get; set; } = null!;
        public virtual DbSet<Salary> Salaries { get; set; } = null!;
        public virtual DbSet<Vacation> Vacations { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>(entity =>
            {
                entity.HasKey(e => e.IdAds)
                    .HasName("Unique_Identifier50");

                entity.ToTable("ADS");

                entity.Property(e => e.IdAds)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ADS");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.TypeAds)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Type_ADS")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClients)
                    .HasName("Unique_Identifier2");

                entity.Property(e => e.IdClients)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Clients");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIO")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDepartament)
                    .HasName("Unique_Identifier1");

                entity.ToTable("Department");

                entity.Property(e => e.IdDepartament)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Departament");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.EmployeCount).HasColumnName("Employe_count");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmloyee)
                    .HasName("Unique_Identifier4");

                entity.ToTable("Employee");

                entity.HasIndex(e => e.IdOffice, "IX_Relationship33");

                entity.Property(e => e.IdEmloyee)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Emloyee");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIO")
                    .IsFixedLength();

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number")
                    .IsFixedLength();

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdOffice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship33");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.IdFeedback)
                    .HasName("Unique_Identifier5");

                entity.ToTable("Feedback");

                entity.HasIndex(e => e.IdClients, "Relationship98");

                entity.Property(e => e.IdFeedback)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Feedback");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdClients).HasColumnName("ID_Clients");

                entity.Property(e => e.Text)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.IdClients)
                    .HasConstraintName("Relationship98");
            });

            modelBuilder.Entity<MethodConnection>(entity =>
            {
                entity.HasKey(e => e.IdOffice)
                    .HasName("Unique_Identifier87");

                entity.ToTable("Method_connection");

                entity.Property(e => e.IdOffice)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Office");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Facebook)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instagram)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.Property(e => e.Vk)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VK")
                    .IsFixedLength();

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithOne(p => p.MethodConnection)
                    .HasForeignKey<MethodConnection>(d => d.IdOffice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship87");
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasKey(e => e.IdOffice)
                    .HasName("Unique_Identifier3");

                entity.ToTable("Office");

                entity.HasIndex(e => e.IdDepartament, "Relationship99");

                entity.Property(e => e.IdOffice)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Office");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.EmployeCount).HasColumnName("Employe_count");

                entity.Property(e => e.IdDepartament).HasColumnName("ID_Departament");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdDepartamentNavigation)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.IdDepartament)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship99");

                entity.HasMany(d => d.IdPartners)
                    .WithMany(p => p.IdOffices)
                    .UsingEntity<Dictionary<string, object>>(
                        "OfficePartner",
                        l => l.HasOne<Partner>().WithMany().HasForeignKey("IdPartners").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Relationship41"),
                        r => r.HasOne<Office>().WithMany().HasForeignKey("IdOffice").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("Relationship40"),
                        j =>
                        {
                            j.HasKey("IdOffice", "IdPartners");

                            j.ToTable("Office/Partners");

                            j.IndexerProperty<int>("IdOffice").HasColumnName("ID_Office");

                            j.IndexerProperty<int>("IdPartners").HasColumnName("ID_Partners");
                        });
            });

            modelBuilder.Entity<OfficeAd>(entity =>
            {
                entity.HasKey(e => e.IdAdsOffice)
                    .HasName("Unique_Identifier76");

                entity.ToTable("Office_ADS");

                entity.HasIndex(e => e.IdAds, "IX_Relationship30_ADS");

                entity.HasIndex(e => e.IdOffice, "IX_Relationship30_Office");

                entity.Property(e => e.IdAdsOffice)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_ADS_Office");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AdsCoordinates)
                    .HasMaxLength(30)
                    .HasColumnName("ADS_Coordinates");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdAds).HasColumnName("ID_ADS");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdAdsNavigation)
                    .WithMany(p => p.OfficeAds)
                    .HasForeignKey(d => d.IdAds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship74");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.OfficeAds)
                    .HasForeignKey(d => d.IdOffice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship76");
            });

            modelBuilder.Entity<OfficeCapital>(entity =>
            {
                entity.HasKey(e => e.IdOfficeCapital)
                    .HasName("Unique_Identifier6");

                entity.ToTable("Office_capital");

                entity.HasIndex(e => e.IdOffice, "IX_Relationship47");

                entity.Property(e => e.IdOfficeCapital)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Office_capital");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.NewCapital).HasColumnName("New_capital");

                entity.Property(e => e.OldCapital).HasColumnName("Old_Capital");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.OfficeCapitals)
                    .HasForeignKey(d => d.IdOffice)
                    .HasConstraintName("Relationship47");
            });

            modelBuilder.Entity<OrderClient>(entity =>
            {
                entity.HasKey(e => e.IdOrderClients)
                    .HasName("Unique_Identifier7");

                entity.ToTable("Order_Clients");

                entity.HasIndex(e => e.IdClients, "IX_Relationship36");

                entity.HasIndex(e => e.IdOffice, "IX_Relationship37");

                entity.Property(e => e.IdOrderClients)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Order_Clients");

                entity.Property(e => e.ConvenientPrice).HasColumnName("Convenient_price");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdClients).HasColumnName("ID_Clients");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.Term).HasColumnType("date");

                entity.Property(e => e.Text)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.Property(e => e.Wish)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdClientsNavigation)
                    .WithMany(p => p.OrderClients)
                    .HasForeignKey(d => d.IdClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship36");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.OrderClients)
                    .HasForeignKey(d => d.IdOffice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship37");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasKey(e => e.IdPartners);

                entity.Property(e => e.IdPartners)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Partners");

                entity.Property(e => e.CompanyActivity)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Company_activity")
                    .IsFixedLength();

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameCompany)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Name_Company")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Phone_number")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");
            });

            modelBuilder.Entity<PaymentsClient>(entity =>
            {
                entity.HasKey(e => e.IdOrderClients)
                    .HasName("Unique_Identifier8");

                entity.ToTable("Payments_Clients");

                entity.HasIndex(e => e.IdOrderClients, "IX_Relationship43");

                entity.Property(e => e.IdOrderClients)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Order_Clients");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdClients).HasColumnName("ID_Clients");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdOrderClientsNavigation)
                    .WithOne(p => p.PaymentsClient)
                    .HasForeignKey<PaymentsClient>(d => d.IdOrderClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship43");
            });

            modelBuilder.Entity<ReportClient>(entity =>
            {
                entity.HasKey(e => e.IdReportClient)
                    .HasName("Unique_Identifier9");

                entity.ToTable("Report_Clients");

                entity.HasIndex(e => e.IdOrderClients, "IX_Relationship29");

                entity.HasIndex(e => e.IdFeedback, "IX_Relationship42");

                entity.HasIndex(e => e.IdOfficeCapital, "IX_Relationship49");

                entity.HasIndex(e => e.IdOffice, "IX_Relationship50");

                entity.Property(e => e.IdReportClient)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Report_Client");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdFeedback).HasColumnName("ID_Feedback");

                entity.Property(e => e.IdOffice).HasColumnName("ID_Office");

                entity.Property(e => e.IdOfficeCapital).HasColumnName("ID_Office_capital");

                entity.Property(e => e.IdOrderClients).HasColumnName("ID_Order_Clients");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdFeedbackNavigation)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.IdFeedback)
                    .HasConstraintName("Relationship42");

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.IdOffice)
                    .HasConstraintName("Relationship50");

                entity.HasOne(d => d.IdOfficeCapitalNavigation)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.IdOfficeCapital)
                    .HasConstraintName("Relationship49");

                entity.HasOne(d => d.IdOrderClientsNavigation)
                    .WithMany(p => p.ReportClients)
                    .HasForeignKey(d => d.IdOrderClients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship29");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.IdSalary)
                    .HasName("Unique_Identifier60");

                entity.ToTable("Salary");

                entity.HasIndex(e => e.IdEmloyee, "IX_Relationship46");

                entity.Property(e => e.IdSalary)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Salary");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.IdEmloyee).HasColumnName("ID_Emloyee");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdEmloyeeNavigation)
                    .WithMany(p => p.Salaries)
                    .HasForeignKey(d => d.IdEmloyee)
                    .HasConstraintName("Relationship46");
            });

            modelBuilder.Entity<Vacation>(entity =>
            {
                entity.HasKey(e => e.IdVacations)
                    .HasName("Unique_Identifier70");

                entity.HasIndex(e => e.IdEmloyee, "IX_Relationship45");

                entity.Property(e => e.IdVacations)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Vacations");

                entity.Property(e => e.BeginningVacations)
                    .HasColumnType("date")
                    .HasColumnName("Beginning_Vacations");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_at");

                entity.Property(e => e.EndVacations)
                    .HasColumnType("date")
                    .HasColumnName("End_Vacations");

                entity.Property(e => e.IdEmloyee).HasColumnName("ID_Emloyee");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_at");

                entity.HasOne(d => d.IdEmloyeeNavigation)
                    .WithMany(p => p.Vacations)
                    .HasForeignKey(d => d.IdEmloyee)
                    .HasConstraintName("Relationship45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
