using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace my_website.Persistance.Context.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "Age", "ArticleId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonalInfo", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"), 0, "Altındağ, Ankara", 23, null, new DateTime(1998, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "6869a072-2188-4542-86da-3dc55583521b", "kirikonurr@gmail.com", true, 2, false, null, "Onur", "KIRIKONURR@GMAIL.COM", "ONURKIRIK", "AQAAAAIAAYagAAAAEBbVGWbxHlHxVvAwb+pKEeuNjPJukNiTO2rpQppb3QAmLtj2GlrbZZuV9bH4ctND9Q==", "Lorem ipsum dolor sit amet", "+905423815262", false, null, "KIRIK", false, "onurkirik" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a8639731-02ef-4616-ad38-169b6a170ffb"), "Sample Category 2" },
                    { new Guid("c9f12a78-5e28-497e-9988-6f32415db2ea"), "Sample Category 1" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("50ac383a-e034-438d-97b7-3123e27837e3"), new Guid("c9f12a78-5e28-497e-9988-6f32415db2ea"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9575), "Sample Article 2", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9577), new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc") },
                    { new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"), new Guid("c9f12a78-5e28-497e-9988-6f32415db2ea"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9548), "Sample Article 1", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9564), new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc") },
                    { new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"), new Guid("a8639731-02ef-4616-ad38-169b6a170ffb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9591), "Sample Article 4", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9592), new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc") },
                    { new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"), new Guid("a8639731-02ef-4616-ad38-169b6a170ffb"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9584), "Sample Article 3", new DateTime(2023, 6, 16, 6, 0, 35, 945, DateTimeKind.Local).AddTicks(9585), new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("50ac383a-e034-438d-97b7-3123e27837e3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a44ce742-19c4-4c85-b8f1-8a2f35f9ceb4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b001002c-39fb-44bf-8cfc-6f72493e160d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dd69b936-a71e-458b-a198-8e1ee07807aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8391c80b-c0f3-478d-a936-c4cf655f20cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8639731-02ef-4616-ad38-169b6a170ffb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9f12a78-5e28-497e-9988-6f32415db2ea"));
        }
    }
}
