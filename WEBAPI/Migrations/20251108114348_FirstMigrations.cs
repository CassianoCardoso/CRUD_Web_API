using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ID             = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("SqlServer:Identity", "1, 1"),
                    Nome           = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao      = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade     = table.Column<int>(type: "int", nullable: false),
                    CodigoDeBarras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca          = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
