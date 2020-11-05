using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HayraKosanlar.Migrations
{
    public partial class Added_GiveAHand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "GiveAHandRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ExtraInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiveAHandRequest", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiveAHandRequest");
        }
    }
}
