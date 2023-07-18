namespace LogicBuiderV._0
{
    partial class editorForm
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
            this.fileMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBtn = new MetroFramework.Controls.MetroButton();
            this.editBtn = new MetroFramework.Controls.MetroButton();
            this.editMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textArea = new MetroFramework.Controls.MetroTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.metroPanelCommOprtns = new MetroFramework.Controls.MetroPanel();
            this.metroButtonTxCommand = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxTxCommand = new MetroFramework.Controls.MetroTextBox();
            this.metroTextComPortMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelComPortMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCommOprtns = new MetroFramework.Controls.MetroLabel();
            this.metroButtonInitiateCommand = new MetroFramework.Controls.MetroButton();
            this.liveBtn = new MetroFramework.Controls.MetroButton();
            this.label = new System.Windows.Forms.Label();
            this.pictureBoxLogicBuilder = new System.Windows.Forms.PictureBox();
            this.metroTileLogicBuilder = new MetroFramework.Controls.MetroTile();
            this.fileMenu.SuspendLayout();
            this.editMenu.SuspendLayout();
            this.metroPanelCommOprtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogicBuilder)).BeginInit();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "metroContextMenu1";
            this.fileMenu.Size = new System.Drawing.Size(115, 114);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fileBtn
            // 
            this.fileBtn.Location = new System.Drawing.Point(13, 51);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(66, 23);
            this.fileBtn.TabIndex = 1;
            this.fileBtn.Text = "File";
            this.fileBtn.UseSelectable = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(85, 51);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(64, 23);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseSelectable = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // editMenu
            // 
            this.editMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(125, 224);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // textArea
            // 
            this.textArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArea.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textArea.CustomButton.Image = null;
            this.textArea.CustomButton.Location = new System.Drawing.Point(539, 2);
            this.textArea.CustomButton.Name = "";
            this.textArea.CustomButton.Size = new System.Drawing.Size(301, 301);
            this.textArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textArea.CustomButton.TabIndex = 1;
            this.textArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textArea.CustomButton.UseSelectable = true;
            this.textArea.CustomButton.Visible = false;
            this.textArea.Lines = new string[0];
            this.textArea.Location = new System.Drawing.Point(13, 80);
            this.textArea.MaxLength = 32767;
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.PasswordChar = '\0';
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textArea.SelectedText = "";
            this.textArea.SelectionLength = 0;
            this.textArea.SelectionStart = 0;
            this.textArea.ShortcutsEnabled = true;
            this.textArea.Size = new System.Drawing.Size(843, 306);
            this.textArea.TabIndex = 3;
            this.textArea.UseSelectable = true;
            this.textArea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textArea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textArea.Click += new System.EventHandler(this.textArea_Click);
            // 
            // metroPanelCommOprtns
            // 
            this.metroPanelCommOprtns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanelCommOprtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanelCommOprtns.Controls.Add(this.metroButtonTxCommand);
            this.metroPanelCommOprtns.Controls.Add(this.metroTextBoxTxCommand);
            this.metroPanelCommOprtns.Controls.Add(this.metroTextComPortMessage);
            this.metroPanelCommOprtns.Controls.Add(this.metroLabelComPortMessage);
            this.metroPanelCommOprtns.HorizontalScrollbarBarColor = true;
            this.metroPanelCommOprtns.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelCommOprtns.HorizontalScrollbarSize = 10;
            this.metroPanelCommOprtns.Location = new System.Drawing.Point(405, 421);
            this.metroPanelCommOprtns.Name = "metroPanelCommOprtns";
            this.metroPanelCommOprtns.Size = new System.Drawing.Size(451, 86);
            this.metroPanelCommOprtns.TabIndex = 4;
            this.metroPanelCommOprtns.VerticalScrollbarBarColor = true;
            this.metroPanelCommOprtns.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelCommOprtns.VerticalScrollbarSize = 10;
            this.metroPanelCommOprtns.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelCommOprtns_Paint);
            // 
            // metroButtonTxCommand
            // 
            this.metroButtonTxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonTxCommand.Location = new System.Drawing.Point(4, 33);
            this.metroButtonTxCommand.Name = "metroButtonTxCommand";
            this.metroButtonTxCommand.Size = new System.Drawing.Size(114, 23);
            this.metroButtonTxCommand.TabIndex = 5;
            this.metroButtonTxCommand.Text = "Transmit Command";
            this.metroButtonTxCommand.UseSelectable = true;
            this.metroButtonTxCommand.Click += new System.EventHandler(this.metroButtonTxCommand_Click);
            // 
            // metroTextBoxTxCommand
            // 
            this.metroTextBoxTxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxTxCommand.CustomButton.Image = null;
            this.metroTextBoxTxCommand.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.metroTextBoxTxCommand.CustomButton.Name = "";
            this.metroTextBoxTxCommand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxTxCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxTxCommand.CustomButton.TabIndex = 1;
            this.metroTextBoxTxCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxTxCommand.CustomButton.UseSelectable = true;
            this.metroTextBoxTxCommand.CustomButton.Visible = false;
            this.metroTextBoxTxCommand.Lines = new string[0];
            this.metroTextBoxTxCommand.Location = new System.Drawing.Point(124, 34);
            this.metroTextBoxTxCommand.MaxLength = 32767;
            this.metroTextBoxTxCommand.Name = "metroTextBoxTxCommand";
            this.metroTextBoxTxCommand.PasswordChar = '\0';
            this.metroTextBoxTxCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxTxCommand.SelectedText = "";
            this.metroTextBoxTxCommand.SelectionLength = 0;
            this.metroTextBoxTxCommand.SelectionStart = 0;
            this.metroTextBoxTxCommand.ShortcutsEnabled = true;
            this.metroTextBoxTxCommand.Size = new System.Drawing.Size(322, 23);
            this.metroTextBoxTxCommand.TabIndex = 4;
            this.metroTextBoxTxCommand.UseSelectable = true;
            this.metroTextBoxTxCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxTxCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextComPortMessage
            // 
            this.metroTextComPortMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextComPortMessage.CustomButton.Image = null;
            this.metroTextComPortMessage.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.metroTextComPortMessage.CustomButton.Name = "";
            this.metroTextComPortMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextComPortMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextComPortMessage.CustomButton.TabIndex = 1;
            this.metroTextComPortMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextComPortMessage.CustomButton.UseSelectable = true;
            this.metroTextComPortMessage.CustomButton.Visible = false;
            this.metroTextComPortMessage.Lines = new string[0];
            this.metroTextComPortMessage.Location = new System.Drawing.Point(124, 5);
            this.metroTextComPortMessage.MaxLength = 32767;
            this.metroTextComPortMessage.Name = "metroTextComPortMessage";
            this.metroTextComPortMessage.PasswordChar = '\0';
            this.metroTextComPortMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextComPortMessage.SelectedText = "";
            this.metroTextComPortMessage.SelectionLength = 0;
            this.metroTextComPortMessage.SelectionStart = 0;
            this.metroTextComPortMessage.ShortcutsEnabled = true;
            this.metroTextComPortMessage.Size = new System.Drawing.Size(322, 23);
            this.metroTextComPortMessage.TabIndex = 3;
            this.metroTextComPortMessage.UseSelectable = true;
            this.metroTextComPortMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextComPortMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelComPortMessage
            // 
            this.metroLabelComPortMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelComPortMessage.AutoSize = true;
            this.metroLabelComPortMessage.Location = new System.Drawing.Point(3, 9);
            this.metroLabelComPortMessage.Name = "metroLabelComPortMessage";
            this.metroLabelComPortMessage.Size = new System.Drawing.Size(115, 19);
            this.metroLabelComPortMessage.TabIndex = 2;
            this.metroLabelComPortMessage.Text = "Your STM Port is :";
            // 
            // metroLabelCommOprtns
            // 
            this.metroLabelCommOprtns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelCommOprtns.AutoSize = true;
            this.metroLabelCommOprtns.Location = new System.Drawing.Point(400, 396);
            this.metroLabelCommOprtns.Name = "metroLabelCommOprtns";
            this.metroLabelCommOprtns.Size = new System.Drawing.Size(306, 19);
            this.metroLabelCommOprtns.TabIndex = 2;
            this.metroLabelCommOprtns.Text = "Press the button to initiate \'Command Operations\':";
            this.metroLabelCommOprtns.Click += new System.EventHandler(this.metroLabelCommOprtns_Click);
            // 
            // metroButtonInitiateCommand
            // 
            this.metroButtonInitiateCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonInitiateCommand.Location = new System.Drawing.Point(712, 392);
            this.metroButtonInitiateCommand.Name = "metroButtonInitiateCommand";
            this.metroButtonInitiateCommand.Size = new System.Drawing.Size(144, 23);
            this.metroButtonInitiateCommand.TabIndex = 3;
            this.metroButtonInitiateCommand.Text = "Initiate";
            this.metroButtonInitiateCommand.UseSelectable = true;
            this.metroButtonInitiateCommand.Click += new System.EventHandler(this.metroButtonInitiateCommand_Click);
            // 
            // liveBtn
            // 
            this.liveBtn.Location = new System.Drawing.Point(155, 51);
            this.liveBtn.Name = "liveBtn";
            this.liveBtn.Size = new System.Drawing.Size(64, 23);
            this.liveBtn.TabIndex = 5;
            this.liveBtn.Text = "Live";
            this.liveBtn.UseSelectable = true;
            this.liveBtn.Click += new System.EventHandler(this.liveBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(49, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 16);
            this.label.TabIndex = 6;
            this.label.Text = "Builder Studio 0.1";
            // 
            // pictureBoxLogicBuilder
            // 
            this.pictureBoxLogicBuilder.Image = global::LogicBuiderV._0.Properties.Resources.Logo_LogicBuilder3;
            this.pictureBoxLogicBuilder.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxLogicBuilder.Name = "pictureBoxLogicBuilder";
            this.pictureBoxLogicBuilder.Size = new System.Drawing.Size(31, 35);
            this.pictureBoxLogicBuilder.TabIndex = 7;
            this.pictureBoxLogicBuilder.TabStop = false;
            // 
            // metroTileLogicBuilder
            // 
            this.metroTileLogicBuilder.ActiveControl = null;
            this.metroTileLogicBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileLogicBuilder.Location = new System.Drawing.Point(192, 3);
            this.metroTileLogicBuilder.Name = "metroTileLogicBuilder";
            this.metroTileLogicBuilder.Size = new System.Drawing.Size(587, 42);
            this.metroTileLogicBuilder.TabIndex = 8;
            this.metroTileLogicBuilder.UseSelectable = true;
            // 
            // editorForm
            // 
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(868, 518);
            this.Controls.Add(this.metroTileLogicBuilder);
            this.Controls.Add(this.pictureBoxLogicBuilder);
            this.Controls.Add(this.label);
            this.Controls.Add(this.liveBtn);
            this.Controls.Add(this.metroButtonInitiateCommand);
            this.Controls.Add(this.metroPanelCommOprtns);
            this.Controls.Add(this.metroLabelCommOprtns);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.fileBtn);
            this.Name = "editorForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fileMenu.ResumeLayout(false);
            this.editMenu.ResumeLayout(false);
            this.metroPanelCommOprtns.ResumeLayout(false);
            this.metroPanelCommOprtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogicBuilder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton fileBtn;
        private MetroFramework.Controls.MetroButton editBtn;
        private MetroFramework.Controls.MetroContextMenu editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox textArea;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MetroFramework.Controls.MetroPanel metroPanelCommOprtns;
        private MetroFramework.Controls.MetroLabel metroLabelCommOprtns;
        private MetroFramework.Controls.MetroButton metroButtonInitiateCommand;
        private MetroFramework.Controls.MetroButton metroButtonTxCommand;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTxCommand;
        private MetroFramework.Controls.MetroTextBox metroTextComPortMessage;
        private MetroFramework.Controls.MetroLabel metroLabelComPortMessage;
        private MetroFramework.Controls.MetroButton liveBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxLogicBuilder;
        private MetroFramework.Controls.MetroTile metroTileLogicBuilder;
    }
}

