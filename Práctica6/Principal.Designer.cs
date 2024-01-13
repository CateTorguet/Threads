namespace Práctica6
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mn_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_Detener = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.ProB = new System.Windows.Forms.ProgressBar();
            this.bt_Ocultar = new System.Windows.Forms.Button();
            this.bt_Iniciar = new System.Windows.Forms.Button();
            this.NumUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PicB = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_Archivo,
            this.Mn_Ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mn_Archivo
            // 
            this.Mn_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_Salir,
            this.mn_Detener});
            this.Mn_Archivo.Name = "Mn_Archivo";
            this.Mn_Archivo.Size = new System.Drawing.Size(60, 20);
            this.Mn_Archivo.Text = "Archivo";
            // 
            // mn_Salir
            // 
            this.mn_Salir.Image = global::Práctica6.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.mn_Salir.Name = "mn_Salir";
            this.mn_Salir.Size = new System.Drawing.Size(115, 22);
            this.mn_Salir.Text = "Salir";
            this.mn_Salir.Click += new System.EventHandler(this.mn_Salir_Click);
            // 
            // mn_Detener
            // 
            this.mn_Detener.Image = global::Práctica6.Properties.Resources._1486348534_music_pause_stop_control_play_80459;
            this.mn_Detener.Name = "mn_Detener";
            this.mn_Detener.Size = new System.Drawing.Size(115, 22);
            this.mn_Detener.Text = "Detener";
            this.mn_Detener.Click += new System.EventHandler(this.mn_Detener_Click);
            // 
            // Mn_Ayuda
            // 
            this.Mn_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_AcercaDe});
            this.Mn_Ayuda.Name = "Mn_Ayuda";
            this.Mn_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.Mn_Ayuda.Text = "Ayuda";
            // 
            // mn_AcercaDe
            // 
            this.mn_AcercaDe.Image = global::Práctica6.Properties.Resources.about_3697;
            this.mn_AcercaDe.Name = "mn_AcercaDe";
            this.mn_AcercaDe.Size = new System.Drawing.Size(136, 22);
            this.mn_AcercaDe.Text = "Acerca De...";
            // 
            // ProB
            // 
            this.ProB.Location = new System.Drawing.Point(12, 218);
            this.ProB.Name = "ProB";
            this.ProB.Size = new System.Drawing.Size(268, 27);
            this.ProB.Step = 1;
            this.ProB.TabIndex = 2;
            // 
            // bt_Ocultar
            // 
            this.bt_Ocultar.Location = new System.Drawing.Point(12, 260);
            this.bt_Ocultar.Name = "bt_Ocultar";
            this.bt_Ocultar.Size = new System.Drawing.Size(113, 23);
            this.bt_Ocultar.TabIndex = 3;
            this.bt_Ocultar.Text = "Ocultar Imagen";
            this.bt_Ocultar.UseVisualStyleBackColor = true;
            this.bt_Ocultar.Click += new System.EventHandler(this.bt_Ocultar_Click);
            // 
            // bt_Iniciar
            // 
            this.bt_Iniciar.Location = new System.Drawing.Point(167, 260);
            this.bt_Iniciar.Name = "bt_Iniciar";
            this.bt_Iniciar.Size = new System.Drawing.Size(113, 23);
            this.bt_Iniciar.TabIndex = 4;
            this.bt_Iniciar.Text = "Iniciar";
            this.bt_Iniciar.UseVisualStyleBackColor = true;
            this.bt_Iniciar.Click += new System.EventHandler(this.bt_Iniciar_Click);
            // 
            // NumUD
            // 
            this.NumUD.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUD.Location = new System.Drawing.Point(167, 303);
            this.NumUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumUD.Name = "NumUD";
            this.NumUD.Size = new System.Drawing.Size(113, 20);
            this.NumUD.TabIndex = 5;
            this.NumUD.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUD.ValueChanged += new System.EventHandler(this.NumUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Velocidad";
            // 
            // PicB
            // 
            this.PicB.Image = global::Práctica6.Properties.Resources.FireLink;
            this.PicB.Location = new System.Drawing.Point(12, 38);
            this.PicB.Name = "PicB";
            this.PicB.Size = new System.Drawing.Size(268, 174);
            this.PicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicB.TabIndex = 1;
            this.PicB.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUD);
            this.Controls.Add(this.bt_Iniciar);
            this.Controls.Add(this.bt_Ocultar);
            this.Controls.Add(this.ProB);
            this.Controls.Add(this.PicB);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Text = "Hilos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mn_Archivo;
        private System.Windows.Forms.ToolStripMenuItem Mn_Ayuda;
        private System.Windows.Forms.PictureBox PicB;
        private System.Windows.Forms.ProgressBar ProB;
        private System.Windows.Forms.Button bt_Ocultar;
        private System.Windows.Forms.Button bt_Iniciar;
        private System.Windows.Forms.NumericUpDown NumUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mn_Salir;
        private System.Windows.Forms.ToolStripMenuItem mn_AcercaDe;
        private System.Windows.Forms.ToolStripMenuItem mn_Detener;
    }
}

