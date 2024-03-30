using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFotografo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaFotografos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Fotografos (NomeCompleto, CPF, DataNascimento, Email, Telefone, Endereco, CameraFotografica, DataUltimaVisita) 
                            VALUES ('Diego Porcino Pereira', '123.456.789-00', '1995-05-13', 'diegottp50@hotmail.com', '(12) 3456-7890', 'Rua Ademar de Azevedo Marques, 28', 'Canon 7D', null)");

            migrationBuilder.Sql(@"INSERT INTO Fotografos (NomeCompleto, CPF, DataNascimento, Email, Telefone, Endereco, CameraFotografica, DataUltimaVisita) 
                            VALUES ('Diogo Porcino Pereira', '456.789.101-10', '2024-11-02', 'diogo27@hotmail.com', '(10) 1112-1314', 'Rua Marques Ademar de Azevedo, 30', 'Canon 80D', null)");

            migrationBuilder.Sql(@"INSERT INTO Fotografos (NomeCompleto, CPF, DataNascimento, Email, Telefone, Endereco, CameraFotografica, DataUltimaVisita) 
                            VALUES ('Dionas Porcino Pereira', '406.799.701-90', '2024-11-10', 'dionaspp501@hotmail.com', '(15) 1617-1819', 'Rua Azevedo Marques de Ademar, 320', 'Canon 6D', null)");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Fotografos");
        }
    }
}
