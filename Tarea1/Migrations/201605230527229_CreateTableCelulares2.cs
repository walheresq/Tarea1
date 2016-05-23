namespace Tarea1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCelulares2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Celulares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IMEI = c.Int(nullable: false),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Celulares");
        }
    }
}
