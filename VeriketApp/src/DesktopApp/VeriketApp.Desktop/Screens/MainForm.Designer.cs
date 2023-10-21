namespace VeriketApp.Desktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetLogsButton = new Button();
            LogsDataGridView = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            ComputerName = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LogsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // GetLogsButton
            // 
            GetLogsButton.Location = new Point(12, 12);
            GetLogsButton.Name = "GetLogsButton";
            GetLogsButton.Size = new Size(440, 23);
            GetLogsButton.TabIndex = 0;
            GetLogsButton.Text = "Logları Getir";
            GetLogsButton.UseVisualStyleBackColor = true;
            GetLogsButton.Click += GetLogsButton_Click;
            // 
            // LogsDataGridView
            // 
            LogsDataGridView.AllowUserToAddRows = false;
            LogsDataGridView.AllowUserToDeleteRows = false;
            LogsDataGridView.AllowUserToResizeColumns = false;
            LogsDataGridView.AllowUserToResizeRows = false;
            LogsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Date, ComputerName, UserName });
            LogsDataGridView.Location = new Point(12, 41);
            LogsDataGridView.Name = "LogsDataGridView";
            LogsDataGridView.RowHeadersVisible = false;
            LogsDataGridView.RowTemplate.Height = 25;
            LogsDataGridView.RowTemplate.ReadOnly = true;
            LogsDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            LogsDataGridView.ShowEditingIcon = false;
            LogsDataGridView.Size = new Size(440, 178);
            LogsDataGridView.TabIndex = 1;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Tarih";
            Date.Name = "Date";
            // 
            // ComputerName
            // 
            ComputerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ComputerName.HeaderText = "Bilgisayar Adı";
            ComputerName.Name = "ComputerName";
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.HeaderText = "Kullanıcı Adı";
            UserName.Name = "UserName";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 231);
            Controls.Add(LogsDataGridView);
            Controls.Add(GetLogsButton);
            MaximumSize = new Size(480, 270);
            MinimumSize = new Size(480, 270);
            Name = "MainForm";
            Text = "Veriket App";
            ((System.ComponentModel.ISupportInitialize)LogsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button GetLogsButton;
        private DataGridView LogsDataGridView;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ComputerName;
        private DataGridViewTextBoxColumn UserName;
    }
}