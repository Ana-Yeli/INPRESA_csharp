
namespace INPRESA
{
    partial class FormCita
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
            this.lblidCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatepicFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dTPHora = new System.Windows.Forms.DateTimePicker();
            this.btnAltaCita = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblidCliente
            // 
            this.lblidCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCliente.ForeColor = System.Drawing.Color.White;
            this.lblidCliente.Location = new System.Drawing.Point(82, 48);
            this.lblidCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(30, 21);
            this.lblidCliente.TabIndex = 94;
            this.lblidCliente.Text = ".....";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(139, 46);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(242, 26);
            this.cmbCliente.TabIndex = 93;
            this.cmbCliente.Text = "Seleccionar";
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 92;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 96;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 97;
            this.label4.Text = "Motivo de Cita:";
            // 
            // DatepicFecha
            // 
            this.DatepicFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatepicFecha.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatepicFecha.BorderRadius = 0;
            this.DatepicFecha.ForeColor = System.Drawing.Color.Black;
            this.DatepicFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatepicFecha.FormatCustom = null;
            this.DatepicFecha.Location = new System.Drawing.Point(86, 105);
            this.DatepicFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatepicFecha.Name = "DatepicFecha";
            this.DatepicFecha.Size = new System.Drawing.Size(261, 28);
            this.DatepicFecha.TabIndex = 98;
            this.DatepicFecha.Value = new System.DateTime(2021, 4, 5, 20, 14, 31, 493);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMotivo.Location = new System.Drawing.Point(139, 233);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(330, 64);
            this.txtMotivo.TabIndex = 100;
            // 
            // dTPHora
            // 
            this.dTPHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dTPHora.CustomFormat = "";
            this.dTPHora.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPHora.Location = new System.Drawing.Point(86, 169);
            this.dTPHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTPHora.Name = "dTPHora";
            this.dTPHora.ShowUpDown = true;
            this.dTPHora.Size = new System.Drawing.Size(156, 31);
            this.dTPHora.TabIndex = 101;
            // 
            // btnAltaCita
            // 
            this.btnAltaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.btnAltaCita.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAltaCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAltaCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAltaCita.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCita.ForeColor = System.Drawing.Color.White;
            this.btnAltaCita.Location = new System.Drawing.Point(236, 359);
            this.btnAltaCita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAltaCita.Name = "btnAltaCita";
            this.btnAltaCita.Size = new System.Drawing.Size(144, 45);
            this.btnAltaCita.TabIndex = 102;
            this.btnAltaCita.Text = "Programar Cita";
            this.btnAltaCita.UseVisualStyleBackColor = false;
            this.btnAltaCita.Click += new System.EventHandler(this.btnAltaCita_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(405, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(476, 48);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 21);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = ".....";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 21);
            this.label6.TabIndex = 106;
            this.label6.Text = "vehiculosinpresa@gmail.com";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "De:";
            // 
            // FormCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(686, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAltaCita);
            this.Controls.Add(this.dTPHora);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.DatepicFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblidCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblidCliente;
        public System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker DatepicFecha;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dTPHora;
        private System.Windows.Forms.Button btnAltaCita;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}