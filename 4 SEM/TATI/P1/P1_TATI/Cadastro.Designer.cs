namespace P1_TATI
{
    partial class frm_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastro));
            lbl_nome = new Label();
            lbl_senha = new Label();
            lbl_pais = new Label();
            lbl_emissora = new Label();
            lbl_telefone = new Label();
            lbl_email = new Label();
            btn_cadastrar = new Button();
            btn_limpar = new Button();
            picFoto = new PictureBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            grb_cadastro = new GroupBox();
            btnEscolher = new Button();
            txtOrg = new TextBox();
            dateNasc = new DateTimePicker();
            label2 = new Label();
            cmbPais = new ComboBox();
            label1 = new Label();
            radioMasc = new RadioButton();
            radioFem = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            grb_cadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.ImageAlign = ContentAlignment.MiddleRight;
            lbl_nome.Location = new Point(18, 35);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(123, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome Completo:";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.ImageAlign = ContentAlignment.MiddleRight;
            lbl_senha.Location = new Point(18, 76);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(52, 20);
            lbl_senha.TabIndex = 2;
            lbl_senha.Text = "Senha:";
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.ImageAlign = ContentAlignment.MiddleRight;
            lbl_pais.Location = new Point(18, 273);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(37, 20);
            lbl_pais.TabIndex = 3;
            lbl_pais.Text = "País:";
            // 
            // lbl_emissora
            // 
            lbl_emissora.AutoSize = true;
            lbl_emissora.ImageAlign = ContentAlignment.MiddleRight;
            lbl_emissora.Location = new Point(18, 312);
            lbl_emissora.Name = "lbl_emissora";
            lbl_emissora.Size = new Size(161, 20);
            lbl_emissora.TabIndex = 5;
            lbl_emissora.Text = "Emissora/Organização:";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.ImageAlign = ContentAlignment.MiddleRight;
            lbl_telefone.Location = new Point(18, 153);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(69, 20);
            lbl_telefone.TabIndex = 6;
            lbl_telefone.Text = "Telefone:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.ImageAlign = ContentAlignment.MiddleRight;
            lbl_email.Location = new Point(18, 115);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(55, 20);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "E-mail:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = SystemColors.HotTrack;
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.Location = new Point(596, 396);
            btn_cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(86, 31);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(504, 396);
            btn_limpar.Margin = new Padding(3, 4, 3, 4);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(86, 31);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Image = Properties.Resources.avatar_azul;
            picFoto.InitialImage = Properties.Resources.avatar_azul;
            picFoto.Location = new Point(531, 35);
            picFoto.Margin = new Padding(3, 4, 3, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(137, 154);
            picFoto.TabIndex = 10;
            picFoto.TabStop = false;
            picFoto.WaitOnLoad = true;
            picFoto.Click += picFoto_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 32);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(348, 27);
            txtNome.TabIndex = 11;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(147, 73);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(348, 27);
            txtSenha.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 116);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(348, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(147, 151);
            txtTelefone.Margin = new Padding(3, 4, 3, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(348, 27);
            txtTelefone.TabIndex = 15;
            // 
            // grb_cadastro
            // 
            grb_cadastro.Anchor = AnchorStyles.None;
            grb_cadastro.Controls.Add(btnEscolher);
            grb_cadastro.Controls.Add(txtOrg);
            grb_cadastro.Controls.Add(dateNasc);
            grb_cadastro.Controls.Add(label2);
            grb_cadastro.Controls.Add(cmbPais);
            grb_cadastro.Controls.Add(label1);
            grb_cadastro.Controls.Add(radioMasc);
            grb_cadastro.Controls.Add(txtTelefone);
            grb_cadastro.Controls.Add(txtEmail);
            grb_cadastro.Controls.Add(radioFem);
            grb_cadastro.Controls.Add(txtSenha);
            grb_cadastro.Controls.Add(btn_limpar);
            grb_cadastro.Controls.Add(btn_cadastrar);
            grb_cadastro.Controls.Add(txtNome);
            grb_cadastro.Controls.Add(picFoto);
            grb_cadastro.Controls.Add(lbl_email);
            grb_cadastro.Controls.Add(lbl_nome);
            grb_cadastro.Controls.Add(lbl_telefone);
            grb_cadastro.Controls.Add(lbl_emissora);
            grb_cadastro.Controls.Add(lbl_senha);
            grb_cadastro.Controls.Add(lbl_pais);
            grb_cadastro.Location = new Point(11, 5);
            grb_cadastro.Margin = new Padding(3, 4, 3, 4);
            grb_cadastro.Name = "grb_cadastro";
            grb_cadastro.Padding = new Padding(3, 4, 3, 4);
            grb_cadastro.Size = new Size(688, 435);
            grb_cadastro.TabIndex = 16;
            grb_cadastro.TabStop = false;
            grb_cadastro.Text = "Cadastro de imprensa";
            grb_cadastro.Enter += grb_cadastro_Enter;
            // 
            // btnEscolher
            // 
            btnEscolher.Location = new Point(545, 197);
            btnEscolher.Margin = new Padding(3, 4, 3, 4);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(113, 31);
            btnEscolher.TabIndex = 24;
            btnEscolher.Text = "Escolher foto";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += btnEscolher_Click;
            // 
            // txtOrg
            // 
            txtOrg.Location = new Point(185, 307);
            txtOrg.Margin = new Padding(3, 4, 3, 4);
            txtOrg.Name = "txtOrg";
            txtOrg.Size = new Size(151, 27);
            txtOrg.TabIndex = 23;
            // 
            // dateNasc
            // 
            dateNasc.Location = new Point(185, 229);
            dateNasc.Margin = new Padding(3, 4, 3, 4);
            dateNasc.Name = "dateNasc";
            dateNasc.Size = new Size(151, 27);
            dateNasc.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(18, 236);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 20;
            label2.Text = "Data de nascimento:";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { " ", "AP \tOrganização Regional Africana da Propriedade Industrial (ARIPO)", "AR \tArgentina", "AT \tÁustria", "AU \tAustrália", "BA \tBósnia e Herzegovina", "BE \tBélgica", "BG \tBulgária", "BR \tBrazil", "CA \tCanadá", "CH \tSuíça", "CN \tChina", "CS \tChecoeslováquia (até 1993)", "CU \tCuba", "CY \tChipre", "CZ \tRepública Checa", "DD \tAlemanha, excluindo o território que, antes de 3 de Outubro de 1990, constituia a República Federal da Alemanha", "DE \tAlemanha", "DK \tDinamarca", "DZ \tArgélia", "EA \tOrganização Euroasiática de Patentes", "EE \tEstónia", "EG \tEgipto", "EP \tOrganização Europeia de Patentes (OPE/EPO)", "ES \tEspanha", "FI \tFinlândia", "FR \tFrança", "GB \tReino Unido", "GR \tGrécia", "HK \tHong Kong", "HR \tCroácia", "HU \tHungria", "IE \tIrlanda", "IL \tIsrael", "IN \tIndia", "IT \tItália", "JP \tJapão", "KE \tQuénia", "KR \tRepública da Coreia", "LT \tLituânia", "LU \tLuxemburgo", "LV \tLetónia", "MC \tMónaco", "MD \tRepública da Moldávia", "MN \tMongólia", "MT \tMalta", "MW \tMalawi", "MX \tMéxico", "MY \tMalásia", "NC \tNova Caledónia", "NL \tHolanda", "NO \tNoruega", "NZ \tNova Zelândia", "OA \tOrganização Africana da Propriedade Intelectual (OAPI)", "PH \tFilipinas", "PL \tPolónia", "PT \tPortugal", "RO \tRoménia", "RU \tFederação Russa", "SE \tSuécia", "SG \tSingapura", "SI \tEslovénia", "SK \tEslováquia", "SU \tUnião das Repúblicas Socialistas Soviéticas (URSS)", "TJ \tTadjiquistão", "TR \tTurquia", "TT \tTrindade e Tobago", "TW \tTaiwan", "US \tEstados Unidos da América", "VN \tVietname", "WO \tOrganização Mundial da Propriedade Intelectual (OMPI/WIPO)", "YU \tJugoslávia", "ZA \tÁfrica do Sul", "ZM \tZâmbia", "ZW \tZimbabwe" });
            cmbPais.Location = new Point(185, 269);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(151, 28);
            cmbPais.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(21, 356);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 17;
            label1.Text = "Sexo:";
            // 
            // radioMasc
            // 
            radioMasc.AutoSize = true;
            radioMasc.Location = new Point(168, 355);
            radioMasc.Name = "radioMasc";
            radioMasc.Size = new Size(97, 24);
            radioMasc.TabIndex = 16;
            radioMasc.TabStop = true;
            radioMasc.Text = "Masculino";
            radioMasc.UseVisualStyleBackColor = true;
            // 
            // radioFem
            // 
            radioFem.AutoSize = true;
            radioFem.Location = new Point(71, 355);
            radioFem.Name = "radioFem";
            radioFem.Size = new Size(91, 24);
            radioFem.TabIndex = 10;
            radioFem.TabStop = true;
            radioFem.Text = "Feminino";
            radioFem.UseVisualStyleBackColor = true;
            // 
            // frm_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 453);
            Controls.Add(grb_cadastro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Cadastro";
            Text = "Cadastro";
            Load += frm_Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            grb_cadastro.ResumeLayout(false);
            grb_cadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_senha;
        private Label lbl_pais;
        private Label lbl_emissora;
        private Label lbl_telefone;
        private Label lbl_email;
        private Button btn_cadastrar;
        private Button btn_limpar;
        private PictureBox picFoto;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private GroupBox grb_cadastro;
        private RadioButton radioFem;
        private RadioButton radioMasc;
        private Label label1;
        private ComboBox cmbPais;
        private Label label2;
        private DateTimePicker dateNasc;
        private TextBox txtOrg;
        private Button btnEscolher;
    }
}