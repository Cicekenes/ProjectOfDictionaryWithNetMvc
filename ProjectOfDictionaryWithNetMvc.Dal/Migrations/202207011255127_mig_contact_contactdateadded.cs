namespace ProjectOfDictionaryWithNetMvc.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_contact_contactdateadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
