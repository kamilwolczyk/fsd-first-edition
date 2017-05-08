namespace Fsd.Cs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newPlayerEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootballTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
            DropTable("dbo.FootballTeams");
        }
    }
}
