using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codePuls.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class initmigrationforauth1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bb6f842-b0b0-473b-8c8f-338ce9c0c310", "AQAAAAIAAYagAAAAEBLE76GcO4da2A4PzKPEOyRrohr+NYBuYQjOLen0xgFptokZooPskPIbSeBm7MXfdA==", "dd295d16-1ce0-4b8b-8f9b-374acb678a43" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b941c90-9e0b-46e4-8ac8-465fe5142204", "AQAAAAIAAYagAAAAEAFMCxjM1Xn8hHp8qR3HW8/rsicpYklYB+vFAxdz+iwKpqdFp/AfBZA5gf+UifvdZg==", "3cdb3bbc-5150-451b-9bc8-162692140390" });
        }
    }
}
