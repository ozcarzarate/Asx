namespace Investment.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSomething : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Something",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            
        }
        
        public override void Down()
        {
            DropTable("dbo.Something");
        }
    }
}
