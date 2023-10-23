namespace Calculator.Model
{
    internal class MessegerCalculator
    {
        private string message = string.Empty;

        public void DisplayMessage(string message)
        {
            this.message = message;
            Console.WriteLine(this.message);
        }
    }
}