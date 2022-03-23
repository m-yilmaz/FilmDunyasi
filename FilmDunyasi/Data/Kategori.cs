using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDunyasi.Data
{
    [Table("Kategoriler")]
    public class Kategori
    {
        public Kategori()
        {
            Filmler = new List<Film>();
        }
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Ad { get; set; }
        public virtual ICollection<Film> Filmler { get; set; }
         
    }
}
