﻿// <auto-generated />
using System;
using BaiThucTaplan1.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucTaplan1.Migrations
{
    [DbContext(typeof(appDbcontext))]
    partial class appDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BaiThucTaplan1.Entity.Chuas", b =>
                {
                    b.Property<int>("chuaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("chuaid"), 1L, 1);

                    b.Property<DateTime?>("capnhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("diachi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaythanhlap")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenchua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("trutri")
                        .HasColumnType("int");

                    b.HasKey("chuaid");

                    b.ToTable("Chuas");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.DaoTrang", b =>
                {
                    b.Property<int>("daotrangid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("daotrangid"), 1L, 1);

                    b.Property<bool?>("daketthuc")
                        .HasColumnType("bit");

                    b.Property<int?>("nguoitrutri")
                        .HasColumnType("int");

                    b.Property<string>("noidung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noitochuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sothanhvienthamgia")
                        .HasColumnType("int");

                    b.Property<DateTime?>("thoigiantochuc")
                        .HasColumnType("datetime2");

                    b.HasKey("daotrangid");

                    b.ToTable("daoTrangs");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Dondangkys", b =>
                {
                    b.Property<int>("dondangkyid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dondangkyid"), 1L, 1);

                    b.Property<int?>("daotrangid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ngayguidon")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayxuly")
                        .HasColumnType("datetime2");

                    b.Property<int?>("nguoixuly")
                        .HasColumnType("int");

                    b.Property<int?>("phantuid")
                        .HasColumnType("int");

                    b.Property<int?>("trangthaidon")
                        .HasColumnType("int");

                    b.HasKey("dondangkyid");

                    b.HasIndex("daotrangid");

                    b.HasIndex("phantuid");

                    b.ToTable("Dondangkys");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Kieuthanhviens", b =>
                {
                    b.Property<int>("kieuthanhvienid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("kieuthanhvienid"), 1L, 1);

                    b.Property<string>("code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenkieu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kieuthanhvienid");

                    b.ToTable("Kieuthanhviens");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Phantu", b =>
                {
                    b.Property<int>("phantuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("phantuid"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("anhchup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("chuaid")
                        .HasColumnType("int");

                    b.Property<int?>("chuaschuaid")
                        .HasColumnType("int");

                    b.Property<bool?>("dahoantuc")
                        .HasColumnType("bit");

                    b.Property<int?>("gioitinh")
                        .HasColumnType("int");

                    b.Property<string>("ho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.Property<int?>("kieuthanhvienid")
                        .HasColumnType("int");

                    b.Property<int?>("kieuthanhvienskieuthanhvienid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ngaycapnhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayketthuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayxuatgia")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phapdanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roll")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sodienthoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tendem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("phantuid");

                    b.HasIndex("chuaschuaid");

                    b.HasIndex("kieuthanhvienskieuthanhvienid");

                    b.ToTable("Phantus");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Phantudaotrangs", b =>
                {
                    b.Property<int>("phantudaotrangid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("phantudaotrangid"), 1L, 1);

                    b.Property<int?>("daotrangid")
                        .HasColumnType("int");

                    b.Property<bool?>("dathamgia")
                        .HasColumnType("bit");

                    b.Property<string>("lydokhongthamgia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phantuid")
                        .HasColumnType("int");

                    b.HasKey("phantudaotrangid");

                    b.HasIndex("daotrangid");

                    b.HasIndex("phantuid");

                    b.ToTable("Phantudaotrangs");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.RolllNumber", b =>
                {
                    b.Property<int>("rollnumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rollnumber"), 1L, 1);

                    b.Property<int>("phantuid")
                        .HasColumnType("int");

                    b.Property<string>("roll")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("rollnumber");

                    b.HasIndex("phantuid");

                    b.ToTable("rolllNumbers");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Dondangkys", b =>
                {
                    b.HasOne("BaiThucTaplan1.Entity.DaoTrang", "daotrangs")
                        .WithMany("dondangkys")
                        .HasForeignKey("daotrangid");

                    b.HasOne("BaiThucTaplan1.Entity.Phantu", "phantu")
                        .WithMany("dondangkys")
                        .HasForeignKey("phantuid");

                    b.Navigation("daotrangs");

                    b.Navigation("phantu");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Phantu", b =>
                {
                    b.HasOne("BaiThucTaplan1.Entity.Chuas", "chuas")
                        .WithMany("phantus")
                        .HasForeignKey("chuaschuaid");

                    b.HasOne("BaiThucTaplan1.Entity.Kieuthanhviens", "kieuthanhviens")
                        .WithMany("phantus")
                        .HasForeignKey("kieuthanhvienskieuthanhvienid");

                    b.Navigation("chuas");

                    b.Navigation("kieuthanhviens");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Phantudaotrangs", b =>
                {
                    b.HasOne("BaiThucTaplan1.Entity.DaoTrang", "daotrang")
                        .WithMany("phantudaotrangs")
                        .HasForeignKey("daotrangid");

                    b.HasOne("BaiThucTaplan1.Entity.Phantu", "phantu")
                        .WithMany("phantudaotrangs")
                        .HasForeignKey("phantuid");

                    b.Navigation("daotrang");

                    b.Navigation("phantu");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.RolllNumber", b =>
                {
                    b.HasOne("BaiThucTaplan1.Entity.Phantu", "Phantu")
                        .WithMany()
                        .HasForeignKey("phantuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Phantu");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Chuas", b =>
                {
                    b.Navigation("phantus");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.DaoTrang", b =>
                {
                    b.Navigation("dondangkys");

                    b.Navigation("phantudaotrangs");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Kieuthanhviens", b =>
                {
                    b.Navigation("phantus");
                });

            modelBuilder.Entity("BaiThucTaplan1.Entity.Phantu", b =>
                {
                    b.Navigation("dondangkys");

                    b.Navigation("phantudaotrangs");
                });
#pragma warning restore 612, 618
        }
    }
}
