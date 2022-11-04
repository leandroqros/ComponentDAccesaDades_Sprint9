
namespace ComponentDAccesaDades_Sprint9
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.lblPrim = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.bntNew = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(57, 78);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(223, 20);
            this.txtCode.TabIndex = 0;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(297, 78);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(223, 20);
            this.txtEspecie.TabIndex = 1;
            // 
            // dtgMain
            // 
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Location = new System.Drawing.Point(12, 122);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.Size = new System.Drawing.Size(776, 316);
            this.dtgMain.TabIndex = 2;
            // 
            // lblPrim
            // 
            this.lblPrim.AutoSize = true;
            this.lblPrim.Location = new System.Drawing.Point(63, 54);
            this.lblPrim.Name = "lblPrim";
            this.lblPrim.Size = new System.Drawing.Size(40, 13);
            this.lblPrim.TabIndex = 3;
            this.lblPrim.Text = "Codigo";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(303, 54);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(45, 13);
            this.lblSec.TabIndex = 4;
            this.lblSec.Text = "Especie";
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(618, 34);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(124, 38);
            this.bntNew.TabIndex = 5;
            this.bntNew.Text = "Nuevo";
            this.bntNew.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(618, 78);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(124, 38);
            this.bntAdd.TabIndex = 7;
            this.bntAdd.Text = "Añadir";
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntNew);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblPrim);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.Label lblPrim;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.Button bntAdd;
    }
}

