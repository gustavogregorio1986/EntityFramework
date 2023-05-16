using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "tb_Candidato",
                columns: table => new
                {
                    IdCandidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCndidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telfone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Candidato", x => x.IdCandidato);
                    table.ForeignKey(
                        name: "FK_tb_Candidato_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Recrutador",
                columns: table => new
                {
                    IdRecrutador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRecrutador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailRecrutador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Recrutador", x => x.IdRecrutador);
                    table.ForeignKey(
                        name: "FK_tb_Recrutador_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Empresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEmopresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Candidato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Empresa", x => x.IdEmpresa);
                    table.ForeignKey(
                        name: "FK_tb_Empresa_tb_Candidato_Id_Candidato",
                        column: x => x.Id_Candidato,
                        principalTable: "tb_Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Candidato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Candidato_Id_Candidato",
                        column: x => x.Id_Candidato,
                        principalTable: "tb_Candidato",
                        principalColumn: "IdCandidato",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Setor",
                columns: table => new
                {
                    IdSetor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeSetor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Empresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Setor", x => x.IdSetor);
                    table.ForeignKey(
                        name: "FK_tb_Setor_tb_Empresa_Id_Empresa",
                        column: x => x.Id_Empresa,
                        principalTable: "tb_Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Candidato_Id_Usuario",
                table: "tb_Candidato",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Empresa_Id_Candidato",
                table: "tb_Empresa",
                column: "Id_Candidato");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Candidato",
                table: "tb_Endereco",
                column: "Id_Candidato");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Recrutador_Id_Usuario",
                table: "tb_Recrutador",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Setor_Id_Empresa",
                table: "tb_Setor",
                column: "Id_Empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Recrutador");

            migrationBuilder.DropTable(
                name: "tb_Setor");

            migrationBuilder.DropTable(
                name: "tb_Empresa");

            migrationBuilder.DropTable(
                name: "tb_Candidato");

            migrationBuilder.DropTable(
                name: "tb_Usuario");
        }
    }
}
