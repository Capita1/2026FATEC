using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P1_TATI
{
    public partial class frm_menu : Form
    {
        public string usuario;
        public frm_menu(string id)
        {
            InitializeComponent();
            usuario = id;
        }
        public void frm_menu_Load(object sender, EventArgs e)
        {
            string s_data = DateTime.Now.ToLongDateString();
            s_data = s_data.Substring(0, 1).ToLower() + s_data.Substring(1, s_data.Length - 1);
            toolStripStatusLabel1.Text = s_data;



            string conexao = ("Server=localhost;Port=3306;Database=onu;Uid=root;Pwd=1324;");
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();//abre comunicação
                    //consulta informações do id
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuarios WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", usuario);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //cria variaveis 
                            string nome = reader["nome"].ToString();
                            string email = reader["email"].ToString();
                            string telefone = reader["telefone"].ToString();
                            string data = reader["data"].ToString();
                            string pais = reader["pais"].ToString();
                            string org = reader["org"].ToString();
                            string sexo = reader["sexo"].ToString();
                            string foto = reader["foto"].ToString();

                            //coloca a informação nos elementos
                            lblNome.Text = nome;
                            lblEmail.Text = email;
                            lblTelefone.Text = telefone;
                            lblNasc.Text = data;
                            lblPais.Text = pais;
                            lblOrg.Text = org;
                            lblSexo.Text = sexo;
                            picFoto.Image = Image.FromFile(foto);
                            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                            //MessageBox.Show($"Usuário: {nome} - Email: {email}"); //teste
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }


        public class ScrollablePictureBox : PictureBox
        {
            private HScrollBar hScroll = new HScrollBar();
            private VScrollBar vScroll = new VScrollBar();
            private Point imgPosition = new Point(0, 0);

            public ScrollablePictureBox()
            {
                // Configuração das scrollbars
                hScroll.Dock = DockStyle.Bottom;
                vScroll.Dock = DockStyle.Right;

                // Adiciona os controles ao PictureBox
                this.Controls.Add(hScroll);
                this.Controls.Add(vScroll);

                // Eventos das scrollbars
                hScroll.Scroll += (s, e) =>
                {
                    imgPosition.X = -e.NewValue;
                    this.Invalidate();
                };

                vScroll.Scroll += (s, e) =>
                {
                    imgPosition.Y = -e.NewValue;
                    this.Invalidate();
                };

                // Evento para quando a imagem mudar
                this.LoadCompleted += (s, e) => UpdateScrollBars();
                this.SizeChanged += (s, e) => UpdateScrollBars();
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                // Desenha a imagem na posição correta
                if (this.Image != null)
                {
                    pe.Graphics.DrawImage(this.Image, imgPosition);
                }
            }

            private void UpdateScrollBars()
            {
                if (this.Image == null)
                {
                    hScroll.Enabled = vScroll.Enabled = false;
                    return;
                }

                // Configuração da scrollbar horizontal
                hScroll.Enabled = this.Image.Width > this.ClientSize.Width;
                hScroll.Maximum = this.Image.Width - this.ClientSize.Width + hScroll.LargeChange - 1;
                hScroll.SmallChange = this.Image.Width / 20;
                hScroll.LargeChange = this.Image.Width / 10;

                // Configuração da scrollbar vertical
                vScroll.Enabled = this.Image.Height > this.ClientSize.Height;
                vScroll.Maximum = this.Image.Height - this.ClientSize.Height + vScroll.LargeChange - 1;
                vScroll.SmallChange = this.Image.Height / 20;
                vScroll.LargeChange = this.Image.Height / 10;
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            //nada
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tmr_war_Tick(object sender, EventArgs e)
        {
            DateTime data_inicio = new DateTime(2022, 2, 24);  // Data correta do início da guerra
            DateTime agora = DateTime.Now;
            TimeSpan tempo_decorrido = agora - data_inicio;  // Usar TimeSpan em vez de DateTime

            // Formatar a saída para mostrar dias, horas, minutos
            string tempo_guerra = $"{tempo_decorrido.Days} dias, " +
                                 $"{tempo_decorrido.Hours} horas, " +
                                 $"{tempo_decorrido.Minutes} minutos";

            lbl_cont_num.Text = tempo_guerra;
            // Atualiza o horário a cada segundo
        }

        private void tmr_Menu_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            // Atualiza o horário a cada segundo

            toolStripProgressBar1.Value = DateTime.Now.Second;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário realmente quer sair
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do programa?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();  // Fecha todo o aplicativo
                                     // ou this.Close() para fechar apenas este formulário
            }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pic_Locais_MouseDown(object sender, MouseEventArgs e, Point mouseDownLocation)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void pic_Locais_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cont_num_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (sender, e) =>
            {
                Bitmap bmp = new Bitmap(dgv.Width, dgv.Height);
                dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
                e.Graphics.DrawImage(bmp, e.MarginBounds);
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();
        }
    }
}
