using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities.Concrete
{
    public class Ogrenci:IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenci()
        {
            this.Emanet = new HashSet<Emanet>();
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string ogrenciAd { get; set; }
        public string ogrenciSoyad { get; set; }
        public string ogrenciEposta { get; set; }

        public string ogrenciTelefon { get; set; }
        public string ogrenciNumarası { get; set; }
        public string ogrenciSifre { get; set; }
        public virtual ICollection<Emanet> Emanet { get; set; }
        
    } 
}
