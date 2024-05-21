namespace Pecas.View
{
    public partial class VisualisadorPecas : Form
    {
        public VisualisadorPecas()
        {
            InitializeComponent();
        }

        private void cbxBlocoB_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBlocoB.Items.Add("Moto Bis branca 2019");
            cbxBlocoB.Items.Add("Cb-600");
            cbxBlocoB.Items.Add("Cb-500");
            cbxBlocoB.Items.Add("Shinerai");
            cbxBlocoB.DisplayMember = "Moto Bis branca 2019";


        }

        public void cbxBlocoC_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void cbxBlocoA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxBlocoD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVenderBlocoB_Click(object sender, EventArgs e)
        {
            var venda = new VendaAutomovel();
            venda.ShowDialog();
        }

        private void btnVenderBlocoA_Click(object sender, EventArgs e)
        {
            var venda = new VendaAutomovel();
            venda.ShowDialog();
        }

        private void btnVenderBlocoD_Click(object sender, EventArgs e)
        {
            var venda = new VendaAutomovel();
            venda.ShowDialog();
        }

        private void btnVenderBlocoC_Click(object sender, EventArgs e)
        {
            var venda = new VendaAutomovel();
            venda.ShowDialog();
        }
    }
}