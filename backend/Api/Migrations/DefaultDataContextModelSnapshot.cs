﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Repository;

namespace Api.Migrations
{
    [DbContext(typeof(DefaultDataContext))]
    partial class DefaultDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CountryId");

                    b.Property<int?>("CountryId1");

                    b.Property<Guid>("StateId");

                    b.Property<int?>("StateId1");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId1");

                    b.HasIndex("StateId1");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Domain.Entities.Collection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("TargetType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TargetTypeId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email_1")
                        .HasMaxLength(100);

                    b.Property<string>("Email_2")
                        .HasMaxLength(100);

                    b.Property<string>("Phone_1")
                        .HasMaxLength(50);

                    b.Property<string>("Phone_2")
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.Country", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneCode")
                        .HasMaxLength(5);

                    b.Property<string>("SortName")
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.EcoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EcoEntities");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.Ico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Icos");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.PhotoType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PhotoTypes");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.State", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.UnSDGGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UnSDGGoals");
                });

            modelBuilder.Entity("Domain.Entities.EcoDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EcoEntityId");

                    b.Property<int?>("IcoId");

                    b.Property<string>("IcoOther")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.Property<int?>("UnSDGGoalId");

                    b.Property<string>("UnSDGGoalsOther")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("EcoEntityId");

                    b.HasIndex("IcoId");

                    b.HasIndex("UnSDGGoalId");

                    b.ToTable("EcoDetails");
                });

            modelBuilder.Entity("Domain.Entities.Idea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Ideas");
                });

            modelBuilder.Entity("Domain.Entities.OrganizationDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CollectionId");

                    b.Property<Guid>("HeadQuaters");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Type");

                    b.Property<Guid?>("TypeId");

                    b.Property<bool>("Verified");

                    b.HasKey("Id");

                    b.HasIndex("CollectionId");

                    b.ToTable("OrganizationDetails");
                });

            modelBuilder.Entity("Domain.Entities.OrganizationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BranchId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OrganizationRoles");
                });

            modelBuilder.Entity("Domain.Entities.OrganizationTypeRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("OrganizationId");

                    b.Property<Guid>("OrganizationRoleId");

                    b.Property<string>("Type");

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("OrganizationTypeRoles");
                });

            modelBuilder.Entity("Domain.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<Guid?>("PhotoTypeId");

                    b.Property<string>("PublicId")
                        .HasMaxLength(1000);

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.Property<string>("Url")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("PhotoTypeId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Domain.Entities.Problem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<Guid?>("CollectionId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CollectionId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Domain.Entities.ProjectUrl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Titile")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("ProjectUrls");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("AgreeToTermsAndCondition");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Entities.UserDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<byte>("Gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid?>("RoleId1");

                    b.Property<Guid?>("UserId1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Domain.Entities.Verification.OrganizationVerification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Answered");

                    b.Property<DateTime>("DateCreated");

                    b.Property<Guid>("OrganizationDetailId");

                    b.Property<int>("RequestType");

                    b.Property<bool>("Validated");

                    b.HasKey("Id");

                    b.ToTable("OrganizationVerifications");
                });

            modelBuilder.Entity("Domain.Entities.Verification.WorkVerification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Answered");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Validated");

                    b.Property<Guid>("WorkId");

                    b.HasKey("Id");

                    b.ToTable("WorkVerifications");
                });

            modelBuilder.Entity("Domain.Entities.Vote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .HasMaxLength(50);

                    b.Property<Guid>("TypeId");

                    b.Property<string>("VoterType")
                        .HasMaxLength(50);

                    b.Property<Guid>("VoterTypeId");

                    b.HasKey("Id");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Domain.Entities.Work", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<Guid>("OrganizationId");

                    b.Property<string>("Position");

                    b.Property<Guid>("UserId");

                    b.Property<bool>("Verified");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("UserId");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.Address", b =>
                {
                    b.HasOne("Domain.Entities.CoreEntities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId1");

                    b.HasOne("Domain.Entities.CoreEntities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId1");
                });

            modelBuilder.Entity("Domain.Entities.CoreEntities.State", b =>
                {
                    b.HasOne("Domain.Entities.CoreEntities.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.EcoDetails", b =>
                {
                    b.HasOne("Domain.Entities.CoreEntities.EcoEntity", "EcoEntity")
                        .WithMany()
                        .HasForeignKey("EcoEntityId");

                    b.HasOne("Domain.Entities.CoreEntities.Ico", "Ico")
                        .WithMany()
                        .HasForeignKey("IcoId");

                    b.HasOne("Domain.Entities.CoreEntities.UnSDGGoal", "UnSDGGoal")
                        .WithMany()
                        .HasForeignKey("UnSDGGoalId");
                });

            modelBuilder.Entity("Domain.Entities.Idea", b =>
                {
                    b.HasOne("Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Domain.Entities.OrganizationDetail", b =>
                {
                    b.HasOne("Domain.Entities.Collection")
                        .WithMany("Organizations")
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("Domain.Entities.Photo", b =>
                {
                    b.HasOne("Domain.Entities.CoreEntities.PhotoType", "PhotoType")
                        .WithMany()
                        .HasForeignKey("PhotoTypeId");
                });

            modelBuilder.Entity("Domain.Entities.Problem", b =>
                {
                    b.HasOne("Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Domain.Entities.Project", b =>
                {
                    b.HasOne("Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Domain.Entities.Collection")
                        .WithMany("Projects")
                        .HasForeignKey("CollectionId");
                });

            modelBuilder.Entity("Domain.Entities.UserDetail", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("Domain.Entities.UserDetail", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Domain.Entities.Work", b =>
                {
                    b.HasOne("Domain.Entities.OrganizationDetail", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
