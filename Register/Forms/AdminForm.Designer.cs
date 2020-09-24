namespace register.Forms
{
    partial class AdminForm
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
            this.DG_AdminView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.B_SaveData = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_AdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_AdminView
            // 
            this.DG_AdminView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_AdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_AdminView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Password,
            this.Role,
            this.AdminLevel});
            this.DG_AdminView.Location = new System.Drawing.Point(12, 25);
            this.DG_AdminView.Name = "DG_AdminView";
            this.DG_AdminView.Size = new System.Drawing.Size(449, 181);
            this.DG_AdminView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // B_SaveData
            // 
            this.B_SaveData.Location = new System.Drawing.Point(13, 211);
            this.B_SaveData.Name = "B_SaveData";
            this.B_SaveData.Size = new System.Drawing.Size(448, 23);
            this.B_SaveData.TabIndex = 4;
            this.B_SaveData.Text = "Сохранить изменения";
            this.B_SaveData.UseVisualStyleBackColor = true;
            this.B_SaveData.Click += new System.EventHandler(this.B_SaveData_Click);
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AdminLevel
            // 
            this.AdminLevel.HeaderText = "AdminLevel";
            this.AdminLevel.Name = "AdminLevel";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 246);
            this.Controls.Add(this.B_SaveData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_AdminView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.DG_AdminView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_AdminView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_SaveData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminLevel;
    }
}