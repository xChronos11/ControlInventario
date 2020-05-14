namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterproductcode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductCode", c => c.Int(nullable: false));
        }
    }
}
