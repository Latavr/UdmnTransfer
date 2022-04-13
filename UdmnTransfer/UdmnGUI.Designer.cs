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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.stopRequest = new System.Windows.Forms.Button();
            this.setCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCOMPort
            // 
            this.checkCOMPort.BackColor = System.Drawing.Color.Red;
            this.checkCOMPort.ForeColor = System.Drawing.Color.White;
            this.checkCOMPort.Location = new System.Drawing.Point(10, 12);
            this.checkCOMPort.Name = "checkCOMPort";
            this.checkCOMPort.Size = new System.Drawing.Size(109, 23);
            this.checkCOMPort.TabIndex = 0;
            this.checkCOMPort.Text = "Подключить";
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
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(426, 411);
            this.leftPanel.TabIndex = 4;
            this.leftPanel.Text = "";
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.Location = new System.Drawing.Point(6, 3);
            this.rightPanel.MinimumSize = new System.Drawing.Size(384, 286);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(433, 411);
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
            this.packageRequest.Location = new System.Drawing.Point(10, 241);
            this.packageRequest.Name = "packageRequest";
            this.packageRequest.Size = new System.Drawing.Size(338, 23);
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
            this.indexData.Location = new System.Drawing.Point(10, 131);
            this.indexData.Name = "indexData";
            this.indexData.Size = new System.Drawing.Size(107, 17);
            this.indexData.TabIndex = 12;
            this.indexData.Text = "Индекс данных";
            // 
            // generateRequest
            // 
            this.generateRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateRequest.Location = new System.Drawing.Point(10, 182);
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
            this.listDataRequest.Location = new System.Drawing.Point(10, 301);
            this.listDataRequest.Name = "listDataRequest";
            this.listDataRequest.Size = new System.Drawing.Size(115, 23);
            this.listDataRequest.TabIndex = 15;
            this.listDataRequest.VisibleChanged += new System.EventHandler(this.Index_Load);
            // 
            // typeData
            // 
            this.typeData.AutoSize = true;
            this.typeData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeData.Location = new System.Drawing.Point(10, 93);
            this.typeData.Name = "typeData";
            this.typeData.Size = new System.Drawing.Size(84, 17);
            this.typeData.TabIndex = 16;
            this.typeData.Text = "Тип данных";
            // 
            // typePackage
            // 
            this.typePackage.AutoSize = true;
            this.typePackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typePackage.Location = new System.Drawing.Point(10, 53);
            this.typePackage.Name = "typePackage";
            this.typePackage.Size = new System.Drawing.Size(77, 17);
            this.typePackage.TabIndex = 17;
            this.typePackage.Text = "Тип пакета";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 379);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rightPanel);
            this.splitContainer1.Size = new System.Drawing.Size(875, 421);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 18;
            // 
            // stopRequest
            // 
            this.stopRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopRequest.Location = new System.Drawing.Point(173, 349);
            this.stopRequest.Name = "stopRequest";
            this.stopRequest.Size = new System.Drawing.Size(75, 23);
            this.stopRequest.TabIndex = 19;
            this.stopRequest.Text = "Стоп";
            this.stopRequest.UseVisualStyleBackColor = true;
            // 
            // setCount
            // 
            this.setCount.Location = new System.Drawing.Point(173, 301);
            this.setCount.Name = "setCount";
            this.setCount.Size = new System.Drawing.Size(75, 23);
            this.setCount.TabIndex = 20;
            this.setCount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Цикл запросов";
            // 
            // Udmn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 805);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setCount);
            this.Controls.Add(this.stopRequest);
            this.Controls.Add(this.splitContainer1);
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
            this.Controls.Add(this.listTypePackage);
            this.Controls.Add(this.listCOMPorts);
            this.Controls.Add(this.checkCOMPort);
            this.Name = "Udmn";
            this.Text = "УДМН-100";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private Button stopRequest;
        private TextBox setCount;
        private Label label1;
    }
}