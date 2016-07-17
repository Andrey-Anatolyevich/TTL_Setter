namespace TTL_Setter {
    partial class DefaultTTL {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultTTL));
            this.comboBoxTTL = new System.Windows.Forms.ComboBox();
            this.labelCurrentTTL = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelMe = new System.Windows.Forms.Label();
            this.toolTipExtraText = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // comboBoxTTL
            // 
            this.comboBoxTTL.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTTL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxTTL.FormattingEnabled = true;
            this.comboBoxTTL.Location = new System.Drawing.Point(120, 40);
            this.comboBoxTTL.Name = "comboBoxTTL";
            this.comboBoxTTL.Size = new System.Drawing.Size(48, 21);
            this.comboBoxTTL.TabIndex = 0;
            this.comboBoxTTL.TabStop = false;
            this.toolTipExtraText.SetToolTip(this.comboBoxTTL, "Choose the TTL to write to register");
            // 
            // labelCurrentTTL
            // 
            this.labelCurrentTTL.AutoSize = true;
            this.labelCurrentTTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentTTL.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCurrentTTL.Location = new System.Drawing.Point(127, 9);
            this.labelCurrentTTL.Name = "labelCurrentTTL";
            this.labelCurrentTTL.Size = new System.Drawing.Size(45, 20);
            this.labelCurrentTTL.TabIndex = 3;
            this.labelCurrentTTL.Text = "none";
            this.toolTipExtraText.SetToolTip(this.labelCurrentTTL, "Current value");
            // 
            // labelExit
            // 
            this.labelExit.Location = new System.Drawing.Point(0, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(100, 23);
            this.labelExit.TabIndex = 10;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInfo2.Location = new System.Drawing.Point(10, 43);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(58, 13);
            this.labelInfo2.TabIndex = 5;
            this.labelInfo2.Text = "Set it to... :";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.ForeColor = System.Drawing.Color.DarkGray;
            this.labelDelete.Location = new System.Drawing.Point(122, 73);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(42, 13);
            this.labelDelete.TabIndex = 6;
            this.labelDelete.Text = "remove";
            this.toolTipExtraText.SetToolTip(this.labelDelete, "Delete written value from register");
            this.labelDelete.Click += new System.EventHandler(this.labelDelete_Click);
            this.labelDelete.MouseEnter += new System.EventHandler(this.labelDelete_MouseEnter);
            this.labelDelete.MouseLeave += new System.EventHandler(this.labelDelete_MouseLeave);
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(10, 13);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(99, 13);
            this.labelInfo1.TabIndex = 7;
            this.labelInfo1.Text = "Currently in register:";
            // 
            // labelInfo3
            // 
            this.labelInfo3.AutoSize = true;
            this.labelInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInfo3.Location = new System.Drawing.Point(10, 73);
            this.labelInfo3.Name = "labelInfo3";
            this.labelInfo3.Size = new System.Drawing.Size(86, 13);
            this.labelInfo3.TabIndex = 5;
            this.labelInfo3.Text = "Or just remove it:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(41, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "* remember to reboot";
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHelp.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelHelp.Location = new System.Drawing.Point(162, 111);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(16, 17);
            this.labelHelp.TabIndex = 8;
            this.labelHelp.Text = "?";
            this.toolTipExtraText.SetToolTip(this.labelHelp, "Click for extra info");
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            this.labelHelp.MouseEnter += new System.EventHandler(this.labelHelp_MouseEnter);
            this.labelHelp.MouseLeave += new System.EventHandler(this.labelHelp_MouseLeave);
            // 
            // labelMe
            // 
            this.labelMe.AutoSize = true;
            this.labelMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMe.Location = new System.Drawing.Point(5, 119);
            this.labelMe.Name = "labelMe";
            this.labelMe.Size = new System.Drawing.Size(94, 13);
            this.labelMe.TabIndex = 9;
            this.labelMe.Tag = "";
            this.labelMe.Text = "© Anatolyevich";
            this.toolTipExtraText.SetToolTip(this.labelMe, "Copy contact e-mail");
            this.labelMe.Click += new System.EventHandler(this.labelMe_Click);
            this.labelMe.MouseEnter += new System.EventHandler(this.labelMe_MouseEnter);
            this.labelMe.MouseLeave += new System.EventHandler(this.labelMe_MouseLeave);
            // 
            // DefaultTTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(190, 137);
            this.Controls.Add(this.labelMe);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo3);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelCurrentTTL);
            this.Controls.Add(this.comboBoxTTL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultTTL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTL Setter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTTL;
        private System.Windows.Forms.Label labelCurrentTTL;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelMe;
        private System.Windows.Forms.ToolTip toolTipExtraText;
    }
}

