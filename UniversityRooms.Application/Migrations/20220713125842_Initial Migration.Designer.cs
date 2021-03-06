// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniversityRooms.UI.Database;

#nullable disable

namespace UniversityRooms.UI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220713125842_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UniversityRooms.UI.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<int>("LevelsCount")
                        .HasColumnType("integer")
                        .HasColumnName("levels_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_buildings");

                    b.ToTable("buildings", (string)null);
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Cathedra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("integer")
                        .HasColumnName("building_id");

                    b.Property<int>("FacultyId")
                        .HasColumnType("integer")
                        .HasColumnName("faculty_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_cathedras");

                    b.HasIndex("BuildingId")
                        .HasDatabaseName("ix_cathedras_building_id");

                    b.HasIndex("FacultyId")
                        .HasDatabaseName("ix_cathedras_faculty_id");

                    b.ToTable("cathedras", (string)null);
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("integer")
                        .HasColumnName("building_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_faculties");

                    b.HasIndex("BuildingId")
                        .HasDatabaseName("ix_faculties_building_id");

                    b.ToTable("faculties", (string)null);
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildingId")
                        .HasColumnType("integer")
                        .HasColumnName("building_id");

                    b.Property<double>("Height")
                        .HasColumnType("double precision")
                        .HasColumnName("height");

                    b.Property<double>("Length")
                        .HasColumnType("double precision")
                        .HasColumnName("length");

                    b.Property<int>("Level")
                        .HasColumnType("integer")
                        .HasColumnName("level");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("room_type_id");

                    b.Property<double>("Width")
                        .HasColumnType("double precision")
                        .HasColumnName("width");

                    b.HasKey("Id")
                        .HasName("pk_rooms");

                    b.HasIndex("BuildingId")
                        .HasDatabaseName("ix_rooms_building_id");

                    b.HasIndex("RoomTypeId")
                        .HasDatabaseName("ix_rooms_room_type_id");

                    b.ToTable("rooms", (string)null);
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_room_types");

                    b.ToTable("room_types", (string)null);
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Cathedra", b =>
                {
                    b.HasOne("UniversityRooms.UI.Models.Building", "Building")
                        .WithMany("Cathedras")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cathedras_buildings_building_id");

                    b.HasOne("UniversityRooms.UI.Models.Faculty", "Faculty")
                        .WithMany("Cathedras")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cathedras_faculties_faculty_id");

                    b.Navigation("Building");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Faculty", b =>
                {
                    b.HasOne("UniversityRooms.UI.Models.Building", "Building")
                        .WithMany("Faculties")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_faculties_buildings_building_id");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Room", b =>
                {
                    b.HasOne("UniversityRooms.UI.Models.Building", "Building")
                        .WithMany("Rooms")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_rooms_buildings_building_id");

                    b.HasOne("UniversityRooms.UI.Models.RoomType", "Type")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_rooms_room_types_room_type_id");

                    b.Navigation("Building");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Building", b =>
                {
                    b.Navigation("Cathedras");

                    b.Navigation("Faculties");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.Faculty", b =>
                {
                    b.Navigation("Cathedras");
                });

            modelBuilder.Entity("UniversityRooms.UI.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
