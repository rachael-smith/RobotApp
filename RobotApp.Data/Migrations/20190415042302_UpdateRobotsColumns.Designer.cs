﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobotApp.Data;

namespace RobotApp.Data.Migrations
{
    [DbContext(typeof(RobotAppContext))]
    [Migration("20190415042302_UpdateRobotsColumns")]
    partial class UpdateRobotsColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("RobotApp.Data.DbSets.Chore", b =>
                {
                    b.Property<int>("ChoreID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChoreName");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("TimeToComplete");

                    b.HasKey("ChoreID");

                    b.ToTable("Chores");
                });

            modelBuilder.Entity("RobotApp.Data.DbSets.CompletedTask", b =>
                {
                    b.Property<int>("CompletedTaskID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ChoreCompletedSuccessfully");

                    b.Property<int>("RobotCompletedID");

                    b.Property<int>("TaskCompletedID");

                    b.Property<DateTime>("TimeCompleted");

                    b.Property<long>("TimeTakenToComplete");

                    b.HasKey("CompletedTaskID");

                    b.ToTable("CompletedTasks");
                });

            modelBuilder.Entity("RobotApp.Data.DbSets.Robot", b =>
                {
                    b.Property<int>("RobotID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("NumberOfChoresCompleted");

                    b.Property<string>("RobotName");

                    b.Property<int>("RobotTypeID");

                    b.HasKey("RobotID");

                    b.ToTable("Robots");
                });

            modelBuilder.Entity("RobotApp.Data.DbSets.RobotType", b =>
                {
                    b.Property<int>("RobotTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RobotTypeName");

                    b.HasKey("RobotTypeID");

                    b.ToTable("RobotTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
