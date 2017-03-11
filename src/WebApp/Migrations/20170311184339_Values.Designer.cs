using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApp.Data;

namespace WebApp.Migrations
{
	[DbContext(typeof(ValueContext))]
	[Migration("20170311184339_Values")]
	partial class Values
	{
		protected override void BuildTargetModel(ModelBuilder modelBuilder)
		{
			modelBuilder
				.HasAnnotation("ProductVersion", "1.1.1");

			modelBuilder.Entity("WebApp.Models.Value", b =>
				{
					b.Property<int>("Id")
						.ValueGeneratedOnAdd();

					b.HasKey("Id");

					b.ToTable("Values");
				});
		}
	}
}
