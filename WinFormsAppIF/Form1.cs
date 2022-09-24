namespace WinFormsAppIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toLine.Text = Properties.Settings.Default.value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            try
            {
                value = int.Parse(this.toLine.Text);
            }
            catch (FormatException)
            {
                return;
            }

            Properties.Settings.Default.value = value;
            Properties.Settings.Default.Save();
            string Message = Logic.Compare(value);
            MessageBox.Show(Logic.Compare(value));

        }
    }
}