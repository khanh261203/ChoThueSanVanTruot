using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ChoThueSanVanTruot.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        public double Price { get; set; }

        public string Photo { get; set; }
        public int Amount { get; set; }
        public double Money
        {
            get
            {
                return Amount * Price;
            }
        }
    }

}