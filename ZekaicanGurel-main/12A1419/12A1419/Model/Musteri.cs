using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12A1419.Model
{
    public class Musteri
    {
        public int Id { get; set; } 

        public string AdSoyad { get; set; }

        public string FirmaAdi { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public string Adres { get; set; }

        public virtual ICollection<Satis> Satislar { get; set; } = new HashSet<Satis>();

    }
}
