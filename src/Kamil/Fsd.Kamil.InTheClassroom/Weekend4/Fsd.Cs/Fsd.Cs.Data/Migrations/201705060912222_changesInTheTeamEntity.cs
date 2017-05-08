namespace Fsd.Cs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInTheTeamEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootballTeams", "FoundationYear", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FootballTeams", "FoundationYear");
        }
    }
}
