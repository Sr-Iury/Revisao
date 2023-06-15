namespace revisão_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vdd2_Click(object sender, EventArgs e)
        {
            Gabarito g = new Gabarito();
            string[] resposta = {r1.Text, r2.Text, r3.Text, r4.Text, r5.Text, r6.Text, r7.Text, r8.Text, r9.Text, r10.Text};
            vdd.Text = Convert.ToString(g.Verifica(resposta));
        }
    }
}