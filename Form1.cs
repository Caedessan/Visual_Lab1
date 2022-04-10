namespace Visual_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum States
        {
            AwaitingNumberOrNumberExpression,
            AwaitingOperator,
            AwaitingParameters,
            AwaitingFurtherInstructions
        }

        private States _currentState = States.AwaitingNumberOrNumberExpression;
        public States CurrentState { get { return _currentState; } }

        private List<string> _parametersRecieved = new List<string>();
        public List<string> ParametersRecieved { get { return _parametersRecieved; } }
        private int _openedBracketsCounter = 0;
        public int OpenedBracketsCounter { get { return _openedBracketsCounter; } }

        private string _currentInput = string.Empty;
        public string CurrentInput { get { return _currentInput; } }

        private string _readyToCalculationExpression = string.Empty;
        public string ReadyToCalculationExpression { get { return _readyToCalculationExpression; } }

        public string ShownToUserExpression
        {
            get
            {
                return WholeExpressionTextBox.Text;
            }
        }
        public Form1(DataToSave savedState)
        {
            InitializeComponent();
            _currentState = savedState.CurrentState;
            _parametersRecieved = savedState.ParametersRecieved;
            _openedBracketsCounter = savedState.OpenedBracketsCounter;
            _currentInput = savedState.CurrentInput;
            _readyToCalculationExpression = savedState.ReadyToCalculationExpression;
            WholeExpressionTextBox.Text = string.Empty;
            WholeExpressionTextBox.AppendText(savedState.ShownToUserExpression);
            UpdateTextBox();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.OemMinus:
                    SubtractButton.SimulateClick();
                    break;
                case Keys.OemQuestion:
                    DivideButton.SimulateClick();
                    break;
                case Keys.Oemplus:
                    if (e.Modifiers == Keys.Shift) AddButton.SimulateClick();
                    else EqualsButton.SimulateClick();
                    break;
                case Keys.Enter:
                    EqualsButton.SimulateClick();
                    break;
                case Keys.OemPeriod:
                    DecimalButton.SimulateClick();
                    break;
                case Keys.D0:
                    if (e.Modifiers == Keys.Shift) CloseBracket.SimulateClick();
                    else Number0.SimulateClick();
                    break;
                case Keys.D1:
                    Number1.SimulateClick();
                    break;
                case Keys.D2:
                    Number2.SimulateClick();
                    break;
                case Keys.D3:
                    Number3.SimulateClick();
                    break;
                case Keys.D4:
                    Number4.SimulateClick();
                    break;
                case Keys.D5:
                    Number5.SimulateClick();
                    break;
                case Keys.D6:
                    Number6.SimulateClick();
                    break;
                case Keys.D7:
                    Number7.SimulateClick();
                    break;
                case Keys.D8:
                    if (e.Modifiers == Keys.Shift) MultiplyButton.SimulateClick();
                    else Number8.SimulateClick();
                    break;
                case Keys.D9:
                    if (e.Modifiers == Keys.Shift) OpenBracket.SimulateClick();
                    else Number9.SimulateClick();
                    break;
                case Keys.OemOpenBrackets:
                    OpenBracket.SimulateClick();
                    break;
                case Keys.OemCloseBrackets:
                    CloseBracket.SimulateClick();
                    break;
                case Keys.Delete:
                    ClearButton.SimulateClick();
                    break;
            }
        }

        private void UpdateTextBox()
        {
            CurrentInputTextBox.Text = _currentInput;
            DisplayMessage(string.Empty);
        }
        private void Operation(char operation)
        {
            if (_currentState == States.AwaitingFurtherInstructions)
            {
                _readyToCalculationExpression = string.Empty;
                WholeExpressionTextBox.Text = string.Empty;
                _openedBracketsCounter = 0;
            }
            else if (_currentState == States.AwaitingOperator)
            {

            }
            else if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    DisplayMessage("Number expected");
                    return;
                }
                else if (!float.TryParse(_currentInput, out _))
                {
                    DisplayMessage("Finish entering number");
                    return;
                }
            }
            else
            {
                DisplayMessage("Operator not expected");
                return;
            }
            _readyToCalculationExpression += " " + _currentInput + " " + operation;
            WholeExpressionTextBox.AppendText(" " + _currentInput + " " + operation);
            _currentState = States.AwaitingNumberOrNumberExpression;
            _currentInput = string.Empty;
            UpdateTextBox();
        }
        private void Digit(char digit)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingFurtherInstructions || _currentState == States.AwaitingParameters)
            {
                _currentInput += digit;
                UpdateTextBox();
            }
            else
            {
                DisplayMessage("Digit not expected");
            }
        }

        private void WholeExpressionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _readyToCalculationExpression = string.Empty;
            WholeExpressionTextBox.Text = string.Empty;
            _currentInput = string.Empty;
            _openedBracketsCounter = 0;
            _parametersRecieved = new List<string>();
            _currentState = States.AwaitingNumberOrNumberExpression;
            UpdateTextBox();
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            Digit('0');
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            Digit('1');
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            Digit('2');
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            Digit('3');
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            Digit('4');
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            Digit('5');
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            Digit('6');
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            Digit('7');
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            Digit('8');
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            Digit('9');
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (_currentInput.Length > 0 || _currentState == States.AwaitingOperator)
            {
                Operation('-');
            }
            else
            {
                if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingParameters)
                {
                    _currentInput += '-';
                    UpdateTextBox();
                }
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void OpenBracket_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    _readyToCalculationExpression += " " + "(";
                    WholeExpressionTextBox.AppendText(" " + "(");
                    _openedBracketsCounter++;
                    UpdateTextBox();
                }
                else
                {
                    DisplayMessage("After number operator expected");
                }
            }
            else
            {
                DisplayMessage("Awaiting number expression");
            }
        }

        private void CloseBracket_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingOperator)
            {

            }
            else if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length < 1)
                {
                    DisplayMessage("Number expression expected");
                    return;
                }
            }
            else
            {
                DisplayMessage("Cant use ) here");
                return;
            }
            if (_openedBracketsCounter < 1)
            {
                DisplayMessage("No brackets to close");
                return;
            }

            _openedBracketsCounter--;
            _readyToCalculationExpression += " " + _currentInput + " " + ")";
            WholeExpressionTextBox.AppendText(" " + _currentInput + " " + ")");
            _currentState = States.AwaitingOperator;
            _currentInput = string.Empty;
            UpdateTextBox();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    _readyToCalculationExpression += " √";
                    WholeExpressionTextBox.AppendText(" √");
                }
                else
                {
                    DisplayMessage("Press √ before number");
                }
            }
            else
            {
                DisplayMessage("√ not expected");
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingParameters)
            {
                if (int.TryParse(_currentInput, out _))
                {
                    _currentInput += ',';
                    UpdateTextBox();
                }
                else
                {
                    DisplayMessage("Too many ,");
                }
            }
            else
            {
                DisplayMessage("Awaiting number expression");
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (float.TryParse(_currentInput, out _))
                {
                    _readyToCalculationExpression += " " + _currentInput;
                    WholeExpressionTextBox.AppendText(" " + _currentInput);
                }
                else
                {
                    DisplayMessage("Finish expression first");
                    return;
                }
            }
            else if (_currentState == States.AwaitingParameters)
            {
                DisplayMessage("Enter parameters first");
                return;
            }
            while (_openedBracketsCounter > 0)
            {
                _readyToCalculationExpression += " )";
                WholeExpressionTextBox.AppendText(" )");
                _openedBracketsCounter--;
            }
            _currentState = States.AwaitingFurtherInstructions;
            var IPN = Program.ConvertToIPN(_readyToCalculationExpression);
            _currentInput = Program.ComputeIPN(IPN).ToString();
            UpdateTextBox();
            DisplayMessage("Result:");
        }

        private void FuncButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    _currentState = States.AwaitingParameters;
                    DisplayMessage("Press func to confirm parameter");
                }
                else
                {
                    DisplayMessage("Function needs to be before parameters");
                }
            }
            else if (_currentState == States.AwaitingParameters)
            {
                if (float.TryParse(_currentInput, out _))
                {
                    if (_parametersRecieved.Count == 0)
                    {
                        _parametersRecieved.Add(_currentInput);
                        WholeExpressionTextBox.AppendText(_currentInput + "x^2+");
                        _currentInput = string.Empty;
                        UpdateTextBox();
                    }
                    else if (_parametersRecieved.Count == 1)
                    {
                        _parametersRecieved.Add(_currentInput);
                        WholeExpressionTextBox.AppendText(_currentInput + "x+");
                        _currentInput = string.Empty;
                        UpdateTextBox();
                    }
                    else
                    {
                        _parametersRecieved.Add(_currentInput);
                        WholeExpressionTextBox.AppendText(_currentInput);
                        _currentInput = string.Empty;
                        UpdateTextBox();
                        _currentState = States.AwaitingOperator;
                        string p = _parametersRecieved[0] + "x^2+" + _parametersRecieved[1] + "x+" + _parametersRecieved[2];
                        double d = Math.Pow(Convert.ToDouble(_parametersRecieved[1], null), 2) - 4 * Convert.ToDouble(_parametersRecieved[0], null) * Convert.ToDouble(_parametersRecieved[2], null);
                        if (d < 0)
                        {
                            _currentInput = "D < 0";
                            UpdateTextBox();
                        }
                        else
                        {
                            double x1 = (-Convert.ToDouble(_parametersRecieved[1], null) + Math.Sqrt(d)) / (2 * Convert.ToDouble(_parametersRecieved[0], null));
                            double x2 = (-Convert.ToDouble(_parametersRecieved[1], null) - Math.Sqrt(d)) / (2 * Convert.ToDouble(_parametersRecieved[0], null));
                            _currentInput = String.Format("{0:0.000}", x1) + " " + String.Format("{0:0.000}", x2);
                            UpdateTextBox();
                        }
                        _currentInput = string.Empty;
                        _parametersRecieved.Clear();
                    }
                }
                else
                {
                    DisplayMessage("Finsh expression first");
                }
            }
            else
            {
                DisplayMessage("Function not expected");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
