namespace crmAppBL
{
    public class PrintOrderPosition
    {

        public int OrderPosition { get; private set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public decimal? OrderPrice { get; set; }

    }
}