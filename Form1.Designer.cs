namespace Pomodoro_Baur
{
    partial class Cuadro_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadro_Principal));
            this.BA_Alarma = new System.Windows.Forms.Button();
            this.B_Star = new System.Windows.Forms.Button();
            this.b_Pause = new System.Windows.Forms.Button();
            this.l_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_pista = new System.Windows.Forms.Label();
            this.l_status = new System.Windows.Forms.Label();
            this.t_Cronometro = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_borrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BA_Alarma
            // 
            this.BA_Alarma.Location = new System.Drawing.Point(6, 19);
            this.BA_Alarma.Name = "BA_Alarma";
            this.BA_Alarma.Size = new System.Drawing.Size(75, 23);
            this.BA_Alarma.TabIndex = 0;
            this.BA_Alarma.Text = "Abrir";
            this.BA_Alarma.UseVisualStyleBackColor = true;
            this.BA_Alarma.Click += new System.EventHandler(this.BA_Alarma_Click);
            // 
            // B_Star
            // 
            this.B_Star.Enabled = false;
            this.B_Star.Location = new System.Drawing.Point(6, 19);
            this.B_Star.Name = "B_Star";
            this.B_Star.Size = new System.Drawing.Size(85, 23);
            this.B_Star.TabIndex = 1;
            this.B_Star.Text = "Iniciar";
            this.B_Star.UseVisualStyleBackColor = true;
            this.B_Star.Click += new System.EventHandler(this.B_Star_Click);
            // 
            // b_Pause
            // 
            this.b_Pause.Enabled = false;
            this.b_Pause.Location = new System.Drawing.Point(6, 43);
            this.b_Pause.Name = "b_Pause";
            this.b_Pause.Size = new System.Drawing.Size(36, 23);
            this.b_Pause.TabIndex = 2;
            this.b_Pause.Text = "II";
            this.b_Pause.UseVisualStyleBackColor = true;
            this.b_Pause.Click += new System.EventHandler(this.B_Pause_Click);
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_time.Location = new System.Drawing.Point(104, 26);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(130, 47);
            this.l_time.TabIndex = 5;
            this.l_time.Text = "25:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_pista);
            this.groupBox1.Controls.Add(this.BA_Alarma);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarma";
            // 
            // l_pista
            // 
            this.l_pista.AutoSize = true;
            this.l_pista.Location = new System.Drawing.Point(87, 24);
            this.l_pista.Name = "l_pista";
            this.l_pista.Size = new System.Drawing.Size(142, 13);
            this.l_pista.TabIndex = 5;
            this.l_pista.Text = "Selecciona una pista \".wav\"";
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(103, 18);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(60, 13);
            this.l_status.TabIndex = 5;
            this.l_status.Text = "Tiempo de ";
            this.l_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // t_Cronometro
            // 
            this.t_Cronometro.Interval = 1000;
            this.t_Cronometro.Tick += new System.EventHandler(this.T_Cronometro_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_borrar);
            this.groupBox2.Controls.Add(this.B_Star);
            this.groupBox2.Controls.Add(this.l_status);
            this.groupBox2.Controls.Add(this.l_time);
            this.groupBox2.Controls.Add(this.b_Pause);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contoles";
            // 
            // b_borrar
            // 
            this.b_borrar.Enabled = false;
            this.b_borrar.Location = new System.Drawing.Point(45, 43);
            this.b_borrar.Name = "b_borrar";
            this.b_borrar.Size = new System.Drawing.Size(46, 23);
            this.b_borrar.TabIndex = 3;
            this.b_borrar.Text = "Borrar";
            this.b_borrar.UseVisualStyleBackColor = true;
            this.b_borrar.Click += new System.EventHandler(this.B_borrar_Click);
            // 
            // Cuadro_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 150);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 189);
            this.Name = "Cuadro_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BA_Alarma;
        private System.Windows.Forms.Button B_Star;
        private System.Windows.Forms.Button b_Pause;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_pista;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Timer t_Cronometro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_borrar;
    }
}

