namespace Command
{
    public class Calculator
    {
        int curr = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
            UnityEngine.Debug.Log($"Current value = {curr} (following {@operator} {operand})");
        }
    }
}