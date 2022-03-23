using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDunyasi.Data
{
    [Table("Filmler")]
    public class Film
    {
        public Film()
        {
            Kategoriler = new List<Kategori>();
        }
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Ad { get; set; }
        public int Yil { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; }
    }
}
