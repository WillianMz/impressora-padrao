namespace ImpressoraPadrao
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
            lsbImpressoras = new ListBox();
            pnlTitulo = new Panel();
            label1 = new Label();
            BtnBuscarImpressora = new Button();
            BtnObterPadrao = new Button();
            BtnObterOrientacao = new Button();
            BtnObterPapel = new Button();
            BtnDefinirPadrao = new Button();
            BtnPropriedades = new Button();
            groupBox1 = new GroupBox();
            RbRetrato = new RadioButton();
            RbPaisagem = new RadioButton();
            groupBox2 = new GroupBox();
            Rb_Oficio = new RadioButton();
            Rb_Letter = new RadioButton();
            Rb_A4 = new RadioButton();
            BtnSelecionarPapel = new Button();
            BtnSelecionarOrientacao = new Button();
            label2 = new Label();
            pnlTitulo.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lsbImpressoras
            // 
            lsbImpressoras.FormattingEnabled = true;
            lsbImpressoras.ItemHeight = 15;
            lsbImpressoras.Location = new Point(12, 51);
            lsbImpressoras.Name = "lsbImpressoras";
            lsbImpressoras.Size = new Size(397, 169);
            lsbImpressoras.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(421, 45);
            pnlTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Impressoras";
            // 
            // BtnBuscarImpressora
            // 
            BtnBuscarImpressora.Location = new Point(12, 227);
            BtnBuscarImpressora.Name = "BtnBuscarImpressora";
            BtnBuscarImpressora.Size = new Size(397, 23);
            BtnBuscarImpressora.TabIndex = 2;
            BtnBuscarImpressora.Text = "Buscar Impressora";
            BtnBuscarImpressora.UseVisualStyleBackColor = true;
            BtnBuscarImpressora.Click += BtnBuscarImpressora_Click;
            // 
            // BtnObterPadrao
            // 
            BtnObterPadrao.Location = new Point(12, 256);
            BtnObterPadrao.Name = "BtnObterPadrao";
            BtnObterPadrao.Size = new Size(124, 23);
            BtnObterPadrao.TabIndex = 3;
            BtnObterPadrao.Text = "Obter Padrão";
            BtnObterPadrao.UseVisualStyleBackColor = true;
            BtnObterPadrao.Click += BtnObterPadrao_Click;
            // 
            // BtnObterOrientacao
            // 
            BtnObterOrientacao.Location = new Point(12, 285);
            BtnObterOrientacao.Name = "BtnObterOrientacao";
            BtnObterOrientacao.Size = new Size(201, 23);
            BtnObterOrientacao.TabIndex = 4;
            BtnObterOrientacao.Text = "Obter Orientação";
            BtnObterOrientacao.UseVisualStyleBackColor = true;
            BtnObterOrientacao.Click += BtnObterOrientacao_Click;
            // 
            // BtnObterPapel
            // 
            BtnObterPapel.Location = new Point(219, 285);
            BtnObterPapel.Name = "BtnObterPapel";
            BtnObterPapel.Size = new Size(190, 23);
            BtnObterPapel.TabIndex = 5;
            BtnObterPapel.Text = "Obter Papel";
            BtnObterPapel.UseVisualStyleBackColor = true;
            BtnObterPapel.Click += BtnObterPapel_Click;
            // 
            // BtnDefinirPadrao
            // 
            BtnDefinirPadrao.Location = new Point(142, 256);
            BtnDefinirPadrao.Name = "BtnDefinirPadrao";
            BtnDefinirPadrao.Size = new Size(137, 23);
            BtnDefinirPadrao.TabIndex = 6;
            BtnDefinirPadrao.Text = "Definir Padrão";
            BtnDefinirPadrao.UseVisualStyleBackColor = true;
            BtnDefinirPadrao.Click += BtnDefinirPadrao_Click;
            // 
            // BtnPropriedades
            // 
            BtnPropriedades.Location = new Point(285, 256);
            BtnPropriedades.Name = "BtnPropriedades";
            BtnPropriedades.Size = new Size(124, 23);
            BtnPropriedades.TabIndex = 7;
            BtnPropriedades.Text = "Propriedades";
            BtnPropriedades.UseVisualStyleBackColor = true;
            BtnPropriedades.Click += BtnPropriedades_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RbRetrato);
            groupBox1.Controls.Add(RbPaisagem);
            groupBox1.Location = new Point(13, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orientação";
            // 
            // RbRetrato
            // 
            RbRetrato.AutoSize = true;
            RbRetrato.Location = new Point(6, 47);
            RbRetrato.Name = "RbRetrato";
            RbRetrato.Size = new Size(63, 19);
            RbRetrato.TabIndex = 2;
            RbRetrato.TabStop = true;
            RbRetrato.Text = "Retrato";
            RbRetrato.UseVisualStyleBackColor = true;
            // 
            // RbPaisagem
            // 
            RbPaisagem.AutoSize = true;
            RbPaisagem.Location = new Point(6, 22);
            RbPaisagem.Name = "RbPaisagem";
            RbPaisagem.Size = new Size(76, 19);
            RbPaisagem.TabIndex = 1;
            RbPaisagem.TabStop = true;
            RbPaisagem.Text = "Paisagem";
            RbPaisagem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Rb_Oficio);
            groupBox2.Controls.Add(Rb_Letter);
            groupBox2.Controls.Add(Rb_A4);
            groupBox2.Location = new Point(219, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo Papel";
            // 
            // Rb_Oficio
            // 
            Rb_Oficio.AutoSize = true;
            Rb_Oficio.Location = new Point(6, 72);
            Rb_Oficio.Name = "Rb_Oficio";
            Rb_Oficio.Size = new Size(57, 19);
            Rb_Oficio.TabIndex = 2;
            Rb_Oficio.TabStop = true;
            Rb_Oficio.Text = "Oficio";
            Rb_Oficio.UseVisualStyleBackColor = true;
            // 
            // Rb_Letter
            // 
            Rb_Letter.AutoSize = true;
            Rb_Letter.Location = new Point(6, 47);
            Rb_Letter.Name = "Rb_Letter";
            Rb_Letter.Size = new Size(55, 19);
            Rb_Letter.TabIndex = 1;
            Rb_Letter.TabStop = true;
            Rb_Letter.Text = "Letter";
            Rb_Letter.UseVisualStyleBackColor = true;
            // 
            // Rb_A4
            // 
            Rb_A4.AutoSize = true;
            Rb_A4.Location = new Point(6, 22);
            Rb_A4.Name = "Rb_A4";
            Rb_A4.Size = new Size(39, 19);
            Rb_A4.TabIndex = 0;
            Rb_A4.TabStop = true;
            Rb_A4.Text = "A4";
            Rb_A4.UseVisualStyleBackColor = true;
            // 
            // BtnSelecionarPapel
            // 
            BtnSelecionarPapel.Location = new Point(219, 314);
            BtnSelecionarPapel.Name = "BtnSelecionarPapel";
            BtnSelecionarPapel.Size = new Size(190, 23);
            BtnSelecionarPapel.TabIndex = 11;
            BtnSelecionarPapel.Text = "Selecionar Papel";
            BtnSelecionarPapel.UseVisualStyleBackColor = true;
            BtnSelecionarPapel.Click += BtnSelecionarPapel_Click;
            // 
            // BtnSelecionarOrientacao
            // 
            BtnSelecionarOrientacao.Location = new Point(12, 314);
            BtnSelecionarOrientacao.Name = "BtnSelecionarOrientacao";
            BtnSelecionarOrientacao.Size = new Size(201, 23);
            BtnSelecionarOrientacao.TabIndex = 10;
            BtnSelecionarOrientacao.Text = "Selecionar Orientação";
            BtnSelecionarOrientacao.UseVisualStyleBackColor = true;
            BtnSelecionarOrientacao.Click += BtnSelecionarOrientacao_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 485);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "WN2025";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 509);
            Controls.Add(label2);
            Controls.Add(BtnSelecionarPapel);
            Controls.Add(BtnSelecionarOrientacao);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnPropriedades);
            Controls.Add(BtnDefinirPadrao);
            Controls.Add(BtnObterPapel);
            Controls.Add(BtnObterOrientacao);
            Controls.Add(BtnObterPadrao);
            Controls.Add(BtnBuscarImpressora);
            Controls.Add(pnlTitulo);
            Controls.Add(lsbImpressoras);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impressoras";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsbImpressoras;
        private Panel pnlTitulo;
        private Label label1;
        private Button BtnBuscarImpressora;
        private Button BtnObterPadrao;
        private Button BtnObterOrientacao;
        private Button BtnObterPapel;
        private Button BtnDefinirPadrao;
        private Button BtnPropriedades;
        private GroupBox groupBox1;
        private RadioButton RbRetrato;
        private RadioButton RbPaisagem;
        private GroupBox groupBox2;
        private RadioButton Rb_Oficio;
        private RadioButton Rb_Letter;
        private RadioButton Rb_A4;
        private Button BtnSelecionarPapel;
        private Button BtnSelecionarOrientacao;
        private Label label2;
    }
}
