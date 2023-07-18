namespace LogicBuiderV._0
{
    partial class DataMonitorWindow
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
            this.dMWindowStartBtn = new MetroFramework.Controls.MetroButton();
            this.dMWindowStopBtn = new MetroFramework.Controls.MetroButton();
            this.dMWindowDisplay = new MetroFramework.Controls.MetroTextBox();
            this.dMWindowReceivedId = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // dMWindowStartBtn
            // 
            this.dMWindowStartBtn.Location = new System.Drawing.Point(11, 34);
            this.dMWindowStartBtn.Name = "dMWindowStartBtn";
            this.dMWindowStartBtn.Size = new System.Drawing.Size(75, 23);
            this.dMWindowStartBtn.TabIndex = 1;
            this.dMWindowStartBtn.Text = "Start";
            this.dMWindowStartBtn.UseSelectable = true;
            this.dMWindowStartBtn.Click += new System.EventHandler(this.dMWindowStartBtn_Click);
            // 
            // dMWindowStopBtn
            // 
            this.dMWindowStopBtn.Location = new System.Drawing.Point(408, 34);
            this.dMWindowStopBtn.Name = "dMWindowStopBtn";
            this.dMWindowStopBtn.Size = new System.Drawing.Size(75, 23);
            this.dMWindowStopBtn.TabIndex = 2;
            this.dMWindowStopBtn.Text = "Stop";
            this.dMWindowStopBtn.UseSelectable = true;
            this.dMWindowStopBtn.Click += new System.EventHandler(this.dMWindowStopBtn_Click);
            // 
            // dMWindowDisplay
            // 
            // 
            // 
            // 
            this.dMWindowDisplay.CustomButton.Image = null;
            this.dMWindowDisplay.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.dMWindowDisplay.CustomButton.Name = "";
            this.dMWindowDisplay.CustomButton.Size = new System.Drawing.Size(369, 369);
            this.dMWindowDisplay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dMWindowDisplay.CustomButton.TabIndex = 1;
            this.dMWindowDisplay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dMWindowDisplay.CustomButton.UseSelectable = true;
            this.dMWindowDisplay.CustomButton.Visible = false;
            this.dMWindowDisplay.Lines = new string[0];
            this.dMWindowDisplay.Location = new System.Drawing.Point(11, 74);
            this.dMWindowDisplay.MaxLength = 32767;
            this.dMWindowDisplay.Multiline = true;
            this.dMWindowDisplay.Name = "dMWindowDisplay";
            this.dMWindowDisplay.PasswordChar = '\0';
            this.dMWindowDisplay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dMWindowDisplay.SelectedText = "";
            this.dMWindowDisplay.SelectionLength = 0;
            this.dMWindowDisplay.SelectionStart = 0;
            this.dMWindowDisplay.ShortcutsEnabled = true;
            this.dMWindowDisplay.Size = new System.Drawing.Size(472, 371);
            this.dMWindowDisplay.TabIndex = 3;
            this.dMWindowDisplay.UseSelectable = true;
            this.dMWindowDisplay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dMWindowDisplay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dMWindowReceivedId
            // 
            // 
            // 
            // 
            this.dMWindowReceivedId.CustomButton.Image = null;
            this.dMWindowReceivedId.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.dMWindowReceivedId.CustomButton.Name = "";
            this.dMWindowReceivedId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dMWindowReceivedId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dMWindowReceivedId.CustomButton.TabIndex = 1;
            this.dMWindowReceivedId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dMWindowReceivedId.CustomButton.UseSelectable = true;
            this.dMWindowReceivedId.CustomButton.Visible = false;
            this.dMWindowReceivedId.Lines = new string[0];
            this.dMWindowReceivedId.Location = new System.Drawing.Point(140, 34);
            this.dMWindowReceivedId.MaxLength = 32767;
            this.dMWindowReceivedId.Name = "dMWindowReceivedId";
            this.dMWindowReceivedId.PasswordChar = '\0';
            this.dMWindowReceivedId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dMWindowReceivedId.SelectedText = "";
            this.dMWindowReceivedId.SelectionLength = 0;
            this.dMWindowReceivedId.SelectionStart = 0;
            this.dMWindowReceivedId.ShortcutsEnabled = true;
            this.dMWindowReceivedId.Size = new System.Drawing.Size(214, 23);
            this.dMWindowReceivedId.TabIndex = 4;
            this.dMWindowReceivedId.UseSelectable = true;
            this.dMWindowReceivedId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dMWindowReceivedId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DataMonitorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 460);
            this.Controls.Add(this.dMWindowReceivedId);
            this.Controls.Add(this.dMWindowDisplay);
            this.Controls.Add(this.dMWindowStopBtn);
            this.Controls.Add(this.dMWindowStartBtn);
            this.Name = "DataMonitorWindow";
            this.Load += new System.EventHandler(this.dataMonitorWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton dMWindowStartBtn;
        private MetroFramework.Controls.MetroButton dMWindowStopBtn;
        private MetroFramework.Controls.MetroTextBox dMWindowDisplay;
        private MetroFramework.Controls.MetroTextBox dMWindowReceivedId;
    }
}