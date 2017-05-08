namespace Fsd.Cs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class joinTeamAndPlayers2 : DbMigration
    {
        public override void Up()
        {            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "FootballTeam_Id", "dbo.FootballTeams");
            DropIndex("dbo.Players", new[] { "FootballTeam_Id" });
            DropColumn("dbo.Players", "FootballTeam_Id");
        }
    }
}
