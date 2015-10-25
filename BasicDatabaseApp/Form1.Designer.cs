namespace BasicDatabaseApp
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
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statmentBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.closeConnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(12, 9);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(38, 13);
            this.serverLabel.TabIndex = 0;
            this.serverLabel.Text = "Server";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(64, 6);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(100, 20);
            this.serverBox.TabIndex = 1;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(64, 33);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 20);
            this.portBox.TabIndex = 3;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(12, 36);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port";
            // 
            // databaseBox
            // 
            this.databaseBox.Location = new System.Drawing.Point(64, 60);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(100, 20);
            this.databaseBox.TabIndex = 5;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(12, 63);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(53, 13);
            this.databaseLabel.TabIndex = 4;
            this.databaseLabel.Text = "Database";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(64, 88);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(100, 20);
            this.userBox.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 91);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(29, 13);
            this.userLabel.TabIndex = 6;
            this.userLabel.Text = "User";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(64, 117);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 120);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 143);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(152, 24);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(183, 36);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(565, 356);
            this.dataGridView.TabIndex = 11;
            // 
            // statmentBox
            // 
            this.statmentBox.Location = new System.Drawing.Point(183, 9);
            this.statmentBox.Name = "statmentBox";
            this.statmentBox.Size = new System.Drawing.Size(457, 20);
            this.statmentBox.TabIndex = 12;
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(646, 9);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(102, 20);
            this.executeButton.TabIndex = 13;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // closeConnButton
            // 
            this.closeConnButton.Location = new System.Drawing.Point(12, 173);
            this.closeConnButton.Name = "closeConnButton";
            this.closeConnButton.Size = new System.Drawing.Size(152, 23);
            this.closeConnButton.TabIndex = 14;
            this.closeConnButton.Text = "Close Connection";
            this.closeConnButton.UseVisualStyleBackColor = true;
            this.closeConnButton.Click += new System.EventHandler(this.closeConnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 402);
            this.Controls.Add(this.closeConnButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.statmentBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.databaseBox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.serverLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox statmentBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button closeConnButton;
    }
}

