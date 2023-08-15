using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Xml;

namespace pontoapp
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        //"Banco de dados"

        List<string> loginsLIST = new List<string>();
        List<string> senhasLIST = new List<string>();
        List<string> estadosLIST = new List<string>();

        //Bot�o bater
        private void baterBT_Click(object sender, EventArgs e)
        {
            loginTXT.Text = loginTXT.Text.ToUpper();
            if (loginsLIST.Contains(loginTXT.Text))
            {
                if (senhasLIST[loginsLIST.IndexOf(loginTXT.Text)] == senhaTXT.Text)
                {
                    if (estadosLIST[loginsLIST.IndexOf(loginTXT.Text)] == "Inativo")
                    {
                        estadosLIST[loginsLIST.IndexOf(loginTXT.Text)] = "Ativo";

                        namelistLISTB.Items[loginsLIST.IndexOf(loginTXT.Text)] = "Ativo || " + loginTXT.Text;

                        MessageBox.Show(loginTXT.Text + " Entrou!");
                    }
                    else
                    {
                        estadosLIST[loginsLIST.IndexOf(loginTXT.Text)] = "Inativo";

                        namelistLISTB.Items[loginsLIST.IndexOf(loginTXT.Text)] = "Inativo || " + loginTXT.Text;

                        MessageBox.Show(loginTXT.Text + " Saiu!");
                    }
                }
                else
                    MessageBox.Show("Senha inv�lida");
            }
            else
            {
                MessageBox.Show("Dados n�o encontrados");
            }
        }

        //Bot�o cadastrar
        private void cadastrarBT_Click(object sender, EventArgs e)
        {
            loginTXT.Text = loginTXT.Text.ToUpper();
            if (!(loginsLIST.Contains(loginTXT.Text)))
            {
                if (loginTXT.Text == "" || senhaTXT.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos");
                }
                else
                {
                    loginsLIST.Add(loginTXT.Text);
                    senhasLIST.Add(senhaTXT.Text);
                    estadosLIST.Add("Inativo");

                    namelistLISTB.Items.Add("Inativo || " + loginTXT.Text);

                    MessageBox.Show("Usu�rio cadastrado com sucesso!");
                }
            }
            else
                MessageBox.Show("Nome de usu�rio indispon�vel");
        }

        //Bot�o apagar
        private void apagarBT_Click(object sender, EventArgs e)
        {
            loginTXT.Text = loginTXT.Text.ToUpper();
            if (loginsLIST.Contains(loginTXT.Text))
            {
                if (senhasLIST[loginsLIST.IndexOf(loginTXT.Text)] == senhaTXT.Text)
                {
                    namelistLISTB.Items.RemoveAt(loginsLIST.IndexOf(loginTXT.Text));

                    estadosLIST.Remove(estadosLIST[loginsLIST.IndexOf(loginTXT.Text)]);
                    senhasLIST.Remove(senhasLIST[loginsLIST.IndexOf(loginTXT.Text)]);
                    loginsLIST.Remove(loginTXT.Text);

                    MessageBox.Show("Dados removidos com sucesso");
                }
                else
                    MessageBox.Show("Senha inv�lida");
            }
            else
                MessageBox.Show("Dados n�o encontrados");
        }
    }
}