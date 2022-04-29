namespace M001FirstApp
{
    public partial class Form1 : Form
    {

        decimal result;
        decimal currentNumber = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
            currentNumber = Convert.ToInt32(txtBox.Text); // 1
        }

        private void button_calculation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "+":
                    result = currentNumber + result;
                    txtBox.Text = "";
                    lblText.Text = result.ToString();
                    break;
                case "-":

                    if (result == 0)
                        result = currentNumber- result;
                    else
                        result = result - currentNumber;


                    txtBox.Text = "";
                    lblText.Text = result.ToString();

                    break;
                case "/":

                    break;
                case "x":

                    break;
                case "=":

                    break;
                default:
                    break;
            }
        }
    }
}