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
            this.components = new System.ComponentModel.Container();
            this.Import = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Generate_Excel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(311, 13);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(103, 36);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Generate_Excel
            // 
            this.Generate_Excel.Location = new System.Drawing.Point(601, 13);
            this.Generate_Excel.Name = "Generate_Excel";
            this.Generate_Excel.Size = new System.Drawing.Size(103, 36);
            this.Generate_Excel.TabIndex = 3;
            this.Generate_Excel.Text = "Generate Excel";
            this.Generate_Excel.UseVisualStyleBackColor = true;
            this.Generate_Excel.Click += new System.EventHandler(this.Generate_Excel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 486);
            this.dataGridView1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 567);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Generate_Excel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Import);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Generate_Excel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}

