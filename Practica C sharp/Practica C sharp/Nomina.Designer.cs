namespace Practica_C_sharp
{
    partial class Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomina));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSueldoto = new System.Windows.Forms.Label();
            this.lblSueldoex = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(190, 126);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(126, 18);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias trabajados";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(47, 108);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(101, 18);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Sueldo base";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(341, 108);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(105, 18);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas extras";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(50, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(396, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(193, 165);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(123, 20);
            this.txtDias.TabIndex = 7;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(334, 140);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(123, 20);
            this.txthoras.TabIndex = 8;
            this.txthoras.TextChanged += new System.EventHandler(this.txthoras_TextChanged);
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(50, 140);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(123, 20);
            this.txtSueldo.TabIndex = 10;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(288, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTicket.BackgroundImage")));
            this.btnTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.Location = new System.Drawing.Point(85, 276);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(152, 34);
            this.btnTicket.TabIndex = 13;
            this.btnTicket.Text = "Imprimir Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(193, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 34);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(334, 215);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // lblSueldoto
            // 
            this.lblSueldoto.AutoSize = true;
            this.lblSueldoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoto.Location = new System.Drawing.Point(341, 194);
            this.lblSueldoto.Name = "lblSueldoto";
            this.lblSueldoto.Size = new System.Drawing.Size(98, 18);
            this.lblSueldoto.TabIndex = 5;
            this.lblSueldoto.Text = "Sueldo total";
            // 
            // lblSueldoex
            // 
            this.lblSueldoex.AutoSize = true;
            this.lblSueldoex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoex.Location = new System.Drawing.Point(47, 194);
            this.lblSueldoex.Name = "lblSueldoex";
            this.lblSueldoex.Size = new System.Drawing.Size(102, 18);
            this.lblSueldoex.TabIndex = 4;
            this.lblSueldoex.Text = "Sueldo extra";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(50, 215);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(123, 20);
            this.txtExtra.TabIndex = 11;
            this.txtExtra.TextChanged += new System.EventHandler(this.txtExtra_TextChanged);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 344);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSueldoto);
            this.Controls.Add(this.lblSueldoex);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblNombre);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSueldoto;
        private System.Windows.Forms.Label lblSueldoex;
        private System.Windows.Forms.TextBox txtExtra;
    }
}