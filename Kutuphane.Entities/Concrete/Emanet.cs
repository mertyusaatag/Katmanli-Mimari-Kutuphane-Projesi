using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kutuphane.Entities.Concrete
{
    public class Emanet : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int emanetNo { get; set; }
        public int OgrenciId { get; set; }
        public int KitapId { get; set; }
        public DateTime EmanetVermeTarih { get; set; }
        public DateTime EmanetGeriAlmaTarih { get; set; }
        public DateTime EmanetIslemTarih { get; set; }
        public String EmanetTeslimEdildi { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Kitap Kitap { get; set; }















    }
}
