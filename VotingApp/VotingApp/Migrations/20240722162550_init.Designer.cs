﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingApp.Data;

#nullable disable

namespace VotingApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240722162550_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VotingApp.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Voter_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Voter_id")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("VotingApp.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BusinessId"));

                    b.Property<int>("BusinessLoginId")
                        .HasColumnType("int");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.HasKey("BusinessId");

                    b.HasIndex("BusinessLoginId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("VotingApp.Models.BusinessLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BusinessLogins");
                });

            modelBuilder.Entity("VotingApp.Models.FinalTeamScores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AverageScore")
                        .HasColumnType("float");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("Team_Id")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamsId");

                    b.ToTable("FinalTeamScores");
                });

            modelBuilder.Entity("VotingApp.Models.General", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusinessLoginId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Voter_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessLoginId");

                    b.HasIndex("Voter_Id")
                        .IsUnique();

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("VotingApp.Models.StaffCoach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Voter_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("StaffCoaches");
                });

            modelBuilder.Entity("VotingApp.Models.TeamData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("AdAppeal")
                        .HasColumnType("float");

                    b.Property<float>("AdAppealBusiness")
                        .HasColumnType("float");

                    b.Property<float>("Amazement")
                        .HasColumnType("float");

                    b.Property<float>("Creativity")
                        .HasColumnType("float");

                    b.Property<float>("PerfFunc")
                        .HasColumnType("float");

                    b.Property<float>("Performance")
                        .HasColumnType("float");

                    b.Property<float>("ProfCom")
                        .HasColumnType("float");

                    b.Property<float>("ProjectDesign")
                        .HasColumnType("float");

                    b.Property<int>("Team_id")
                        .HasColumnType("int");

                    b.Property<float>("Theme")
                        .HasColumnType("float");

                    b.Property<float>("ThemeIntegration")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Team_id")
                        .IsUnique();

                    b.ToTable("TeamDatas");
                });

            modelBuilder.Entity("VotingApp.Models.Teams", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompeteLevel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MemberCount")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Team_Id")
                        .HasColumnType("int");

                    b.Property<int>("VotesReceived")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("VotingApp.Models.Admin", b =>
                {
                    b.HasOne("VotingApp.Models.General", "General")
                        .WithOne("Admin")
                        .HasForeignKey("VotingApp.Models.Admin", "Voter_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("General");
                });

            modelBuilder.Entity("VotingApp.Models.Business", b =>
                {
                    b.HasOne("VotingApp.Models.BusinessLogin", "BusinessLogin")
                        .WithMany("Businesses")
                        .HasForeignKey("BusinessLoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessLogin");
                });

            modelBuilder.Entity("VotingApp.Models.FinalTeamScores", b =>
                {
                    b.HasOne("VotingApp.Models.Teams", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("VotingApp.Models.General", b =>
                {
                    b.HasOne("VotingApp.Models.BusinessLogin", "BusinessLogin")
                        .WithMany("Generals")
                        .HasForeignKey("BusinessLoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VotingApp.Models.StaffCoach", "StaffCoach")
                        .WithOne("General")
                        .HasForeignKey("VotingApp.Models.General", "Voter_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessLogin");

                    b.Navigation("StaffCoach");
                });

            modelBuilder.Entity("VotingApp.Models.TeamData", b =>
                {
                    b.HasOne("VotingApp.Models.Teams", "Teams")
                        .WithOne("TeamData")
                        .HasForeignKey("VotingApp.Models.TeamData", "Team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("VotingApp.Models.BusinessLogin", b =>
                {
                    b.Navigation("Businesses");

                    b.Navigation("Generals");
                });

            modelBuilder.Entity("VotingApp.Models.General", b =>
                {
                    b.Navigation("Admin")
                        .IsRequired();
                });

            modelBuilder.Entity("VotingApp.Models.StaffCoach", b =>
                {
                    b.Navigation("General")
                        .IsRequired();
                });

            modelBuilder.Entity("VotingApp.Models.Teams", b =>
                {
                    b.Navigation("TeamData")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
