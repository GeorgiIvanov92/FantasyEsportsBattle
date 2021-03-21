﻿// <auto-generated />
using System;
using FantasyEsportsBattle.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FantasyEsportsBattle.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210314090719_MinorChange")]
    partial class MinorChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FantasyEsportsBattle.Host.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.ApplicationUserTournament", b =>
                {
                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TournamentId", "ApplicationUserId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ApplicationUserTournaments");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayImage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AheadInCSAt15MinPercent")
                        .HasColumnType("real");

                    b.Property<float>("CSDifferenceAt15Min")
                        .HasColumnType("real");

                    b.Property<float>("CSPM")
                        .HasColumnType("real");

                    b.Property<int>("CompetitionPlayerStatsId")
                        .HasColumnType("int");

                    b.Property<float>("DamagePerMinute")
                        .HasColumnType("real");

                    b.Property<float>("DamagePercent")
                        .HasColumnType("real");

                    b.Property<int>("DisplayImage")
                        .HasColumnType("int");

                    b.Property<float>("FirstBloodParticipationPercent")
                        .HasColumnType("real");

                    b.Property<float>("FirstBloodVictimPercent")
                        .HasColumnType("real");

                    b.Property<float>("GPM")
                        .HasColumnType("real");

                    b.Property<float>("GoldDifferenceAt15Min")
                        .HasColumnType("real");

                    b.Property<float>("GoldPercent")
                        .HasColumnType("real");

                    b.Property<float>("KDA")
                        .HasColumnType("real");

                    b.Property<float>("KillParticipationPercent")
                        .HasColumnType("real");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<float>("VisionScorePerMinute")
                        .HasColumnType("real");

                    b.Property<float>("Winrate")
                        .HasColumnType("real");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.Property<float>("XPDifferenceAt15Min")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("CompetitionPlayers");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayerStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("TournamentPlayerId")
                        .HasColumnType("int");

                    b.Property<float>("Winrate")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionPlayerId")
                        .IsUnique();

                    b.ToTable("CompetitionPlayerStatuses");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.FinishedEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GameDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("Score1")
                        .HasColumnType("int");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("FinishedEvents");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageGameTime")
                        .HasColumnType("real");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<int>("DisplayImage")
                        .HasColumnType("int");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.Property<int>("TotalGames")
                        .HasColumnType("int");

                    b.Property<float>("Winrate")
                        .HasColumnType("real");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayImage")
                        .HasColumnType("int");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TournamentAlgorithm")
                        .HasColumnType("int");

                    b.Property<string>("TournamentHostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TournamentState")
                        .HasColumnType("int");

                    b.Property<int>("TournamentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentHostId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentBoughtPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitionPlayerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsReserve")
                        .HasColumnType("bit");

                    b.Property<int>("TournamentStatsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionPlayerId");

                    b.HasIndex("TournamentStatsId");

                    b.ToTable("TournamentBoughtPlayers");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentCompetition", b =>
                {
                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.HasKey("TournamentId", "CompetitionId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("TournamentCompetitions");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentInvitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InvitationSenderUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InvitedUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvitationSenderUserId");

                    b.HasIndex("InvitedUserId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TournamentInvitations");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TournamentStatuses");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.ApplicationUserTournament", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserTournaments")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", "Tournament")
                        .WithMany("ApplicationUserTournaments")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayer", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayerStats", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayer", "CompetitionPlayer")
                        .WithOne("CompetitionPlayerStats")
                        .HasForeignKey("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayerStats", "CompetitionPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompetitionPlayer");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.FinishedEvent", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", "AwayTeam")
                        .WithMany("AwayTeamFinishedEvents")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Competition", "Competition")
                        .WithMany("FinishedEvents")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", "HomeTeam")
                        .WithMany("HomeTeamFinishedEvents")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("Competition");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Competition", "Competition")
                        .WithMany("Teams")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", "TournamentHost")
                        .WithMany("HostedTournaments")
                        .HasForeignKey("TournamentHostId");

                    b.Navigation("TournamentHost");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentBoughtPlayer", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayer", "CompetitionPlayer")
                        .WithMany()
                        .HasForeignKey("CompetitionPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentStats", "TournamentStats")
                        .WithMany("BoughtPlayers")
                        .HasForeignKey("TournamentStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompetitionPlayer");

                    b.Navigation("TournamentStats");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentCompetition", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Competition", "Competition")
                        .WithMany("TournamentCompetitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", "Tournament")
                        .WithMany("TournamentCompetitions")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentInvitation", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", "InvitationSenderUser")
                        .WithMany()
                        .HasForeignKey("InvitationSenderUserId");

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", "InvitedUser")
                        .WithMany("TournamentInvitations")
                        .HasForeignKey("InvitedUserId");

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", "Tournament")
                        .WithMany("TournamentInvitations")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvitationSenderUser");

                    b.Navigation("InvitedUser");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentStats", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("TournamentStatuses")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", "Tournament")
                        .WithMany()
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserTournaments");

                    b.Navigation("HostedTournaments");

                    b.Navigation("TournamentInvitations");

                    b.Navigation("TournamentStatuses");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Competition", b =>
                {
                    b.Navigation("FinishedEvents");

                    b.Navigation("Teams");

                    b.Navigation("TournamentCompetitions");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.CompetitionPlayer", b =>
                {
                    b.Navigation("CompetitionPlayerStats");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Team", b =>
                {
                    b.Navigation("AwayTeamFinishedEvents");

                    b.Navigation("HomeTeamFinishedEvents");

                    b.Navigation("Players");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.Tournament", b =>
                {
                    b.Navigation("ApplicationUserTournaments");

                    b.Navigation("TournamentCompetitions");

                    b.Navigation("TournamentInvitations");
                });

            modelBuilder.Entity("FantasyEsportsBattle.Web.Data.Models.Tournament.TournamentStats", b =>
                {
                    b.Navigation("BoughtPlayers");
                });
#pragma warning restore 612, 618
        }
    }
}
