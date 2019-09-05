namespace crmAppBL
{
    public class OrderPosition
    {
        public OrderPosition()
        {

        }

        public OrderPosition(int orderPositionID)
        {
            OrderPositionID = orderPositionID;

        }

        public int OrderPositionID { get; private set; }
        public int Amount { get; set; }
        public int ProductID { get; set; }
        public decimal? OrderPrice { get; set; }

        public bool Validate()
        {


            var status = true;

            if (Amount <= 0) { status = false; }
            if (ProductID <= 0) { status = false; }
            if (OrderPrice <= 0) { status = false; }

            return status;

        }


        public bool SaveOrder()
        {
            /// <summary>
            /// Funkcja zapisująca
            /// </summary>
            /// <returns></returns>
            return true;

        }

        public OrderPosition GetPosition(int orderPositionID)
        {
            /// <summary>
            /// Funkcja pobierająca produkt po ID
            /// </summary>
            /// <returns></returns>
            return new OrderPosition();

        }

        

    }
}
