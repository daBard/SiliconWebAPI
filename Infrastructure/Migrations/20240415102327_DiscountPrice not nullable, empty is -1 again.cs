using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DiscountPricenotnullableemptyis1again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                    name: "DiscountPrice",
                    table: "Courses",
                    type: "smallmoney",
                    nullable: false,
                    defaultValue: -1m
                    );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                    name: "DiscountPrice",
                    table: "Courses",
                    type: "smallmoney",
                    nullable: false,
                    defaultValue: 0m
                    );
        }
    }
}
