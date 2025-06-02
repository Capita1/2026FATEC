using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
namespace P1_TATI
{
    public partial class frm_Login : Form
    {
        string server = "Server=localhost;Port=3306;Database=onu;Uid=root;Pwd=1324;";
        public frm_Login()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            string conexao = (server);
    
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();//abre comunicação
                    //consulta hash da senha de determinado email
                    MySqlCommand cmd = new MySqlCommand("SELECT senha FROM usuarios WHERE email = @email", conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    var resultado = cmd.ExecuteScalar();
                    //consulta id de determinado email
                    MySqlCommand cmd2 = new MySqlCommand("SELECT id FROM usuarios WHERE email = @email", conn);
                    cmd2.Parameters.AddWithValue("@email", email);
                    string id = (cmd2.ExecuteScalar()).ToString();

                    if (resultado != null)//se a senha for diferente de nula
                    {
                        string senhaHash = resultado.ToString();

                        if (BCrypt.Net.BCrypt.Verify(senha, senhaHash))
                        {
                            frm_menu Menu = new frm_menu(id);//passa id para menu
                            Menu.ShowDialog();
                            this.Close();//se fechar menu, fecha login
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message);
                }
            }
        }
        

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
