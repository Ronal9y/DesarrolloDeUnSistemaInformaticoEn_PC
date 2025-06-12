using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloDeUnSistemaInformaticoEn_PC.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adoptantes",
                columns: table => new
                {
                    AdoptanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Preferencias = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptantes", x => x.AdoptanteId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosMascota",
                columns: table => new
                {
                    EstadoMascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosMascota", x => x.EstadoMascotaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosSolicitud",
                columns: table => new
                {
                    EstadoSolicitudId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosSolicitud", x => x.EstadoSolicitudId);
                });

            migrationBuilder.CreateTable(
                name: "RelacionSizes",
                columns: table => new
                {
                    RelacionSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionSizes", x => x.RelacionSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    RazaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.RazaId);
                    table.ForeignKey(
                        name: "FK_Razas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    RazaId = table.Column<int>(type: "int", nullable: false),
                    RelacionSizeId = table.Column<int>(type: "int", nullable: false),
                    Tamaño = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascotas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_Razas_RazaId",
                        column: x => x.RazaId,
                        principalTable: "Razas",
                        principalColumn: "RazaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_RelacionSizes_RelacionSizeId",
                        column: x => x.RelacionSizeId,
                        principalTable: "RelacionSizes",
                        principalColumn: "RelacionSizeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialAdopciones",
                columns: table => new
                {
                    HistorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdoptanteId = table.Column<int>(type: "int", nullable: false),
                    MascotaId = table.Column<int>(type: "int", nullable: false),
                    FechaAdopcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialAdopciones", x => x.HistorialId);
                    table.ForeignKey(
                        name: "FK_HistorialAdopciones_Adoptantes_AdoptanteId",
                        column: x => x.AdoptanteId,
                        principalTable: "Adoptantes",
                        principalColumn: "AdoptanteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistorialAdopciones_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeguimientosMascotas",
                columns: table => new
                {
                    SeguimientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MascotaId = table.Column<int>(type: "int", nullable: false),
                    AdoptanteId = table.Column<int>(type: "int", nullable: false),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoMascotaId = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientosMascotas", x => x.SeguimientoId);
                    table.ForeignKey(
                        name: "FK_SeguimientosMascotas_Adoptantes_AdoptanteId",
                        column: x => x.AdoptanteId,
                        principalTable: "Adoptantes",
                        principalColumn: "AdoptanteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeguimientosMascotas_EstadosMascota_EstadoMascotaId",
                        column: x => x.EstadoMascotaId,
                        principalTable: "EstadosMascota",
                        principalColumn: "EstadoMascotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeguimientosMascotas_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudesAdopcion",
                columns: table => new
                {
                    SolicitudAdopcionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdoptanteId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoSolicitudId = table.Column<int>(type: "int", nullable: false),
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudesAdopcion", x => x.SolicitudAdopcionId);
                    table.ForeignKey(
                        name: "FK_SolicitudesAdopcion_Adoptantes_AdoptanteId",
                        column: x => x.AdoptanteId,
                        principalTable: "Adoptantes",
                        principalColumn: "AdoptanteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudesAdopcion_EstadosSolicitud_EstadoSolicitudId",
                        column: x => x.EstadoSolicitudId,
                        principalTable: "EstadosSolicitud",
                        principalColumn: "EstadoSolicitudId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolicitudesAdopcion_Mascotas_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascotas",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialAdopciones_AdoptanteId",
                table: "HistorialAdopciones",
                column: "AdoptanteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialAdopciones_MascotaId",
                table: "HistorialAdopciones",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_CategoriaId",
                table: "Mascotas",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_EstadoId",
                table: "Mascotas",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_RazaId",
                table: "Mascotas",
                column: "RazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_RelacionSizeId",
                table: "Mascotas",
                column: "RelacionSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Razas_CategoriaId",
                table: "Razas",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosMascotas_AdoptanteId",
                table: "SeguimientosMascotas",
                column: "AdoptanteId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosMascotas_EstadoMascotaId",
                table: "SeguimientosMascotas",
                column: "EstadoMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientosMascotas_MascotaId",
                table: "SeguimientosMascotas",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesAdopcion_AdoptanteId",
                table: "SolicitudesAdopcion",
                column: "AdoptanteId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesAdopcion_EstadoSolicitudId",
                table: "SolicitudesAdopcion",
                column: "EstadoSolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudesAdopcion_MascotaId",
                table: "SolicitudesAdopcion",
                column: "MascotaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialAdopciones");

            migrationBuilder.DropTable(
                name: "SeguimientosMascotas");

            migrationBuilder.DropTable(
                name: "SolicitudesAdopcion");

            migrationBuilder.DropTable(
                name: "EstadosMascota");

            migrationBuilder.DropTable(
                name: "Adoptantes");

            migrationBuilder.DropTable(
                name: "EstadosSolicitud");

            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Razas");

            migrationBuilder.DropTable(
                name: "RelacionSizes");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
