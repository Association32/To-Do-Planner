namespace Assignement4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatafileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatafileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listLblDecription = new System.Windows.Forms.Label();
            this.listLblPriority = new System.Windows.Forms.Label();
            this.listLblHour = new System.Windows.Forms.Label();
            this.listLblDate = new System.Windows.Forms.Label();
            this.toDoLabel2 = new System.Windows.Forms.Label();
            this.listboxToDo = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxToDo = new System.Windows.Forms.TextBox();
            this.lblToDo = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dateTimePickerToDo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCurTime = new System.Windows.Forms.Label();
            this.toolTipPrio = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.openDatafileToolStripMenuItem1,
            this.saveDatafileToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.newToolStripMenuItem2.Text = "New";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem2_Click);
            // 
            // openDatafileToolStripMenuItem1
            // 
            this.openDatafileToolStripMenuItem1.Name = "openDatafileToolStripMenuItem1";
            this.openDatafileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openDatafileToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.openDatafileToolStripMenuItem1.Text = "Open Datafile";
            this.openDatafileToolStripMenuItem1.Click += new System.EventHandler(this.openDatafileToolStripMenuItem1_Click);
            // 
            // saveDatafileToolStripMenuItem1
            // 
            this.saveDatafileToolStripMenuItem1.Name = "saveDatafileToolStripMenuItem1";
            this.saveDatafileToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDatafileToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.saveDatafileToolStripMenuItem1.Text = "Save Datafile";
            this.saveDatafileToolStripMenuItem1.Click += new System.EventHandler(this.saveDatafileToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openDatafileToolStripMenuItem,
            this.saveDatafileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openDatafileToolStripMenuItem
            // 
            this.openDatafileToolStripMenuItem.Name = "openDatafileToolStripMenuItem";
            this.openDatafileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openDatafileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openDatafileToolStripMenuItem.Text = "Open datafile";
            // 
            // saveDatafileToolStripMenuItem
            // 
            this.saveDatafileToolStripMenuItem.Name = "saveDatafileToolStripMenuItem";
            this.saveDatafileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDatafileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveDatafileToolStripMenuItem.Text = "Save datafile";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listLblDecription);
            this.groupBox1.Controls.Add(this.listLblPriority);
            this.groupBox1.Controls.Add(this.listLblHour);
            this.groupBox1.Controls.Add(this.listLblDate);
            this.groupBox1.Controls.Add(this.toDoLabel2);
            this.groupBox1.Controls.Add(this.listboxToDo);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBoxToDo);
            this.groupBox1.Controls.Add(this.lblToDo);
            this.groupBox1.Controls.Add(this.comboBoxPriority);
            this.groupBox1.Controls.Add(this.lblPriority);
            this.groupBox1.Controls.Add(this.dateTimePickerToDo);
            this.groupBox1.Controls.Add(this.lblDateTime);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 355);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // listLblDecription
            // 
            this.listLblDecription.AutoSize = true;
            this.listLblDecription.Location = new System.Drawing.Point(291, 146);
            this.listLblDecription.Name = "listLblDecription";
            this.listLblDecription.Size = new System.Drawing.Size(60, 13);
            this.listLblDecription.TabIndex = 14;
            this.listLblDecription.Text = "Description";
            // 
            // listLblPriority
            // 
            this.listLblPriority.AutoSize = true;
            this.listLblPriority.Location = new System.Drawing.Point(208, 146);
            this.listLblPriority.Name = "listLblPriority";
            this.listLblPriority.Size = new System.Drawing.Size(38, 13);
            this.listLblPriority.TabIndex = 13;
            this.listLblPriority.Text = "Priority";
            // 
            // listLblHour
            // 
            this.listLblHour.AutoSize = true;
            this.listLblHour.Location = new System.Drawing.Point(111, 146);
            this.listLblHour.Name = "listLblHour";
            this.listLblHour.Size = new System.Drawing.Size(30, 13);
            this.listLblHour.TabIndex = 12;
            this.listLblHour.Text = "Hour";
            // 
            // listLblDate
            // 
            this.listLblDate.AutoSize = true;
            this.listLblDate.Location = new System.Drawing.Point(10, 146);
            this.listLblDate.Name = "listLblDate";
            this.listLblDate.Size = new System.Drawing.Size(30, 13);
            this.listLblDate.TabIndex = 11;
            this.listLblDate.Text = "Date";
            // 
            // toDoLabel2
            // 
            this.toDoLabel2.AutoSize = true;
            this.toDoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoLabel2.ForeColor = System.Drawing.Color.YellowGreen;
            this.toDoLabel2.Location = new System.Drawing.Point(10, 118);
            this.toDoLabel2.Name = "toDoLabel2";
            this.toDoLabel2.Size = new System.Drawing.Size(47, 18);
            this.toDoLabel2.TabIndex = 10;
            this.toDoLabel2.Text = "To do";
            this.toDoLabel2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // listboxToDo
            // 
            this.listboxToDo.FormattingEnabled = true;
            this.listboxToDo.Location = new System.Drawing.Point(10, 174);
            this.listboxToDo.Name = "listboxToDo";
            this.listboxToDo.Size = new System.Drawing.Size(549, 173);
            this.listboxToDo.TabIndex = 9;
            this.listboxToDo.SelectedIndexChanged += new System.EventHandler(this.listboxToDo_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(436, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(276, 70);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxToDo
            // 
            this.txtBoxToDo.Location = new System.Drawing.Point(71, 44);
            this.txtBoxToDo.Name = "txtBoxToDo";
            this.txtBoxToDo.Size = new System.Drawing.Size(488, 20);
            this.txtBoxToDo.TabIndex = 5;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(7, 47);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(37, 13);
            this.lblToDo.TabIndex = 4;
            this.lblToDo.Text = "To Do";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Very important",
            "Important",
            "Less important"});
            this.comboBoxPriority.Location = new System.Drawing.Point(438, 17);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriority.TabIndex = 3;
            this.toolTipPrio.SetToolTip(this.comboBoxPriority, "Chose your priority");
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(373, 20);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority";
            // 
            // dateTimePickerToDo
            // 
            this.dateTimePickerToDo.CustomFormat = "HH:mm dddd dd:MM:yyyy ";
            this.dateTimePickerToDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDo.Location = new System.Drawing.Point(131, 19);
            this.dateTimePickerToDo.Name = "dateTimePickerToDo";
            this.dateTimePickerToDo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerToDo.TabIndex = 1;
            this.toolTipPrio.SetToolTip(this.dateTimePickerToDo, "Click here to select time or write manually");
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(7, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(73, 13);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date and time";
            // 
            // lblCurTime
            // 
            this.lblCurTime.AutoSize = true;
            this.lblCurTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurTime.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblCurTime.Location = new System.Drawing.Point(475, 397);
            this.lblCurTime.Name = "lblCurTime";
            this.lblCurTime.Size = new System.Drawing.Size(115, 18);
            this.lblCurTime.TabIndex = 3;
            this.lblCurTime.Text = "My Time is Now";
            // 
            // toolTipPrio
            // 
            this.toolTipPrio.Tag = "Chose the priotity";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 424);
            this.Controls.Add(this.lblCurTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxToDo;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label listLblDecription;
        private System.Windows.Forms.Label listLblPriority;
        private System.Windows.Forms.Label listLblHour;
        private System.Windows.Forms.Label listLblDate;
        private System.Windows.Forms.Label toDoLabel2;
        private System.Windows.Forms.ListBox listboxToDo;
        private System.Windows.Forms.Label lblCurTime;
        private System.Windows.Forms.ToolTip toolTipPrio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openDatafileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveDatafileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

