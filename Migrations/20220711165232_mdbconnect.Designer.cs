﻿// <auto-generated />
using GroupServer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupServer.Migrations
{
    [DbContext(typeof(DbConnect))]
    [Migration("20220711165232_mdbconnect")]
    partial class mdbconnect
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GroupServer.Model.Admin", b =>
                {
                    b.Property<int>("admin_id")
                        .HasColumnType("int");

                    b.Property<string>("admin_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("securityQ1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("GroupServer.Model.Medicine", b =>
                {
                    b.Property<int>("Medicine_ID")
                        .HasColumnType("int");

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category_Of_Medicine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EXP_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MF_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicine_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price_Rs")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Medicine_ID");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("GroupServer.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Confirm_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone_No")
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
