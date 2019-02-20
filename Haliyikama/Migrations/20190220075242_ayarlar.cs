using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Haliyikama.Migrations
{
    public partial class ayarlar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ayarlar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    LogoURL = table.Column<string>(nullable: true),
                    FacebookURL = table.Column<string>(nullable: true),
                    InstagramURL = table.Column<string>(nullable: true),
                    TwitteURL = table.Column<string>(nullable: true),
                    YoutubeLink = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    PhoneNumber2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DescountedPriceSlider = table.Column<string>(nullable: true),
                    VideoLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ayarlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ayarlar");
        }
    }
}
