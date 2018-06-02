namespace HY_PIP
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLoadData = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPotrait = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWarnning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxEStop = new System.Windows.Forms.PictureBox();
            this.comboBoxCarrierName = new System.Windows.Forms.ComboBox();
            this.comboBoxProcessName = new System.Windows.Forms.ComboBox();
            this.labelPersonPosition = new System.Windows.Forms.Label();
            this.labelPersonJobNumber = new System.Windows.Forms.Label();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelX = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layoutDrawing1 = new LayoutDrawing();
            this.temperature121 = new System.Windows.Forms.Label();
            this.temperature111 = new System.Windows.Forms.Label();
            this.temperature10 = new System.Windows.Forms.Label();
            this.temperature71 = new System.Windows.Forms.Label();
            this.temperature61 = new System.Windows.Forms.Label();
            this.temperature51 = new System.Windows.Forms.Label();
            this.temperature41 = new System.Windows.Forms.Label();
            this.temperature3 = new System.Windows.Forms.Label();
            this.temperature1 = new System.Windows.Forms.Label();
            this.processPanelCtrl1 = new HY_PIP.ProcessPanelCtrl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotrait)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEStop)).BeginInit();
            this.panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutDrawing1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLoadData
            // 
            this.timerLoadData.Tick += new System.EventHandler(this.timerLoadData_Tick);
            // 
            // pictureBoxPotrait
            // 
            this.pictureBoxPotrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxPotrait.Image = global::HY_PIP.Properties.Resources.portrait;
            this.pictureBoxPotrait.Location = new System.Drawing.Point(10, 49);
            this.pictureBoxPotrait.Name = "pictureBoxPotrait";
            this.pictureBoxPotrait.Size = new System.Drawing.Size(110, 127);
            this.pictureBoxPotrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPotrait.TabIndex = 23;
            this.pictureBoxPotrait.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.BackgroundImage = global::HY_PIP.Properties.Resources.panel1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelWarnning);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBoxLock);
            this.panel1.Controls.Add(this.pictureBoxStart);
            this.panel1.Controls.Add(this.pictureBoxEStop);
            this.panel1.Controls.Add(this.comboBoxCarrierName);
            this.panel1.Controls.Add(this.comboBoxProcessName);
            this.panel1.Controls.Add(this.labelPersonPosition);
            this.panel1.Controls.Add(this.labelPersonJobNumber);
            this.panel1.Controls.Add(this.labelPersonName);
            this.panel1.Controls.Add(this.pictureBoxPotrait);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 565);
            this.panel1.TabIndex = 24;
            // 
            // labelWarnning
            // 
            this.labelWarnning.AutoSize = true;
            this.labelWarnning.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarnning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWarnning.Location = new System.Drawing.Point(3, 534);
            this.labelWarnning.Name = "labelWarnning";
            this.labelWarnning.Size = new System.Drawing.Size(71, 26);
            this.labelWarnning.TabIndex = 38;
            this.labelWarnning.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(231, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.Image = global::HY_PIP.Properties.Resources._lock;
            this.pictureBoxLock.Location = new System.Drawing.Point(327, 117);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(127, 69);
            this.pictureBoxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLock.TabIndex = 34;
            this.pictureBoxLock.TabStop = false;
            this.pictureBoxLock.Click += new System.EventHandler(this.pictureBoxLock_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = global::HY_PIP.Properties.Resources.start;
            this.pictureBoxStart.Location = new System.Drawing.Point(275, 249);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(81, 39);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStart.TabIndex = 33;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStart_Click);
            // 
            // pictureBoxEStop
            // 
            this.pictureBoxEStop.Image = global::HY_PIP.Properties.Resources.estop_up;
            this.pictureBoxEStop.Location = new System.Drawing.Point(327, 3);
            this.pictureBoxEStop.Name = "pictureBoxEStop";
            this.pictureBoxEStop.Size = new System.Drawing.Size(127, 69);
            this.pictureBoxEStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEStop.TabIndex = 32;
            this.pictureBoxEStop.TabStop = false;
            this.pictureBoxEStop.Click += new System.EventHandler(this.pictureBoxEStop_Click);
            // 
            // comboBoxCarrierName
            // 
            this.comboBoxCarrierName.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCarrierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarrierName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCarrierName.FormattingEnabled = true;
            this.comboBoxCarrierName.ItemHeight = 21;
            this.comboBoxCarrierName.Location = new System.Drawing.Point(112, 230);
            this.comboBoxCarrierName.Name = "comboBoxCarrierName";
            this.comboBoxCarrierName.Size = new System.Drawing.Size(157, 29);
            this.comboBoxCarrierName.TabIndex = 31;
            // 
            // comboBoxProcessName
            // 
            this.comboBoxProcessName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxProcessName.FormattingEnabled = true;
            this.comboBoxProcessName.ItemHeight = 21;
            this.comboBoxProcessName.Location = new System.Drawing.Point(112, 259);
            this.comboBoxProcessName.Name = "comboBoxProcessName";
            this.comboBoxProcessName.Size = new System.Drawing.Size(157, 29);
            this.comboBoxProcessName.TabIndex = 24;
            // 
            // labelPersonPosition
            // 
            this.labelPersonPosition.AutoSize = true;
            this.labelPersonPosition.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPersonPosition.ForeColor = System.Drawing.Color.White;
            this.labelPersonPosition.Location = new System.Drawing.Point(148, 132);
            this.labelPersonPosition.Name = "labelPersonPosition";
            this.labelPersonPosition.Size = new System.Drawing.Size(126, 25);
            this.labelPersonPosition.TabIndex = 30;
            this.labelPersonPosition.Text = "岗位：技术员";
            // 
            // labelPersonJobNumber
            // 
            this.labelPersonJobNumber.AutoSize = true;
            this.labelPersonJobNumber.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPersonJobNumber.ForeColor = System.Drawing.Color.White;
            this.labelPersonJobNumber.Location = new System.Drawing.Point(148, 100);
            this.labelPersonJobNumber.Name = "labelPersonJobNumber";
            this.labelPersonJobNumber.Size = new System.Drawing.Size(124, 25);
            this.labelPersonJobNumber.TabIndex = 29;
            this.labelPersonJobNumber.Text = "工号：25736";
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPersonName.ForeColor = System.Drawing.Color.White;
            this.labelPersonName.Location = new System.Drawing.Point(148, 70);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(107, 25);
            this.labelPersonName.TabIndex = 28;
            this.labelPersonName.Text = "姓名：王兵";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelX
            // 
            this.panelX.AutoScroll = true;
            this.panelX.Controls.Add(this.pictureBox3);
            this.panelX.Controls.Add(this.pictureBox2);
            this.panelX.Controls.Add(this.pictureBox1);
            this.panelX.Controls.Add(this.panel1);
            this.panelX.Controls.Add(this.layoutDrawing1);
            this.panelX.Controls.Add(this.processPanelCtrl1);
            this.panelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelX.Location = new System.Drawing.Point(0, 0);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(1386, 772);
            this.panelX.TabIndex = 26;
            this.panelX.Paint += new System.Windows.Forms.PaintEventHandler(this.panelX_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(502, 514);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 22);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 474);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 25);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 23);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // layoutDrawing1
            // 
            this.layoutDrawing1.Controls.Add(this.temperature121);
            this.layoutDrawing1.Controls.Add(this.temperature111);
            this.layoutDrawing1.Controls.Add(this.temperature10);
            this.layoutDrawing1.Controls.Add(this.temperature71);
            this.layoutDrawing1.Controls.Add(this.temperature61);
            this.layoutDrawing1.Controls.Add(this.temperature51);
            this.layoutDrawing1.Controls.Add(this.temperature41);
            this.layoutDrawing1.Controls.Add(this.temperature3);
            this.layoutDrawing1.Controls.Add(this.temperature1);
            this.layoutDrawing1.Location = new System.Drawing.Point(3, 576);
            this.layoutDrawing1.Name = "layoutDrawing1";
            this.layoutDrawing1.Size = new System.Drawing.Size(1920, 450);
            this.layoutDrawing1.TabIndex = 12;
            // 
            // temperature121
            // 
            this.temperature121.AutoSize = true;
            this.temperature121.BackColor = System.Drawing.Color.Transparent;
            this.temperature121.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature121.ForeColor = System.Drawing.Color.Red;
            this.temperature121.Location = new System.Drawing.Point(1389, 387);
            this.temperature121.Name = "temperature121";
            this.temperature121.Size = new System.Drawing.Size(60, 19);
            this.temperature121.TabIndex = 8;
            this.temperature121.Text = "label10";
            // 
            // temperature111
            // 
            this.temperature111.AutoSize = true;
            this.temperature111.BackColor = System.Drawing.Color.Transparent;
            this.temperature111.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature111.ForeColor = System.Drawing.Color.Red;
            this.temperature111.Location = new System.Drawing.Point(1299, 387);
            this.temperature111.Name = "temperature111";
            this.temperature111.Size = new System.Drawing.Size(51, 19);
            this.temperature111.TabIndex = 7;
            this.temperature111.Text = "label9";
            // 
            // temperature10
            // 
            this.temperature10.AutoSize = true;
            this.temperature10.BackColor = System.Drawing.Color.Transparent;
            this.temperature10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature10.ForeColor = System.Drawing.Color.Red;
            this.temperature10.Location = new System.Drawing.Point(1162, 387);
            this.temperature10.Name = "temperature10";
            this.temperature10.Size = new System.Drawing.Size(51, 19);
            this.temperature10.TabIndex = 6;
            this.temperature10.Text = "label8";
            // 
            // temperature71
            // 
            this.temperature71.AutoSize = true;
            this.temperature71.BackColor = System.Drawing.Color.Transparent;
            this.temperature71.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature71.ForeColor = System.Drawing.Color.Red;
            this.temperature71.Location = new System.Drawing.Point(857, 387);
            this.temperature71.Name = "temperature71";
            this.temperature71.Size = new System.Drawing.Size(51, 19);
            this.temperature71.TabIndex = 5;
            this.temperature71.Text = "label7";
            // 
            // temperature61
            // 
            this.temperature61.AutoSize = true;
            this.temperature61.BackColor = System.Drawing.Color.Transparent;
            this.temperature61.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature61.ForeColor = System.Drawing.Color.Red;
            this.temperature61.Location = new System.Drawing.Point(764, 387);
            this.temperature61.Name = "temperature61";
            this.temperature61.Size = new System.Drawing.Size(51, 19);
            this.temperature61.TabIndex = 4;
            this.temperature61.Text = "label6";
            // 
            // temperature51
            // 
            this.temperature51.AutoSize = true;
            this.temperature51.BackColor = System.Drawing.Color.Transparent;
            this.temperature51.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature51.ForeColor = System.Drawing.Color.Red;
            this.temperature51.Location = new System.Drawing.Point(671, 387);
            this.temperature51.Name = "temperature51";
            this.temperature51.Size = new System.Drawing.Size(51, 19);
            this.temperature51.TabIndex = 3;
            this.temperature51.Text = "label5";
            // 
            // temperature41
            // 
            this.temperature41.AutoSize = true;
            this.temperature41.BackColor = System.Drawing.Color.Transparent;
            this.temperature41.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature41.ForeColor = System.Drawing.Color.Red;
            this.temperature41.Location = new System.Drawing.Point(574, 387);
            this.temperature41.Name = "temperature41";
            this.temperature41.Size = new System.Drawing.Size(51, 19);
            this.temperature41.TabIndex = 2;
            this.temperature41.Text = "label4";
            // 
            // temperature3
            // 
            this.temperature3.AutoSize = true;
            this.temperature3.BackColor = System.Drawing.Color.Transparent;
            this.temperature3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature3.ForeColor = System.Drawing.Color.Red;
            this.temperature3.Location = new System.Drawing.Point(489, 387);
            this.temperature3.Name = "temperature3";
            this.temperature3.Size = new System.Drawing.Size(51, 19);
            this.temperature3.TabIndex = 1;
            this.temperature3.Text = "label3";
            // 
            // temperature1
            // 
            this.temperature1.AutoSize = true;
            this.temperature1.BackColor = System.Drawing.Color.Transparent;
            this.temperature1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temperature1.ForeColor = System.Drawing.Color.Red;
            this.temperature1.Location = new System.Drawing.Point(348, 384);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(51, 19);
            this.temperature1.TabIndex = 0;
            this.temperature1.Text = "label2";
            // 
            // processPanelCtrl1
            // 
            this.processPanelCtrl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processPanelCtrl1.BackgroundImage")));
            this.processPanelCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processPanelCtrl1.Location = new System.Drawing.Point(472, 3);
            this.processPanelCtrl1.Margin = new System.Windows.Forms.Padding(0);
            this.processPanelCtrl1.Name = "processPanelCtrl1";
            this.processPanelCtrl1.Size = new System.Drawing.Size(1412, 560);
            this.processPanelCtrl1.TabIndex = 25;
            this.processPanelCtrl1.workGroup = null;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 21);
            this.textBox2.TabIndex = 39;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 772);
            this.Controls.Add(this.panelX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "红宇新材 PIP生产线";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotrait)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEStop)).EndInit();
            this.panelX.ResumeLayout(false);
            this.panelX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutDrawing1.ResumeLayout(false);
            this.layoutDrawing1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerLoadData;
        private System.Windows.Forms.PictureBox pictureBoxPotrait;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxProcessName;
        private System.Windows.Forms.Label labelPersonPosition;
        private System.Windows.Forms.Label labelPersonJobNumber;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.ComboBox comboBoxCarrierName;
        private ProcessPanelCtrl processPanelCtrl1;
        private System.Windows.Forms.PictureBox pictureBoxEStop;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBoxLock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelX;
        private LayoutDrawing layoutDrawing1;
        private System.Windows.Forms.Label labelWarnning;
        private System.Windows.Forms.Label temperature121;
        private System.Windows.Forms.Label temperature111;
        private System.Windows.Forms.Label temperature10;
        private System.Windows.Forms.Label temperature71;
        private System.Windows.Forms.Label temperature61;
        private System.Windows.Forms.Label temperature51;
        private System.Windows.Forms.Label temperature41;
        private System.Windows.Forms.Label temperature3;
        private System.Windows.Forms.Label temperature1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

