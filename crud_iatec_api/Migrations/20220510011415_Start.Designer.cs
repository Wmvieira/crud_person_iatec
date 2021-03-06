// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crud_iatec_api.Data;

#nullable disable

namespace crud_iatec_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220510011415_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("crud_iatec_api.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("crud_iatec_api.Phone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("id");

                    b.HasIndex("personId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("crud_iatec_api.Phone", b =>
                {
                    b.HasOne("crud_iatec_api.Person", "person")
                        .WithMany("phones")
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");
                });

            modelBuilder.Entity("crud_iatec_api.Person", b =>
                {
                    b.Navigation("phones");
                });
#pragma warning restore 612, 618
        }
    }
}
