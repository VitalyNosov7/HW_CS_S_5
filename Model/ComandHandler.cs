using Calculator.View;

namespace Calculator.Model
{
    internal class ComandHandler
    {
        private MessegerCalculator messegerComandHandler = new MessegerCalculator();
        private OperationCalculator operationCalculator = new OperationCalculator();
        private CalculatorCommands calculatorCommands = new CalculatorCommands();

        public void LaunchHandler()
        {
            string action = string.Empty;
            int num1, num2;

            while (true)
            {
                calculatorCommands.ViewCommands();
                try
                {
                    action = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }


                if (action == "+" || action == "-" || action == "*" || action == "/" || action == "q")
                {

                    if (action == "q")
                    {
                        messegerComandHandler.DisplayMessage("Выполнение расчёта прервано пользователем!");
                        break;
                    }

                    try
                    {
                        messegerComandHandler.DisplayMessage("Введите первое число:");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        messegerComandHandler.DisplayMessage("Введите второе число:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        messegerComandHandler.DisplayMessage("Введено не число!");
                        Console.ReadLine();
                        continue;
                    }

                    switch (action)
                    {
                        case "+":
                            operationCalculator.Add(num1, num2);
                            break;

                        case "-":
                            operationCalculator.Sub(num1, num2);
                            break;

                        case "*":
                            operationCalculator.Mul(num1, num2);
                            break;

                        case "/":
                            operationCalculator.Div(num1, num2);
                            break;
                        default:

                            messegerComandHandler.DisplayMessage("Некорректное действие!");
                            break;
                    }

                    messegerComandHandler.DisplayMessage($"Результат вычисления = {operationCalculator.GetResult()}");
                    messegerComandHandler.DisplayMessage("===================================================\n" +
                                                         "Для продолжения нажмите (Y). Для выхода нажмите (q)\n" +
                                                         "===================================================\n");
                }

                try
                {
                    action = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                if (action == "y")
                {
                    Console.Clear();
                    continue;
                }
                else if (action == "q")
                {
                    Console.Clear();
                    messegerComandHandler.DisplayMessage("Выходим из программы!");
                    break;

                }
            }

            messegerComandHandler.DisplayMessage("Программа завершена.");
            Console.ReadLine();
        }
    }
}