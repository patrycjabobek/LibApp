using Microsoft.EntityFrameworkCore.Migrations;

namespace LibApp.Data.Migrations
{
    public partial class SetNameOfGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (5, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (6, 'SciFi')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
