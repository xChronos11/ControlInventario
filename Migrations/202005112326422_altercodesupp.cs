namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercodesupp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "SupplierCode", c => c.Int(nullable: false));
        }
    }
}
