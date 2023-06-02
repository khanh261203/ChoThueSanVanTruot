using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoThueSanVanTruot.Models
{
    public class ProductModel
    {
        private readonly List<CartItem> products;

        public ProductModel()
        {
            this.products = new List<CartItem>() {
                new CartItem {
                    Id = 1,
                    Name = "Push Skateboard Park",
                    Price = 150000,

                },
                new CartItem {
                    Id = 2,
                    Name = "VIVO Skate Park",
                    Price = 220000,

                },
                new CartItem {
                    Id = 3,
                    Name = "Bitexco Financial Tower Skydeck",
                    Price = 300000,

                },

                 new CartItem {
                    Id = 4,
                    Name = "Vincom Mega Mall Thảo Điền",
                    Price = 250000,

                },

                 new CartItem {
                    Id = 5,
                    Name = "Cantavil Premier",
                    Price = 190000,

                },

                  new CartItem {
                    Id = 6,
                    Name = "Bitexco Financial Tower Skydeck",
                    Price = 170000,

                },


            };
        }

        public List<CartItem> FindAll()
        {
            return this.products;
        }

        public CartItem FindProduct(int id)
        {
            return this.products.Single(p => p.Id.Equals(id));
        }

    }
}