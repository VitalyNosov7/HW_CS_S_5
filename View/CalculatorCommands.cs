using Calculator.Model;

namespace Calculator.View
{
    internal class CalculatorCommands
    {
        private MessegerCalculator messegerCalculatorCommands = new MessegerCalculator();
        private static int sizeLine = 50;
        private string viewCommands = ($"{new string('-', sizeLine)}\n" +
                                     "'Доступные команды':\n" +
                                     $"{new string('-', sizeLine)}\n" +
                                     "(+): Сложение.\n" +
                                     "(-): Вычитание.\n" +
                                     "(*): Умножение.\n" +
                                     "(/): Деление.\n" +
                                     "(q): Выход из программы.\n" +
                                     $"{new string('-', sizeLine)}\n" +
                                     "Введите команду: ");

        public string GetCommands()
        {
            return this.viewCommands;
        }

        public void ViewCommands()
        {
            messegerCalculatorCommands.DisplayMessage(this.viewCommands);
        }
    }
}