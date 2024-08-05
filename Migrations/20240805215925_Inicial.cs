using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Declaraciones.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Iddt = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Nart = table.Column<int>(type: "int", nullable: false),
                    Carttyp = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Codbenef = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Cartetamrc = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Iespnce = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Cartdesc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Cartpayori = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Cartpayacq = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Cartpayprc = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Iddtapu = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    Nartapu = table.Column<int>(type: "int", nullable: true),
                    Qartbul = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martunitar = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    Cartuntdcl = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Qartuntdcl = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Cartuntest = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Qartuntest = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Qartkgrbrt = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Qartkgrnet = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Martfob = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Martfobdol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Martfle = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martass = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martemma = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martfrai = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martajuinc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martajuded = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martbasimp = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Martbasimp2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => new { x.Iddt, x.Nart });
                });

            migrationBuilder.CreateTable(
                name: "Declaraciones",
                columns: table => new
                {
                    Iddt = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Iddtextr = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Cddtver = table.Column<int>(type: "int", nullable: false),
                    Iddtext = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Iext = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Cddteta = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Dddtoficia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dddtrectifa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cddtcirvis = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Qddttaxchg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ista = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Cddtbur = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Cddtburdst = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Cddtdep = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Cddtentrep = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Cddtage = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Cddtagr = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Lddtagr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nddtimmioe = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Lddtnomioe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cddtpayori = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Cddtpaidst = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Lddtnomfod = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Cddtincote = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Cddtdevfob = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Cddtdevfle = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Cddtdevass = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Cddttransp = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Cddtmdetrn = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    Cddtpaytrn = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Nddtart = table.Column<int>(type: "int", nullable: false),
                    Nddtdelai = table.Column<int>(type: "int", nullable: true),
                    Dddtbae = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtsalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtcancel = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dddtechean = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cddtobs = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaraciones", x => x.Iddt);
                });

            migrationBuilder.CreateTable(
                name: "LiquidacionesArticulo",
                columns: table => new
                {
                    Iliq = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Nart = table.Column<int>(type: "int", nullable: false),
                    Clqatax = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Clqatyp = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Mlqabas = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Qlqacoefic = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Mlqa = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidacionesArticulo", x => new { x.Iliq, x.Nart, x.Clqatax, x.Clqatyp });
                });

            migrationBuilder.CreateTable(
                name: "Liquidaciones",
                columns: table => new
                {
                    Iliq = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Cliqdop = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Cliqeta = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Mliq = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mliqgar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dlippay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Clipnomope = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Iddt = table.Column<string>(type: "nvarchar(17)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidaciones", x => x.Iliq);
                    table.ForeignKey(
                        name: "FK_Liquidaciones_Declaraciones_Iddt",
                        column: x => x.Iddt,
                        principalTable: "Declaraciones",
                        principalColumn: "Iddt");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Liquidaciones_Iddt",
                table: "Liquidaciones",
                column: "Iddt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");

            migrationBuilder.DropTable(
                name: "Liquidaciones");

            migrationBuilder.DropTable(
                name: "LiquidacionesArticulo");

            migrationBuilder.DropTable(
                name: "Declaraciones");
        }
    }
}
