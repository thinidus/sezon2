using System.Collections.Generic;

namespace crmAppBL
{
    public class Client
    {

        public Client()
        {

        }

        public Client(int clientID)
        {
            this.ClientID = clientID;
        }

        private string _surname;
        private string _name;
        private string _addressemail;
        private string _clientID;
        
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

        // Methods

        public bool Validate()
        {

            var ok = true;

            if (string.IsNullOrWhiteSpace(Surname)) { ok = false; }
            if (string.IsNullOrWhiteSpace(Addressemail)) { ok = false; }


            return ok;

           }


        public bool SaveClient()
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            return true;

        }

        public Client GetClient(int clientID)
        {
            /// <summary>
            /// Funkcja pobierająca klient po ID
            /// </summary>
            /// <returns></returns>
            return new Client();

        }

        public List<Client> GetClient()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkich klientów
            /// </summary>
            /// <returns></returns>
            return new List<Client>();

        }




    }
}



