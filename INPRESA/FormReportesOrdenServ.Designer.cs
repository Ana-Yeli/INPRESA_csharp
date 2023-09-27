
namespace INPRESA
{
    partial class FormReportesOrdenServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportesOrdenServ));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.OrdenServicioXidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipal = new INPRESA.DataSetPrincipal();
            this.cmbidOrdenServ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdenServicioXidTableAdapter = new INPRESA.DataSetPrincipalTableAdapters.OrdenServicioXidTableAdapter();
            this.btnFormEnviarEmail = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenServicioXidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenServicioXidBindingSource
            // 
            this.OrdenServicioXidBindingSource.DataMember = "OrdenServicioXid";
            this.OrdenServicioXidBindingSource.DataSource = this.DataSetPrincipal;
            // 
            // DataSetPrincipal
            // 
            this.DataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.DataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbidOrdenServ
            // 
            this.cmbidOrdenServ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbidOrdenServ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbidOrdenServ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbidOrdenServ.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidOrdenServ.FormattingEnabled = true;
            this.cmbidOrdenServ.Location = new System.Drawing.Point(204, 7);
            this.cmbidOrdenServ.Margin = new System.Windows.Forms.Padding(2);
            this.cmbidOrdenServ.Name = "cmbidOrdenServ";
            this.cmbidOrdenServ.Size = new System.Drawing.Size(144, 26);
            this.cmbidOrdenServ.TabIndex = 12;
            this.cmbidOrdenServ.Text = "Seleccionar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "id Orden de Servicio";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AllowToggling = false;
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerar.AnimationSpeed = 200;
            this.btnGenerar.AutoGenerateColors = false;
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.BackgroundImage")));
            this.btnGenerar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGenerar.ButtonText = "Generar";
            this.btnGenerar.ButtonTextMarginLeft = 0;
            this.btnGenerar.ColorContrastOnClick = 45;
            this.btnGenerar.ColorContrastOnHover = 45;
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGenerar.CustomizableEdges = borderEdges1;
            this.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnGenerar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.IconMarginLeft = 11;
            this.btnGenerar.IconPadding = 10;
            this.btnGenerar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.IdleBorderRadius = 3;
            this.btnGenerar.IdleBorderThickness = 1;
            this.btnGenerar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.IdleIconLeftImage = null;
            this.btnGenerar.IdleIconRightImage = null;
            this.btnGenerar.IndicateFocus = false;
            this.btnGenerar.Location = new System.Drawing.Point(362, 1);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnGenerar.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnGenerar.OnPressedState = stateProperties2;
            this.btnGenerar.Size = new System.Drawing.Size(93, 32);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerar.TextMarginLeft = 0;
            this.btnGenerar.UseDefaultRadiusAndThickness = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenServicioXidBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "INPRESA.ReporteOrdenServicio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 54);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(882, 720);
            this.reportViewer1.TabIndex = 17;
            // 
            // OrdenServicioXidTableAdapter
            // 
            this.OrdenServicioXidTableAdapter.ClearBeforeFill = true;
            // 
            // btnFormEnviarEmail
            // 
            this.btnFormEnviarEmail.AllowToggling = false;
            this.btnFormEnviarEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFormEnviarEmail.AnimationSpeed = 200;
            this.btnFormEnviarEmail.AutoGenerateColors = false;
            this.btnFormEnviarEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnFormEnviarEmail.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFormEnviarEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormEnviarEmail.BackgroundImage")));
            this.btnFormEnviarEmail.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFormEnviarEmail.ButtonText = "Enviar por Email";
            this.btnFormEnviarEmail.ButtonTextMarginLeft = 0;
            this.btnFormEnviarEmail.ColorContrastOnClick = 45;
            this.btnFormEnviarEmail.ColorContrastOnHover = 45;
            this.btnFormEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFormEnviarEmail.CustomizableEdges = borderEdges2;
            this.btnFormEnviarEmail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFormEnviarEmail.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnFormEnviarEmail.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFormEnviarEmail.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFormEnviarEmail.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFormEnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnFormEnviarEmail.ForeColor = System.Drawing.Color.Black;
            this.btnFormEnviarEmail.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormEnviarEmail.IconMarginLeft = 11;
            this.btnFormEnviarEmail.IconPadding = 10;
            this.btnFormEnviarEmail.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormEnviarEmail.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFormEnviarEmail.IdleBorderRadius = 3;
            this.btnFormEnviarEmail.IdleBorderThickness = 1;
            this.btnFormEnviarEmail.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFormEnviarEmail.IdleIconLeftImage = null;
            this.btnFormEnviarEmail.IdleIconRightImage = null;
            this.btnFormEnviarEmail.IndicateFocus = false;
            this.btnFormEnviarEmail.Location = new System.Drawing.Point(697, 1);
            this.btnFormEnviarEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormEnviarEmail.Name = "btnFormEnviarEmail";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnFormEnviarEmail.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnFormEnviarEmail.OnPressedState = stateProperties4;
            this.btnFormEnviarEmail.Size = new System.Drawing.Size(176, 32);
            this.btnFormEnviarEmail.TabIndex = 18;
            this.btnFormEnviarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormEnviarEmail.TextMarginLeft = 0;
            this.btnFormEnviarEmail.UseDefaultRadiusAndThickness = true;
            this.btnFormEnviarEmail.Click += new System.EventHandler(this.btnFormEnviarEmail_Click);
            // 
            // FormReportesOrdenServ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.btnFormEnviarEmail);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cmbidOrdenServ);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReportesOrdenServ";
            this.Text = "Reportes Orden de Servicio";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenServicioXidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbidOrdenServ;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenServicioXidBindingSource;
        private DataSetPrincipal DataSetPrincipal;
        private DataSetPrincipalTableAdapters.OrdenServicioXidTableAdapter OrdenServicioXidTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFormEnviarEmail;
    }
}