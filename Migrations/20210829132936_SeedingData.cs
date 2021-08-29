using Microsoft.EntityFrameworkCore.Migrations;

namespace HList.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "Name", "ShortName" },
                values: new object[] { 1, "Sri Lanka", "SL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "Name", "ShortName" },
                values: new object[] { 2, "Australia", "AU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "Name", "ShortName" },
                values: new object[] { 3, "New Zreland", "NZ" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 1, "Colombo", 1, "Hilton ", 5.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 2, "Perth", 2, "New Moon", 4.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelID", "Address", "CountryID", "Name", "Rating" },
                values: new object[] { 3, "Welington", 3, "River Face", 4.5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 3);
        }
    }
}
