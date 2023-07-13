using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_website.Persistance.Context.Migrations
{
    /// <inheritdoc />
    public partial class socialmediaaddedproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 7, 43, 47, 950, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 7, 43, 47, 950, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 7, 43, 47, 950, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 13, 7, 43, 47, 950, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24dbe699-cb1c-4584-9400-76b9c07e16a3", "AQAAAAIAAYagAAAAEPODdOE8oq/zHKWZJFOCB2a99PPPXsP966G3TQWtjwJNlBHLSWmRHFJtQTqTNeOz1Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialMedias");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 23, 45, 7, 949, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 23, 45, 7, 949, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 23, 45, 7, 949, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 12, 23, 45, 7, 949, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98697d69-2281-41e5-b822-ffce99739dad", "AQAAAAIAAYagAAAAENA5oXbuaAhTAsjJjXwiTk8HsBJ1hCsndJgBaE21LRlkqeTK2vSyDBOIfi7GveKo9w==" });
        }
    }
}
