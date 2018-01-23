namespace Formulario.Consultas
{
    partial class cPersonas
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
            this.PersonasdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonasdataGridView
            // 
            this.PersonasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasdataGridView.Location = new System.Drawing.Point(17, 67);
            this.PersonasdataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PersonasdataGridView.Name = "PersonasdataGridView";
            this.PersonasdataGridView.RowTemplate.Height = 24;
            this.PersonasdataGridView.Size = new System.Drawing.Size(396, 206);
            this.PersonasdataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(327, 8);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(86, 54);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Nombres",
            "Monto",
            "Balance",
            "Observaciones"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(17, 43);
            this.FiltrarcomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarcomboBox.TabIndex = 18;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(112, 43);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(211, 20);
            this.CriteriotextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Campo a Filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Criterio de busqueda";
            // 
            // cPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PersonasdataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "cPersonas";
            this.Text = "Consulta de Personas";
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonasdataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}