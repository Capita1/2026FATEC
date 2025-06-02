namespace P1_TATI
{
    public partial class frm_index : Form
    {
        public frm_index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Login objTela = new frm_Login();
            objTela.ShowDialog();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            frm_Cadastro objTela = new frm_Cadastro();
            objTela.ShowDialog();
        }

        private void frm_index_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
