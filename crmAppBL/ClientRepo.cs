using System.Collections.Generic;

namespace crmAppBL
{
    public class ClientRepo
    {



        public Client GetClient(int clientID)

        {
            Client client = new Client(clientID);
            ///TEMP properties
            ///
            if (clientID == 1)
            {
                client.Addressemail = "artur@sury.pl";
                client.Name = "Artur";
                client.Surname = "Sury";



            }

            /// <summary>
            /// Funkcja pobierająca klient po ID
            /// </summary>
            /// <returns></returns>
            return client;

        }

        public List<Client> GetClient()
        {
            /// <summary>
            /// Funkcja pobierająca wszystkich klientów
            /// </summary>
            /// <returns></returns>
            return new List<Client>(); 

        }

        public bool SaveClient(Client client)
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            var succes = true;
            if (client.IsChanged && client.DataOK)
            {
                if (client.IsNew)
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
