namespace ProjectOfDictionaryWithNetMvc.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_headingstatus_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
