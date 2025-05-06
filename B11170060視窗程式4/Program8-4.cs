namespace _8_4
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            int[] X = new int[6];

            for (int i = 0; i < X.Length; i++)
            {
                int.TryParse(textBoxes[i].Text, out X[i]);
            }

            int minValue = arrMin(X);
            int maxValue = arrMax(X);
            label1.Text = $"程{maxValue}程{minValue}";

        }
        private int arrMin(int[] arr)
        {
            int min = arr[0];  // 安砞材琌程
            foreach (int num in arr)
                if (num < min)
                    min = num;
            return min;
        }

        private int arrMax(int[] arr)
        {
            int max = arr[0];  // 安砞材琌程
            foreach (int num in arr)
                if (num > max)
                    max = num;
            return max;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
