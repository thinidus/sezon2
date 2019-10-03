using System;
using System.Collections.Generic;

namespace crmAppBL
{
    public class Order : BaseClass
    {
        #region CONSTRUCTORS
        public Order()
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
        }

        #endregion

        #region PROPERTIES

        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderPosition> orderPositions { get; set; }
        public int ClientID { get; set;  }
        public int DeliveryAddress { get; set; }

        #endregion

        #region METODY

        public override bool Validate() 
        {


            var status = true;

            if (OrderDate == null) { status = false; }

            return status;

        }

        public override string ToString()
        {
            return OrderDate.Value.Date + "[ " + OrderID + " ]";
        }

        #endregion




    }
}
