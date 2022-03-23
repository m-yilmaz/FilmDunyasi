using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDunyasi.Data
{
    public class FilmDunyasiContext : DbContext
    {
        public FilmDunyasiContext() : base("name=Connection")
        {

        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
