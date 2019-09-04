using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmAppBL
{
    public class Client
    {
        private string _surname;
        private string _name;
        private string _addressemail;
        private string _clientID;

        public Client()
        {
            Licznik++;
        }

        //Properties


        public static int Licznik { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Addressemail { get; set; }
        public int ClientID { get; private set; }
        public string FullName
        {
            get
            {
                string space = " ";
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname))
                {
                    space = "";
                }

                return $"{Name}{space}{Surname}";
            }
        }






    }
}



