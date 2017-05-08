namespace Fsd.Cs.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInThePlayerEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Age");
        }
    }
}
