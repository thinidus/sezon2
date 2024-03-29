﻿using System;
using System.Collections.Generic;

namespace crmAppBL
{
    public class ProductRepo
    {




        public Product GetProduct(int productID)
        {
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            /// 
            Product productRepo = new Product(productID);

            if (productID == 5)
            {
                productRepo.ProductName = "Klocki LEGO";
                productRepo.Describe = "No klocki jak w mordę strzelił";
                productRepo.CurrentPrice = 200.00M;

            }

            Object myObject = new Object();
            Console.WriteLine("Wyświetlony obiekt myObject: " + myObject.ToString());
            Console.WriteLine("Wyświetlony obiekt ProductRepo: " + productRepo.ToString());


            return productRepo;

        }

        public List<Product> GetProduct()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            return new List<Product>();

        }

        public bool SaveProduct(Product product)
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            /// 
            var succes = true;
            if (product.IsChanged && product.DataOK)
            {
                if (product.IsNew)
                {
                    //insert
                }
                else
                {
                    //update

                }
            }


            return succes;

        }

    }
}
