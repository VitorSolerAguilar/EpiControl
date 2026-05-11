using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpiControl.epicontrol.dao
{
    public partial class frmOrcamentoEpi : Form
    {
        public frmOrcamentoEpi()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrcamento.Text))
            {
                MessageBox.Show("Informe o valor do orçamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrcamento.Focus();
                return;
            }

            if (!decimal.TryParse(txtOrcamento.Text, out decimal orcamentoTotal) || orcamentoTotal <= 0)
            {
                MessageBox.Show("Informe um valor de orçamento válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrcamento.Focus();
                return;
            }

            try
            {
                EstoqueEpiDAO dao = new EstoqueEpiDAO();
                DataTable epis = dao.listarEpisMaisUtilizadosComPreco();

                if (epis.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum EPI com histórico de saídas e preço cadastrado foi encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable resultado = calcularDistribuicao(epis, orcamentoTotal);
                dgvResultado.DataSource = resultado;

                dgvResultado.Columns["Nome"].HeaderText = "EPI";
                dgvResultado.Columns["Preco Unitario"].HeaderText = "Valor Unitário (R$)";
                dgvResultado.Columns["Orcamento Alocado"].HeaderText = "Orçamento Alocado (R$)";
                dgvResultado.Columns["Quantidade"].HeaderText = "Qtd. Sugerida";
                dgvResultado.Columns["Total Gasto"].HeaderText = "Total (R$)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular orçamento: " + ex.Message);
            }
        }

        private DataTable calcularDistribuicao(DataTable epis, decimal orcamentoTotal)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("Nome", typeof(string));
            resultado.Columns.Add("Preco Unitario", typeof(decimal));
            resultado.Columns.Add("Orcamento Alocado", typeof(decimal));
            resultado.Columns.Add("Quantidade", typeof(int));
            resultado.Columns.Add("Total Gasto", typeof(decimal));

            decimal totalSaidas = 0;
            foreach (DataRow row in epis.Rows)
                totalSaidas += Convert.ToDecimal(row["total_saidas"]);

            decimal orcamentoRestante = orcamentoTotal;

            foreach (DataRow row in epis.Rows)
            {
                string nome = row["nome"].ToString();
                decimal precoUnitario = Convert.ToDecimal(row["valor_unitario"]);
                decimal saidas = Convert.ToDecimal(row["total_saidas"]);

                if (precoUnitario <= 0) continue;

                decimal peso = saidas / totalSaidas;
                decimal orcamentoAlocado = Math.Round(orcamentoTotal * peso, 2);

                orcamentoAlocado = Math.Min(orcamentoAlocado, orcamentoRestante);

                int quantidade = (int)(orcamentoAlocado / precoUnitario);
                decimal totalGasto = quantidade * precoUnitario;

                if (quantidade > 0)
                {
                    resultado.Rows.Add(nome, precoUnitario, orcamentoAlocado, quantidade, totalGasto);
                    orcamentoRestante -= totalGasto;
                }
            }

            lblSaldo.Text = $"Saldo restante: R$ {orcamentoRestante:F2}";

            return resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOrcamento.Clear();
            dgvResultado.DataSource = null;
            lblSaldo.Text = string.Empty;
        }
    }
}
