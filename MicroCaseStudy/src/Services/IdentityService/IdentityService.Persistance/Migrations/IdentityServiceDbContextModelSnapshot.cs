﻿// <auto-generated />
using System;
using IdentityService.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IdentityService.Persistance.Migrations
{
    [DbContext(typeof(IdentityServiceDbContext))]
    partial class IdentityServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.HasSequence("RefreshTokenSeq");

            modelBuilder.HasSequence("RoleSeq")
                .StartsAt(3L);

            modelBuilder.HasSequence("UserRoleSeq")
                .StartsAt(9L);

            modelBuilder.HasSequence("UserSeq")
                .StartsAt(6L);

            modelBuilder.Entity("IdentityService.Domain.Entities.Log", b =>
                {
                    b.Property<string>("Body")
                        .HasColumnType("jsonb")
                        .HasColumnName("body");

                    b.Property<string>("Exception")
                        .HasColumnType("text")
                        .HasColumnName("exception");

                    b.Property<string>("HttpMethod")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("http_method");

                    b.Property<string>("Level")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("level");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.Property<string>("MessageTemplate")
                        .HasColumnType("text")
                        .HasColumnName("message_template");

                    b.Property<string>("Path")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("path");

                    b.Property<string>("Properties")
                        .HasColumnType("jsonb")
                        .HasColumnName("properties");

                    b.Property<string>("QueryParams")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("query_params");

                    b.Property<DateTime?>("TimeStamp")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("time_stamp");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.ToTable("logs", (string)null);
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('\"RefreshTokenSeq\"'::regclass)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("created_by_ip");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("integer")
                        .HasColumnName("deleted_by");

                    b.Property<DateTime>("ExpiresDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expires_date");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("Jti")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("jti");

                    b.Property<string>("ReasonRevoked")
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("reason_revoked");

                    b.Property<Guid>("RecordGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("record_guid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ReplacedByJti")
                        .HasColumnType("text")
                        .HasColumnName("replaced_by_jti");

                    b.Property<string>("RevokedByIp")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("revoked_by_ip");

                    b.Property<DateTime?>("RevokedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("revoked_date");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("refresh_tokens_pk");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('\"RoleSeq\"'::regclass)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("integer")
                        .HasColumnName("deleted_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("RecordGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("record_guid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("RoleValue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("role_value");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("roles_pk");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4780),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("67a60545-6fdc-4e46-ab93-307b7a810ab3"),
                            RoleValue = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4790),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("e4e17ac3-95d1-448a-8ab4-c9b7f062d4ef"),
                            RoleValue = "User"
                        });
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('\"UserSeq\"'::regclass)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("integer")
                        .HasColumnName("deleted_by");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea")
                        .HasColumnName("password_hash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea")
                        .HasColumnName("password_salt");

                    b.Property<Guid>("RecordGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("record_guid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Surname")
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)")
                        .HasColumnName("surname");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("user_pk");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4680),
                            Email = "fatihsari1992@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Fatih",
                            PasswordHash = new byte[] { 61, 113, 107, 215, 227, 184, 85, 59, 184, 93, 163, 54, 78, 100, 185, 117, 81, 159, 98, 22, 18, 157, 84, 138, 13, 212, 237, 146, 163, 126, 169, 134, 17, 245, 163, 194, 70, 219, 3, 6, 252, 147, 192, 253, 188, 102, 161, 123, 78, 191, 3, 178, 180, 251, 116, 213, 207, 120, 134, 92, 240, 136, 127, 53 },
                            PasswordSalt = new byte[] { 115, 137, 47, 244, 22, 169, 144, 102, 210, 133, 224, 78, 130, 204, 197, 220, 132, 131, 126, 1, 72, 71, 1, 176, 115, 190, 141, 200, 32, 245, 97, 45, 160, 1, 10, 31, 41, 152, 164, 193, 190, 20, 2, 248, 97, 69, 188, 105, 173, 4, 124, 171, 245, 255, 116, 78, 106, 165, 245, 252, 68, 8, 137, 164, 213, 86, 210, 8, 107, 88, 63, 41, 10, 36, 5, 97, 79, 68, 87, 86, 203, 0, 129, 132, 162, 44, 141, 106, 136, 179, 164, 20, 78, 204, 59, 1, 219, 184, 93, 53, 241, 57, 5, 63, 118, 188, 238, 199, 17, 160, 250, 176, 35, 108, 145, 172, 122, 245, 92, 97, 82, 29, 156, 164, 143, 65, 151, 141 },
                            RecordGuid = new Guid("6483bf25-3dba-4c47-b5d2-baf98e1f43e5"),
                            Surname = "Sarı",
                            Username = "sari1fatih"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4690),
                            Email = "tahirgorkan@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Tahir",
                            PasswordHash = new byte[] { 61, 113, 107, 215, 227, 184, 85, 59, 184, 93, 163, 54, 78, 100, 185, 117, 81, 159, 98, 22, 18, 157, 84, 138, 13, 212, 237, 146, 163, 126, 169, 134, 17, 245, 163, 194, 70, 219, 3, 6, 252, 147, 192, 253, 188, 102, 161, 123, 78, 191, 3, 178, 180, 251, 116, 213, 207, 120, 134, 92, 240, 136, 127, 53 },
                            PasswordSalt = new byte[] { 115, 137, 47, 244, 22, 169, 144, 102, 210, 133, 224, 78, 130, 204, 197, 220, 132, 131, 126, 1, 72, 71, 1, 176, 115, 190, 141, 200, 32, 245, 97, 45, 160, 1, 10, 31, 41, 152, 164, 193, 190, 20, 2, 248, 97, 69, 188, 105, 173, 4, 124, 171, 245, 255, 116, 78, 106, 165, 245, 252, 68, 8, 137, 164, 213, 86, 210, 8, 107, 88, 63, 41, 10, 36, 5, 97, 79, 68, 87, 86, 203, 0, 129, 132, 162, 44, 141, 106, 136, 179, 164, 20, 78, 204, 59, 1, 219, 184, 93, 53, 241, 57, 5, 63, 118, 188, 238, 199, 17, 160, 250, 176, 35, 108, 145, 172, 122, 245, 92, 97, 82, 29, 156, 164, 143, 65, 151, 141 },
                            RecordGuid = new Guid("c929ffad-6122-4f2c-bdf0-f9f09aefd1a5"),
                            Surname = "Görkan",
                            Username = "gorkan1tahir"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4700),
                            Email = "utkan@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Utkan",
                            PasswordHash = new byte[] { 61, 113, 107, 215, 227, 184, 85, 59, 184, 93, 163, 54, 78, 100, 185, 117, 81, 159, 98, 22, 18, 157, 84, 138, 13, 212, 237, 146, 163, 126, 169, 134, 17, 245, 163, 194, 70, 219, 3, 6, 252, 147, 192, 253, 188, 102, 161, 123, 78, 191, 3, 178, 180, 251, 116, 213, 207, 120, 134, 92, 240, 136, 127, 53 },
                            PasswordSalt = new byte[] { 115, 137, 47, 244, 22, 169, 144, 102, 210, 133, 224, 78, 130, 204, 197, 220, 132, 131, 126, 1, 72, 71, 1, 176, 115, 190, 141, 200, 32, 245, 97, 45, 160, 1, 10, 31, 41, 152, 164, 193, 190, 20, 2, 248, 97, 69, 188, 105, 173, 4, 124, 171, 245, 255, 116, 78, 106, 165, 245, 252, 68, 8, 137, 164, 213, 86, 210, 8, 107, 88, 63, 41, 10, 36, 5, 97, 79, 68, 87, 86, 203, 0, 129, 132, 162, 44, 141, 106, 136, 179, 164, 20, 78, 204, 59, 1, 219, 184, 93, 53, 241, 57, 5, 63, 118, 188, 238, 199, 17, 160, 250, 176, 35, 108, 145, 172, 122, 245, 92, 97, 82, 29, 156, 164, 143, 65, 151, 141 },
                            RecordGuid = new Guid("02be94e8-0b99-4ddc-a5ac-7fa25f3919fb"),
                            Surname = "Adıgüzel",
                            Username = "adıguzel1utkan"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4700),
                            Email = "kutay@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Kutay",
                            PasswordHash = new byte[] { 61, 113, 107, 215, 227, 184, 85, 59, 184, 93, 163, 54, 78, 100, 185, 117, 81, 159, 98, 22, 18, 157, 84, 138, 13, 212, 237, 146, 163, 126, 169, 134, 17, 245, 163, 194, 70, 219, 3, 6, 252, 147, 192, 253, 188, 102, 161, 123, 78, 191, 3, 178, 180, 251, 116, 213, 207, 120, 134, 92, 240, 136, 127, 53 },
                            PasswordSalt = new byte[] { 115, 137, 47, 244, 22, 169, 144, 102, 210, 133, 224, 78, 130, 204, 197, 220, 132, 131, 126, 1, 72, 71, 1, 176, 115, 190, 141, 200, 32, 245, 97, 45, 160, 1, 10, 31, 41, 152, 164, 193, 190, 20, 2, 248, 97, 69, 188, 105, 173, 4, 124, 171, 245, 255, 116, 78, 106, 165, 245, 252, 68, 8, 137, 164, 213, 86, 210, 8, 107, 88, 63, 41, 10, 36, 5, 97, 79, 68, 87, 86, 203, 0, 129, 132, 162, 44, 141, 106, 136, 179, 164, 20, 78, 204, 59, 1, 219, 184, 93, 53, 241, 57, 5, 63, 118, 188, 238, 199, 17, 160, 250, 176, 35, 108, 145, 172, 122, 245, 92, 97, 82, 29, 156, 164, 143, 65, 151, 141 },
                            RecordGuid = new Guid("39908266-05e0-4850-83ba-5b0dc5c8defe"),
                            Surname = "Acar",
                            Username = "acar1kutay"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4710),
                            Email = "enes@gmail.com",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Enes",
                            PasswordHash = new byte[] { 61, 113, 107, 215, 227, 184, 85, 59, 184, 93, 163, 54, 78, 100, 185, 117, 81, 159, 98, 22, 18, 157, 84, 138, 13, 212, 237, 146, 163, 126, 169, 134, 17, 245, 163, 194, 70, 219, 3, 6, 252, 147, 192, 253, 188, 102, 161, 123, 78, 191, 3, 178, 180, 251, 116, 213, 207, 120, 134, 92, 240, 136, 127, 53 },
                            PasswordSalt = new byte[] { 115, 137, 47, 244, 22, 169, 144, 102, 210, 133, 224, 78, 130, 204, 197, 220, 132, 131, 126, 1, 72, 71, 1, 176, 115, 190, 141, 200, 32, 245, 97, 45, 160, 1, 10, 31, 41, 152, 164, 193, 190, 20, 2, 248, 97, 69, 188, 105, 173, 4, 124, 171, 245, 255, 116, 78, 106, 165, 245, 252, 68, 8, 137, 164, 213, 86, 210, 8, 107, 88, 63, 41, 10, 36, 5, 97, 79, 68, 87, 86, 203, 0, 129, 132, 162, 44, 141, 106, 136, 179, 164, 20, 78, 204, 59, 1, 219, 184, 93, 53, 241, 57, 5, 63, 118, 188, 238, 199, 17, 160, 250, 176, 35, 108, 145, 172, 122, 245, 92, 97, 82, 29, 156, 164, 143, 65, 151, 141 },
                            RecordGuid = new Guid("e7f8a186-f416-459f-b91a-f2ce41dd105e"),
                            Surname = "Behlül",
                            Username = "behlul1enes"
                        });
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasDefaultValueSql("nextval('\"UserRoleSeq\"'::regclass)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("integer")
                        .HasColumnName("deleted_by");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("RecordGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("record_guid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("user_roles_pk");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4810),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("f7867ea0-022a-4d36-b414-48038093c945"),
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4820),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("a295ed80-d16f-4d8e-b7ee-5b4eb5809f31"),
                            RoleId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4820),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("b4053beb-89f9-4ac9-bf22-1c688f8b0f14"),
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4830),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("1fd77b14-7ba5-4733-9c7e-b9596cdbe0e1"),
                            RoleId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4830),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("27283539-afc9-464a-bfb5-85fc4e9cbd71"),
                            RoleId = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4840),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("f5cdc333-b458-45cc-9236-142f6771447f"),
                            RoleId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4840),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("9f12fd16-80dd-4e62-a15f-cc6f13bddf9e"),
                            RoleId = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2025, 2, 14, 15, 40, 38, 579, DateTimeKind.Utc).AddTicks(4840),
                            CreatedBy = 1,
                            IsActive = true,
                            IsDeleted = false,
                            RecordGuid = new Guid("54954d51-172f-473b-ad3e-8c06e2692e7e"),
                            RoleId = 2,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.User", "CreatedByNavigation")
                        .WithMany("RefreshTokenCreatedByNavigations")
                        .HasForeignKey("CreatedBy")
                        .IsRequired()
                        .HasConstraintName("refreshtokens_users_created_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "DeletedByNavigation")
                        .WithMany("RefreshTokenDeletedByNavigations")
                        .HasForeignKey("DeletedBy")
                        .HasConstraintName("refreshtokens_users_deleted_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "UpdatedByNavigation")
                        .WithMany("RefreshTokenUpdatedByNavigations")
                        .HasForeignKey("UpdatedBy")
                        .HasConstraintName("refreshtokens_users_updated_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "User")
                        .WithMany("RefreshTokenUsers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("refreshtokens_users_user_id_fk");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("DeletedByNavigation");

                    b.Navigation("UpdatedByNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Role", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.User", "CreatedByNavigation")
                        .WithMany("RoleCreatedByNavigations")
                        .HasForeignKey("CreatedBy")
                        .IsRequired()
                        .HasConstraintName("roles_users_created_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "DeletedByNavigation")
                        .WithMany("RoleDeletedByNavigations")
                        .HasForeignKey("DeletedBy")
                        .HasConstraintName("roles_users_deleted_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "UpdatedByNavigation")
                        .WithMany("RoleUpdatedByNavigations")
                        .HasForeignKey("UpdatedBy")
                        .HasConstraintName("roles_users_updated_by_fk");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("DeletedByNavigation");

                    b.Navigation("UpdatedByNavigation");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.User", "DeletedByNavigation")
                        .WithMany("InverseDeletedByNavigation")
                        .HasForeignKey("DeletedBy")
                        .HasConstraintName("users_users_deleted_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "UpdatedByNavigation")
                        .WithMany("InverseUpdatedByNavigation")
                        .HasForeignKey("UpdatedBy")
                        .HasConstraintName("users_users_updated_by_fk");

                    b.Navigation("DeletedByNavigation");

                    b.Navigation("UpdatedByNavigation");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.UserRole", b =>
                {
                    b.HasOne("IdentityService.Domain.Entities.User", "CreatedByNavigation")
                        .WithMany("UserRoleCreatedByNavigations")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("userroles_users_created_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "DeletedByNavigation")
                        .WithMany("UserRoleDeletedByNavigations")
                        .HasForeignKey("DeletedBy")
                        .HasConstraintName("userroles_users_deleted_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("userroles_roles_role_id_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "UpdatedByNavigation")
                        .WithMany("UserRoleUpdatedByNavigations")
                        .HasForeignKey("UpdatedBy")
                        .HasConstraintName("userroles_users_updated_by_fk");

                    b.HasOne("IdentityService.Domain.Entities.User", "User")
                        .WithMany("UserRoleUsers")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("userroles_users_user_id_fk");

                    b.Navigation("CreatedByNavigation");

                    b.Navigation("DeletedByNavigation");

                    b.Navigation("Role");

                    b.Navigation("UpdatedByNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("IdentityService.Domain.Entities.User", b =>
                {
                    b.Navigation("InverseDeletedByNavigation");

                    b.Navigation("InverseUpdatedByNavigation");

                    b.Navigation("RefreshTokenCreatedByNavigations");

                    b.Navigation("RefreshTokenDeletedByNavigations");

                    b.Navigation("RefreshTokenUpdatedByNavigations");

                    b.Navigation("RefreshTokenUsers");

                    b.Navigation("RoleCreatedByNavigations");

                    b.Navigation("RoleDeletedByNavigations");

                    b.Navigation("RoleUpdatedByNavigations");

                    b.Navigation("UserRoleCreatedByNavigations");

                    b.Navigation("UserRoleDeletedByNavigations");

                    b.Navigation("UserRoleUpdatedByNavigations");

                    b.Navigation("UserRoleUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
