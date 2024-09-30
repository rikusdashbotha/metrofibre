﻿// <auto-generated />
using System;
using MetroFibre.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MetroFibre.Data.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20240930080945_add_seed")]
    partial class add_seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MetroFibre.Core.Entities.IngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000000"),
                            Name = "Meat",
                            Quantity = 6
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000001"),
                            Name = "Lettuce",
                            Quantity = 3
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000002"),
                            Name = "Tomato",
                            Quantity = 6
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000003"),
                            Name = "Cheese",
                            Quantity = 8
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000004"),
                            Name = "Dough",
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000005"),
                            Name = "Cucumber",
                            Quantity = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000000006"),
                            Name = "Olives",
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("MetroFibre.Core.Entities.RecipeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Feeds")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001000"),
                            Feeds = 1,
                            Name = "Burger"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001001"),
                            Feeds = 2,
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001002"),
                            Feeds = 6,
                            Name = "Tomato"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001003"),
                            Feeds = 1,
                            Name = "Pie"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001004"),
                            Feeds = 3,
                            Name = "Salad"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001005"),
                            Feeds = 1,
                            Name = "Sandwich"
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000001006"),
                            Feeds = 4,
                            Name = "Pizza"
                        });
                });

            modelBuilder.Entity("MetroFibre.Core.Entities.RecipeIngredientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RequiredAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002000"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000000"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001000"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002001"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000001"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001000"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002002"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000002"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001000"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002003"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000003"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001000"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002004"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000004"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001000"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002005"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000004"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001001"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002006"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000002"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001001"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002007"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000003"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001001"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002008"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000000"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001001"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002009"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000004"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001003"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002010"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000000"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001003"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002011"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000001"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001004"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002012"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000002"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001004"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002013"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000005"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001004"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002014"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000003"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001004"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002015"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000006"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001004"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002016"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000004"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001005"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002017"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000005"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001005"),
                            RequiredAmount = 1
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002018"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000004"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001006"),
                            RequiredAmount = 3
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002019"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000002"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001006"),
                            RequiredAmount = 2
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002020"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000003"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001006"),
                            RequiredAmount = 3
                        },
                        new
                        {
                            Id = new Guid("00000000-da7a-0000-0000-000000002021"),
                            IngredientId = new Guid("00000000-da7a-0000-0000-000000000006"),
                            RecipeId = new Guid("00000000-da7a-0000-0000-000000001006"),
                            RequiredAmount = 1
                        });
                });

            modelBuilder.Entity("MetroFibre.Core.Entities.RecipeIngredientEntity", b =>
                {
                    b.HasOne("MetroFibre.Core.Entities.IngredientEntity", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MetroFibre.Core.Entities.RecipeEntity", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("MetroFibre.Core.Entities.IngredientEntity", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("MetroFibre.Core.Entities.RecipeEntity", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
