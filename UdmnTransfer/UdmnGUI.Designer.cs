namespace UdmnTransfer
{
    partial class Udmn
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
            this.CheckCOMPort = new System.Windows.Forms.Button();
            this.CheckIndex = new System.Windows.Forms.Button();
            this.ListCOMPorts = new System.Windows.Forms.ComboBox();
            this.ListIndex = new System.Windows.Forms.ComboBox();
            this.LeftPanel = new System.Windows.Forms.RichTextBox();
            this.RightPanel = new System.Windows.Forms.RichTextBox();
            this.SendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckCOMPort
            // 
            this.CheckCOMPort.Location = new System.Drawing.Point(12, 12);
            this.CheckCOMPort.Name = "CheckCOMPort";
            this.CheckCOMPort.Size = new System.Drawing.Size(109, 23);
            this.CheckCOMPort.TabIndex = 0;
            this.CheckCOMPort.Text = "Выбрать порт";
            this.CheckCOMPort.UseVisualStyleBackColor = true;
            this.CheckCOMPort.Click += CheckCOMPort_Click;
            // 
            // CheckIndex
            // 
            this.CheckIndex.Location = new System.Drawing.Point(12, 52);
            this.CheckIndex.Name = "CheckIndex";
            this.CheckIndex.Size = new System.Drawing.Size(109, 23);
            this.CheckIndex.TabIndex = 1;
            this.CheckIndex.Text = "Выбрать запрос";
            this.CheckIndex.UseVisualStyleBackColor = true;
            // 
            // ListCOMPorts
            // 
            this.ListCOMPorts.FormattingEnabled = true;
            this.ListCOMPorts.Location = new System.Drawing.Point(127, 12);
            this.ListCOMPorts.Name = "ListCOMPorts";
            this.ListCOMPorts.Size = new System.Drawing.Size(121, 23);
            this.ListCOMPorts.TabIndex = 2;
            // 
            // ListIndex
            // 
            this.ListIndex.FormattingEnabled = true;
            this.ListIndex.Location = new System.Drawing.Point(127, 52);
            this.ListIndex.Name = "ListIndex";
            this.ListIndex.Size = new System.Drawing.Size(121, 23);
            this.ListIndex.TabIndex = 3;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Location = new System.Drawing.Point(12, 170);
            this.LeftPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(384, 300);
            this.LeftPanel.TabIndex = 4;
            this.LeftPanel.Text = "";
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.Location = new System.Drawing.Point(403, 170);
            this.RightPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(384, 300);
            this.RightPanel.TabIndex = 5;
            this.RightPanel.Text = "";
            // 
            // SendRequest
            // 
            this.SendRequest.Location = new System.Drawing.Point(12, 141);
            this.SendRequest.Name = "SendRequest";
            this.SendRequest.Size = new System.Drawing.Size(109, 23);
            this.SendRequest.TabIndex = 6;
            this.SendRequest.Text = "Послать запрос";
            this.SendRequest.UseVisualStyleBackColor = true;
            // 
            // Udmn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.SendRequest);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.ListIndex);
            this.Controls.Add(this.ListCOMPorts);
            this.Controls.Add(this.CheckIndex);
            this.Controls.Add(this.CheckCOMPort);
            this.Name = "Udmn";
            this.Text = "УДМН-100";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CheckCOMPort;
        private Button CheckIndex;
        private Button SendRequest;
        private ComboBox ListCOMPorts;
        private ComboBox ListIndex;
        private RichTextBox LeftPanel;
        private RichTextBox RightPanel;
    }
}