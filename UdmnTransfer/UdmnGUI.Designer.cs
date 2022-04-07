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
            this.listCOMPorts = new System.Windows.Forms.ComboBox();
            this.listTypePackage = new System.Windows.Forms.ComboBox();
            this.leftPanel = new System.Windows.Forms.RichTextBox();
            this.rightPanel = new System.Windows.Forms.RichTextBox();
            this.sendRequest = new System.Windows.Forms.Button();
            this.packageRequest = new System.Windows.Forms.TextBox();
            this.headerRequest = new System.Windows.Forms.Label();
            this.listTypeData = new System.Windows.Forms.ComboBox();
            this.listIndex = new System.Windows.Forms.ComboBox();
            this.indexData = new System.Windows.Forms.Label();
            this.generateRequest = new System.Windows.Forms.Button();
            this.dataRequest = new System.Windows.Forms.Label();
            this.listDataRequest = new System.Windows.Forms.TextBox();
            this.typeData = new System.Windows.Forms.Label();
            this.typePackage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkCOMPort
            // 
            this.checkCOMPort.BackColor = System.Drawing.SystemColors.Control;
            this.checkCOMPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkCOMPort.Location = new System.Drawing.Point(12, 12);
            this.checkCOMPort.Name = "checkCOMPort";
            this.checkCOMPort.Size = new System.Drawing.Size(109, 23);
            this.checkCOMPort.TabIndex = 0;
            this.checkCOMPort.Text = "Соединение";
            this.checkCOMPort.UseVisualStyleBackColor = false;
            this.checkCOMPort.Click += new System.EventHandler(this.CheckCOMPort_Click);
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
            // listTypePackage
            // 
            this.listTypePackage.FormattingEnabled = true;
            this.listTypePackage.Location = new System.Drawing.Point(127, 52);
            this.listTypePackage.Name = "listTypePackage";
            this.listTypePackage.Size = new System.Drawing.Size(121, 23);
            this.listTypePackage.TabIndex = 3;
            this.listTypePackage.VisibleChanged += new System.EventHandler(this.ListTypePackage_Load);
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftPanel.Location = new System.Drawing.Point(9, 386);
            this.leftPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(384, 469);
            this.leftPanel.TabIndex = 4;
            this.leftPanel.Text = "";
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Location = new System.Drawing.Point(397, 386);
            this.rightPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(561, 468);
            this.rightPanel.TabIndex = 5;
            this.rightPanel.Text = "";
            // 
            // sendRequest
            // 
            this.sendRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendRequest.Location = new System.Drawing.Point(10, 349);
            this.sendRequest.Name = "sendRequest";
            this.sendRequest.Size = new System.Drawing.Size(128, 24);
            this.sendRequest.TabIndex = 6;
            this.sendRequest.Text = "Послать запрос";
            this.sendRequest.UseVisualStyleBackColor = true;
            this.sendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // packageRequest
            // 
            this.packageRequest.Location = new System.Drawing.Point(12, 241);
            this.packageRequest.Name = "packageRequest";
            this.packageRequest.Size = new System.Drawing.Size(236, 23);
            this.packageRequest.TabIndex = 7;
            // 
            // headerRequest
            // 
            this.headerRequest.AutoSize = true;
            this.headerRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerRequest.Location = new System.Drawing.Point(12, 221);
            this.headerRequest.Name = "headerRequest";
            this.headerRequest.Size = new System.Drawing.Size(128, 17);
            this.headerRequest.TabIndex = 8;
            this.headerRequest.Text = "Заголовок запроса";
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
            // listIndex
            // 
            this.listIndex.FormattingEnabled = true;
            this.listIndex.Location = new System.Drawing.Point(127, 130);
            this.listIndex.Name = "listIndex";
            this.listIndex.Size = new System.Drawing.Size(121, 23);
            this.listIndex.TabIndex = 11;
            this.listIndex.VisibleChanged += new System.EventHandler(this.Index_Load);
            // 
            // indexData
            // 
            this.indexData.AutoSize = true;
            this.indexData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.indexData.Location = new System.Drawing.Point(14, 131);
            this.indexData.Name = "indexData";
            this.indexData.Size = new System.Drawing.Size(107, 17);
            this.indexData.TabIndex = 12;
            this.indexData.Text = "Индекс данных";
            // 
            // generateRequest
            // 
            this.generateRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateRequest.Location = new System.Drawing.Point(14, 182);
            this.generateRequest.Name = "generateRequest";
            this.generateRequest.Size = new System.Drawing.Size(234, 27);
            this.generateRequest.TabIndex = 13;
            this.generateRequest.Text = "Сформировать запрос";
            this.generateRequest.UseVisualStyleBackColor = true;
            this.generateRequest.Click += new System.EventHandler(this.GenerateRequest_Click);
            // 
            // dataRequest
            // 
            this.dataRequest.AutoSize = true;
            this.dataRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataRequest.Location = new System.Drawing.Point(12, 281);
            this.dataRequest.Name = "dataRequest";
            this.dataRequest.Size = new System.Drawing.Size(113, 17);
            this.dataRequest.TabIndex = 14;
            this.dataRequest.Text = "Данные запроса";
            // 
            // listDataRequest
            // 
            this.listDataRequest.Location = new System.Drawing.Point(12, 301);
            this.listDataRequest.Name = "listDataRequest";
            this.listDataRequest.Size = new System.Drawing.Size(109, 23);
            this.listDataRequest.TabIndex = 15;
            this.listDataRequest.VisibleChanged += new System.EventHandler(this.Index_Load);
            // 
            // typeData
            // 
            this.typeData.AutoSize = true;
            this.typeData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeData.Location = new System.Drawing.Point(14, 95);
            this.typeData.Name = "typeData";
            this.typeData.Size = new System.Drawing.Size(84, 17);
            this.typeData.TabIndex = 16;
            this.typeData.Text = "Тип данных";
            // 
            // typePackage
            // 
            this.typePackage.AutoSize = true;
            this.typePackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typePackage.Location = new System.Drawing.Point(14, 55);
            this.typePackage.Name = "typePackage";
            this.typePackage.Size = new System.Drawing.Size(77, 17);
            this.typePackage.TabIndex = 17;
            this.typePackage.Text = "Тип пакета";
            // 
            // Udmn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 865);
            this.Controls.Add(this.typePackage);
            this.Controls.Add(this.typeData);
            this.Controls.Add(this.listDataRequest);
            this.Controls.Add(this.dataRequest);
            this.Controls.Add(this.generateRequest);
            this.Controls.Add(this.indexData);
            this.Controls.Add(this.listIndex);
            this.Controls.Add(this.listTypeData);
            this.Controls.Add(this.headerRequest);
            this.Controls.Add(this.packageRequest);
            this.Controls.Add(this.sendRequest);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.listTypePackage);
            this.Controls.Add(this.listCOMPorts);
            this.Controls.Add(this.checkCOMPort);
            this.Name = "Udmn";
            this.Text = "УДМН-100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkCOMPort;
        private Button sendRequest;
        private ComboBox listCOMPorts;
        private ComboBox listTypePackage;
        private RichTextBox leftPanel;
        private RichTextBox rightPanel;
        private TextBox packageRequest;
        private Label headerRequest;
        private ComboBox listTypeData;
        private ComboBox listIndex;
        private Label indexData;
        private Button generateRequest;
        private Label dataRequest;
        private TextBox listDataRequest;
        private Label typeData;
        private Label typePackage;
    }
}