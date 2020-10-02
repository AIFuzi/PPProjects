namespace Matrix
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
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.DG_Matrix = new System.Windows.Forms.DataGridView();
            this.B_N1 = new System.Windows.Forms.Button();
            this.B_N2 = new System.Windows.Forms.Button();
            this.B_N3 = new System.Windows.Forms.Button();
            this.B_N4 = new System.Windows.Forms.Button();
            this.B_N5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Result
            // 
            this.TB_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Result.Location = new System.Drawing.Point(13, 13);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(399, 22);
            this.TB_Result.TabIndex = 0;
            // 
            // DG_Matrix
            // 
            this.DG_Matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Matrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DG_Matrix.Location = new System.Drawing.Point(13, 40);
            this.DG_Matrix.Name = "DG_Matrix";
            this.DG_Matrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DG_Matrix.Size = new System.Drawing.Size(399, 256);
            this.DG_Matrix.TabIndex = 1;
            // 
            // B_N1
            // 
            this.B_N1.Location = new System.Drawing.Point(13, 302);
            this.B_N1.Name = "B_N1";
            this.B_N1.Size = new System.Drawing.Size(75, 42);
            this.B_N1.TabIndex = 2;
            this.B_N1.Text = "Часть 1";
            this.B_N1.UseVisualStyleBackColor = true;
            this.B_N1.Click += new System.EventHandler(this.B_N1_Click);
            // 
            // B_N2
            // 
            this.B_N2.Location = new System.Drawing.Point(94, 302);
            this.B_N2.Name = "B_N2";
            this.B_N2.Size = new System.Drawing.Size(75, 42);
            this.B_N2.TabIndex = 3;
            this.B_N2.Text = "Часть 2";
            this.B_N2.UseVisualStyleBackColor = true;
            this.B_N2.Click += new System.EventHandler(this.B_N2_Click);
            // 
            // B_N3
            // 
            this.B_N3.Location = new System.Drawing.Point(175, 302);
            this.B_N3.Name = "B_N3";
            this.B_N3.Size = new System.Drawing.Size(75, 42);
            this.B_N3.TabIndex = 4;
            this.B_N3.Text = "Часть 3";
            this.B_N3.UseVisualStyleBackColor = true;
            this.B_N3.Click += new System.EventHandler(this.B_N3_Click);
            // 
            // B_N4
            // 
            this.B_N4.Location = new System.Drawing.Point(256, 302);
            this.B_N4.Name = "B_N4";
            this.B_N4.Size = new System.Drawing.Size(75, 42);
            this.B_N4.TabIndex = 5;
            this.B_N4.Text = "Часть 4";
            this.B_N4.UseVisualStyleBackColor = true;
            this.B_N4.Click += new System.EventHandler(this.B_N4_Click);
            // 
            // B_N5
            // 
            this.B_N5.Location = new System.Drawing.Point(337, 302);
            this.B_N5.Name = "B_N5";
            this.B_N5.Size = new System.Drawing.Size(75, 42);
            this.B_N5.TabIndex = 6;
            this.B_N5.Text = "Часть 5";
            this.B_N5.UseVisualStyleBackColor = true;
            this.B_N5.Click += new System.EventHandler(this.B_N5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 356);
            this.Controls.Add(this.B_N5);
            this.Controls.Add(this.B_N4);
            this.Controls.Add(this.B_N3);
            this.Controls.Add(this.B_N2);
            this.Controls.Add(this.B_N1);
            this.Controls.Add(this.DG_Matrix);
            this.Controls.Add(this.TB_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.DataGridView DG_Matrix;
        private System.Windows.Forms.Button B_N1;
        private System.Windows.Forms.Button B_N2;
        private System.Windows.Forms.Button B_N3;
        private System.Windows.Forms.Button B_N4;
        private System.Windows.Forms.Button B_N5;
    }
}

