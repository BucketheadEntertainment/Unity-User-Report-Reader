namespace Unity_User_Reporting_Reader
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
            this.openJSONFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.thumbnailPictureBox = new System.Windows.Forms.PictureBox();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.receivedOnTextBox = new System.Windows.Forms.TextBox();
            this.receivedOnLabel = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.imagesTab = new System.Windows.Forms.TabPage();
            this.imageCountTextBox = new System.Windows.Forms.TextBox();
            this.previousImageButton = new System.Windows.Forms.Button();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.screenshotPictureBox = new System.Windows.Forms.PictureBox();
            this.deviceMetadataTab = new System.Windows.Forms.TabPage();
            this.deviceMetadataGrid = new System.Windows.Forms.DataGridView();
            this.deviceMetadataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceMetadataValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsTab = new System.Windows.Forms.TabPage();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.exceptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullMessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stackTraceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.imagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotPictureBox)).BeginInit();
            this.deviceMetadataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceMetadataGrid)).BeginInit();
            this.eventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // openJSONFileDialog
            // 
            this.openJSONFileDialog.DefaultExt = "json";
            this.openJSONFileDialog.FileName = "openJSONFileDialog";
            this.openJSONFileDialog.Filter = "JSON files|*.json";
            this.openJSONFileDialog.Title = "Open a valid Unity JSON file";
            this.openJSONFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openJSONFile_FileOk);
            // 
            // thumbnailPictureBox
            // 
            this.thumbnailPictureBox.Location = new System.Drawing.Point(6, 6);
            this.thumbnailPictureBox.Name = "thumbnailPictureBox";
            this.thumbnailPictureBox.Size = new System.Drawing.Size(480, 270);
            this.thumbnailPictureBox.TabIndex = 0;
            this.thumbnailPictureBox.TabStop = false;
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Location = new System.Drawing.Point(610, 39);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.PlaceholderText = "SUMMARY";
            this.summaryTextBox.ReadOnly = true;
            this.summaryTextBox.Size = new System.Drawing.Size(434, 27);
            this.summaryTextBox.TabIndex = 1;
            // 
            // receivedOnTextBox
            // 
            this.receivedOnTextBox.Location = new System.Drawing.Point(610, 6);
            this.receivedOnTextBox.Name = "receivedOnTextBox";
            this.receivedOnTextBox.PlaceholderText = "RECEIVED ON";
            this.receivedOnTextBox.ReadOnly = true;
            this.receivedOnTextBox.Size = new System.Drawing.Size(434, 27);
            this.receivedOnTextBox.TabIndex = 2;
            // 
            // receivedOnLabel
            // 
            this.receivedOnLabel.AutoSize = true;
            this.receivedOnLabel.Location = new System.Drawing.Point(514, 9);
            this.receivedOnLabel.Name = "receivedOnLabel";
            this.receivedOnLabel.Size = new System.Drawing.Size(90, 20);
            this.receivedOnLabel.TabIndex = 3;
            this.receivedOnLabel.Text = "Received on";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(533, 42);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(71, 20);
            this.summaryLabel.TabIndex = 4;
            this.summaryLabel.Text = "Summary";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.overviewTab);
            this.tabControl.Controls.Add(this.imagesTab);
            this.tabControl.Controls.Add(this.deviceMetadataTab);
            this.tabControl.Controls.Add(this.eventsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1060, 559);
            this.tabControl.TabIndex = 5;
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.descriptionTextBox);
            this.overviewTab.Controls.Add(this.categoryTextBox);
            this.overviewTab.Controls.Add(this.descriptionLabel);
            this.overviewTab.Controls.Add(this.categoryLabel);
            this.overviewTab.Controls.Add(this.thumbnailPictureBox);
            this.overviewTab.Controls.Add(this.summaryLabel);
            this.overviewTab.Controls.Add(this.summaryTextBox);
            this.overviewTab.Controls.Add(this.receivedOnLabel);
            this.overviewTab.Controls.Add(this.receivedOnTextBox);
            this.overviewTab.Location = new System.Drawing.Point(4, 29);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(1052, 526);
            this.overviewTab.TabIndex = 0;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(610, 105);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "DESCRIPTION";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(434, 174);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(610, 72);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.PlaceholderText = "CATEGORY";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(434, 27);
            this.categoryTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(519, 108);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(85, 20);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(535, 75);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 20);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            // 
            // imagesTab
            // 
            this.imagesTab.Controls.Add(this.imageCountTextBox);
            this.imagesTab.Controls.Add(this.previousImageButton);
            this.imagesTab.Controls.Add(this.nextImageButton);
            this.imagesTab.Controls.Add(this.screenshotPictureBox);
            this.imagesTab.Location = new System.Drawing.Point(4, 29);
            this.imagesTab.Name = "imagesTab";
            this.imagesTab.Padding = new System.Windows.Forms.Padding(3);
            this.imagesTab.Size = new System.Drawing.Size(1052, 526);
            this.imagesTab.TabIndex = 1;
            this.imagesTab.Text = "Images";
            this.imagesTab.UseVisualStyleBackColor = true;
            // 
            // imageCountTextBox
            // 
            this.imageCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageCountTextBox.Location = new System.Drawing.Point(832, 8);
            this.imageCountTextBox.Name = "imageCountTextBox";
            this.imageCountTextBox.ReadOnly = true;
            this.imageCountTextBox.Size = new System.Drawing.Size(112, 27);
            this.imageCountTextBox.TabIndex = 3;
            this.imageCountTextBox.Text = "0/0";
            this.imageCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // previousImageButton
            // 
            this.previousImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousImageButton.Location = new System.Drawing.Point(732, 6);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(94, 29);
            this.previousImageButton.TabIndex = 2;
            this.previousImageButton.Text = "Previous";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.previousImageButton_Click);
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Location = new System.Drawing.Point(950, 7);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(94, 29);
            this.nextImageButton.TabIndex = 1;
            this.nextImageButton.Text = "Next";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // screenshotPictureBox
            // 
            this.screenshotPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenshotPictureBox.Location = new System.Drawing.Point(3, 3);
            this.screenshotPictureBox.Name = "screenshotPictureBox";
            this.screenshotPictureBox.Size = new System.Drawing.Size(1046, 520);
            this.screenshotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screenshotPictureBox.TabIndex = 0;
            this.screenshotPictureBox.TabStop = false;
            // 
            // deviceMetadataTab
            // 
            this.deviceMetadataTab.Controls.Add(this.deviceMetadataGrid);
            this.deviceMetadataTab.Location = new System.Drawing.Point(4, 29);
            this.deviceMetadataTab.Name = "deviceMetadataTab";
            this.deviceMetadataTab.Size = new System.Drawing.Size(1052, 526);
            this.deviceMetadataTab.TabIndex = 3;
            this.deviceMetadataTab.Text = "Device Metadata";
            this.deviceMetadataTab.UseVisualStyleBackColor = true;
            // 
            // deviceMetadataGrid
            // 
            this.deviceMetadataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deviceMetadataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.deviceMetadataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceMetadataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceMetadataName,
            this.deviceMetadataValue});
            this.deviceMetadataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceMetadataGrid.Location = new System.Drawing.Point(0, 0);
            this.deviceMetadataGrid.Name = "deviceMetadataGrid";
            this.deviceMetadataGrid.ReadOnly = true;
            this.deviceMetadataGrid.RowHeadersWidth = 51;
            this.deviceMetadataGrid.RowTemplate.Height = 29;
            this.deviceMetadataGrid.Size = new System.Drawing.Size(1052, 526);
            this.deviceMetadataGrid.TabIndex = 0;
            // 
            // deviceMetadataName
            // 
            this.deviceMetadataName.HeaderText = "Name";
            this.deviceMetadataName.MinimumWidth = 6;
            this.deviceMetadataName.Name = "deviceMetadataName";
            this.deviceMetadataName.ReadOnly = true;
            // 
            // deviceMetadataValue
            // 
            this.deviceMetadataValue.HeaderText = "Value";
            this.deviceMetadataValue.MinimumWidth = 6;
            this.deviceMetadataValue.Name = "deviceMetadataValue";
            this.deviceMetadataValue.ReadOnly = true;
            // 
            // eventsTab
            // 
            this.eventsTab.Controls.Add(this.eventsDataGrid);
            this.eventsTab.Location = new System.Drawing.Point(4, 29);
            this.eventsTab.Name = "eventsTab";
            this.eventsTab.Size = new System.Drawing.Size(1052, 526);
            this.eventsTab.TabIndex = 4;
            this.eventsTab.Text = "Events";
            this.eventsTab.UseVisualStyleBackColor = true;
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exceptionColumn,
            this.frameNumberColumn,
            this.fullMessageColumn,
            this.levelColumn,
            this.messageColumn,
            this.stackTraceColumn,
            this.timestampColumn});
            this.eventsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.ReadOnly = true;
            this.eventsDataGrid.RowHeadersWidth = 10;
            this.eventsDataGrid.RowTemplate.Height = 29;
            this.eventsDataGrid.Size = new System.Drawing.Size(1052, 526);
            this.eventsDataGrid.TabIndex = 1;
            // 
            // exceptionColumn
            // 
            this.exceptionColumn.HeaderText = "Exception";
            this.exceptionColumn.MinimumWidth = 6;
            this.exceptionColumn.Name = "exceptionColumn";
            this.exceptionColumn.ReadOnly = true;
            // 
            // frameNumberColumn
            // 
            this.frameNumberColumn.HeaderText = "Frame No.";
            this.frameNumberColumn.MinimumWidth = 6;
            this.frameNumberColumn.Name = "frameNumberColumn";
            this.frameNumberColumn.ReadOnly = true;
            // 
            // fullMessageColumn
            // 
            this.fullMessageColumn.HeaderText = "Full Message";
            this.fullMessageColumn.MinimumWidth = 6;
            this.fullMessageColumn.Name = "fullMessageColumn";
            this.fullMessageColumn.ReadOnly = true;
            // 
            // levelColumn
            // 
            this.levelColumn.HeaderText = "Level";
            this.levelColumn.MinimumWidth = 6;
            this.levelColumn.Name = "levelColumn";
            this.levelColumn.ReadOnly = true;
            // 
            // messageColumn
            // 
            this.messageColumn.HeaderText = "Message";
            this.messageColumn.MinimumWidth = 6;
            this.messageColumn.Name = "messageColumn";
            this.messageColumn.ReadOnly = true;
            // 
            // stackTraceColumn
            // 
            this.stackTraceColumn.HeaderText = "Stack Trace";
            this.stackTraceColumn.MinimumWidth = 6;
            this.stackTraceColumn.Name = "stackTraceColumn";
            this.stackTraceColumn.ReadOnly = true;
            // 
            // timestampColumn
            // 
            this.timestampColumn.HeaderText = "Time";
            this.timestampColumn.MinimumWidth = 6;
            this.timestampColumn.Name = "timestampColumn";
            this.timestampColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 559);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Unity User Reporting Reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.overviewTab.ResumeLayout(false);
            this.overviewTab.PerformLayout();
            this.imagesTab.ResumeLayout(false);
            this.imagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotPictureBox)).EndInit();
            this.deviceMetadataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceMetadataGrid)).EndInit();
            this.eventsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openJSONFile;
        private OpenFileDialog openJSONFileDialog;
        private PictureBox thumbnailPictureBox;
        private TextBox summaryTextBox;
        private TextBox receivedOnTextBox;
        private Label receivedOnLabel;
        private Label summaryLabel;
        private TabControl tabControl;
        private TabPage overviewTab;
        private TabPage imagesTab;
        private TextBox imageCountTextBox;
        private Button previousImageButton;
        private Button nextImageButton;
        private PictureBox screenshotPictureBox;
        private Label categoryLabel;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private TextBox categoryTextBox;
        private TabPage deviceMetadataTab;
        private TabPage eventsTab;
        private DataGridView deviceMetadataGrid;
        private DataGridViewTextBoxColumn deviceMetadataName;
        private DataGridViewTextBoxColumn deviceMetadataValue;
        private DataGridView eventsDataGrid;
        private DataGridViewTextBoxColumn exceptionColumn;
        private DataGridViewTextBoxColumn frameNumberColumn;
        private DataGridViewTextBoxColumn fullMessageColumn;
        private DataGridViewTextBoxColumn levelColumn;
        private DataGridViewTextBoxColumn messageColumn;
        private DataGridViewTextBoxColumn stackTraceColumn;
        private DataGridViewTextBoxColumn timestampColumn;
    }
}