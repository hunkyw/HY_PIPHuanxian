namespace HY_PIP
{
    partial class NewProcessForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProcessForm));
            this.panelX = new System.Windows.Forms.Panel();
            this.rowMergeView1 = new HY_PIP.RowMergeView(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNewProcess = new System.Windows.Forms.Button();
            this.buttonDeleteProcess = new System.Windows.Forms.Button();
            this.buttonUpdateProcess = new System.Windows.Forms.Button();
            this.pictureBoxProcessImport = new System.Windows.Forms.PictureBox();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessExport = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessExport)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelX
            // 
            this.panelX.AutoScroll = true;
            this.panelX.AutoSize = true;
            this.panelX.Controls.Add(this.panel2);
            this.panelX.Controls.Add(this.rowMergeView1);
            this.panelX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelX.Location = new System.Drawing.Point(0, 0);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(1354, 733);
            this.panelX.TabIndex = 64;
            // 
            // rowMergeView1
            // 
            this.rowMergeView1.AllowUserToAddRows = false;
            this.rowMergeView1.AllowUserToDeleteRows = false;
            this.rowMergeView1.AllowUserToResizeColumns = false;
            this.rowMergeView1.AllowUserToResizeRows = false;
            this.rowMergeView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rowMergeView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rowMergeView1.ColumnHeadersHeight = 80;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rowMergeView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.rowMergeView1.Location = new System.Drawing.Point(10, -75);
            this.rowMergeView1.Margin = new System.Windows.Forms.Padding(10);
            this.rowMergeView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.rowMergeView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rowMergeView1.MergeColumnNames")));
            this.rowMergeView1.MultiSelect = false;
            this.rowMergeView1.Name = "rowMergeView1";
            this.rowMergeView1.ReadOnly = true;
            this.rowMergeView1.RowHeadersVisible = false;
            this.rowMergeView1.RowTemplate.Height = 30;
            this.rowMergeView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rowMergeView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rowMergeView1.ShowCellToolTips = false;
            this.rowMergeView1.Size = new System.Drawing.Size(1370, 486);
            this.rowMergeView1.TabIndex = 54;
            this.rowMergeView1.SelectionChanged += new System.EventHandler(this.rowMergeView1_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBoxProcessExport);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxProcessName);
            this.panel1.Controls.Add(this.pictureBoxProcessImport);
            this.panel1.Controls.Add(this.buttonUpdateProcess);
            this.panel1.Controls.Add(this.buttonDeleteProcess);
            this.panel1.Controls.Add(this.buttonNewProcess);
            this.panel1.Controls.Add(this.buttonPrev);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 558);
            this.panel1.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HY_PIP.Properties.Resources.NewProcessBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNext.Location = new System.Drawing.Point(851, 113);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(275, 104);
            this.buttonNext.TabIndex = 100;
            this.buttonNext.Text = "下一条工艺";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPrev.Location = new System.Drawing.Point(851, 1);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(275, 104);
            this.buttonPrev.TabIndex = 101;
            this.buttonPrev.Text = "上一条工艺";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonNewProcess
            // 
            this.buttonNewProcess.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNewProcess.Location = new System.Drawing.Point(851, 225);
            this.buttonNewProcess.Name = "buttonNewProcess";
            this.buttonNewProcess.Size = new System.Drawing.Size(275, 104);
            this.buttonNewProcess.TabIndex = 102;
            this.buttonNewProcess.Text = "新增工艺";
            this.buttonNewProcess.UseVisualStyleBackColor = true;
            this.buttonNewProcess.Click += new System.EventHandler(this.buttonNewProcess_Click);
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDeleteProcess.Location = new System.Drawing.Point(851, 337);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(275, 104);
            this.buttonDeleteProcess.TabIndex = 103;
            this.buttonDeleteProcess.Text = "删除工艺";
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteProcess.Click += new System.EventHandler(this.buttonDeleteProcess_Click);
            // 
            // buttonUpdateProcess
            // 
            this.buttonUpdateProcess.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUpdateProcess.Location = new System.Drawing.Point(851, 449);
            this.buttonUpdateProcess.Name = "buttonUpdateProcess";
            this.buttonUpdateProcess.Size = new System.Drawing.Size(275, 104);
            this.buttonUpdateProcess.TabIndex = 104;
            this.buttonUpdateProcess.Text = "修改工艺";
            this.buttonUpdateProcess.UseVisualStyleBackColor = true;
            this.buttonUpdateProcess.Click += new System.EventHandler(this.buttonUpdateProcess_Click);
            // 
            // pictureBoxProcessImport
            // 
            this.pictureBoxProcessImport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxProcessImport.ErrorImage = global::HY_PIP.Properties.Resources.daorugongyi;
            this.pictureBoxProcessImport.Image = global::HY_PIP.Properties.Resources.daorugongyi;
            this.pictureBoxProcessImport.Location = new System.Drawing.Point(36, 290);
            this.pictureBoxProcessImport.Name = "pictureBoxProcessImport";
            this.pictureBoxProcessImport.Size = new System.Drawing.Size(179, 50);
            this.pictureBoxProcessImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessImport.TabIndex = 63;
            this.pictureBoxProcessImport.TabStop = false;
            this.pictureBoxProcessImport.Click += new System.EventHandler(this.pictureBoxProcessImport_Click);
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProcessName.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxProcessName.Location = new System.Drawing.Point(151, 45);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(110, 22);
            this.textBoxProcessName.TabIndex = 61;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Image = global::HY_PIP.Properties.Resources.xinzengzhiwen;
            this.pictureBox2.Location = new System.Drawing.Point(36, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxProcessExport
            // 
            this.pictureBoxProcessExport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxProcessExport.ErrorImage = null;
            this.pictureBoxProcessExport.Image = global::HY_PIP.Properties.Resources.daochugongyi;
            this.pictureBoxProcessExport.Location = new System.Drawing.Point(36, 225);
            this.pictureBoxProcessExport.Name = "pictureBoxProcessExport";
            this.pictureBoxProcessExport.Size = new System.Drawing.Size(179, 50);
            this.pictureBoxProcessExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessExport.TabIndex = 62;
            this.pictureBoxProcessExport.TabStop = false;
            this.pictureBoxProcessExport.Click += new System.EventHandler(this.pictureBoxProcessExport_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(107, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 575);
            this.panel2.TabIndex = 64;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(318, 449);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 22);
            this.pictureBox3.TabIndex = 105;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(318, 487);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 25);
            this.pictureBox4.TabIndex = 106;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(318, 526);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 107;
            this.pictureBox5.TabStop = false;
            // 
            // NewProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panelX);
            this.Name = "NewProcessForm";
            this.Text = "NewProcessForm";
            this.Load += new System.EventHandler(this.NewProcessForm_Load);
            this.panelX.ResumeLayout(false);
            this.panelX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessExport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RowMergeView rowMergeView1;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxProcessExport;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxProcessName;
        private System.Windows.Forms.PictureBox pictureBoxProcessImport;
        private System.Windows.Forms.Button buttonUpdateProcess;
        private System.Windows.Forms.Button buttonDeleteProcess;
        private System.Windows.Forms.Button buttonNewProcess;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}