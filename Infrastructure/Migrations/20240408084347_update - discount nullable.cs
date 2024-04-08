using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatediscountnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "Courses",
                type: "smallmoney",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "smallmoney");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountPrice",
                table: "Courses",
                type: "smallmoney",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "smallmoney",
                oldNullable: true);
        }
    }
}
