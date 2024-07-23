namespace Cliente
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            splitContainer3 = new SplitContainer();
            button5 = new Button();
            splitContainer4 = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            txtJugador = new TextBox();
            btnJugar = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblRespuesta = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.FixedSingle;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(4, 3, 4, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(button5);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(664, 428);
            splitContainer3.SplitterDistance = 55;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 255);
            button5.Dock = DockStyle.Fill;
            button5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(662, 53);
            button5.TabIndex = 1;
            button5.Text = "Quién descubrió la gravedad?";
            button5.UseVisualStyleBackColor = false;
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = BorderStyle.FixedSingle;
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.FixedPanel = FixedPanel.Panel2;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(4, 3, 4, 3);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(lblRespuesta);
            splitContainer4.Panel1.Controls.Add(label2);
            splitContainer4.Panel1.Controls.Add(label1);
            splitContainer4.Panel1.Controls.Add(txtJugador);
            splitContainer4.Panel1.Controls.Add(btnJugar);
            splitContainer4.Panel1.Controls.Add(textBox1);
            splitContainer4.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer4.Size = new Size(664, 368);
            splitContainer4.SplitterDistance = 262;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(492, 131);
            label2.Name = "label2";
            label2.Size = new Size(122, 19);
            label2.TabIndex = 5;
            label2.Text = "Nombre jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(492, 80);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 4;
            label1.Text = "Partida";
            // 
            // txtJugador
            // 
            txtJugador.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJugador.Location = new Point(492, 153);
            txtJugador.Margin = new Padding(4, 3, 4, 3);
            txtJugador.Name = "txtJugador";
            txtJugador.Size = new Size(155, 26);
            txtJugador.TabIndex = 3;
            txtJugador.TextAlign = HorizontalAlignment.Right;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.FromArgb(255, 192, 192);
            btnJugar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.Location = new Point(492, 185);
            btnJugar.Margin = new Padding(4, 3, 4, 3);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(88, 32);
            btnJugar.TabIndex = 2;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(492, 102);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 26);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 36);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(662, 99);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 0);
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(335, 52);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(323, 44);
            button4.TabIndex = 3;
            button4.Text = "Thomas Edison";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(4, 52);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(323, 44);
            button3.TabIndex = 2;
            button3.Text = "Isaac Newton";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(335, 3);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(323, 43);
            button2.TabIndex = 1;
            button2.Text = "Nicola Tesla";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(4, 3);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(323, 43);
            button1.TabIndex = 0;
            button1.Text = "Benjamin Franklin";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRespuesta.ForeColor = Color.Red;
            lblRespuesta.Location = new Point(492, 220);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(0, 19);
            lblRespuesta.TabIndex = 6;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 428);
            Controls.Add(splitContainer3);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormCliente";
            ShowIcon = false;
            Text = "Jugador";
            FormClosing += FormCliente_FormClosing;
            Load += FormCliente_Load;
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.TextBox textBox1;
        private TextBox txtJugador;
        private Label label2;
        private Label label1;
        private Label lblRespuesta;
    }
}