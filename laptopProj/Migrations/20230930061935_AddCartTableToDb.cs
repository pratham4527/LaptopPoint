using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace laptopProj.Migrations
{
    /// <inheritdoc />
    public partial class AddCartTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Laptops",
                table: "Laptops");

            migrationBuilder.RenameTable(
                name: "Laptops",
                newName: "Laptopstbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laptopstbl",
                table: "Laptopstbl",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Carttbl",
                columns: table => new
                {
                    P_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carttbl", x => x.P_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carttbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Laptopstbl",
                table: "Laptopstbl");

            migrationBuilder.RenameTable(
                name: "Laptopstbl",
                newName: "Laptops");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Laptops",
                table: "Laptops",
                column: "Id");
        }
    }
}
