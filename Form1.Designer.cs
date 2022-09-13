namespace Graficos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xvalor = new System.Windows.Forms.TextBox();
            this.yvalor = new System.Windows.Forms.TextBox();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.palleteCor = new System.Windows.Forms.ComboBox();
            this.grafico3d = new System.Windows.Forms.CheckBox();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gráfico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Y";
            // 
            // xvalor
            // 
            this.xvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xvalor.Location = new System.Drawing.Point(16, 94);
            this.xvalor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xvalor.Name = "xvalor";
            this.xvalor.Size = new System.Drawing.Size(199, 37);
            this.xvalor.TabIndex = 3;
            this.xvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xvalor_KeyPress);
            // 
            // yvalor
            // 
            this.yvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yvalor.Location = new System.Drawing.Point(251, 94);
            this.yvalor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yvalor.Name = "yvalor";
            this.yvalor.Size = new System.Drawing.Size(199, 37);
            this.yvalor.TabIndex = 4;
            this.yvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yvalor_KeyPress);
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.Location = new System.Drawing.Point(16, 140);
            this.btnInserirValores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(435, 58);
            this.btnInserirValores.TabIndex = 5;
            this.btnInserirValores.Text = "Inserir Valores no Gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataValores.Location = new System.Drawing.Point(17, 206);
            this.dataValores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.RowHeadersVisible = false;
            this.dataValores.RowHeadersWidth = 51;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(433, 240);
            this.dataValores.TabIndex = 6;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
            // 
            // X
            // 
            this.X.HeaderText = "Eixo X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Eixo Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(17, 453);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(435, 58);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(17, 554);
            this.tipoGrafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(433, 28);
            this.tipoGrafico.TabIndex = 8;
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // palleteCor
            // 
            this.palleteCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palleteCor.FormattingEnabled = true;
            this.palleteCor.Location = new System.Drawing.Point(460, 554);
            this.palleteCor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.palleteCor.Name = "palleteCor";
            this.palleteCor.Size = new System.Drawing.Size(319, 28);
            this.palleteCor.TabIndex = 9;
            this.palleteCor.SelectedIndexChanged += new System.EventHandler(this.palleteCor_SelectedIndexChanged);
            // 
            // grafico3d
            // 
            this.grafico3d.AutoSize = true;
            this.grafico3d.Location = new System.Drawing.Point(788, 559);
            this.grafico3d.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafico3d.Name = "grafico3d";
            this.grafico3d.Size = new System.Drawing.Size(92, 20);
            this.grafico3d.TabIndex = 10;
            this.grafico3d.Text = "Gráfico 3D";
            this.grafico3d.UseVisualStyleBackColor = true;
            this.grafico3d.CheckedChanged += new System.EventHandler(this.grafico3d_CheckedChanged);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.Location = new System.Drawing.Point(889, 542);
            this.btnAleatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(208, 47);
            this.btnAleatorio.TabIndex = 11;
            this.btnAleatorio.Text = "Inserir Valores Aleatórios";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(460, 11);
            this.grafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "X vs Y";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(636, 500);
            this.grafico.TabIndex = 12;
            this.grafico.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 530);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo do Gráfico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cor do Gráfico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.grafico3d);
            this.Controls.Add(this.palleteCor);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataValores);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.yvalor);
            this.Controls.Add(this.xvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xvalor;
        private System.Windows.Forms.TextBox yvalor;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.ComboBox palleteCor;
        private System.Windows.Forms.CheckBox grafico3d;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

