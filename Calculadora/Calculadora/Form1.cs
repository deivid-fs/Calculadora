using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        private double lblN1 = 0;
        private double lblN2 = 0;
        private string operacao = "";
        private string Na = "";

        public frmPrincipal()
        {
            InitializeComponent();

            // Associar todos os botões numéricos ao método btnNumero_Click
            btnN0.Click += new EventHandler(btnNumero_Click);
            btnN1.Click += new EventHandler(btnNumero_Click);
            btnN2.Click += new EventHandler(btnNumero_Click);
            btnN3.Click += new EventHandler(btnNumero_Click);
            btnN4.Click += new EventHandler(btnNumero_Click);
            btnN5.Click += new EventHandler(btnNumero_Click);
            btnN6.Click += new EventHandler(btnNumero_Click);
            btnN7.Click += new EventHandler(btnNumero_Click);
            btnN8.Click += new EventHandler(btnNumero_Click);
            btnN9.Click += new EventHandler(btnNumero_Click);
            btnVirgula.Click += new EventHandler(btnNumero_Click);

            // Associar os botões de operação ao método btnOperacao_Click
            btnAdic.Click += new EventHandler(btnOperacao_Click); // Botão +
            btnSub.Click += new EventHandler(btnOperacao_Click);  // Botão -
            btnMult.Click += new EventHandler(btnOperacao_Click); // Botão *
            btnDiv.Click += new EventHandler(btnOperacao_Click);  // Botão /
            btnPorcentagem.Click += new EventHandler(btnOperacao_Click);  // Botão %

            // Associar o botão de raiz quadrada ao novo método btnRaizQuadrada_Click
            btnQuadrado.Click += new EventHandler(btnRaizQuadrada_Click);  // Botão √x (raiz quadrada)

            // Associar o botão igual ao método BtnCalc_Click
            btnCalc.Click += new EventHandler(btnCalc_Click); // Botão =

            // Associar o botão Clear ao método btnClear_Click
            btnClear.Click += new EventHandler(btnClear_Click); // Botão Clear
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Na += btn.Text; // Concatena o número clicado
                lblRes.Text = Na; // Atualiza o Label com o número atual
            }
        }
        private void btnRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Na))
            {
                lblN1 = double.Parse(Na); // Converte a entrada atual para um número
                double resultado = Math.Sqrt(lblN1); // Calcula a raiz quadrada de lblN1
                lblRes.Text = resultado.ToString(); // Exibe o resultado na label
                Na = "";
                // Atualiza a entrada para permitir operações subsequentes
            }
        }
        private void btnOperacao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                // Se a entrada Na não estiver vazia, converta e armazene lblN1
                if (!string.IsNullOrEmpty(Na))
                {
                    lblN1 = double.Parse(Na); // Armazena o primeiro número
                    operacao = btn.Text.Trim(); // Armazena a operação escolhida e remove possíveis espaços
                    Na = ""; // Limpa o texto de entrada para o próximo número
                    lblRes.Text = operacao; // Atualiza o Label com a operação (opcional)
                }
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {

            // Verifica se há uma operação e um número para realizar o cálculo
            if (!string.IsNullOrEmpty(operacao) && !string.IsNullOrEmpty(Na))
            {
                lblN2 = double.Parse(Na); // Armazena o segundo número
                double resultado = 0;
                // Simplifique para testar apenas a lógica de adição como exemplo
                if (operacao == "&+")
                {
                    resultado = lblN1 + lblN2;
                    lblRes.Text = Convert.ToString(resultado);
                }

                else if (operacao == "&-")
                {
                    resultado = lblN1 - lblN2;
                    lblRes.Text = Convert.ToString(resultado);
                }
                else if (operacao == "&X")
                {
                    resultado = lblN1 * lblN2;
                    lblRes.Text = Convert.ToString(resultado);
                }
                else if (operacao == "&/")
                {
                    if (lblN2 != 0)
                    {
                        resultado = lblN1 / lblN2;
                        lblRes.Text = Convert.ToString(resultado);
                    }

                    else
                    {
                        MessageBox.Show("Divisão por zero não permitida");
                        return; // Sai do método para evitar mostrar resultado inválido
                    }
                }
                else if (operacao == "&%")
                {
                    resultado = (lblN1 / 100) * lblN2;
                    lblRes.Text = Convert.ToString(resultado);
                }
                else
                {
                    MessageBox.Show($"Operação inválida: '{operacao}'");
                    return;
                }

                // Atualiza o label com o resultado
                lblRes.Text = resultado.ToString();
                lblN1 = resultado; // Atualiza lblN1 para futuras operações
                Na = ""; // Reseta a entrada para permitir uma nova operação
                operacao = ""; // Limpa a operação após o cálculo
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblN1 = 0;
            lblN2 = 0;
            Na = "";
            operacao = "";
            lblRes.Text = "0"; // Reseta o Label
        }
    }
}
