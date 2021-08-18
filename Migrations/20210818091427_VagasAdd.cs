using Microsoft.EntityFrameworkCore.Migrations;

namespace api_jobsnet.Migrations
{
    public partial class VagasAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    cpf = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    nascimento = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    cep = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    logradouro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    numero_logradouro = table.Column<int>(type: "int", nullable: false),
                    bairro = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    cidade = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Estado = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    telefone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    id_vaga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vagas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    descricao = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidatos");

            migrationBuilder.DropTable(
                name: "vagas");
        }
    }
}
