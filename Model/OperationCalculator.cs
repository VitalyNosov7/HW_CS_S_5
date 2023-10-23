using Calculator.Model;

namespace Calculator
{
    internal class OperationCalculator : ICalc
    {
        private MessegerCalculator messegerOperationCalculator = new MessegerCalculator();
        private float result = 0;
        public Stack<Tuple<string, int, int, float>> operation = new Stack<Tuple<string, int, int, float>>();

        public float Add(int a, int b)
        {
            result = a + b;
            operation.Push(new Tuple<string, int, int, float>("+", a, b, result));
            return result;
        }

        public float Sub(int a, int b)
        {
            result = a - b;
            operation.Push(new Tuple<string, int, int, float>("+", a, b, result));
            return result;
        }

        public float Mul(int a, int b)
        {
            result = a * b;
            operation.Push(new Tuple<string, int, int, float>("+", a, b, result));
            return result;
        }

        public float Div(int a, int b)
        {
            if (b == 0)
            {
                result = 0;
                messegerOperationCalculator.DisplayMessage("Попытка деления на ноль!");
                return result;
            }
            else
            {
                result = a / b;
                operation.Push(new Tuple<string, int, int, float>("+", a, b, result));
                return result;
            }
        }

        public float GetResult()
        {
            return result;
        }

        public void CancelLast()
        {
            string currentOperation = operation.Peek().Item1;
            switch (currentOperation)
            {
                case "+":
                    result -= operation.Pop().Item2;
                    break;
                case "-":
                    result += operation.Pop().Item2;
                    break;
                case "*":
                    result /= operation.Pop().Item2;
                    break;
                case "/":
                    result *= operation.Pop().Item2;
                    break;
                default:
                    messegerOperationCalculator.DisplayMessage("Ошибка");
                    break;

            }
        }
    }
}