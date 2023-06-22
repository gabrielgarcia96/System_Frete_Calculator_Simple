namespace SistemaDeFrete
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textKm = new System.Windows.Forms.TextBox();
            this.textValorCombustivel = new System.Windows.Forms.TextBox();
            this.PanelPrinpal = new System.Windows.Forms.Panel();
            this.textCep = new System.Windows.Forms.MaskedTextBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbool = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTabela = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImgVeiculo = new System.Windows.Forms.PictureBox();
            this.resultado = new System.Windows.Forms.Label();
            this.textConsumoCombustivel = new System.Windows.Forms.TextBox();
            this.textCustoPorKm = new System.Windows.Forms.TextBox();
            this.textDespesaCombustivel = new System.Windows.Forms.TextBox();
            this.textKmRodado = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelPrinpal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Frete";
            // 
            // textKm
            // 
            this.textKm.BackColor = System.Drawing.SystemColors.Window;
            this.textKm.Location = new System.Drawing.Point(448, 35);
            this.textKm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(87, 20);
            this.textKm.TabIndex = 3;
            // 
            // textValorCombustivel
            // 
            this.textValorCombustivel.BackColor = System.Drawing.SystemColors.Window;
            this.textValorCombustivel.Location = new System.Drawing.Point(34, 124);
            this.textValorCombustivel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textValorCombustivel.Name = "textValorCombustivel";
            this.textValorCombustivel.Size = new System.Drawing.Size(173, 20);
            this.textValorCombustivel.TabIndex = 4;
            // 
            // PanelPrinpal
            // 
            this.PanelPrinpal.BackColor = System.Drawing.SystemColors.Window;
            this.PanelPrinpal.Controls.Add(this.textCep);
            this.PanelPrinpal.Controls.Add(this.imgLogo);
            this.PanelPrinpal.Controls.Add(this.button1);
            this.PanelPrinpal.Controls.Add(this.checkbool);
            this.PanelPrinpal.Controls.Add(this.label6);
            this.PanelPrinpal.Controls.Add(this.comboBoxTabela);
            this.PanelPrinpal.Controls.Add(this.comboBox1);
            this.PanelPrinpal.Controls.Add(this.label5);
            this.PanelPrinpal.Controls.Add(this.label4);
            this.PanelPrinpal.Controls.Add(this.label3);
            this.PanelPrinpal.Controls.Add(this.label2);
            this.PanelPrinpal.Controls.Add(this.textKm);
            this.PanelPrinpal.Controls.Add(this.textValorCombustivel);
            this.PanelPrinpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPrinpal.Location = new System.Drawing.Point(11, 80);
            this.PanelPrinpal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelPrinpal.Name = "PanelPrinpal";
            this.PanelPrinpal.Size = new System.Drawing.Size(994, 243);
            this.PanelPrinpal.TabIndex = 7;
            // 
            // textCep
            // 
            this.textCep.BackColor = System.Drawing.SystemColors.Window;
            this.textCep.Location = new System.Drawing.Point(259, 33);
            this.textCep.Mask = "00000-000";
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(86, 20);
            this.textCep.TabIndex = 15;
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(606, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(388, 234);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 14;
            this.imgLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(31, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbool
            // 
            this.checkbool.AutoSize = true;
            this.checkbool.BackColor = System.Drawing.SystemColors.Window;
            this.checkbool.Location = new System.Drawing.Point(448, 126);
            this.checkbool.Name = "checkbool";
            this.checkbool.Size = new System.Drawing.Size(87, 17);
            this.checkbool.TabIndex = 13;
            this.checkbool.Text = "Ida / Volta";
            this.checkbool.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tabela:";
            // 
            // comboBoxTabela
            // 
            this.comboBoxTabela.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTabela.FormattingEnabled = true;
            this.comboBoxTabela.Location = new System.Drawing.Point(233, 124);
            this.comboBoxTabela.Name = "comboBoxTabela";
            this.comboBoxTabela.Size = new System.Drawing.Size(173, 21);
            this.comboBoxTabela.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Combustivel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distancia KM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veiculo:";
            // 
            // ImgVeiculo
            // 
            this.ImgVeiculo.BackColor = System.Drawing.SystemColors.Window;
            this.ImgVeiculo.Location = new System.Drawing.Point(605, 3);
            this.ImgVeiculo.Name = "ImgVeiculo";
            this.ImgVeiculo.Size = new System.Drawing.Size(388, 249);
            this.ImgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgVeiculo.TabIndex = 8;
            this.ImgVeiculo.TabStop = false;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(105, 229);
            this.resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(54, 13);
            this.resultado.TabIndex = 16;
            this.resultado.Text = "Destino:";
            // 
            // textConsumoCombustivel
            // 
            this.textConsumoCombustivel.Location = new System.Drawing.Point(447, 52);
            this.textConsumoCombustivel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textConsumoCombustivel.Name = "textConsumoCombustivel";
            this.textConsumoCombustivel.Size = new System.Drawing.Size(77, 20);
            this.textConsumoCombustivel.TabIndex = 16;
            // 
            // textCustoPorKm
            // 
            this.textCustoPorKm.Location = new System.Drawing.Point(453, 169);
            this.textCustoPorKm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCustoPorKm.Name = "textCustoPorKm";
            this.textCustoPorKm.Size = new System.Drawing.Size(77, 20);
            this.textCustoPorKm.TabIndex = 17;
            // 
            // textDespesaCombustivel
            // 
            this.textDespesaCombustivel.Location = new System.Drawing.Point(192, 52);
            this.textDespesaCombustivel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textDespesaCombustivel.Name = "textDespesaCombustivel";
            this.textDespesaCombustivel.Size = new System.Drawing.Size(87, 20);
            this.textDespesaCombustivel.TabIndex = 18;
            // 
            // textKmRodado
            // 
            this.textKmRodado.Location = new System.Drawing.Point(202, 169);
            this.textKmRodado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textKmRodado.Name = "textKmRodado";
            this.textKmRodado.Size = new System.Drawing.Size(77, 20);
            this.textKmRodado.TabIndex = 19;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(523, 229);
            this.textTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(77, 20);
            this.textTotal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Consumo Combustivel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Despesa Combustivel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "KM Rodado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(479, 232);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Custo por KM:";
            // 
            // textDestino
            // 
            this.textDestino.AutoSize = true;
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(199, 229);
            this.textDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(0, 13);
            this.textDestino.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ImgVeiculo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textTotal);
            this.panel1.Controls.Add(this.textKmRodado);
            this.panel1.Controls.Add(this.textCustoPorKm);
            this.panel1.Controls.Add(this.textDestino);
            this.panel1.Controls.Add(this.textDespesaCombustivel);
            this.panel1.Controls.Add(this.resultado);
            this.panel1.Controls.Add(this.textConsumoCombustivel);
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 255);
            this.panel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1024, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelPrinpal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelPrinpal.ResumeLayout(false);
            this.PanelPrinpal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVeiculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox textValorCombustivel;
        private System.Windows.Forms.Panel PanelPrinpal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTabela;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox ImgVeiculo;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox textConsumoCombustivel;
        private System.Windows.Forms.TextBox textCustoPorKm;
        private System.Windows.Forms.TextBox textDespesaCombustivel;
        private System.Windows.Forms.TextBox textKmRodado;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label textDestino;
        private System.Windows.Forms.MaskedTextBox textCep;
        private System.Windows.Forms.Panel panel1;
    }
}

