using FilmDunyasi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmDunyasi
{
    public partial class Form1 : Form
    {
        FilmDunyasiContext db = new FilmDunyasiContext();
        public Form1()
        {
            InitializeComponent();
            KategoriYukle();
            FilmleriYukle();
        }

        private void FilmleriYukle()
        {
            Kategori seciliKategori = (Kategori)cmbKategoriler.SelectedItem;

            IQueryable<Film> sorgu;

            if (seciliKategori.Id == 0)
            {
                sorgu = db.Filmler;
            }
            else
            {
                sorgu = db.Filmler.Where(x => x.Kategoriler.Any(y => y.Id == seciliKategori.Id));
            }

            dgvFilmler.DataSource = sorgu.OrderBy(x => x.Ad).ToList()
                .Select(f => new
                {
                    Id = f.Id,
                    Ad = f.Ad,
                    Yil = f.Yil,
                    Kategoriler = string.Join(", ", f.Kategoriler.Select(k => k.Ad))
                }).ToList();
        }

        private void KategoriYukle()
        {
            clbKategoriler.DataSource = db.Kategoriler.OrderBy(x => x.Ad).ToList();
            clbKategoriler.DisplayMember = "Ad";
            clbKategoriler.ValueMember = "Id";

            var kategoriler = db.Kategoriler.OrderBy(x => x.Ad).ToList();
            kategoriler.Insert(0, new Kategori() { Ad = "Tümü" });
            cmbKategoriler.DataSource = kategoriler;
            cmbKategoriler.DisplayMember = "Ad";
            cmbKategoriler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad != null && clbKategoriler.CheckedItems.Count > 0)
            {
                db.Filmler.Add(new Film
                {
                    Ad = ad,
                    Yil = (int)nudYil.Value,
                    Kategoriler = clbKategoriler.CheckedItems.OfType<Kategori>().ToList()
                });
                db.SaveChanges();
                FilmleriYukle();
                FormuTemizle();
            }




        }

        private void FormuTemizle()
        {
            txtAd.Clear();
            nudYil.Value = 2000;
            foreach (int i in clbKategoriler.CheckedIndices)
                clbKategoriler.SetItemCheckState(i, CheckState.Unchecked);
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriYukle();
        }
    }
}
