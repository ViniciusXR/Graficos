using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {
        //Declara um Dictionary que irá armazenar os valores de x e y
        Dictionary<double, double> valores;

        //Declara a variável que irá definir os valores aleatorios de x 
        int contadorX = 0;
        public Form1()
        {
            InitializeComponent();

            //Instancia a variável que irá armazernar os valores de x e y
            valores = new Dictionary<double, double>();

            //Define que o gráfico 3d será utilizado como padrão
            grafico3d.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            xvalor.Focus();
            for (int i = 0; i < 35; i++)//Preenche o combobox com todos os tipos de gráficos
            {
                tipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)//Preenche o combobox que irá permitir mudar a cor do gráfico
            {
                palleteCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void btnInserirValores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(xvalor.Text) || string.IsNullOrEmpty(yvalor.Text))
            {
                MessageBox.Show("É necessário inserir os valores de X e Y","Calcular Gráfico");
                return;
            }

            if (valores.ContainsKey(double.Parse(xvalor.Text)))
            {
                valores[double.Parse(xvalor.Text)] = double.Parse(yvalor.Text);
            }
            else
            {
                valores.Add(double.Parse(xvalor.Text) , double.Parse(yvalor.Text));
            }

            //Ordena os valores de forma crescente
            var items = from valor in valores orderby valor.Key ascending select valor;

            dataValores.Rows.Clear();
            grafico.Series[0].Points.Clear();

            foreach (var item in items)
            {
                dataValores.Rows.Add(item.Key, item.Value);
                grafico.Series[0].Points.AddXY(item.Key, item.Value);
            }
            grafico.Update();

            xvalor.Text = "";
            yvalor.Text = "";
            xvalor.Focus();

        }

        private void dataValores_SelectionChanged(object sender, EventArgs e)
        {
            xvalor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[0].Value.ToString();
            yvalor.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa todos os valores que podem armazenar dados
            valores.Clear();
            grafico.Series[0].Points.Clear();
            dataValores.Rows.Clear();
            contadorX = 0;
            xvalor.Text = "";
            yvalor.Text = "";
            xvalor.Focus();
        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aplica o novo tipo de gráfico selecionado no combobox tipoGrafico
            grafico.Series[0].ChartType = (SeriesChartType)tipoGrafico.SelectedItem;
        }

        private void palleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aplica a nova cor no gráfico selecionado no combobox palleteCor
            grafico.Palette = (ChartColorPalette)palleteCor.SelectedItem;
        }

        private void grafico3d_CheckedChanged(object sender, EventArgs e)
        {
            //Alterna a forma de exibição do gráfico
            grafico.ChartAreas[0].Area3DStyle.Enable3D = grafico3d.Checked;
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //Ativa o timer que irá chamar o método para gerar números aleatórios a cada 500 milissegundos
            timer1.Enabled = !timer1.Enabled;
        }

        private void xvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se o valor que foi digitado no TextBox xvalor é um número válido
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (xvalor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void yvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se o valor que foi digitado no TextBox yvalor é um número válido
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (yvalor.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (grafico.Series[0].Points.Count() > 15)
            {
                grafico.Series[0].Points.RemoveAt(0);//Remove um valor grafico quando a quantidade de items é maior que 15
                grafico.Update();
            }

            int y = new Random().Next(1000);

            //Incrementa o valor de X e adiciona um valor aleatório de Y no gráfico
            grafico.Series[0].Points.AddXY(contadorX++, y);
            dataValores.Rows.Add(contadorX, y);
            dataValores.CurrentCell = dataValores.Rows[dataValores.Rows.Count - 1].Cells[0];
        }
    }
}
