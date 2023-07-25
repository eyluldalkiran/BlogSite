using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedcompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("01fa1372-98b1-476d-9fd5-7c3450d25139"), "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(7212), null, null, false, null, null, "ASP.net" },
                    { new Guid("36d3c733-c838-4caa-a507-23287fbaf903"), "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(7221), null, null, false, null, null, "Visual Studio" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("0fb825b6-540d-4726-a3f0-f08bf69e6fb4"), "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(7466), null, null, "images/testimage2", "png", false, null, null },
                    { new Guid("38681e98-5fd8-4ad5-b318-d658f8d05913"), "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(7459), null, null, "images/testimage", "jpeg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b1a4c2a4-34af-4e48-a4cc-db6f018c007f"), new Guid("36d3c733-c838-4caa-a507-23287fbaf903"), "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi quis semper ipsum, a viverra lacus. Sed eleifend rutrum ligula sed venenatis. Proin quis eros quis mauris euismod mollis. Fusce aliquet sem malesuada urna scelerisque dictum. Proin id odio non neque gravida facilisis. Donec molestie euismod dolor eu molestie. Vivamus dictum pulvinar dignissim. Proin blandit faucibus nulla. Donec dictum ante et massa congue commodo. Donec quis purus purus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Ut nec dolor id ante venenatis sagittis. Fusce id tortor tristique, posuere magna sed, gravida metus. Suspendisse potenti. Nam elementum pulvinar orci, tempus tristique ante tempus non.", "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(6755), null, null, new Guid("0fb825b6-540d-4726-a3f0-f08bf69e6fb4"), false, null, null, "Visual Studio makalesi", 15 },
                    { new Guid("fa3c1884-09ec-42d6-9a2e-0d19f1b0c4e4"), new Guid("01fa1372-98b1-476d-9fd5-7c3450d25139"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi quis semper ipsum, a viverra lacus. Sed eleifend rutrum ligula sed venenatis. Proin quis eros quis mauris euismod mollis. Fusce aliquet sem malesuada urna scelerisque dictum. Proin id odio non neque gravida facilisis. Donec molestie euismod dolor eu molestie. Vivamus dictum pulvinar dignissim. Proin blandit faucibus nulla. Donec dictum ante et massa congue commodo. Donec quis purus purus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Ut nec dolor id ante venenatis sagittis. Fusce id tortor tristique, posuere magna sed, gravida metus. Suspendisse potenti. Nam elementum pulvinar orci, tempus tristique ante tempus non.", "Admin Test", new DateTime(2023, 7, 5, 14, 30, 59, 422, DateTimeKind.Local).AddTicks(6726), null, null, new Guid("38681e98-5fd8-4ad5-b318-d658f8d05913"), false, null, null, "Asp.net core deneme makalesi", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b1a4c2a4-34af-4e48-a4cc-db6f018c007f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fa3c1884-09ec-42d6-9a2e-0d19f1b0c4e4"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("01fa1372-98b1-476d-9fd5-7c3450d25139"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("36d3c733-c838-4caa-a507-23287fbaf903"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0fb825b6-540d-4726-a3f0-f08bf69e6fb4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("38681e98-5fd8-4ad5-b318-d658f8d05913"));

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
