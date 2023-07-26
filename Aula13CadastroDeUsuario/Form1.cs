namespace Aula13CadastroDeUsuario
{
    public partial class Form1 : Form
    {
        List<Pessoa> Listapessoa = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        public void atualizarInterFace()
        {
            for (int i = 0; i < Listapessoa.Count; i++)
            {
                listView1.Items.Add(Listapessoa[i].nome);
                listView1.Items.Add(Listapessoa[i].idade.ToString());
                listView1.Items.Add(Listapessoa[i].rua);
                listView1.Items.Add(Listapessoa[i].cidade);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtRua.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa (nome , idade, rua, cidade);
            atualizarInterFace();
            
        }
    }
}