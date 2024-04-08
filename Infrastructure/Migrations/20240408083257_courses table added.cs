using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class coursestableadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "smallmoney", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    TotalBuyers = table.Column<long>(type: "bigint", nullable: false),
                    TotalLikes = table.Column<long>(type: "bigint", nullable: false),
                    BestSeller = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
