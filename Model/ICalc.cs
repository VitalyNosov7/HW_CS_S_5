namespace Calculator
{
    internal interface ICalc
    {
        float Add(int a, int b);
        float Sub(int a, int b);
        float Div(int a, int b);
        float Mul(int a, int b);
        void CancelLast();
    }
}
