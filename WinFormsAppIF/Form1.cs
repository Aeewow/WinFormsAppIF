namespace WinFormsAppIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toLine_TextChanged(object sender, EventArgs e)
        {

        }
        public class Logic
        {
            public static string Compare(int value)
            {
                string outMessage = "";
                if (value <= 0)
                {
                    outMessage = $"Значение x равно {value}";
                }
                else if (value > 0 && value <= 1)
                {
                    outMessage = $"Значение x равно введённому числу {value}";
                }
                else
                {
                    outMessage = $"Значение x равно квадрату введённого числа {value * value}";
                }
                return outMessage;
            }
        }
    }
}