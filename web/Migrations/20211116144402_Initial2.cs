using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nepremicnina_Agent_AgentID",
                table: "Nepremicnina");

            migrationBuilder.DropIndex(
                name: "IX_Nepremicnina_AgentID",
                table: "Nepremicnina");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Agent",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "AgentID",
                table: "Nepremicnina",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Agent",
                newName: "FirstMidName");

            migrationBuilder.AlterColumn<int>(
                name: "AgentID",
                table: "Nepremicnina",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nepremicnina_AgentID",
                table: "Nepremicnina",
                column: "AgentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Nepremicnina_Agent_AgentID",
                table: "Nepremicnina",
                column: "AgentID",
                principalTable: "Agent",
                principalColumn: "ID");
        }
    }
}
