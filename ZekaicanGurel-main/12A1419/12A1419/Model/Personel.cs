using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12A1419.Model
{
    public class Personel
    {
        //[Key]
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Telefon { get; set; }

        public string Mail{ get; set; }

        public string Adres { get; set; }

        public string KullanıcıAdı {  get; set; }

        public string Sifre { get; set; }

        //[ForeignKey("Yetki")]

        public int YetkiId { get; set; }

        public virtual ICollection<Satis> Satislar { get; set; }= new HashSet<Satis>();


    }
}
