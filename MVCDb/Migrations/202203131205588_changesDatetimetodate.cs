namespace MVCDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesDatetimetodate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainer", "DateofBirth", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainer", "DateofBirth", c => c.DateTime(nullable: false));
        }
    }
}
