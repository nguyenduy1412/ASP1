using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public string Id { get; set; }


        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [DisplayName("Ảnh sản phẩm")]
        public string Image { get; set; }

        [DisplayName("Giá")]
        public float Price { get; set; }

        [DisplayName("Giá Sale")]
        public float PriceSale { get; set; }
        [DisplayName("Sale")]
        public int Sale { get; set; }

    }
}