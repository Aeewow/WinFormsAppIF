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
                    outMessage = $"�������� x ����� {value}";
                }
                else if (value > 0 && value <= 1)
                {
                    outMessage = $"�������� x ����� ��������� ����� {value}";
                }
                else
                {
                    outMessage = $"�������� x ����� �������� ��������� ����� {value * value}";
                }
                return outMessage;
            }
        }
    }
}