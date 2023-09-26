namespace CalabozosYDragones_lab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TimerDado = new System.Windows.Forms.Timer(this.components);
            this.pBdado = new System.Windows.Forms.PictureBox();
            this.dado = new System.Windows.Forms.Label();
            this.dadoR = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragoncito = new System.Windows.Forms.Timer(this.components);
            this.dragoncito2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.DragonVerde2 = new System.Windows.Forms.Panel();
            this.DragonVerde1 = new System.Windows.Forms.Panel();
            this.DragonAzul2 = new System.Windows.Forms.Panel();
            this.DragonAzul1 = new System.Windows.Forms.Panel();
            this.DragonAmarillo2 = new System.Windows.Forms.Panel();
            this.DragonAmarillo1 = new System.Windows.Forms.Panel();
            this.CaballeroAmarillo = new System.Windows.Forms.Panel();
            this.CaballeroVerde = new System.Windows.Forms.Panel();
            this.DragonRosa2 = new System.Windows.Forms.Panel();
            this.DragonRosa1 = new System.Windows.Forms.Panel();
            this.Calabozo1 = new System.Windows.Forms.Panel();
            this.Calabozo3 = new System.Windows.Forms.Panel();
            this.Calabozo2 = new System.Windows.Forms.Panel();
            this.CaballeroAzul = new System.Windows.Forms.Panel();
            this.CaballeroRosa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TimerDado
            // 
            this.TimerDado.Interval = 1000;
            this.TimerDado.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pBdado
            // 
            resources.ApplyResources(this.pBdado, "pBdado");
            this.pBdado.Name = "pBdado";
            this.pBdado.TabStop = false;
            // 
            // dado
            // 
            resources.ApplyResources(this.dado, "dado");
            this.dado.Name = "dado";
            this.dado.VisibleChanged += new System.EventHandler(this.dadoA_VisibleChanged);
            // 
            // dadoR
            // 
            resources.ApplyResources(this.dadoR, "dadoR");
            this.dadoR.Name = "dadoR";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dragoncito
            // 
            this.dragoncito.Tick += new System.EventHandler(this.dragoncito_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 1200;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DragonVerde2
            // 
            resources.ApplyResources(this.DragonVerde2, "DragonVerde2");
            this.DragonVerde2.Name = "DragonVerde2";
            // 
            // DragonVerde1
            // 
            resources.ApplyResources(this.DragonVerde1, "DragonVerde1");
            this.DragonVerde1.Name = "DragonVerde1";
            // 
            // DragonAzul2
            // 
            resources.ApplyResources(this.DragonAzul2, "DragonAzul2");
            this.DragonAzul2.Name = "DragonAzul2";
            // 
            // DragonAzul1
            // 
            resources.ApplyResources(this.DragonAzul1, "DragonAzul1");
            this.DragonAzul1.Name = "DragonAzul1";
            // 
            // DragonAmarillo2
            // 
            resources.ApplyResources(this.DragonAmarillo2, "DragonAmarillo2");
            this.DragonAmarillo2.Name = "DragonAmarillo2";
            this.DragonAmarillo2.Paint += new System.Windows.Forms.PaintEventHandler(this.DragonAmarillo2_Paint);
            // 
            // DragonAmarillo1
            // 
            resources.ApplyResources(this.DragonAmarillo1, "DragonAmarillo1");
            this.DragonAmarillo1.Name = "DragonAmarillo1";
            // 
            // CaballeroAmarillo
            // 
            resources.ApplyResources(this.CaballeroAmarillo, "CaballeroAmarillo");
            this.CaballeroAmarillo.Name = "CaballeroAmarillo";
            // 
            // CaballeroVerde
            // 
            resources.ApplyResources(this.CaballeroVerde, "CaballeroVerde");
            this.CaballeroVerde.Name = "CaballeroVerde";
            // 
            // DragonRosa2
            // 
            resources.ApplyResources(this.DragonRosa2, "DragonRosa2");
            this.DragonRosa2.Name = "DragonRosa2";
            // 
            // DragonRosa1
            // 
            resources.ApplyResources(this.DragonRosa1, "DragonRosa1");
            this.DragonRosa1.Name = "DragonRosa1";
            // 
            // Calabozo1
            // 
            resources.ApplyResources(this.Calabozo1, "Calabozo1");
            this.Calabozo1.Name = "Calabozo1";
            // 
            // Calabozo3
            // 
            resources.ApplyResources(this.Calabozo3, "Calabozo3");
            this.Calabozo3.Name = "Calabozo3";
            // 
            // Calabozo2
            // 
            resources.ApplyResources(this.Calabozo2, "Calabozo2");
            this.Calabozo2.Name = "Calabozo2";
            // 
            // CaballeroAzul
            // 
            resources.ApplyResources(this.CaballeroAzul, "CaballeroAzul");
            this.CaballeroAzul.Name = "CaballeroAzul";
            // 
            // CaballeroRosa
            // 
            resources.ApplyResources(this.CaballeroRosa, "CaballeroRosa");
            this.CaballeroRosa.Name = "CaballeroRosa";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.DragonVerde2);
            this.Controls.Add(this.DragonVerde1);
            this.Controls.Add(this.DragonAzul2);
            this.Controls.Add(this.DragonAzul1);
            this.Controls.Add(this.DragonAmarillo2);
            this.Controls.Add(this.DragonAmarillo1);
            this.Controls.Add(this.CaballeroAmarillo);
            this.Controls.Add(this.CaballeroVerde);
            this.Controls.Add(this.DragonRosa2);
            this.Controls.Add(this.DragonRosa1);
            this.Controls.Add(this.Calabozo1);
            this.Controls.Add(this.Calabozo3);
            this.Controls.Add(this.Calabozo2);
            this.Controls.Add(this.CaballeroAzul);
            this.Controls.Add(this.CaballeroRosa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBdado);
            this.Controls.Add(this.dadoR);
            this.Controls.Add(this.dado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBdado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer TimerDado;
        private System.Windows.Forms.PictureBox pBdado;
        private System.Windows.Forms.Label dado;
        private System.Windows.Forms.Label dadoR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer dragoncito;
        private System.Windows.Forms.Timer dragoncito2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel DragonVerde2;
        private System.Windows.Forms.Panel DragonVerde1;
        private System.Windows.Forms.Panel DragonAzul2;
        private System.Windows.Forms.Panel DragonAzul1;
        private System.Windows.Forms.Panel DragonAmarillo2;
        private System.Windows.Forms.Panel DragonAmarillo1;
        private System.Windows.Forms.Panel CaballeroAmarillo;
        private System.Windows.Forms.Panel CaballeroVerde;
        private System.Windows.Forms.Panel DragonRosa2;
        private System.Windows.Forms.Panel DragonRosa1;
        private System.Windows.Forms.Panel Calabozo1;
        private System.Windows.Forms.Panel Calabozo3;
        private System.Windows.Forms.Panel Calabozo2;
        private System.Windows.Forms.Panel CaballeroAzul;
        private System.Windows.Forms.Panel CaballeroRosa;
    }
}

