namespace FilmDunyasi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                        Yil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KategoriFilms",
                c => new
                    {
                        Kategori_Id = c.Int(nullable: false),
                        Film_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Kategori_Id, t.Film_Id })
                .ForeignKey("dbo.Kategoriler", t => t.Kategori_Id, cascadeDelete: true)
                .ForeignKey("dbo.Filmler", t => t.Film_Id, cascadeDelete: true)
                .Index(t => t.Kategori_Id)
                .Index(t => t.Film_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KategoriFilms", "Film_Id", "dbo.Filmler");
            DropForeignKey("dbo.KategoriFilms", "Kategori_Id", "dbo.Kategoriler");
            DropIndex("dbo.KategoriFilms", new[] { "Film_Id" });
            DropIndex("dbo.KategoriFilms", new[] { "Kategori_Id" });
            DropTable("dbo.KategoriFilms");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Filmler");
        }
    }
}
