using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teams.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "infoTeams",
                columns: table => new
                {
                    Team_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Team_name = table.Column<string>(nullable: true),
                    Coach_name = table.Column<string>(nullable: true),
                    Maches_Played = table.Column<int>(nullable: false),
                    Maches_Lost = table.Column<int>(nullable: false),
                    Maches_Won = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infoTeams", x => x.Team_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "infoTeams");
        }
    }
}
