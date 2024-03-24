namespace FisicaApp_2._0___Básico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numEntrada1 = new NumericUpDown();
            numEntrada2 = new NumericUpDown();
            numEntrada3 = new NumericUpDown();
            btVelocidade = new Button();
            btAceleracao = new Button();
            btMovimento = new Button();
            btTorricelli = new Button();
            label4 = new Label();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)numEntrada1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "Entrada 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 60);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 1;
            label2.Text = "Entrada 2:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 111);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 2;
            label3.Text = "Entrada 3:";
            // 
            // numEntrada1
            // 
            numEntrada1.Location = new Point(144, 16);
            numEntrada1.Name = "numEntrada1";
            numEntrada1.Size = new Size(120, 23);
            numEntrada1.TabIndex = 3;
            // 
            // numEntrada2
            // 
            numEntrada2.Location = new Point(144, 67);
            numEntrada2.Name = "numEntrada2";
            numEntrada2.Size = new Size(120, 23);
            numEntrada2.TabIndex = 4;
            // 
            // numEntrada3
            // 
            numEntrada3.Location = new Point(144, 118);
            numEntrada3.Name = "numEntrada3";
            numEntrada3.Size = new Size(120, 23);
            numEntrada3.TabIndex = 5;
            // 
            // btVelocidade
            // 
            btVelocidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btVelocidade.Location = new Point(78, 210);
            btVelocidade.Name = "btVelocidade";
            btVelocidade.Size = new Size(95, 60);
            btVelocidade.TabIndex = 6;
            btVelocidade.Text = "Velocidade Média";
            btVelocidade.UseVisualStyleBackColor = true;
            btVelocidade.Click += btVelocidade_Click;
            // 
            // btAceleracao
            // 
            btAceleracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAceleracao.Location = new Point(235, 210);
            btAceleracao.Name = "btAceleracao";
            btAceleracao.Size = new Size(95, 60);
            btAceleracao.TabIndex = 7;
            btAceleracao.Text = "Aceleração";
            btAceleracao.UseVisualStyleBackColor = true;
            btAceleracao.Click += btAceleracao_Click;
            // 
            // btMovimento
            // 
            btMovimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMovimento.Location = new Point(400, 210);
            btMovimento.Name = "btMovimento";
            btMovimento.Size = new Size(105, 60);
            btMovimento.TabIndex = 8;
            btMovimento.Text = "Movimento Uniforme";
            btMovimento.UseVisualStyleBackColor = true;
            btMovimento.Click += btMovimento_Click;
            // 
            // btTorricelli
            // 
            btTorricelli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btTorricelli.Location = new Point(577, 210);
            btTorricelli.Name = "btTorricelli";
            btTorricelli.Size = new Size(95, 60);
            btTorricelli.TabIndex = 9;
            btTorricelli.Text = "Torricelli";
            btTorricelli.UseVisualStyleBackColor = true;
            btTorricelli.Click += btTorricelli_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 339);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 10;
            label4.Text = "Resultado:";
            label4.Click += label4_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(172, 339);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 30);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Resultado aqui";
            lblResultado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(btTorricelli);
            Controls.Add(btMovimento);
            Controls.Add(btAceleracao);
            Controls.Add(btVelocidade);
            Controls.Add(numEntrada3);
            Controls.Add(numEntrada2);
            Controls.Add(numEntrada1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FisicaApp 2.0 - Básico";
            ((System.ComponentModel.ISupportInitialize)numEntrada1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntrada3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numEntrada1;
        private NumericUpDown numEntrada2;
        private NumericUpDown numEntrada3;
        private Button btVelocidade;
        private Button btAceleracao;
        private Button btMovimento;
        private Button btTorricelli;
        private Label label4;
        private Label lblResultado;
    }
}
