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
            this.checkCOMPort = new System.Windows.Forms.Button();
            this.checkTypePackage = new System.Windows.Forms.Button();
            this.listCOMPorts = new System.Windows.Forms.ComboBox();
            this.typePackage = new System.Windows.Forms.ComboBox();
            this.leftPanel = new System.Windows.Forms.RichTextBox();
            this.rightPanel = new System.Windows.Forms.RichTextBox();
            this.sendRequest = new System.Windows.Forms.Button();
            this.packageRequest = new System.Windows.Forms.TextBox();
            this.headerRequest = new System.Windows.Forms.Label();
            this.typeData = new System.Windows.Forms.Button();
            this.listTypeData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkCOMPort
            // 
            this.checkCOMPort.Location = new System.Drawing.Point(12, 12);
            this.checkCOMPort.Name = "checkCOMPort";
            this.checkCOMPort.Size = new System.Drawing.Size(109, 23);
            this.checkCOMPort.TabIndex = 0;
            this.checkCOMPort.Text = "Выбрать порт";
            this.checkCOMPort.UseVisualStyleBackColor = true;
            // 
            // checkTypePackage
            // 
            this.checkTypePackage.Location = new System.Drawing.Point(12, 52);
            this.checkTypePackage.Name = "checkTypePackage";
            this.checkTypePackage.Size = new System.Drawing.Size(109, 23);
            this.checkTypePackage.TabIndex = 1;
            this.checkTypePackage.Text = "Тип пакет";
            this.checkTypePackage.UseVisualStyleBackColor = true;
            this.checkTypePackage.Click += new System.EventHandler(this.CheckTypePackage_Click);
            // 
            // listCOMPorts
            // 
            this.listCOMPorts.FormattingEnabled = true;
            this.listCOMPorts.Location = new System.Drawing.Point(127, 12);
            this.listCOMPorts.Name = "listCOMPorts";
            this.listCOMPorts.Size = new System.Drawing.Size(121, 23);
            this.listCOMPorts.TabIndex = 2;
            this.listCOMPorts.VisibleChanged += new System.EventHandler(this.ListCOMPorts_Load);
            // 
            // typePackage
            // 
            this.typePackage.FormattingEnabled = true;
            this.typePackage.Location = new System.Drawing.Point(127, 52);
            this.typePackage.Name = "typePackage";
            this.typePackage.Size = new System.Drawing.Size(121, 23);
            this.typePackage.TabIndex = 3;
            this.typePackage.VisibleChanged += new System.EventHandler(this.ListTypePackage_Load);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftPanel.Location = new System.Drawing.Point(12, 225);
            this.leftPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(384, 300);
            this.leftPanel.TabIndex = 4;
            this.leftPanel.Text = "";
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightPanel.Location = new System.Drawing.Point(403, 225);
            this.rightPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(384, 300);
            this.rightPanel.TabIndex = 5;
            this.rightPanel.Text = "";
            // 
            // sendRequest
            // 
            this.sendRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendRequest.Location = new System.Drawing.Point(12, 196);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(109, 23);
            this.sendRequest.TabIndex = 6;
            this.sendRequest.Text = "Послать запрос";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // packageRequest
            // 
            this.packageRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.packageRequest.Location = new System.Drawing.Point(12, 167);
            this.packageRequest.Name = "packageRequest";
            this.packageRequest.Size = new System.Drawing.Size(236, 23);
            this.packageRequest.TabIndex = 7;
            this.packageRequest.VisibleChanged += new System.EventHandler(this.TypePackageRequest_Load);
            // 
            // headerRequest
            // 
            this.headerRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerRequest.AutoSize = true;
            this.headerRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerRequest.Location = new System.Drawing.Point(12, 147);
            this.headerRequest.Name = "headerRequest";
            this.headerRequest.Size = new System.Drawing.Size(128, 17);
            this.headerRequest.TabIndex = 8;
            this.headerRequest.Text = "Заголовок запроса";
            // 
            // typeData
            // 
            this.typeData.Location = new System.Drawing.Point(12, 92);
            this.typeData.Name = "typeData";
            this.typeData.Size = new System.Drawing.Size(109, 23);
            this.typeData.TabIndex = 9;
            this.typeData.Text = "Тип данных";
            this.typeData.UseVisualStyleBackColor = true;
            this.typeData.Click += new System.EventHandler(this.CheckTypeData_Click);
            // 
            // listTypeData
            // 
            this.listTypeData.FormattingEnabled = true;
            this.listTypeData.Location = new System.Drawing.Point(127, 92);
            this.listTypeData.Name = "listTypeData";
            this.listTypeData.Size = new System.Drawing.Size(121, 23);
            this.listTypeData.TabIndex = 10;
            this.listTypeData.VisibleChanged += new System.EventHandler(this.ListTypeData_Load);
            // 
            // Udmn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 590);
            this.Controls.Add(this.listTypeData);
            this.Controls.Add(this.typeData);
            this.Controls.Add(this.headerRequest);
            this.Controls.Add(this.packageRequest);
            this.Controls.Add(this.sendRequest);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.typePackage);
            this.Controls.Add(this.listCOMPorts);
            this.Controls.Add(this.checkTypePackage);
            this.Controls.Add(this.checkCOMPort);
            this.Name = "Udmn";
            this.Text = "УДМН-100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkCOMPort;
        private Button checkTypePackage;
        private Button sendRequest;
        private ComboBox listCOMPorts;
        private ComboBox typePackage;
        private RichTextBox leftPanel;
        private RichTextBox rightPanel;
        private TextBox packageRequest;
        private Label headerRequest;
        private Button typeData;
        private ComboBox listTypeData;
    }
}