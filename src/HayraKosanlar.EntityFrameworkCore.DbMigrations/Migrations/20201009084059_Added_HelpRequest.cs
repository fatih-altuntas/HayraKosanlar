using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HayraKosanlar.Migrations
{
    public partial class Added_HelpRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HelpRequest",
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
                    IdentityNumber = table.Column<string>(nullable: true),
                    TownId = table.Column<long>(nullable: false),
                    Birthplace = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EducationLevel = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<int>(nullable: false),
                    PartnerName = table.Column<string>(nullable: true),
                    ChildrenCount = table.Column<long>(nullable: false),
                    ExtraInformation = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRequest", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelpRequest");
        }
    }
}
