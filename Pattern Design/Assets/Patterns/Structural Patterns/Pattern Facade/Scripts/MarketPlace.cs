namespace Facade{
    public class MarketPlace{
        private ProciderCommunication _prociderCommunication;
        private Site _site;
        private DataBaseSite _dataBase;

        public MarketPlace()
        {
            _prociderCommunication = new ProciderCommunication();
            _site = new Site();
            _dataBase = new DataBaseSite();
        }

        public void ProductReceipt()
        {
            _prociderCommunication.Receive();
            _site.Placement();
            _dataBase.Insert();
        }

        public void ProductRelease()
        {
            _prociderCommunication.Payment();
            _site.Del();
            _dataBase.Del();
        }
    }
}