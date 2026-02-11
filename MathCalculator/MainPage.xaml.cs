namespace MathCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculate(object sender, EventArgs e)
    {
        // Obtain the input from the user: left op, right op and operator
        string leftOperandInput = _txtLeftOp.Text;
        double leftOperand = double.Parse(leftOperandInput);

        double rightOperand = double.Parse(_txtRightOp.Text);

        string opInput = (string)_pckOperand.SelectedItem;
        char op = opInput[0];

        // Check the chosen operator and perform the corresponding operation
        double result = PerformArithmeticOperation(leftOperand, rightOperand);

        // Display the arithmetic expression in the output control
        string expression = $"{leftOperand} {op} {rightOperand} = {result}";
        _txtMathExp.Text = expression;
    }

    private double PerformArithmeticOperation(double leftOperand, double rightOperand)
    {
        //TODO: Implement the calculation of the arithmetic op and return result
        return 3.14;
    }

}