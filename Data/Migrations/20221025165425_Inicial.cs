using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    idcargo = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    puesto = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcargo);
                });

            migrationBuilder.CreateTable(
                name: "oficina",
                columns: table => new
                {
                    idoficina = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    abreviatura = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idoficina);
                });

            migrationBuilder.CreateTable(
                name: "particulares",
                columns: table => new
                {
                    idParticulares = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: true),
                    ocupacion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    EstadoCivil = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Estudios = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    idPeticionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idParticulares);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    idPersona = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    apaterno = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    amaterno = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPersona);
                });

            migrationBuilder.CreateTable(
                name: "reportes",
                columns: table => new
                {
                    idreportes = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idreportes);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    idFuncionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    persona_idPersona = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    oficina_idoficina = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    cargo_idcargo = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idFuncionario);
                    table.ForeignKey(
                        name: "fk_Funcionario_cargo1",
                        column: x => x.cargo_idcargo,
                        principalTable: "cargo",
                        principalColumn: "idcargo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Funcionario_oficina1",
                        column: x => x.oficina_idoficina,
                        principalTable: "oficina",
                        principalColumn: "idoficina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Funcionario_persona1",
                        column: x => x.persona_idPersona,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "peticionario",
                columns: table => new
                {
                    idPeticionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    alias = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    identidadResguardada = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: true),
                    Domicilio = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    GrupoEtnico = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Lengua = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    telefono = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    persona_idPersona = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    funcionario_idFuncionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idPeticionario);
                    table.ForeignKey(
                        name: "fk_peticionario_funcionario1",
                        column: x => x.funcionario_idFuncionario,
                        principalTable: "funcionario",
                        principalColumn: "idFuncionario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_peticionario_persona1",
                        column: x => x.persona_idPersona,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "archivo",
                columns: table => new
                {
                    idarchivo = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    serieindevep = table.Column<int>(type: "int", nullable: true),
                    delito = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    carpeta = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Juez = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    procesoPenal = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    SegundaInstancia = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Toca = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Amparo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    ExpedinteAmparo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Estatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    idPeticionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    particulares_idParticulares = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    Fiscalia = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    Victima = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idarchivo);
                    table.ForeignKey(
                        name: "fk_archivo_particulares1",
                        column: x => x.particulares_idParticulares,
                        principalTable: "particulares",
                        principalColumn: "idParticulares",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_archivo_peticionario1",
                        column: x => x.idPeticionario,
                        principalTable: "peticionario",
                        principalColumn: "idPeticionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "famiiliar",
                columns: table => new
                {
                    persona_idPersona = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    peticionario_idPeticionario = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.persona_idPersona, x.peticionario_idPeticionario });
                    table.ForeignKey(
                        name: "fk_famiiliar_persona",
                        column: x => x.persona_idPersona,
                        principalTable: "persona",
                        principalColumn: "idPersona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_famiiliar_peticionario",
                        column: x => x.peticionario_idPeticionario,
                        principalTable: "peticionario",
                        principalColumn: "idPeticionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "citas",
                columns: table => new
                {
                    idcitas = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    FechaAudiencia = table.Column<DateTime>(type: "datetime", nullable: true),
                    sala = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    audiencia = table.Column<string>(type: "varchar(155)", maxLength: 155, nullable: true),
                    ResultadoAudiencia = table.Column<string>(type: "longtext", nullable: true),
                    reportes_idreportes = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    archivo_idarchivo = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idcitas);
                    table.ForeignKey(
                        name: "fk_citas_archivo1",
                        column: x => x.archivo_idarchivo,
                        principalTable: "archivo",
                        principalColumn: "idarchivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_citas_reportes1",
                        column: x => x.reportes_idreportes,
                        principalTable: "reportes",
                        principalColumn: "idreportes",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "cargo",
                columns: new[] { "idcargo", "puesto" },
                values: new object[] { "3e53adf4-53b8-11ed-b965-a4bb6dda82fc", "Defensor publico" });

            migrationBuilder.InsertData(
                table: "oficina",
                columns: new[] { "idoficina", "abreviatura", "nombre" },
                values: new object[] { "9d58cb76-53b7-11ed-b965-a4bb6dda82fc", "COA", "COATEPEC" });

            migrationBuilder.InsertData(
                table: "persona",
                columns: new[] { "idPersona", "amaterno", "apaterno", "nombre" },
                values: new object[] { "100014414521958400", "RAMIREZ", "CUEVAS", "EDNA DONAJI" });

            migrationBuilder.InsertData(
                table: "funcionario",
                columns: new[] { "idFuncionario", "cargo_idcargo", "oficina_idoficina", "persona_idPersona" },
                values: new object[] { "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4", "3e53adf4-53b8-11ed-b965-a4bb6dda82fc", "9d58cb76-53b7-11ed-b965-a4bb6dda82fc", "100014414521958400" });

            migrationBuilder.CreateIndex(
                name: "fk_archivo_particulares1_idx",
                table: "archivo",
                column: "particulares_idParticulares");

            migrationBuilder.CreateIndex(
                name: "fk_archivo_peticionario1_idx",
                table: "archivo",
                column: "idPeticionario");

            migrationBuilder.CreateIndex(
                name: "fk_citas_archivo1_idx1",
                table: "citas",
                column: "archivo_idarchivo");

            migrationBuilder.CreateIndex(
                name: "fk_citas_reportes1_idx",
                table: "citas",
                column: "reportes_idreportes");

            migrationBuilder.CreateIndex(
                name: "fk_famiiliar_persona1_idx",
                table: "famiiliar",
                column: "persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "fk_famiiliar_peticionario1_idx",
                table: "famiiliar",
                column: "peticionario_idPeticionario");

            migrationBuilder.CreateIndex(
                name: "fk_Funcionario_cargo1_idx",
                table: "funcionario",
                column: "cargo_idcargo");

            migrationBuilder.CreateIndex(
                name: "fk_Funcionario_oficina1_idx",
                table: "funcionario",
                column: "oficina_idoficina");

            migrationBuilder.CreateIndex(
                name: "fk_Funcionario_persona1_idx",
                table: "funcionario",
                column: "persona_idPersona");

            migrationBuilder.CreateIndex(
                name: "fk_particulares_peticionario1_idx",
                table: "particulares",
                column: "idPeticionario");

            migrationBuilder.CreateIndex(
                name: "fk_peticionario_funcionario1_idx",
                table: "peticionario",
                column: "funcionario_idFuncionario");

            migrationBuilder.CreateIndex(
                name: "fk_peticionario_persona1_idx",
                table: "peticionario",
                column: "persona_idPersona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "citas");

            migrationBuilder.DropTable(
                name: "famiiliar");

            migrationBuilder.DropTable(
                name: "archivo");

            migrationBuilder.DropTable(
                name: "reportes");

            migrationBuilder.DropTable(
                name: "particulares");

            migrationBuilder.DropTable(
                name: "peticionario");

            migrationBuilder.DropTable(
                name: "funcionario");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "oficina");

            migrationBuilder.DropTable(
                name: "persona");
        }
    }
}
