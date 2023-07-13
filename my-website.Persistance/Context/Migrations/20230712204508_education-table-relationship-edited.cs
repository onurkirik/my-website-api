using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_website.Persistance.Context.Migrations
{
    /// <inheritdoc />
    public partial class educationtablerelationshipedited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Educations_UserId",
                table: "Educations");

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

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Educations_UserId",
                table: "Educations");

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

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId",
                unique: true);
        }
    }
}
