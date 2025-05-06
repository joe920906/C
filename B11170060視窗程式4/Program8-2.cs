namespace _8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] X= new int[5];

            Random rand = new Random();

            for (int i = 0; i < X.Length; i++)
                X[i] = rand.Next(1, 201);

            label1.Text = string.Join(", ", X);
        }
    }
}
