using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProva
{
    public partial class Form1 : Form
    {
        int total_venda = 0;
        double valorTotalCompra = 0;
        double totalVendas = 0;


        public Form1()
        {
            InitializeComponent();
            UpdateTotalVendas();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica a existeência de linhas no Grid
            if (dgv.RowCount > 0)
            {
                // Move o conteúdo da primeira célula da linha selecionada pra a caixa de texto
                txtalterar.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            //Adicona o contéudo das caixas de texto nas colunas correspondentes
            dgv.Rows.Add(txtproduto.Text, txtqntd.Text, txtvalor.Text);

            //Limpa as caixas de texto
            txtproduto.Clear();
            txtqntd.Clear();
            txtvalor.Clear();


            //Exibe uma mensagem ao usuário de inclusão com sucesso!
            MessageBox.Show("Venda Incluida com sucesso", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            while (dgv.Rows.Count != 0)
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    dgv.Rows.Remove(item);
                }
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                double quantidade = Convert.ToDouble(row.Cells[1].Value);
                double valor = Convert.ToDouble(row.Cells[2].Value);

                valorTotalCompra = quantidade * valor;
                lbltotal.Text = valorTotalCompra.ToString();

            }
            UpdateTotalVendas();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            //Finaliza a aplicasção
            Application.Exit();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtalterar.Text != null)
            {
                //Move o novo valor da caixa de texto ALteração para célula selecionada
                dgv.CurrentRow.Cells[1].Value = txtalterar.Text;

                //Exibe a mensagem de alteração com sucesso
                MessageBox.Show("Venda alterada com sucesso", "Alteração",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                UpdateTotalVendas();
            }
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            //Verifica a existência de linhas no Grid
            if (dgv.Rows.Count > 0)
            {
                //Remove a linha selecionada pelo Grid
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);

                //Exibe uma mensagem ao usuário de exclusão com sucesso!
                MessageBox.Show("Venda Excluída com sucesso", "Exclusão",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Exibe na label o contador de linhas do GridView atualizado após a remoção
                lbltotal.Text = dgv.RowCount.ToString();
                UpdateTotalVendas();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtproduto.Clear();
            txtqntd.Clear();
            txtvalor.Clear();
           
            while(dgv.Rows.Count != 0)
            {
                foreach(DataGridViewRow item in dgv.Rows)
                {
                    dgv.Rows.Remove(item);
                }
            }

            UpdateTotalVendas();


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            txtproduto.Clear();
            txtqntd.Clear();
            txtvalor.Clear();

            total_venda += 1;

            vendas.Text = total_venda.ToString();

            UpdateTotalVendas();


        }

        private void UpdateTotalVendas()
        {
            totalVendas = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Column3"].Value != null && row.Cells["QUANTIDADE"].Value != null)
                {
                    double valorProduto;
                    int quantidadeProduto;
                    if (double.TryParse(row.Cells["Column3"].Value.ToString(), out valorProduto) &&
                        int.TryParse(row.Cells["QUANTIDADE"].Value.ToString(), out quantidadeProduto))
                    {
                        totalVendas += valorProduto * quantidadeProduto;
                    }
                }
            }
            lbltotal.Text = $"{totalVendas:C}";
        }

        private void vendas_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
