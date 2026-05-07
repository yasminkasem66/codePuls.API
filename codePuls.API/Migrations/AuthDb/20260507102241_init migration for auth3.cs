using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codePuls.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class initmigrationforauth3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aaa37cd-afda-4863-812b-44b6d53bad91", "AQAAAAIAAYagAAAAEMrmTYytzb+QlEqDE3OPPjT1R5o0KSYvvjwyn0g+BuJzhJwD/YmoV/fJW6ipk2fWwA==", "3afefbb6-6437-4fb8-91e3-e125d10bf1b2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fd6413c-b88f-4f06-987d-d28917922479", "AQAAAAIAAYagAAAAEESo1xrMMhvTOQgzlDis3CwJChCD0BNHloBFsey0DavPCbL/oyYQJFpwEq3MmOkgnQ==", "2812a105-e980-472a-89d5-0719aa19c06d" });
        }
    }
}
