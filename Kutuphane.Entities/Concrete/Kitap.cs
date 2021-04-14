using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kutuphane.Entities.Concrete
{
   public  class Kitap :IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.Emanet = new HashSet<Emanet>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [DisplayName("Kitabın ADI")]

        public string kitapAd { get; set; }


        [DisplayName("Kitabın Sayfa Sayısı")]
        public Int32 kitapSayfaSayisi { get; set; }

        [DisplayName("Kitabın Yazarı")]
        public string kitapYazari { get; set; }
       

        public bool kitapRaftami { get; set; }

        public virtual ICollection<Emanet> Emanet { get; set; }
    }
}
