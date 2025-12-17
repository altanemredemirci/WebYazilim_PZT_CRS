using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_EntityFramework_CodeFirst_2.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sinif",
                table: "Ogrenciler");

            migrationBuilder.AddColumn<int>(
                name: "SinifId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sube = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinif", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler",
                column: "SinifId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Sinif_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Sinif",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Sinif_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "SinifId",
                table: "Ogrenciler");

            migrationBuilder.AddColumn<string>(
                name: "Sinif",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
