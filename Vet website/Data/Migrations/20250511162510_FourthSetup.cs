using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vet_website.Data.Migrations
{
    /// <inheritdoc />
    public partial class FourthSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Owner_Ownerid",
                table: "Pet");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Procedure",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Procedure",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Ownerid",
                table: "Pet",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_Ownerid",
                table: "Pet",
                newName: "IX_Pet_OwnerId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Owner",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Owner_OwnerId",
                table: "Pet",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Owner_OwnerId",
                table: "Pet");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Procedure",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Procedure",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Pet",
                newName: "Ownerid");

            migrationBuilder.RenameIndex(
                name: "IX_Pet_OwnerId",
                table: "Pet",
                newName: "IX_Pet_Ownerid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Owner",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Owner_Ownerid",
                table: "Pet",
                column: "Ownerid",
                principalTable: "Owner",
                principalColumn: "id");
        }
    }
}
