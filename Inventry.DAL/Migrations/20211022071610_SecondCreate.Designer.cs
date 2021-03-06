// <auto-generated />
using System;
using Inventry.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventry.DAL.Migrations
{
    [DbContext(typeof(BitCubeStoreDataContext))]
    [Migration("20211022071610_SecondCreate")]
    partial class SecondCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventry.DAL.Entities.ProductPurchase", b =>
                {
                    b.Property<int>("ProductPurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("TypeProductProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductPurchaseId");

                    b.HasIndex("TypeProductProductTypeId");

                    b.ToTable("ProductsPurchaseOrders");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.ProductSold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductPurchaseId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductPurchaseId")
                        .IsUnique();

                    b.ToTable("SolProducts");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.TypeProduct", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.ProductPurchase", b =>
                {
                    b.HasOne("Inventry.DAL.Entities.TypeProduct", "TypeProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeProductProductTypeId");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.ProductSold", b =>
                {
                    b.HasOne("Inventry.DAL.Entities.ProductPurchase", "ProductPurchase")
                        .WithOne("ProductSold")
                        .HasForeignKey("Inventry.DAL.Entities.ProductSold", "ProductPurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductPurchase");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.ProductPurchase", b =>
                {
                    b.Navigation("ProductSold");
                });

            modelBuilder.Entity("Inventry.DAL.Entities.TypeProduct", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
