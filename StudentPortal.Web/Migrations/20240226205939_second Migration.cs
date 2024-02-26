using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal.Web.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subcribe",
                table: "Student",
                newName: "Subscribed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subscribed",
                table: "Student",
                newName: "Subcribe");
        }
    }
}
