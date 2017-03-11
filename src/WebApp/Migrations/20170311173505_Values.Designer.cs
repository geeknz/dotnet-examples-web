using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using nz.geek.colin.examples.dotnet.data;

namespace nz.geek.colin.examples.dotnet.controllers.Migrations
{
    [DbContext(typeof(ValueContext))]
    [Migration("20170311173505_Values")]
    partial class Values
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("nz.geek.colin.examples.dotnet.models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
        }
    }
}
