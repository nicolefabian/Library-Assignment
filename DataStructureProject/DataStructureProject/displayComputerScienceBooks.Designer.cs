namespace DataStructureProject
{
    partial class displayComputerScienceBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.computerScienceDataGrid = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerScienceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // computerScienceDataGrid
            // 
            this.computerScienceDataGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.computerScienceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(165)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.computerScienceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.computerScienceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.computerScienceDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.computerScienceDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.computerScienceDataGrid.Location = new System.Drawing.Point(95, 120);
            this.computerScienceDataGrid.Name = "computerScienceDataGrid";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.computerScienceDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.computerScienceDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            this.computerScienceDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.computerScienceDataGrid.RowTemplate.Height = 33;
            this.computerScienceDataGrid.Size = new System.Drawing.Size(935, 465);
            this.computerScienceDataGrid.TabIndex = 9;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(103)))), ((int)(((byte)(110)))));
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.Location = new System.Drawing.Point(463, 611);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(161, 63);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "Show Books";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(357, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computer Science";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayComputerScienceBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 713);
            this.Controls.Add(this.computerScienceDataGrid);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "displayComputerScienceBooks";
            this.Text = "displayComputerScienceBooks";
            ((System.ComponentModel.ISupportInitialize)(this.computerScienceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView computerScienceDataGrid;
        private Button showButton;
        private Label label1;
    }
}