using Kutuphane.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Kutuphane.Entities.Concrete
{
   public class Kullanıcı :IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int KullanıcıID { get; set; }
        public string kullanıcıUserName { get; set; }
        public string kullanıcıPassword { get; set; }
        public int k_ogrenciNo { get; set; }
    }
}
