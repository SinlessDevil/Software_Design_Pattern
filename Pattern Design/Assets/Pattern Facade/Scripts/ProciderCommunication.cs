namespace Facade{
    public class ProciderCommunication{
        public void Receive() => UnityEngine.Debug.Log("Получение продукции от производителя ");
        public void Payment() => UnityEngine.Debug.Log("Оплата поставщику с удержанием комиссии за продажу продукции ");
    }
}