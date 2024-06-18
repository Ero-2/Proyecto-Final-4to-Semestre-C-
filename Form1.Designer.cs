namespace PROYECTO_RIOJAS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.SaveJsonButton = new System.Windows.Forms.Button();
            this.LoadJsonButton = new System.Windows.Forms.Button();
            this.SaveXmlButton = new System.Windows.Forms.Button();
            this.LoadXmlButton = new System.Windows.Forms.Button();
            this.SaveCsvButton = new System.Windows.Forms.Button();
            this.LoadCsvButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(486, 25);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataButton.TabIndex = 1;
            this.LoadDataButton.Text = "CargarData";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // SaveJsonButton
            // 
            this.SaveJsonButton.Location = new System.Drawing.Point(650, 25);
            this.SaveJsonButton.Name = "SaveJsonButton";
            this.SaveJsonButton.Size = new System.Drawing.Size(75, 23);
            this.SaveJsonButton.TabIndex = 2;
            this.SaveJsonButton.Text = "JSON";
            this.SaveJsonButton.UseVisualStyleBackColor = true;
            this.SaveJsonButton.Click += new System.EventHandler(this.SaveJsonButton_Click);
            // 
            // LoadJsonButton
            // 
            this.LoadJsonButton.Location = new System.Drawing.Point(616, 66);
            this.LoadJsonButton.Name = "LoadJsonButton";
            this.LoadJsonButton.Size = new System.Drawing.Size(132, 23);
            this.LoadJsonButton.TabIndex = 3;
            this.LoadJsonButton.Text = "CARGAR JSON";
            this.LoadJsonButton.UseVisualStyleBackColor = true;
            this.LoadJsonButton.Click += new System.EventHandler(this.LoadJsonButton_Click);
            // 
            // SaveXmlButton
            // 
            this.SaveXmlButton.Location = new System.Drawing.Point(650, 135);
            this.SaveXmlButton.Name = "SaveXmlButton";
            this.SaveXmlButton.Size = new System.Drawing.Size(75, 23);
            this.SaveXmlButton.TabIndex = 4;
            this.SaveXmlButton.Text = "XML";
            this.SaveXmlButton.UseVisualStyleBackColor = true;
            this.SaveXmlButton.Click += new System.EventHandler(this.SaveXmlButton_Click);
            // 
            // LoadXmlButton
            // 
            this.LoadXmlButton.Location = new System.Drawing.Point(633, 176);
            this.LoadXmlButton.Name = "LoadXmlButton";
            this.LoadXmlButton.Size = new System.Drawing.Size(115, 23);
            this.LoadXmlButton.TabIndex = 5;
            this.LoadXmlButton.Text = "CARGAR XML";
            this.LoadXmlButton.UseVisualStyleBackColor = true;
            this.LoadXmlButton.Click += new System.EventHandler(this.LoadXmlButton_Click);
            // 
            // SaveCsvButton
            // 
            this.SaveCsvButton.Location = new System.Drawing.Point(650, 232);
            this.SaveCsvButton.Name = "SaveCsvButton";
            this.SaveCsvButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCsvButton.TabIndex = 6;
            this.SaveCsvButton.Text = "CSV";
            this.SaveCsvButton.UseVisualStyleBackColor = true;
            this.SaveCsvButton.Click += new System.EventHandler(this.SaveCsvButton_Click);
            // 
            // LoadCsvButton
            // 
            this.LoadCsvButton.Location = new System.Drawing.Point(626, 281);
            this.LoadCsvButton.Name = "LoadCsvButton";
            this.LoadCsvButton.Size = new System.Drawing.Size(122, 23);
            this.LoadCsvButton.TabIndex = 7;
            this.LoadCsvButton.Text = "CARGAR CSV";
            this.LoadCsvButton.UseVisualStyleBackColor = true;
            this.LoadCsvButton.Click += new System.EventHandler(this.LoadCsvButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadCsvButton);
            this.Controls.Add(this.SaveCsvButton);
            this.Controls.Add(this.LoadXmlButton);
            this.Controls.Add(this.SaveXmlButton);
            this.Controls.Add(this.LoadJsonButton);
            this.Controls.Add(this.SaveJsonButton);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button SaveJsonButton;
        private System.Windows.Forms.Button LoadJsonButton;
        private System.Windows.Forms.Button SaveXmlButton;
        private System.Windows.Forms.Button LoadXmlButton;
        private System.Windows.Forms.Button SaveCsvButton;
        private System.Windows.Forms.Button LoadCsvButton;
    }
}

