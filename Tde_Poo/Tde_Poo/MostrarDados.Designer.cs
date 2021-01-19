namespace Tde_Poo
{
    partial class MostrarDados
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
            this.GridPesquisar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPesquisar
            // 
            this.GridPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPesquisar.Location = new System.Drawing.Point(1, 0);
            this.GridPesquisar.Name = "GridPesquisar";
            this.GridPesquisar.Size = new System.Drawing.Size(923, 109);
            this.GridPesquisar.TabIndex = 0;
            // 
            // MostrarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 109);
            this.Controls.Add(this.GridPesquisar);
            this.Name = "MostrarDados";
            this.Text = "MostrarDados";
            this.Load += new System.EventHandler(this.MostrarDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridPesquisar;
    }
}