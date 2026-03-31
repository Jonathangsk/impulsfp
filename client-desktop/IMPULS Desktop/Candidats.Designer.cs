namespace IMPULS_Desktop
{
    partial class Candidats
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarCandidat = new System.Windows.Forms.Button();
            this.btnTriarCandidat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEliminarCandidat
            // 
            this.btnEliminarCandidat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarCandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCandidat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminarCandidat.Location = new System.Drawing.Point(59, 461);
            this.btnEliminarCandidat.Name = "btnEliminarCandidat";
            this.btnEliminarCandidat.Size = new System.Drawing.Size(247, 47);
            this.btnEliminarCandidat.TabIndex = 1;
            this.btnEliminarCandidat.Text = "Eliminar Candidat";
            this.btnEliminarCandidat.UseVisualStyleBackColor = false;
            this.btnEliminarCandidat.Click += new System.EventHandler(this.btnEliminarCandidat_Click);
            // 
            // btnTriarCandidat
            // 
            this.btnTriarCandidat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTriarCandidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriarCandidat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTriarCandidat.Location = new System.Drawing.Point(331, 461);
            this.btnTriarCandidat.Name = "btnTriarCandidat";
            this.btnTriarCandidat.Size = new System.Drawing.Size(215, 47);
            this.btnTriarCandidat.TabIndex = 2;
            this.btnTriarCandidat.Text = "Triar Candidat";
            this.btnTriarCandidat.UseVisualStyleBackColor = false;
            this.btnTriarCandidat.Click += new System.EventHandler(this.btnTriarCandidat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(573, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tancar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Candidats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTriarCandidat);
            this.Controls.Add(this.btnEliminarCandidat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Candidats";
            this.Text = "Candidats";
            this.Load += new System.EventHandler(this.Candidats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarCandidat;
        private System.Windows.Forms.Button btnTriarCandidat;
        private System.Windows.Forms.Button button1;
    }
}