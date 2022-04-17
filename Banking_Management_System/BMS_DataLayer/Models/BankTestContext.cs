using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer.Models
{
    public partial class BankTestContext : DbContext
    {
        public BankTestContext()
        {
        }

        public BankTestContext(DbContextOptions<BankTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDetail> AccountDetails { get; set; }
        public virtual DbSet<AdminAccount> AdminAccounts { get; set; }
        public virtual DbSet<AdminDetail> AdminDetails { get; set; }
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
        public virtual DbSet<UpdateHistory> UpdateHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=RUSHIKESH;Database=BankTest;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__AccountD__91CBC3987501B0C0");

                entity.Property(e => e.AccId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AccID");

                entity.Property(e => e.CusId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CusID");

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.AccountDetails)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK_AccountDetails_CustomerDetails");
            });

            modelBuilder.Entity<AdminAccount>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__AdminAcc__AF2DBA793AD6F9CE");

                entity.ToTable("AdminAccount");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmpID");

                entity.Property(e => e.AdminType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminDetail>(entity =>
            {
                entity.HasKey(e => e.AdmId)
                    .HasName("PK__AdminDet__A13DEA8A58D2B0D6");

                entity.Property(e => e.AdmId).HasColumnName("AdmID");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.AdminDetails)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_AdminDetails_AdminAccount");
            });

            modelBuilder.Entity<Beneficiary>(entity =>
            {
                entity.HasKey(e => e.BId)
                    .HasName("PK__Benefici__4B26EFE6384E387E");

                entity.ToTable("Beneficiary");

                entity.Property(e => e.BId).HasColumnName("B_ID");

                entity.Property(e => e.AccId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AccID");

                entity.Property(e => e.BAccId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("B_AccID");

                entity.Property(e => e.BName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("B_Name");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_Beneficiary_AccountDetails");
            });

            modelBuilder.Entity<CustomerAccount>(entity =>
            {
                entity.HasKey(e => e.CuserName)
                    .HasName("PK__Customer__5946F960AA5856C5");

                entity.ToTable("CustomerAccount");

                entity.Property(e => e.CuserName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CUserName");

                entity.Property(e => e.AccId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AccID");

                entity.Property(e => e.Cpassword)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CPassword");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.CustomerAccounts)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_CustomerAccount_AccountDetails");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__Customer__2F18713057D819A3");

                entity.Property(e => e.CusId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CusID");

                entity.Property(e => e.Aadhaar)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Pan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PAN");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Aadhaar)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CusId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CusID");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Pan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PAN");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RequestStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK_Requests_CustomerDetails");
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Transact__55433A4B971D000B");

                entity.ToTable("TransactionHistory");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.AccId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AccID");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.TransactionHistories)
                    .HasForeignKey(d => d.AccId)
                    .HasConstraintName("FK_TransactionHistory_AccountDetails");
            });

            modelBuilder.Entity<UpdateHistory>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PK__UpdateHi__7A0CF3254D15A1EC");

                entity.ToTable("UpdateHistory");

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateInfo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdatedID");

                entity.Property(e => e.UpdaterId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UpdaterID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
