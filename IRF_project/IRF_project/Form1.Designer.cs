namespace IRF_project
{
    partial class Form1
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
            this.Import = new System.Windows.Forms.Button();
            this.Weight = new System.Windows.Forms.Button();
            this.Height = new System.Windows.Forms.Button();
            this.Generate_Excel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(13, 13);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(103, 36);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(194, 13);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(103, 36);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "Weight";
            this.Weight.UseVisualStyleBackColor = true;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(391, 13);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(103, 36);
            this.Height.TabIndex = 2;
            this.Height.Text = "Height";
            this.Height.UseVisualStyleBackColor = true;
            // 
            // Generate_Excel
            // 
            this.Generate_Excel.Location = new System.Drawing.Point(601, 13);
            this.Generate_Excel.Name = "Generate_Excel";
            this.Generate_Excel.Size = new System.Drawing.Size(103, 36);
            this.Generate_Excel.TabIndex = 3;
            this.Generate_Excel.Text = "Generate Excel";
            this.Generate_Excel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 486);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 567);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Generate_Excel);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Import);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Weight;
        private System.Windows.Forms.Button Height;
        private System.Windows.Forms.Button Generate_Excel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

