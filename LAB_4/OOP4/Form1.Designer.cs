namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInbox = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Inbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabToday = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColTod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.InputField = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMen = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMen = new System.Windows.Forms.ToolStripMenuItem();
            this.DateMen = new System.Windows.Forms.ToolStripMenuItem();
            this.Datebox = new System.Windows.Forms.ToolStripTextBox();
            this.applyDatebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeMen = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeBox = new System.Windows.Forms.ToolStripTextBox();
            this.ApllyTimebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBox = new System.Windows.Forms.ToolStripTextBox();
            this.EditApplBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editBtn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nameBx2 = new System.Windows.Forms.ToolStripTextBox();
            this.dateBx2 = new System.Windows.Forms.ToolStripTextBox();
            this.timeBx2 = new System.Windows.Forms.ToolStripTextBox();
            this.applBtn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.delBtn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.projBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delbtn3 = new System.Windows.Forms.ToolStripMenuItem();
            this.addEv = new System.Windows.Forms.ToolStripMenuItem();
            this.datebtnEv3 = new System.Windows.Forms.ToolStripTextBox();
            this.timebtnEv3 = new System.Windows.Forms.ToolStripTextBox();
            this.applybtnEv3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ditbtn3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editFld3 = new System.Windows.Forms.ToolStripTextBox();
            this.aplEdit3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateBx = new System.Windows.Forms.MaskedTextBox();
            this.timeBx = new System.Windows.Forms.MaskedTextBox();
            this.serbtn = new System.Windows.Forms.Button();
            this.Deserbtn = new System.Windows.Forms.Button();
            this.archBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabInbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabProjects.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInbox);
            this.tabControl1.Controls.Add(this.tabToday);
            this.tabControl1.Controls.Add(this.tabProjects);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(5, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInbox
            // 
            this.tabInbox.AutoScroll = true;
            this.tabInbox.BackColor = System.Drawing.Color.DarkGray;
            this.tabInbox.Controls.Add(this.dataGridView1);
            this.tabInbox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabInbox.Location = new System.Drawing.Point(4, 22);
            this.tabInbox.Margin = new System.Windows.Forms.Padding(0);
            this.tabInbox.Name = "tabInbox";
            this.tabInbox.Size = new System.Drawing.Size(786, 389);
            this.tabInbox.TabIndex = 0;
            this.tabInbox.Text = "Inbox";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inbox});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // Inbox
            // 
            this.Inbox.Frozen = true;
            this.Inbox.HeaderText = "Inbox";
            this.Inbox.Name = "Inbox";
            this.Inbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Inbox.Width = 800;
            // 
            // tabToday
            // 
            this.tabToday.BackColor = System.Drawing.Color.DarkGray;
            this.tabToday.Controls.Add(this.dataGridView2);
            this.tabToday.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabToday.Location = new System.Drawing.Point(4, 22);
            this.tabToday.Name = "tabToday";
            this.tabToday.Padding = new System.Windows.Forms.Padding(3);
            this.tabToday.Size = new System.Drawing.Size(786, 389);
            this.tabToday.TabIndex = 1;
            this.tabToday.Text = "Event";
            this.tabToday.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTod,
            this.Time,
            this.Date});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(801, 384);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.UseWaitCursor = true;
            // 
            // ColTod
            // 
            this.ColTod.Frozen = true;
            this.ColTod.HeaderText = "Today";
            this.ColTod.Name = "ColTod";
            this.ColTod.ReadOnly = true;
            this.ColTod.Width = 550;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // tabProjects
            // 
            this.tabProjects.BackColor = System.Drawing.Color.DarkGray;
            this.tabProjects.Controls.Add(this.treeView1);
            this.tabProjects.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(786, 389);
            this.tabProjects.TabIndex = 2;
            this.tabProjects.Text = "Projects";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(792, 384);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputField
            // 
            this.InputField.BackColor = System.Drawing.SystemColors.Control;
            this.InputField.Location = new System.Drawing.Point(47, 13);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(293, 20);
            this.InputField.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Task",
            "Today",
            "Project",
            "Event",
            "Sub Task"});
            this.comboBox1.Location = new System.Drawing.Point(371, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMen,
            this.DelMen,
            this.DateMen,
            this.TimeMen,
            this.editItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 114);
            // 
            // AddMen
            // 
            this.AddMen.Name = "AddMen";
            this.AddMen.Size = new System.Drawing.Size(159, 22);
            this.AddMen.Text = "Add to project...";
            this.AddMen.Click += new System.EventHandler(this.AddMen_Click);
            // 
            // DelMen
            // 
            this.DelMen.Name = "DelMen";
            this.DelMen.Size = new System.Drawing.Size(159, 22);
            this.DelMen.Text = "Delete";
            this.DelMen.Click += new System.EventHandler(this.DelMen_Click);
            // 
            // DateMen
            // 
            this.DateMen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datebox,
            this.applyDatebtn});
            this.DateMen.Name = "DateMen";
            this.DateMen.Size = new System.Drawing.Size(159, 22);
            this.DateMen.Text = "Add date";
            // 
            // Datebox
            // 
            this.Datebox.Name = "Datebox";
            this.Datebox.Size = new System.Drawing.Size(100, 23);
            this.Datebox.Text = "Enter date...";
            this.Datebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Datebox_KeyPress);
            this.Datebox.Click += new System.EventHandler(this.Datebox_Click);
            // 
            // applyDatebtn
            // 
            this.applyDatebtn.Name = "applyDatebtn";
            this.applyDatebtn.Size = new System.Drawing.Size(160, 22);
            this.applyDatebtn.Text = "Apply";
            this.applyDatebtn.Click += new System.EventHandler(this.applyDatebtn_Click);
            // 
            // TimeMen
            // 
            this.TimeMen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeBox,
            this.ApllyTimebtn});
            this.TimeMen.Name = "TimeMen";
            this.TimeMen.Size = new System.Drawing.Size(159, 22);
            this.TimeMen.Text = "Add time";
            // 
            // TimeBox
            // 
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 23);
            this.TimeBox.Text = "Enter time...";
            this.TimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeBox_KeyPress);
            this.TimeBox.Click += new System.EventHandler(this.TimeBox_Click);
            // 
            // ApllyTimebtn
            // 
            this.ApllyTimebtn.Name = "ApllyTimebtn";
            this.ApllyTimebtn.Size = new System.Drawing.Size(160, 22);
            this.ApllyTimebtn.Text = "Apply";
            this.ApllyTimebtn.Click += new System.EventHandler(this.ApllyTimebtn_Click);
            // 
            // editItem
            // 
            this.editItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBox,
            this.EditApplBtn});
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(159, 22);
            this.editItem.Text = "Edit Item...";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // editBox
            // 
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(100, 23);
            // 
            // EditApplBtn
            // 
            this.EditApplBtn.Name = "EditApplBtn";
            this.EditApplBtn.Size = new System.Drawing.Size(160, 22);
            this.EditApplBtn.Text = "Apply";
            this.EditApplBtn.Click += new System.EventHandler(this.EditApplBtn_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBtn2,
            this.delBtn2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(108, 48);
            // 
            // editBtn2
            // 
            this.editBtn2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameBx2,
            this.dateBx2,
            this.timeBx2,
            this.applBtn2});
            this.editBtn2.Name = "editBtn2";
            this.editBtn2.Size = new System.Drawing.Size(107, 22);
            this.editBtn2.Text = "Edit...";
            this.editBtn2.Click += new System.EventHandler(this.editBtn2_Click);
            // 
            // nameBx2
            // 
            this.nameBx2.Name = "nameBx2";
            this.nameBx2.Size = new System.Drawing.Size(100, 23);
            this.nameBx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBx2_KeyPress);
            // 
            // dateBx2
            // 
            this.dateBx2.Name = "dateBx2";
            this.dateBx2.Size = new System.Drawing.Size(100, 23);
            this.dateBx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBx2_KeyPress);
            // 
            // timeBx2
            // 
            this.timeBx2.Name = "timeBx2";
            this.timeBx2.Size = new System.Drawing.Size(100, 23);
            this.timeBx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBx2_KeyPress);
            // 
            // applBtn2
            // 
            this.applBtn2.Name = "applBtn2";
            this.applBtn2.Size = new System.Drawing.Size(160, 22);
            this.applBtn2.Text = "Apply";
            this.applBtn2.Click += new System.EventHandler(this.applBtn2_Click);
            // 
            // delBtn2
            // 
            this.delBtn2.Name = "delBtn2";
            this.delBtn2.Size = new System.Drawing.Size(107, 22);
            this.delBtn2.Text = "Delete";
            this.delBtn2.Click += new System.EventHandler(this.delBtn2_Click);
            // 
            // projBox
            // 
            this.projBox.FormattingEnabled = true;
            this.projBox.Location = new System.Drawing.Point(538, 13);
            this.projBox.Name = "projBox";
            this.projBox.Size = new System.Drawing.Size(121, 21);
            this.projBox.TabIndex = 1;
            this.projBox.Text = "Choose Project...";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delbtn3,
            this.addEv,
            this.ditbtn3});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(148, 70);
            // 
            // delbtn3
            // 
            this.delbtn3.Name = "delbtn3";
            this.delbtn3.Size = new System.Drawing.Size(147, 22);
            this.delbtn3.Text = "Delete";
            this.delbtn3.Click += new System.EventHandler(this.delbtn3_Click);
            // 
            // addEv
            // 
            this.addEv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datebtnEv3,
            this.timebtnEv3,
            this.applybtnEv3});
            this.addEv.Name = "addEv";
            this.addEv.Size = new System.Drawing.Size(147, 22);
            this.addEv.Text = "Add to Events";
            // 
            // datebtnEv3
            // 
            this.datebtnEv3.Name = "datebtnEv3";
            this.datebtnEv3.Size = new System.Drawing.Size(100, 23);
            this.datebtnEv3.Text = "Enter date";
            this.datebtnEv3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datebtnEv3_KeyPress);
            this.datebtnEv3.Click += new System.EventHandler(this.datebtnEv3_Click);
            // 
            // timebtnEv3
            // 
            this.timebtnEv3.Name = "timebtnEv3";
            this.timebtnEv3.Size = new System.Drawing.Size(100, 23);
            this.timebtnEv3.Text = "Enter time";
            this.timebtnEv3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timebtnEv3_KeyPress);
            this.timebtnEv3.Click += new System.EventHandler(this.timebtnEv3_Click);
            // 
            // applybtnEv3
            // 
            this.applybtnEv3.DoubleClickEnabled = true;
            this.applybtnEv3.Name = "applybtnEv3";
            this.applybtnEv3.Size = new System.Drawing.Size(160, 22);
            this.applybtnEv3.Text = "Apply";
            this.applybtnEv3.Click += new System.EventHandler(this.applybtnEv3_Click);
            // 
            // ditbtn3
            // 
            this.ditbtn3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFld3,
            this.aplEdit3});
            this.ditbtn3.Name = "ditbtn3";
            this.ditbtn3.Size = new System.Drawing.Size(147, 22);
            this.ditbtn3.Text = "Edit...";
            this.ditbtn3.Click += new System.EventHandler(this.ditbtn3_Click);
            // 
            // editFld3
            // 
            this.editFld3.Name = "editFld3";
            this.editFld3.Size = new System.Drawing.Size(100, 23);
            // 
            // aplEdit3
            // 
            this.aplEdit3.Name = "aplEdit3";
            this.aplEdit3.Size = new System.Drawing.Size(160, 22);
            this.aplEdit3.Text = "Apply";
            this.aplEdit3.Click += new System.EventHandler(this.aplEdit3_Click);
            // 
            // dateBx
            // 
            this.dateBx.Location = new System.Drawing.Point(538, 14);
            this.dateBx.Name = "dateBx";
            this.dateBx.Size = new System.Drawing.Size(100, 20);
            this.dateBx.TabIndex = 2;
            this.dateBx.Text = "Enter date...";
            this.dateBx.Visible = false;
            this.dateBx.Click += new System.EventHandler(this.dateBx_Click);
            // 
            // timeBx
            // 
            this.timeBx.Location = new System.Drawing.Point(665, 14);
            this.timeBx.Name = "timeBx";
            this.timeBx.Size = new System.Drawing.Size(100, 20);
            this.timeBx.TabIndex = 1;
            this.timeBx.Text = "Enter time...";
            this.timeBx.Visible = false;
            this.timeBx.Click += new System.EventHandler(this.timeBx_Click);
            // 
            // serbtn
            // 
            this.serbtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.serbtn.Location = new System.Drawing.Point(173, 39);
            this.serbtn.Name = "serbtn";
            this.serbtn.Size = new System.Drawing.Size(77, 30);
            this.serbtn.TabIndex = 4;
            this.serbtn.Text = "Serialize";
            this.serbtn.UseVisualStyleBackColor = true;
            this.serbtn.Click += new System.EventHandler(this.serbtn_Click);
            // 
            // Deserbtn
            // 
            this.Deserbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deserbtn.Location = new System.Drawing.Point(256, 41);
            this.Deserbtn.Name = "Deserbtn";
            this.Deserbtn.Size = new System.Drawing.Size(76, 28);
            this.Deserbtn.TabIndex = 5;
            this.Deserbtn.Text = "Deserialize";
            this.Deserbtn.UseVisualStyleBackColor = true;
            this.Deserbtn.Click += new System.EventHandler(this.Deserbtn_Click);
            // 
            // archBox
            // 
            this.archBox.FormattingEnabled = true;
            this.archBox.Items.AddRange(new object[] {
            "ZIP"});
            this.archBox.Location = new System.Drawing.Point(354, 48);
            this.archBox.Name = "archBox";
            this.archBox.Size = new System.Drawing.Size(133, 21);
            this.archBox.TabIndex = 7;
            this.archBox.DropDown += new System.EventHandler(this.archBox_DropDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.archBox);
            this.Controls.Add(this.Deserbtn);
            this.Controls.Add(this.serbtn);
            this.Controls.Add(this.timeBx);
            this.Controls.Add(this.dateBx);
            this.Controls.Add(this.projBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabInbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabToday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabProjects.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInbox;
        private System.Windows.Forms.TabPage tabToday;
        private System.Windows.Forms.TabPage tabProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddMen;
        private System.Windows.Forms.ToolStripMenuItem DelMen;
        private System.Windows.Forms.ToolStripMenuItem DateMen;
        private System.Windows.Forms.ToolStripTextBox Datebox;
        private System.Windows.Forms.ToolStripMenuItem TimeMen;
        private System.Windows.Forms.ToolStripTextBox TimeBox;
        private System.Windows.Forms.ToolStripMenuItem editItem;
        private System.Windows.Forms.ToolStripMenuItem applyDatebtn;
        private System.Windows.Forms.ToolStripMenuItem ApllyTimebtn;
        private System.Windows.Forms.ToolStripTextBox editBox;
        private System.Windows.Forms.ToolStripMenuItem EditApplBtn;
        private System.Windows.Forms.ToolStripMenuItem editBtn2;
        private System.Windows.Forms.ToolStripTextBox nameBx2;
        private System.Windows.Forms.ToolStripTextBox dateBx2;
        private System.Windows.Forms.ToolStripTextBox timeBx2;
        private System.Windows.Forms.ToolStripMenuItem applBtn2;
        private System.Windows.Forms.ToolStripMenuItem delBtn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inbox;
        private System.Windows.Forms.ComboBox projBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem delbtn3;
        private System.Windows.Forms.ToolStripMenuItem addEv;
        private System.Windows.Forms.ToolStripTextBox datebtnEv3;
        private System.Windows.Forms.ToolStripTextBox timebtnEv3;
        private System.Windows.Forms.ToolStripMenuItem applybtnEv3;
        private System.Windows.Forms.ToolStripMenuItem ditbtn3;
        private System.Windows.Forms.ToolStripTextBox editFld3;
        private System.Windows.Forms.ToolStripMenuItem aplEdit3;
        private System.Windows.Forms.MaskedTextBox dateBx;
        private System.Windows.Forms.MaskedTextBox timeBx;
        private System.Windows.Forms.Button serbtn;
        private System.Windows.Forms.Button Deserbtn;
        public System.Windows.Forms.ComboBox archBox;
    }
}

