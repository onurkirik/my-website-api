using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_website.Persistance.Context.Migrations
{
    /// <inheritdoc />
    public partial class imagurlremoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 1, 24, 59, 282, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 1, 24, 59, 282, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 1, 24, 59, 282, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 29, 1, 24, 59, 282, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "590f84ce-57df-4371-b52e-3b67d12e90ff", "AQAAAAIAAYagAAAAENyxxReD+WHtHswI9Dau7yTRTeb/nVhrSfMYZT2OYcKZxsn6Iext7DPZIa4+eFlhIw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 20, 46, 37, 934, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 20, 46, 37, 934, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 20, 46, 37, 934, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 28, 20, 46, 37, 934, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash" },
                values: new object[] { "4d21155c-4ce7-46c3-8b1b-aaaeb2c6a50c", null, "AQAAAAIAAYagAAAAEJ/JJex4ipxiR9cHqOBJvav/uGkpmIWBGel4mg6SmF++Sv8YuNLKua9HXhOFQiX8qw==" });
        }
    }
}
