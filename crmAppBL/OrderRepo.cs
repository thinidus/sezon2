using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmAppBL;

namespace crmAppBL
{
    public class OrderRepo
    {



        public Order GetOrder(int orderID)
        {

            Order order = new Order(orderID);
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            /// 

            if (orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;

        }

        public List<Order> GetOrder()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkie produkty
            /// </summary>
            /// <returns></returns>
            return new List<Order>();

        }

        public bool SaveOrder(Order order)
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            var succes = true;
            if (order.IsChanged && order.DataOK)
            {
                if (order.IsNew)
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

        public PrintOrder GetPrintOrder(int orderID)
        {
            PrintOrder printOrder = new PrintOrder();
            //Kod który pobiera zdefiniowane pola zamówienia.
            //Tymczasowe dane zakodowane na stałe

            if (orderID == 10)
            {

                printOrder.Name = "Artur";
                printOrder.Surname = "Sury";
                printOrder.OrderDate = new DateTimeOffset(2019, 09, 17, 12, 00, 00, new TimeSpan(5, 0, 0));
                printOrder.OrderAddres = new Address()
                {
                    AddressType = 2,
                    Street = "Osadnicza",
                    City = "Bielsko-Biała",
                    ZipCode = "43-300"
                };
                printOrder.PrintOrderPositions = new List<PrintOrderPosition>();
            }

            //Dane zakodowane na stałę: powinno być pobrane z DB

            if (orderID == 10)
            {
                var PrintOrderPosition = new PrintOrderPosition()
                {
                    ProductName = "Stół",
                    OrderPrice = 300.50M,
                    Amount = 10


                };

                printOrder.PrintOrderPositions.Add(PrintOrderPosition);

                PrintOrderPosition = new PrintOrderPosition()
                {
                    ProductName = "Krzesło",
                    OrderPrice = 300.50M,
                    Amount = 10


                };

                printOrder.PrintOrderPositions.Add(PrintOrderPosition);

            }


            return printOrder;
        }

    }

}

