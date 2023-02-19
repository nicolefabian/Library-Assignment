namespace DataStructureProject
{
    partial class displayNetworkingBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.networkingDataGrid = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.networkingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // networkingDataGrid
            // 
            this.networkingDataGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.networkingDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(165)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.networkingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.networkingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.networkingDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.networkingDataGrid.GridColor = System.Drawing.Color.DimGray;
            this.networkingDataGrid.Location = new System.Drawing.Point(95, 120);
            this.networkingDataGrid.Name = "networkingDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.networkingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.networkingDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(107)))), ((int)(((byte)(79)))));
            this.networkingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.networkingDataGrid.RowTemplate.Height = 33;
            this.networkingDataGrid.Size = new System.Drawing.Size(935, 465);
            this.networkingDataGrid.TabIndex = 12;
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
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show Books";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.label1.Location = new System.Drawing.Point(423, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Networking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayNetworkingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 713);
            this.Controls.Add(this.networkingDataGrid);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "displayNetworkingBooks";
            this.Text = "displayNetworkingBooks";
            ((System.ComponentModel.ISupportInitialize)(this.networkingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView networkingDataGrid;
        private Button showButton;
        private Label label1;
    }
}