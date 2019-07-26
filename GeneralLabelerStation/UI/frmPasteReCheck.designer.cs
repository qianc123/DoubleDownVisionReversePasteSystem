﻿namespace GeneralLabelerStation.UI
{
    partial class frmPasteReCheck
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
            this.dGVMark = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bGoPaste = new System.Windows.Forms.Button();
            this.dGVPaste = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bGoMark2 = new System.Windows.Forms.Button();
            this.bGoMark1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lCur = new System.Windows.Forms.Label();
            this.bPrev = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bUpGrab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bRealPaste = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEnPasteOffset = new System.Windows.Forms.CheckBox();
            this.tPasteOffsetY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tPasteOffsetX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bSetAll = new System.Windows.Forms.Button();
            this.bSetLike = new System.Windows.Forms.Button();
            this.bNeedPaste = new System.Windows.Forms.Button();
            this.bUpdateToFlow = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bFull = new System.Windows.Forms.Button();
            this.bSetToSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tOffsetY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tOffsetX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageSet = new NationalInstruments.Vision.WindowsForms.ImageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMark)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPaste)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVMark
            // 
            this.dGVMark.AllowUserToAddRows = false;
            this.dGVMark.AllowUserToDeleteRows = false;
            this.dGVMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dGVMark.Dock = System.Windows.Forms.DockStyle.Left;
            this.dGVMark.Location = new System.Drawing.Point(0, 0);
            this.dGVMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGVMark.Name = "dGVMark";
            this.dGVMark.ReadOnly = true;
            this.dGVMark.RowHeadersVisible = false;
            this.dGVMark.RowTemplate.Height = 23;
            this.dGVMark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMark.Size = new System.Drawing.Size(300, 201);
            this.dGVMark.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "板号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mark1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mark2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(395, 666);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "识别点位";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bGoPaste);
            this.panel2.Controls.Add(this.dGVPaste);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 225);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 436);
            this.panel2.TabIndex = 3;
            // 
            // bGoPaste
            // 
            this.bGoPaste.Dock = System.Windows.Forms.DockStyle.Top;
            this.bGoPaste.Location = new System.Drawing.Point(326, 0);
            this.bGoPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGoPaste.Name = "bGoPaste";
            this.bGoPaste.Size = new System.Drawing.Size(61, 38);
            this.bGoPaste.TabIndex = 2;
            this.bGoPaste.Text = "到贴附点";
            this.bGoPaste.UseVisualStyleBackColor = true;
            this.bGoPaste.Click += new System.EventHandler(this.bGoPaste_Click);
            // 
            // dGVPaste
            // 
            this.dGVPaste.AllowUserToAddRows = false;
            this.dGVPaste.AllowUserToDeleteRows = false;
            this.dGVPaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPaste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dGVPaste.Dock = System.Windows.Forms.DockStyle.Left;
            this.dGVPaste.Location = new System.Drawing.Point(0, 0);
            this.dGVPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dGVPaste.Name = "dGVPaste";
            this.dGVPaste.ReadOnly = true;
            this.dGVPaste.RowHeadersVisible = false;
            this.dGVPaste.RowTemplate.Height = 23;
            this.dGVPaste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPaste.Size = new System.Drawing.Size(326, 436);
            this.dGVPaste.TabIndex = 1;
            this.dGVPaste.SelectionChanged += new System.EventHandler(this.dGVPaste_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "大板号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "小板号";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 35;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "贴附坐标";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 102;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "吸嘴";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "角度";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 60F;
            this.Column8.HeaderText = "X偏移";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 60F;
            this.Column9.HeaderText = "Y偏移";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bGoMark2);
            this.panel1.Controls.Add(this.bGoMark1);
            this.panel1.Controls.Add(this.dGVMark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 201);
            this.panel1.TabIndex = 2;
            // 
            // bGoMark2
            // 
            this.bGoMark2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bGoMark2.Location = new System.Drawing.Point(300, 38);
            this.bGoMark2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGoMark2.Name = "bGoMark2";
            this.bGoMark2.Size = new System.Drawing.Size(87, 38);
            this.bGoMark2.TabIndex = 2;
            this.bGoMark2.Text = "到Mark2";
            this.bGoMark2.UseVisualStyleBackColor = true;
            this.bGoMark2.Click += new System.EventHandler(this.bGoMark2_Click);
            // 
            // bGoMark1
            // 
            this.bGoMark1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bGoMark1.Location = new System.Drawing.Point(300, 0);
            this.bGoMark1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGoMark1.Name = "bGoMark1";
            this.bGoMark1.Size = new System.Drawing.Size(87, 38);
            this.bGoMark1.TabIndex = 1;
            this.bGoMark1.Text = "到Mark1";
            this.bGoMark1.UseVisualStyleBackColor = true;
            this.bGoMark1.Click += new System.EventHandler(this.bGoMark1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lCur);
            this.panel3.Controls.Add(this.bPrev);
            this.panel3.Controls.Add(this.bNext);
            this.panel3.Controls.Add(this.bUpGrab);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(395, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 42);
            this.panel3.TabIndex = 2;
            // 
            // lCur
            // 
            this.lCur.AutoSize = true;
            this.lCur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lCur.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lCur.Location = new System.Drawing.Point(276, 9);
            this.lCur.Name = "lCur";
            this.lCur.Size = new System.Drawing.Size(196, 25);
            this.lCur.TabIndex = 5;
            this.lCur.Text = "当前第 [1] 板第 [1] 个";
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(483, 7);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(91, 29);
            this.bPrev.TabIndex = 4;
            this.bPrev.Text = "上一个";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(580, 7);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(91, 29);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "下一个";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bUpGrab
            // 
            this.bUpGrab.Location = new System.Drawing.Point(178, 8);
            this.bUpGrab.Name = "bUpGrab";
            this.bUpGrab.Size = new System.Drawing.Size(91, 29);
            this.bUpGrab.TabIndex = 2;
            this.bUpGrab.Text = "上视觉拍照";
            this.bUpGrab.UseVisualStyleBackColor = true;
            this.bUpGrab.Click += new System.EventHandler(this.bUpGrab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(99, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(73, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "坐标系角度:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRealPaste
            // 
            this.bRealPaste.Location = new System.Drawing.Point(19, 72);
            this.bRealPaste.Name = "bRealPaste";
            this.bRealPaste.Size = new System.Drawing.Size(102, 32);
            this.bRealPaste.TabIndex = 5;
            this.bRealPaste.Text = "拾取实际贴附位置";
            this.bRealPaste.UseVisualStyleBackColor = true;
            this.bRealPaste.Click += new System.EventHandler(this.bGetPaste_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.btnRevoke);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Controls.Add(this.bSetAll);
            this.panel4.Controls.Add(this.bSetLike);
            this.panel4.Controls.Add(this.bNeedPaste);
            this.panel4.Controls.Add(this.bUpdateToFlow);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.bFull);
            this.panel4.Controls.Add(this.bSetToSelect);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.bRealPaste);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(879, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 624);
            this.panel4.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEnPasteOffset);
            this.groupBox3.Controls.Add(this.tPasteOffsetY);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tPasteOffsetX);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox3.Location = new System.Drawing.Point(7, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(126, 114);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "贴附无标记时用";
            // 
            // cbEnPasteOffset
            // 
            this.cbEnPasteOffset.AutoSize = true;
            this.cbEnPasteOffset.Location = new System.Drawing.Point(12, 21);
            this.cbEnPasteOffset.Name = "cbEnPasteOffset";
            this.cbEnPasteOffset.Size = new System.Drawing.Size(112, 24);
            this.cbEnPasteOffset.TabIndex = 10;
            this.cbEnPasteOffset.Text = "启用贴附偏差";
            this.cbEnPasteOffset.UseVisualStyleBackColor = true;
            // 
            // tPasteOffsetY
            // 
            this.tPasteOffsetY.Location = new System.Drawing.Point(38, 82);
            this.tPasteOffsetY.Name = "tPasteOffsetY";
            this.tPasteOffsetY.Size = new System.Drawing.Size(68, 26);
            this.tPasteOffsetY.TabIndex = 9;
            this.tPasteOffsetY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // tPasteOffsetX
            // 
            this.tPasteOffsetX.Location = new System.Drawing.Point(38, 49);
            this.tPasteOffsetX.Name = "tPasteOffsetX";
            this.tPasteOffsetX.Size = new System.Drawing.Size(68, 26);
            this.tPasteOffsetX.TabIndex = 7;
            this.tPasteOffsetX.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "X:";
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(9, 440);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(49, 30);
            this.btnRevoke.TabIndex = 22;
            this.btnRevoke.Text = "撤销";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 624);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // bSetAll
            // 
            this.bSetAll.BackColor = System.Drawing.Color.Red;
            this.bSetAll.Location = new System.Drawing.Point(7, 384);
            this.bSetAll.Name = "bSetAll";
            this.bSetAll.Size = new System.Drawing.Size(126, 50);
            this.bSetAll.TabIndex = 20;
            this.bSetAll.Text = "应用到所有(同角度)";
            this.bSetAll.UseVisualStyleBackColor = false;
            this.bSetAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSetLike
            // 
            this.bSetLike.BackColor = System.Drawing.Color.Red;
            this.bSetLike.Location = new System.Drawing.Point(4, 249);
            this.bSetLike.Name = "bSetLike";
            this.bSetLike.Size = new System.Drawing.Size(127, 73);
            this.bSetLike.TabIndex = 18;
            this.bSetLike.Text = "应用到同一种类(吸嘴和角度相同的)";
            this.bSetLike.UseVisualStyleBackColor = false;
            this.bSetLike.Click += new System.EventHandler(this.bSetLike_Click);
            // 
            // bNeedPaste
            // 
            this.bNeedPaste.Location = new System.Drawing.Point(19, 110);
            this.bNeedPaste.Name = "bNeedPaste";
            this.bNeedPaste.Size = new System.Drawing.Size(102, 32);
            this.bNeedPaste.TabIndex = 17;
            this.bNeedPaste.Text = "拾取应该贴附位置";
            this.bNeedPaste.UseVisualStyleBackColor = true;
            this.bNeedPaste.Click += new System.EventHandler(this.bNeedPaste_Click);
            // 
            // bUpdateToFlow
            // 
            this.bUpdateToFlow.BackColor = System.Drawing.Color.Yellow;
            this.bUpdateToFlow.Location = new System.Drawing.Point(4, 590);
            this.bUpdateToFlow.Name = "bUpdateToFlow";
            this.bUpdateToFlow.Size = new System.Drawing.Size(126, 29);
            this.bUpdateToFlow.TabIndex = 16;
            this.bUpdateToFlow.Text = "更新到程式";
            this.bUpdateToFlow.UseVisualStyleBackColor = false;
            this.bUpdateToFlow.Click += new System.EventHandler(this.bUpdateToFlow_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "显示十字架";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bFull
            // 
            this.bFull.BackColor = System.Drawing.Color.Yellow;
            this.bFull.Location = new System.Drawing.Point(26, 6);
            this.bFull.Name = "bFull";
            this.bFull.Size = new System.Drawing.Size(95, 29);
            this.bFull.TabIndex = 14;
            this.bFull.Text = "Full";
            this.bFull.UseVisualStyleBackColor = false;
            this.bFull.Click += new System.EventHandler(this.bFull_Click);
            // 
            // bSetToSelect
            // 
            this.bSetToSelect.BackColor = System.Drawing.Color.Red;
            this.bSetToSelect.Location = new System.Drawing.Point(4, 328);
            this.bSetToSelect.Name = "bSetToSelect";
            this.bSetToSelect.Size = new System.Drawing.Size(126, 50);
            this.bSetToSelect.TabIndex = 13;
            this.bSetToSelect.Text = "应用到已选择贴附位";
            this.bSetToSelect.UseVisualStyleBackColor = false;
            this.bSetToSelect.Click += new System.EventHandler(this.bSetToSelect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tOffsetY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tOffsetX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "误差";
            // 
            // tOffsetY
            // 
            this.tOffsetY.Location = new System.Drawing.Point(38, 58);
            this.tOffsetY.Name = "tOffsetY";
            this.tOffsetY.Size = new System.Drawing.Size(68, 26);
            this.tOffsetY.TabIndex = 9;
            this.tOffsetY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y:";
            // 
            // tOffsetX
            // 
            this.tOffsetX.Location = new System.Drawing.Point(38, 25);
            this.tOffsetX.Name = "tOffsetX";
            this.tOffsetX.Size = new System.Drawing.Size(68, 26);
            this.tOffsetX.TabIndex = 7;
            this.tOffsetX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "X:";
            // 
            // imageSet
            // 
            this.imageSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSet.Location = new System.Drawing.Point(395, 42);
            this.imageSet.Margin = new System.Windows.Forms.Padding(0);
            this.imageSet.Name = "imageSet";
            this.imageSet.ShowImageInfo = true;
            this.imageSet.ShowToolbar = true;
            this.imageSet.Size = new System.Drawing.Size(484, 624);
            this.imageSet.TabIndex = 295;
            this.imageSet.ImageMouseDown += new System.EventHandler<NationalInstruments.Vision.WindowsForms.ImageMouseEventArgs>(this.imageSet_ImageMouseDown);
            this.imageSet.ImageMouseMove += new System.EventHandler<NationalInstruments.Vision.WindowsForms.ImageMouseEventArgs>(this.imageSet_ImageMouseMove);
            this.imageSet.Resize += new System.EventHandler(this.imageSet_Resize);
            // 
            // frmPasteReCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 666);
            this.Controls.Add(this.imageSet);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPasteReCheck";
            this.Text = "回看";
            this.Load += new System.EventHandler(this.frmPasteReCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMark)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPaste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bGoPaste;
        private System.Windows.Forms.DataGridView dGVPaste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bGoMark2;
        private System.Windows.Forms.Button bGoMark1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bUpGrab;
        private System.Windows.Forms.Button bPrev;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bRealPaste;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tOffsetY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tOffsetX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bSetToSelect;
        public NationalInstruments.Vision.WindowsForms.ImageViewer imageSet;
        private System.Windows.Forms.Label lCur;
        private System.Windows.Forms.Button bFull;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bUpdateToFlow;
        private System.Windows.Forms.Button bNeedPaste;
        private System.Windows.Forms.Button bSetLike;
        private System.Windows.Forms.Button bSetAll;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tPasteOffsetY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tPasteOffsetX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbEnPasteOffset;
    }
}