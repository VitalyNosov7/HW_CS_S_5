using Calculator.Model;

namespace Calculator.Controller
{
    internal class LaunchCalculator
    {
        private MessegerCalculator startMessege = new MessegerCalculator();
        public LaunchCalculator()
        {
            LauncherControllerCalculator();
        }

        public void LauncherControllerCalculator()
        {
            startMessege.DisplayMessage("Добро пожаловать в приложение Calculator!");
            new ControllerCalculator();

        }
    }
}