namespace crmAppBL
{
    public abstract class BaseClass
    {

        public bool IsNew { get; set; }
        public bool IsChanged { get; set; }
        public ObjectStateOption ObjectState { get; set; }
        public bool DataOK
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
    }

    public enum ObjectStateOption
    {
        Active,
        Deleted

    }
}
