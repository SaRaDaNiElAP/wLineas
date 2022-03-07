
namespace wLíneas
{
    partial class Form1
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
            this.txtxinicio = new System.Windows.Forms.TextBox();
            this.txtyinicio = new System.Windows.Forms.TextBox();
            this.txtxfin = new System.Windows.Forms.TextBox();
            this.txtyfin = new System.Windows.Forms.TextBox();
            this.btndibujar = new System.Windows.Forms.Button();
            this.txtnumlineas = new System.Windows.Forms.TextBox();
            this.lblxinicio = new System.Windows.Forms.Label();
            this.lblyinicio = new System.Windows.Forms.Label();
            this.lblyfin = new System.Windows.Forms.Label();
            this.lblxfin = new System.Windows.Forms.Label();
            this.lblnumlineas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtxinicio
            // 
            this.txtxinicio.Location = new System.Drawing.Point(99, 72);
            this.txtxinicio.Name = "txtxinicio";
            this.txtxinicio.Size = new System.Drawing.Size(100, 20);
            this.txtxinicio.TabIndex = 0;
            // 
            // txtyinicio
            // 
            this.txtyinicio.Location = new System.Drawing.Point(386, 72);
            this.txtyinicio.Name = "txtyinicio";
            this.txtyinicio.Size = new System.Drawing.Size(100, 20);
            this.txtyinicio.TabIndex = 1;
            // 
            // txtxfin
            // 
            this.txtxfin.Location = new System.Drawing.Point(99, 127);
            this.txtxfin.Name = "txtxfin";
            this.txtxfin.Size = new System.Drawing.Size(100, 20);
            this.txtxfin.TabIndex = 2;
            // 
            // txtyfin
            // 
            this.txtyfin.Location = new System.Drawing.Point(386, 127);
            this.txtyfin.Name = "txtyfin";
            this.txtyfin.Size = new System.Drawing.Size(100, 20);
            this.txtyfin.TabIndex = 3;
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(255, 190);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(75, 48);
            this.btndibujar.TabIndex = 4;
            this.btndibujar.Text = "Dibujar Línea";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // txtnumlineas
            // 
            this.txtnumlineas.Location = new System.Drawing.Point(386, 273);
            this.txtnumlineas.Name = "txtnumlineas";
            this.txtnumlineas.Size = new System.Drawing.Size(100, 20);
            this.txtnumlineas.TabIndex = 5;
            // 
            // lblxinicio
            // 
            this.lblxinicio.AutoSize = true;
            this.lblxinicio.Location = new System.Drawing.Point(54, 78);
            this.lblxinicio.Name = "lblxinicio";
            this.lblxinicio.Size = new System.Drawing.Size(43, 13);
            this.lblxinicio.TabIndex = 6;
            this.lblxinicio.Text = "X inicial";
            // 
            // lblyinicio
            // 
            this.lblyinicio.AutoSize = true;
            this.lblyinicio.Location = new System.Drawing.Point(339, 72);
            this.lblyinicio.Name = "lblyinicio";
            this.lblyinicio.Size = new System.Drawing.Size(43, 13);
            this.lblyinicio.TabIndex = 7;
            this.lblyinicio.Text = "Y inicial";
            // 
            // lblyfin
            // 
            this.lblyfin.AutoSize = true;
            this.lblyfin.Location = new System.Drawing.Point(342, 133);
            this.lblyfin.Name = "lblyfin";
            this.lblyfin.Size = new System.Drawing.Size(36, 13);
            this.lblyfin.TabIndex = 8;
            this.lblyfin.Text = "Y final";
            // 
            // lblxfin
            // 
            this.lblxfin.AutoSize = true;
            this.lblxfin.Location = new System.Drawing.Point(57, 133);
            this.lblxfin.Name = "lblxfin";
            this.lblxfin.Size = new System.Drawing.Size(36, 13);
            this.lblxfin.TabIndex = 9;
            this.lblxfin.Text = "X final";
            // 
            // lblnumlineas
            // 
            this.lblnumlineas.AutoSize = true;
            this.lblnumlineas.Location = new System.Drawing.Point(397, 257);
            this.lblnumlineas.Name = "lblnumlineas";
            this.lblnumlineas.Size = new System.Drawing.Size(89, 13);
            this.lblnumlineas.TabIndex = 10;
            this.lblnumlineas.Text = "Número de lineas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnumlineas);
            this.Controls.Add(this.lblxfin);
            this.Controls.Add(this.lblyfin);
            this.Controls.Add(this.lblyinicio);
            this.Controls.Add(this.lblxinicio);
            this.Controls.Add(this.txtnumlineas);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.txtyfin);
            this.Controls.Add(this.txtxfin);
            this.Controls.Add(this.txtyinicio);
            this.Controls.Add(this.txtxinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtxinicio;
        private System.Windows.Forms.TextBox txtyinicio;
        private System.Windows.Forms.TextBox txtxfin;
        private System.Windows.Forms.TextBox txtyfin;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.TextBox txtnumlineas;
        private System.Windows.Forms.Label lblxinicio;
        private System.Windows.Forms.Label lblyinicio;
        private System.Windows.Forms.Label lblyfin;
        private System.Windows.Forms.Label lblxfin;
        private System.Windows.Forms.Label lblnumlineas;
    }
}

