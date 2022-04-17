using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFornecedor.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    cod_empresa = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razao_social = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    nome_fantasia = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    emp_email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.cod_empresa);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    cod_fornecedor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_contato_forn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.cod_fornecedor);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    cod_endereco = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    referente = table.Column<string>(type: "text", nullable: false),
                    end_cidade = table.Column<string>(type: "text", maxLength: 20, nullable: false),
                    end_bairro = table.Column<string>(type: "text", maxLength: 20, nullable: false),
                    end_cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    end_logradouro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    end_numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cod_empresa = table.Column<long>(type: "bigint", nullable: true),
                    Empresacod_empresa = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.cod_endereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Empresa_Empresacod_empresa",
                        column: x => x.Empresacod_empresa,
                        principalTable: "Empresa",
                        principalColumn: "cod_empresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FornEmp",
                columns: table => new
                {
                    cod_forn_emps = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_empresa = table.Column<long>(type: "bigint", nullable: true),
                    cod_fornecedor = table.Column<long>(type: "bigint", nullable: true),
                    Empresacod_empresa = table.Column<long>(type: "bigint", nullable: false),
                    Fornecedorcod_fornecedor = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornEmp", x => x.cod_forn_emps);
                    table.ForeignKey(
                        name: "FK_FornEmp_Empresa_Empresacod_empresa",
                        column: x => x.Empresacod_empresa,
                        principalTable: "Empresa",
                        principalColumn: "cod_empresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FornEmp_Fornecedor_Fornecedorcod_fornecedor",
                        column: x => x.Fornecedorcod_fornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "cod_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Empresacod_empresa",
                table: "Endereco",
                column: "Empresacod_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_FornEmp_Empresacod_empresa",
                table: "FornEmp",
                column: "Empresacod_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_FornEmp_Fornecedorcod_fornecedor",
                table: "FornEmp",
                column: "Fornecedorcod_fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "FornEmp");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
