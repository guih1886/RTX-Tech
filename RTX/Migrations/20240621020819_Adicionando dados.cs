using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RTX.Migrations
{
    /// <inheritdoc />
    public partial class Adicionandodados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, "Creme de leite ideal para preparo de um belo strognoff.", "Creme de leite", "https://superprix.vteximg.com.br/arquivos/ids/208274-600-600/7898215151784--1-.jpg?v=637915926153930000", 2.5899999999999999 },
                    { 2, "Achocolado da vaquinha.", "Achocolatado Toddy", "https://ibassets.com.br/ib.item.image.large/l-a61c4723589c44c1b15c32685f5cee67.png", 12.99 },
                    { 3, "Maionese premium feita com ingredientes selecionados.", "Maionese Heinz", "https://ibassets.com.br/ib.item.image.large/l-0bb27cf2a14c450ead9ab29f0fa2b4d1.jpeg", 19.989999999999998 },
                    { 4, "Salgadinho sabor cheddar, o melhor de todos.", "Salgadinho Doritos", "https://atacadaobr.vtexassets.com/arquivos/ids/252509/g.jpg?v=638353972719200000", 10.0 },
                    { 5, "Refrigerante de cola mais famoso do mundo", "Coca-Cola 2L", "https://www.paodeacucar.com/img/uploads/1/120/24982120.png", 8.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
