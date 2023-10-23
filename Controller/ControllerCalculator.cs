using Calculator.Model;

namespace Calculator.Controller
{
    internal class ControllerCalculator
    {
        private ComandHandler comandHandler = new ComandHandler();

        public ControllerCalculator()
        {
            LauncherCalculatorHandler();
        }

        public void LauncherCalculatorHandler()
        {
            comandHandler.LaunchHandler();
        }
    }
}