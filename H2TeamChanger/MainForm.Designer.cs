namespace H2TeamChanger
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
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRedTeam = new System.Windows.Forms.Button();
            this.btnBlueTeam = new System.Windows.Forms.Button();
            this.btnYellowTeam = new System.Windows.Forms.Button();
            this.btnGreenTeam = new System.Windows.Forms.Button();
            this.btnPurpleTeam = new System.Windows.Forms.Button();
            this.btnOrangeTeam = new System.Windows.Forms.Button();
            this.btnBrownTeam = new System.Windows.Forms.Button();
            this.btnPinkTeam = new System.Windows.Forms.Button();
            this.btnObserverTeam = new System.Windows.Forms.Button();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.StatusStripBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelGameState = new System.Windows.Forms.Label();
            this.lblGameState = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StatusStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // btnRedTeam
            // 
            this.btnRedTeam.Location = new System.Drawing.Point(12, 46);
            this.btnRedTeam.Name = "btnRedTeam";
            this.btnRedTeam.Size = new System.Drawing.Size(95, 23);
            this.btnRedTeam.TabIndex = 4;
            this.btnRedTeam.Text = "Red Team (0)";
            this.btnRedTeam.UseVisualStyleBackColor = true;
            this.btnRedTeam.Click += new System.EventHandler(this.btnRedTeam_Click);
            // 
            // btnBlueTeam
            // 
            this.btnBlueTeam.Location = new System.Drawing.Point(113, 46);
            this.btnBlueTeam.Name = "btnBlueTeam";
            this.btnBlueTeam.Size = new System.Drawing.Size(95, 23);
            this.btnBlueTeam.TabIndex = 5;
            this.btnBlueTeam.Text = "Blue Team (1)";
            this.btnBlueTeam.UseVisualStyleBackColor = true;
            this.btnBlueTeam.Click += new System.EventHandler(this.btnBlueTeam_Click);
            // 
            // btnYellowTeam
            // 
            this.btnYellowTeam.Location = new System.Drawing.Point(214, 46);
            this.btnYellowTeam.Name = "btnYellowTeam";
            this.btnYellowTeam.Size = new System.Drawing.Size(95, 23);
            this.btnYellowTeam.TabIndex = 6;
            this.btnYellowTeam.Text = "Yellow Team (2)";
            this.btnYellowTeam.UseVisualStyleBackColor = true;
            this.btnYellowTeam.Click += new System.EventHandler(this.btnYellowTeam_Click);
            // 
            // btnGreenTeam
            // 
            this.btnGreenTeam.Location = new System.Drawing.Point(315, 46);
            this.btnGreenTeam.Name = "btnGreenTeam";
            this.btnGreenTeam.Size = new System.Drawing.Size(95, 23);
            this.btnGreenTeam.TabIndex = 7;
            this.btnGreenTeam.Text = "Green Team (3)";
            this.btnGreenTeam.UseVisualStyleBackColor = true;
            this.btnGreenTeam.Click += new System.EventHandler(this.btnGreenTeam_Click);
            // 
            // btnPurpleTeam
            // 
            this.btnPurpleTeam.Location = new System.Drawing.Point(12, 75);
            this.btnPurpleTeam.Name = "btnPurpleTeam";
            this.btnPurpleTeam.Size = new System.Drawing.Size(95, 23);
            this.btnPurpleTeam.TabIndex = 8;
            this.btnPurpleTeam.Text = "Purple Team (4)";
            this.btnPurpleTeam.UseVisualStyleBackColor = true;
            this.btnPurpleTeam.Click += new System.EventHandler(this.btnPurpleTeam_Click);
            // 
            // btnOrangeTeam
            // 
            this.btnOrangeTeam.Location = new System.Drawing.Point(113, 75);
            this.btnOrangeTeam.Name = "btnOrangeTeam";
            this.btnOrangeTeam.Size = new System.Drawing.Size(95, 23);
            this.btnOrangeTeam.TabIndex = 9;
            this.btnOrangeTeam.Text = "Orange team (5)";
            this.btnOrangeTeam.UseVisualStyleBackColor = true;
            this.btnOrangeTeam.Click += new System.EventHandler(this.btnOrangeTeam_Click);
            // 
            // btnBrownTeam
            // 
            this.btnBrownTeam.Location = new System.Drawing.Point(214, 75);
            this.btnBrownTeam.Name = "btnBrownTeam";
            this.btnBrownTeam.Size = new System.Drawing.Size(95, 23);
            this.btnBrownTeam.TabIndex = 10;
            this.btnBrownTeam.Text = "Brown Team (6)";
            this.btnBrownTeam.UseVisualStyleBackColor = true;
            this.btnBrownTeam.Click += new System.EventHandler(this.btnBrownTeam_Click);
            // 
            // btnPinkTeam
            // 
            this.btnPinkTeam.Location = new System.Drawing.Point(315, 75);
            this.btnPinkTeam.Name = "btnPinkTeam";
            this.btnPinkTeam.Size = new System.Drawing.Size(95, 23);
            this.btnPinkTeam.TabIndex = 11;
            this.btnPinkTeam.Text = "Pink Team (7)";
            this.btnPinkTeam.UseVisualStyleBackColor = true;
            this.btnPinkTeam.Click += new System.EventHandler(this.btnPinkTeam_Click);
            // 
            // btnObserverTeam
            // 
            this.btnObserverTeam.Location = new System.Drawing.Point(12, 104);
            this.btnObserverTeam.Name = "btnObserverTeam";
            this.btnObserverTeam.Size = new System.Drawing.Size(124, 23);
            this.btnObserverTeam.TabIndex = 12;
            this.btnObserverTeam.Text = "Observers Team (255)";
            this.btnObserverTeam.UseVisualStyleBackColor = true;
            this.btnObserverTeam.Click += new System.EventHandler(this.btnObserverTeam_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(264, 107);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.ReadOnly = true;
            this.txtTeam.Size = new System.Drawing.Size(146, 20);
            this.txtTeam.TabIndex = 13;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam.Location = new System.Drawing.Point(211, 108);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(47, 16);
            this.labelTeam.TabIndex = 14;
            this.labelTeam.Text = "Team:";
            // 
            // StatusStripBottom
            // 
            this.StatusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCredits});
            this.StatusStripBottom.Location = new System.Drawing.Point(0, 353);
            this.StatusStripBottom.Name = "StatusStripBottom";
            this.StatusStripBottom.Size = new System.Drawing.Size(462, 22);
            this.StatusStripBottom.SizingGrip = false;
            this.StatusStripBottom.TabIndex = 15;
            this.StatusStripBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCredits
            // 
            this.toolStripStatusLabelCredits.Name = "toolStripStatusLabelCredits";
            this.toolStripStatusLabelCredits.Size = new System.Drawing.Size(230, 17);
            this.toolStripStatusLabelCredits.Text = "Program made by Phoenix and Killer Chief";
            // 
            // labelGameState
            // 
            this.labelGameState.AutoSize = true;
            this.labelGameState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameState.Location = new System.Drawing.Point(12, 14);
            this.labelGameState.Name = "labelGameState";
            this.labelGameState.Size = new System.Drawing.Size(93, 16);
            this.labelGameState.TabIndex = 16;
            this.labelGameState.Text = "Game State:";
            // 
            // lblGameState
            // 
            this.lblGameState.AutoSize = true;
            this.lblGameState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameState.ForeColor = System.Drawing.Color.Red;
            this.lblGameState.Location = new System.Drawing.Point(108, 14);
            this.lblGameState.Name = "lblGameState";
            this.lblGameState.Size = new System.Drawing.Size(100, 16);
            this.lblGameState.TabIndex = 18;
            this.lblGameState.Text = "Loading State...";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(15, 147);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 135);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process ID";
            this.columnHeader2.Width = 113;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(286, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Select Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "Refresh List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblGameState);
            this.Controls.Add(this.labelGameState);
            this.Controls.Add(this.StatusStripBottom);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.btnObserverTeam);
            this.Controls.Add(this.btnPinkTeam);
            this.Controls.Add(this.btnBrownTeam);
            this.Controls.Add(this.btnOrangeTeam);
            this.Controls.Add(this.btnPurpleTeam);
            this.Controls.Add(this.btnGreenTeam);
            this.Controls.Add(this.btnYellowTeam);
            this.Controls.Add(this.btnBlueTeam);
            this.Controls.Add(this.btnRedTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "H2 Team Changer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.StatusStripBottom.ResumeLayout(false);
            this.StatusStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button btnRedTeam;
        private System.Windows.Forms.Button btnBlueTeam;
        private System.Windows.Forms.Button btnYellowTeam;
        private System.Windows.Forms.Button btnGreenTeam;
        private System.Windows.Forms.Button btnPurpleTeam;
        private System.Windows.Forms.Button btnOrangeTeam;
        private System.Windows.Forms.Button btnBrownTeam;
        private System.Windows.Forms.Button btnPinkTeam;
        private System.Windows.Forms.Button btnObserverTeam;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.StatusStrip StatusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCredits;
        private System.Windows.Forms.Label labelGameState;
        private System.Windows.Forms.Label lblGameState;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

