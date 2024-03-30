using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFotografo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaVisitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Visitas (DataHora, FotografoId) 
                        VALUES ('2023-01-15 10:00:00', 1)");

            migrationBuilder.Sql(@"INSERT INTO Visitas (DataHora, FotografoId) 
                        VALUES ('2023-02-20 15:30:00', 2)");

            migrationBuilder.Sql(@"INSERT INTO Visitas (DataHora, FotografoId) 
                        VALUES ('2023-03-10 09:45:00', 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Visitas");
        }
    }
}
