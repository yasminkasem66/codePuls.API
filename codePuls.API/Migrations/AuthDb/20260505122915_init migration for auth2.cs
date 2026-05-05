using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codePuls.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class initmigrationforauth2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fd6413c-b88f-4f06-987d-d28917922479", "AQAAAAIAAYagAAAAEESo1xrMMhvTOQgzlDis3CwJChCD0BNHloBFsey0DavPCbL/oyYQJFpwEq3MmOkgnQ==", "2812a105-e980-472a-89d5-0719aa19c06d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bb6f842-b0b0-473b-8c8f-338ce9c0c310", "AQAAAAIAAYagAAAAEBLE76GcO4da2A4PzKPEOyRrohr+NYBuYQjOLen0xgFptokZooPskPIbSeBm7MXfdA==", "dd295d16-1ce0-4b8b-8f9b-374acb678a43" });
        }
    }
}
