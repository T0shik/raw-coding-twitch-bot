﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoistBot.Database;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MoistBot.Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200729195851_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MoistBot.Models.Twitch.TwitchSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Context")
                        .HasColumnType("text");

                    b.Property<int>("StreakMonths")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionPlan")
                        .HasColumnType("integer");

                    b.Property<string>("SubscriptionPlanName")
                        .HasColumnType("text");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("TotalMonths")
                        .HasColumnType("integer");

                    b.Property<string>("TwitchUsername")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TwitchSubscriptions");
                });

            modelBuilder.Entity("MoistBot.Models.Twitch.TwitchUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("Followed")
                        .HasColumnType("boolean");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("TwitchMetadata");
                });

            modelBuilder.Entity("MoistBot.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MoistBot.Models.Twitch.TwitchSubscription", b =>
                {
                    b.HasOne("MoistBot.Models.Twitch.TwitchUser", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MoistBot.Models.Twitch.TwitchUser", b =>
                {
                    b.HasOne("MoistBot.Models.User", "User")
                        .WithOne("TwitchUser")
                        .HasForeignKey("MoistBot.Models.Twitch.TwitchUser", "UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
