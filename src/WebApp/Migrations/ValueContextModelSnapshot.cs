﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebApp.Data;

namespace WebApp.Migrations
{
	[DbContext(typeof(ValueContext))]
	partial class ValueContextModelSnapshot : ModelSnapshot
	{
		protected override void BuildModel(ModelBuilder modelBuilder)
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
