using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroFornecedor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Empresa",
                columns: table => new
                {
                    cod_empresa = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    razao_social = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    nome_fantasia = table.Column<string>(type: "text", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Empresa", x => x.cod_empresa);
                });

            migrationBuilder.CreateTable(
                name: "tbl_fornecedor",
                columns: table => new
                {
                    cod_fornecedor = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_contato_forn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_fornecedor", x => x.cod_fornecedor);
                });

            migrationBuilder.CreateTable(
                name: "Forn_Emps",
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
                    table.PrimaryKey("PK_Forn_Emps", x => x.cod_forn_emps);
                    table.ForeignKey(
                        name: "FK_Forn_Emps_tbl_Empresa_Empresacod_empresa",
                        column: x => x.Empresacod_empresa,
                        principalTable: "tbl_Empresa",
                        principalColumn: "cod_empresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forn_Emps_tbl_fornecedor_Fornecedorcod_fornecedor",
                        column: x => x.Fornecedorcod_fornecedor,
                        principalTable: "tbl_fornecedor",
                        principalColumn: "cod_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Endereco",
                columns: table => new
                {
                    cod_endereco = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    end_cidade = table.Column<string>(type: "text", maxLength: 20, nullable: false),
                    end_bairro = table.Column<string>(type: "text", maxLength: 20, nullable: false),
                    end_cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    end_logradouro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cod_fornecedor = table.Column<long>(type: "bigint", nullable: true),
                    Fornecedorcod_fornecedor = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Endereco", x => x.cod_endereco);
                    table.ForeignKey(
                        name: "FK_tbl_Endereco_tbl_fornecedor_Fornecedorcod_fornecedor",
                        column: x => x.Fornecedorcod_fornecedor,
                        principalTable: "tbl_fornecedor",
                        principalColumn: "cod_fornecedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forn_Emps_Empresacod_empresa",
                table: "Forn_Emps",
                column: "Empresacod_empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Forn_Emps_Fornecedorcod_fornecedor",
                table: "Forn_Emps",
                column: "Fornecedorcod_fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Endereco_Fornecedorcod_fornecedor",
                table: "tbl_Endereco",
                column: "Fornecedorcod_fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forn_Emps");

            migrationBuilder.DropTable(
                name: "tbl_Endereco");

            migrationBuilder.DropTable(
                name: "tbl_Empresa");

            migrationBuilder.DropTable(
                name: "tbl_fornecedor");
        }
    }
}
