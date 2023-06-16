namespace TravianoApp
{
    partial class FrmAccount
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            accountDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Server = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new Button();
            serverTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            serverLabel = new Label();
            passwordLabel = new Label();
            userNameLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(accountDataGridView);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(serverTextBox);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(userNameTextBox);
            groupBox1.Controls.Add(serverLabel);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(userNameLabel);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // accountDataGridView
            // 
            accountDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accountDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Password, Server });
            accountDataGridView.ContextMenuStrip = contextMenuStrip1;
            accountDataGridView.Location = new Point(44, 194);
            accountDataGridView.Name = "accountDataGridView";
            accountDataGridView.RowHeadersWidth = 51;
            accountDataGridView.RowTemplate.Height = 25;
            accountDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            accountDataGridView.Size = new Size(647, 140);
            accountDataGridView.TabIndex = 7;
            accountDataGridView.RowHeaderMouseDoubleClick += accountDataGridView_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // Server
            // 
            Server.HeaderText = "Server";
            Server.MinimumWidth = 6;
            Server.Name = "Server";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(425, 33);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(99, 106);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(138, 112);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(266, 29);
            serverTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(138, 73);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(266, 29);
            passwordTextBox.TabIndex = 4;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(138, 35);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(266, 29);
            userNameTextBox.TabIndex = 3;
            // 
            // serverLabel
            // 
            serverLabel.AutoSize = true;
            serverLabel.Location = new Point(44, 115);
            serverLabel.Name = "serverLabel";
            serverLabel.Size = new Size(55, 21);
            serverLabel.TabIndex = 2;
            serverLabel.Text = "Server";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(44, 76);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 21);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(44, 38);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(88, 21);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name";
            // 
            // FrmAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 349);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Entry";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox serverTextBox;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label serverLabel;
        private Label passwordLabel;
        private Label userNameLabel;
        private Button saveButton;
        private DataGridView accountDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Server;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}