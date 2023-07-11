using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_website.Persistance.Context.Migrations
{
    /// <inheritdoc />
    public partial class projectaddednewfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 21, 12, 9, 858, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 21, 12, 9, 858, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 21, 12, 9, 858, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 21, 12, 9, 858, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5470b95-42e2-4021-a2fa-b3388832bf24", "AQAAAAIAAYagAAAAECPjB/EJ/j4ykL3nTzjgeKqFq5NNjyBbrhdVW432FP1whtZm730Rtx/MD7d4RFYGEg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 21, 4, 14, 909, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 21, 4, 14, 909, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 21, 4, 14, 909, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 20, 21, 4, 14, 909, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac3a6bc8-30a4-4e22-bbfb-5dc11944ea1a", "AQAAAAIAAYagAAAAEIZjy4rh9KnIxOtle+zE6qvszc6zSYm9pLMdmb383tS0S+MMFtWe+OYyfQt3L4EGdA==" });
        }
    }
}
