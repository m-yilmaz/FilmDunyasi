namespace FilmDunyasi.Migrations
{
    using FilmDunyasi.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmDunyasi.Data.FilmDunyasiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FilmDunyasi.Data.FilmDunyasiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.Kategoriler.Any())
            {
                context.Kategoriler.Add(new Kategori() { Ad = "Aksiyon" });
                context.Kategoriler.Add(new Kategori() { Ad = "Macera" });
                context.Kategoriler.Add(new Kategori() { Ad = "Animasyon" });
                context.Kategoriler.Add(new Kategori() { Ad = "Biyografi" });
                context.Kategoriler.Add(new Kategori() { Ad = "Komedi" });
                context.Kategoriler.Add(new Kategori() { Ad = "Suç" });
                context.Kategoriler.Add(new Kategori() { Ad = "Belgesel" });
                context.Kategoriler.Add(new Kategori() { Ad = "Dram" });
                context.Kategoriler.Add(new Kategori() { Ad = "Fantezi" });
                context.Kategoriler.Add(new Kategori() { Ad = "Korku" });
                context.Kategoriler.Add(new Kategori() { Ad = "Gizem" });
                context.Kategoriler.Add(new Kategori() { Ad = "Romantik" });
                context.Kategoriler.Add(new Kategori() { Ad = "Bilim Kurgu" });
                context.Kategoriler.Add(new Kategori() { Ad = "Gerilim" });
                context.Kategoriler.Add(new Kategori() { Ad = "Savaş" });
            }
        }
    }
}
