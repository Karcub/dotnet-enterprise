using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_enterprise.Migrations
{
    public partial class SeedUpdatedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Category",
                value: "THEATER");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Category",
                value: "THEATER");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Category",
                value: "THEATER");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Category",
                value: "THEATER");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Category", "City", "Location", "Subtitle" },
                values: new object[] { "THEATER", "Budapest", "Budapest Bábszínház, Nagyszínpad <br>1062 Budapest, Andrássy út 69.", "Ajánlott korhatár: +3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 26L,
                column: "Category",
                value: "OPERA");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 27L,
                column: "Category",
                value: "OPERA");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 28L,
                column: "Category",
                value: "OPERA");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 29L,
                column: "Category",
                value: "MUSICAL");

            migrationBuilder.UpdateData(
                table: "EventItems",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "Category", "City", "Location", "Subtitle" },
                values: new object[] { "PUPPET-THEATER", "Budapest Bábszínház, Nagyszínpad <br>1062 Budapest, Andrássy út 69.", "Budapest", "Ajánlott életkor: 3+" });
        }
    }
}
