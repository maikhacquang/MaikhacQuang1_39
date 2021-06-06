using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MaikhacQuang1_39.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public int MaPhongban { get; set; }
        public string TenPhongBan { get; set; }
    }
}