
namespace P1_TATI
{
    partial class frm_menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            menuStrip1 = new MenuStrip();
            estatísticaToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            lblNome = new Label();
            picFoto = new PictureBox();
            lblEmail = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSexo = new Label();
            label7 = new Label();
            lblOrg = new Label();
            lblNasc = new Label();
            label6 = new Label();
            lblPais = new Label();
            label3 = new Label();
            lblTelefone = new Label();
            label5 = new Label();
            label4 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            tmr_Menu = new System.Windows.Forms.Timer(components);
            tmr_war = new System.Windows.Forms.Timer(components);
            tabControl_Menu = new TabControl();
            t_Page_Locais = new TabPage();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            link_lbl_Local = new LinkLabel();
            pic_Locais = new PictureBox();
            t_Page_Acordos = new TabPage();
            label9 = new Label();
            richTextBox2 = new RichTextBox();
            t_Page_Religião = new TabPage();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            lbl_contagem = new Label();
            lbl_cont_num = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl_Menu.SuspendLayout();
            t_Page_Locais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Locais).BeginInit();
            t_Page_Acordos.SuspendLayout();
            t_Page_Religião.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { estatísticaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(893, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // estatísticaToolStripMenuItem
            // 
            estatísticaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imprimirToolStripMenuItem, sairToolStripMenuItem });
            estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            estatísticaToolStripMenuItem.Size = new Size(61, 20);
            estatísticaToolStripMenuItem.Text = "Arquivo";
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(86, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(148, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "nome";
            lblNome.Click += lblNome_Click;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(6, 22);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(104, 105);
            picFoto.TabIndex = 2;
            picFoto.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(86, 17);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(148, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 17);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(picFoto);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 180);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.0806465F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.91936F));
            tableLayoutPanel1.Controls.Add(lblSexo, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(lblOrg, 1, 5);
            tableLayoutPanel1.Controls.Add(lblNome, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNasc, 1, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPais, 1, 4);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(lblTelefone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblEmail, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Location = new Point(121, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(237, 135);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(86, 114);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 15;
            lblSexo.Text = "sexo";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 114);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 11;
            label7.Text = "Sexo:";
            // 
            // lblOrg
            // 
            lblOrg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblOrg.AutoSize = true;
            lblOrg.Location = new Point(86, 94);
            lblOrg.Name = "lblOrg";
            lblOrg.Size = new Size(148, 20);
            lblOrg.TabIndex = 14;
            lblOrg.Text = "organização";
            // 
            // lblNasc
            // 
            lblNasc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNasc.AutoSize = true;
            lblNasc.Location = new Point(86, 54);
            lblNasc.Name = "lblNasc";
            lblNasc.Size = new Size(148, 20);
            lblNasc.TabIndex = 13;
            lblNasc.Text = "nascimento";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 94);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "Organização:";
            // 
            // lblPais
            // 
            lblPais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPais.AutoSize = true;
            lblPais.Location = new Point(86, 74);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(148, 20);
            lblPais.TabIndex = 6;
            lblPais.Text = "pais";
            lblPais.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "País:";
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(86, 34);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(148, 20);
            lblTelefone.TabIndex = 12;
            lblTelefone.Text = "telefone";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 54);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Nascimento:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 34);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefone:";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 526);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(893, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(31, 17);
            toolStripStatusLabel1.Text = "Data";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(33, 17);
            toolStripStatusLabel2.Text = "Hora";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Maximum = 59;
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // tmr_Menu
            // 
            tmr_Menu.Enabled = true;
            tmr_Menu.Tick += tmr_Menu_Tick;
            // 
            // tmr_war
            // 
            tmr_war.Enabled = true;
            tmr_war.Tick += tmr_war_Tick;
            // 
            // tabControl_Menu
            // 
            tabControl_Menu.Controls.Add(t_Page_Locais);
            tabControl_Menu.Controls.Add(t_Page_Acordos);
            tabControl_Menu.Controls.Add(t_Page_Religião);
            tabControl_Menu.Location = new Point(20, 227);
            tabControl_Menu.Name = "tabControl_Menu";
            tabControl_Menu.SelectedIndex = 0;
            tabControl_Menu.Size = new Size(852, 296);
            tabControl_Menu.TabIndex = 10;
            // 
            // t_Page_Locais
            // 
            t_Page_Locais.Controls.Add(vScrollBar1);
            t_Page_Locais.Controls.Add(hScrollBar1);
            t_Page_Locais.Controls.Add(link_lbl_Local);
            t_Page_Locais.Controls.Add(pic_Locais);
            t_Page_Locais.Location = new Point(4, 24);
            t_Page_Locais.Name = "t_Page_Locais";
            t_Page_Locais.Padding = new Padding(3);
            t_Page_Locais.Size = new Size(844, 268);
            t_Page_Locais.TabIndex = 1;
            t_Page_Locais.Text = "Locais Seguros";
            t_Page_Locais.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(818, 15);
            vScrollBar1.Maximum = 721;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 220);
            vScrollBar1.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 100;
            hScrollBar1.Location = new Point(21, 218);
            hScrollBar1.Maximum = 1631;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(794, 17);
            hScrollBar1.TabIndex = 2;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // link_lbl_Local
            // 
            link_lbl_Local.AutoSize = true;
            link_lbl_Local.Location = new Point(21, 243);
            link_lbl_Local.Name = "link_lbl_Local";
            link_lbl_Local.Size = new Size(134, 15);
            link_lbl_Local.TabIndex = 1;
            link_lbl_Local.TabStop = true;
            link_lbl_Local.Text = "https://liveuamap.com/";
            // 
            // pic_Locais
            // 
            pic_Locais.BackgroundImageLayout = ImageLayout.None;
            pic_Locais.Image = Properties.Resources.Locais_Seguros;
            pic_Locais.Location = new Point(22, 15);
            pic_Locais.Name = "pic_Locais";
            pic_Locais.Size = new Size(793, 200);
            pic_Locais.TabIndex = 0;
            pic_Locais.TabStop = false;
            pic_Locais.MouseDown += pic_Locais_MouseDown;
            pic_Locais.MouseMove += pic_Locais_MouseMove;
            // 
            // t_Page_Acordos
            // 
            t_Page_Acordos.Controls.Add(label9);
            t_Page_Acordos.Controls.Add(richTextBox2);
            t_Page_Acordos.Location = new Point(4, 24);
            t_Page_Acordos.Name = "t_Page_Acordos";
            t_Page_Acordos.Size = new Size(844, 268);
            t_Page_Acordos.TabIndex = 2;
            t_Page_Acordos.Text = "Linha do Tempo";
            t_Page_Acordos.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(34, 14);
            label9.Name = "label9";
            label9.Size = new Size(381, 19);
            label9.TabIndex = 1;
            label9.Text = "Linha do Tempo do Conflito Rússia-Ucrânia (2022-2024)";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(34, 44);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(785, 214);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // t_Page_Religião
            // 
            t_Page_Religião.Controls.Add(richTextBox1);
            t_Page_Religião.Controls.Add(label8);
            t_Page_Religião.Controls.Add(pictureBox1);
            t_Page_Religião.Controls.Add(linkLabel1);
            t_Page_Religião.Location = new Point(4, 24);
            t_Page_Religião.Name = "t_Page_Religião";
            t_Page_Religião.Size = new Size(844, 268);
            t_Page_Religião.TabIndex = 4;
            t_Page_Religião.Text = "Religião";
            t_Page_Religião.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(21, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(322, 162);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(21, 18);
            label8.Name = "label8";
            label8.Size = new Size(322, 21);
            label8.TabIndex = 2;
            label8.Text = "Religiosos Presos por se oporem a guerra";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TW_Presos;
            pictureBox1.Location = new Point(366, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(360, 230);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(434, 15);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://www.jw.org/pt/noticias/por-regiao/russia/testemunhas-jeova-na-prisao/";
            // 
            // lbl_contagem
            // 
            lbl_contagem.AutoSize = true;
            lbl_contagem.Location = new Point(468, 40);
            lbl_contagem.Name = "lbl_contagem";
            lbl_contagem.Size = new Size(177, 15);
            lbl_contagem.TabIndex = 11;
            lbl_contagem.Text = "Contagem de tempo em guerra:";
            lbl_contagem.Click += label9_Click;
            // 
            // lbl_cont_num
            // 
            lbl_cont_num.AutoSize = true;
            lbl_cont_num.Location = new Point(661, 41);
            lbl_cont_num.Name = "lbl_cont_num";
            lbl_cont_num.Size = new Size(10, 15);
            lbl_cont_num.TabIndex = 12;
            lbl_cont_num.Text = " ";
            lbl_cont_num.Click += lbl_cont_num_Click;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(893, 548);
            Controls.Add(lbl_cont_num);
            Controls.Add(lbl_contagem);
            Controls.Add(tabControl_Menu);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frm_menu";
            Text = "Menu";
            Load += frm_menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl_Menu.ResumeLayout(false);
            t_Page_Locais.ResumeLayout(false);
            t_Page_Locais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Locais).EndInit();
            t_Page_Acordos.ResumeLayout(false);
            t_Page_Acordos.PerformLayout();
            t_Page_Religião.ResumeLayout(false);
            t_Page_Religião.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pic_Locais_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem estatísticaToolStripMenuItem;
        private Label lblNome;
        private PictureBox picFoto;
        private Label lblEmail;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label lblPais;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label lblSexo;
        private Label lblOrg;
        private Label lblNasc;
        private Label lblTelefone;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer tmr_Menu;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripProgressBar toolStripProgressBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer tmr_war;
        private TabControl tabControl_Menu;
        private TabPage t_page_Estatistica;
        private TabPage t_Page_Locais;
        private TabPage t_Page_Acordos;
        private TabPage t_Page_Religião;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private LinkLabel link_lbl_Local;
        private PictureBox pic_Locais;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Label label8;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private RichTextBox richTextBox1;
        private Label lbl_contagem;
        private Label lbl_cont_num;
        private RichTextBox richTextBox2;
        private Label label9;
    }
}