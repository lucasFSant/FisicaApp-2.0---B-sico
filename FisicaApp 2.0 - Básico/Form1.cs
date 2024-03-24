namespace FisicaApp_2._0___Básico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal Velocidade(decimal deslocamento, decimal tempo)
        {
            return deslocamento / tempo;
        }

        decimal Aceleracao(decimal velocidade, decimal tempo)
        {
            return velocidade / tempo;
        }

        decimal Mu(decimal posicaoInicial, decimal velocidade, decimal tempo)
        {
            return posicaoInicial + (velocidade * tempo);
        }

        decimal VelFinal(decimal velocidadeInicial, decimal aceleracao,decimal deslocamento)
        {
            return (decimal)Math.Sqrt((double)(velocidadeInicial * velocidadeInicial) + (2 * (double)aceleracao * (double)deslocamento));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btVelocidade_Click(object sender, EventArgs e)
        {
            decimal deslocamento, tempo;

            deslocamento = numEntrada1.Value;
            tempo = numEntrada2.Value;

            if (deslocamento == 0)
            {
                MessageBox.Show("Coloca um deslocamento maior que 0");
            }
            else
            {
                decimal velocidade = Velocidade(deslocamento, tempo);

                lblResultado.Visible = true;
                lblResultado.Text = velocidade.ToString("0.0");
            }

        }

        private void btAceleracao_Click(object sender, EventArgs e)
        {
            decimal velocidade, tempo;

            velocidade = numEntrada1.Value;
            tempo = numEntrada2.Value;

            if (velocidade == 0)
            {
                MessageBox.Show("Coloca uma velocidade maior que 0");
            }
            else
            {
                decimal aceleracao = Aceleracao(velocidade, tempo);

                lblResultado.Visible = true;
                lblResultado.Text = aceleracao.ToString("0.0");
            }
        }

        private void btMovimento_Click(object sender, EventArgs e)
        {
            decimal posicaoInicial, velocidade, tempo;

            posicaoInicial = numEntrada1.Value;
            velocidade = numEntrada2.Value;
            tempo = numEntrada3.Value;

            decimal posicaoFinal = Mu(posicaoInicial, velocidade, tempo);

            lblResultado.Visible = true;
            lblResultado.Text = posicaoFinal.ToString("0.0");
        }

        private void btTorricelli_Click(object sender, EventArgs e)
        {
            decimal velocidadeInicial, aceleracao, deslocamento;

            velocidadeInicial = numEntrada1.Value;
            aceleracao = numEntrada2.Value;
            deslocamento = numEntrada3.Value;

            decimal velocidadeFinal = VelFinal(velocidadeInicial, aceleracao, deslocamento);

            lblResultado.Visible = true;
            lblResultado.Text = velocidadeFinal.ToString("0.000");
        }
    }
}
