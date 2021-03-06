// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Santi.Federico._5h.PrimoEF.Models;

namespace Santi.Federico._5h.PrimoEF.Migrations
{
    [DbContext(typeof(DBPersone))]
    [Migration("20211015073935_PrimaVersione")]
    partial class PrimaVersione
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Santi.Federico._5h.PrimoEF.Models.Persona", b =>
                {
                    b.Property<int>("idPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("idPersona");

                    b.ToTable("Persone");
                });
#pragma warning restore 612, 618
        }
    }
}
