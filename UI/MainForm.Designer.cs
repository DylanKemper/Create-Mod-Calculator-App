namespace Create_Mod_Calculator_App
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.cmbRecipeDuration = new System.Windows.Forms.ComboBox();
            this.txtItemsPerSec = new System.Windows.Forms.TextBox();
            this.lblItemsPerSec = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblInputDelay = new System.Windows.Forms.Label();
            this.txtInputDelay = new System.Windows.Forms.TextBox();
            this.lblRecipeDuration = new System.Windows.Forms.Label();
            this.lblStackSize = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.txtStackSize = new System.Windows.Forms.TextBox();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.cmbMachines = new System.Windows.Forms.ComboBox();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.AutoSize = true;
            this.pnlInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInput.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.cmbRecipeDuration);
            this.pnlInput.Controls.Add(this.txtItemsPerSec);
            this.pnlInput.Controls.Add(this.lblItemsPerSec);
            this.pnlInput.Controls.Add(this.lblHeading);
            this.pnlInput.Controls.Add(this.lblInputDelay);
            this.pnlInput.Controls.Add(this.txtInputDelay);
            this.pnlInput.Controls.Add(this.lblRecipeDuration);
            this.pnlInput.Controls.Add(this.lblStackSize);
            this.pnlInput.Controls.Add(this.lblRPM);
            this.pnlInput.Controls.Add(this.txtStackSize);
            this.pnlInput.Controls.Add(this.txtRPM);
            this.pnlInput.Controls.Add(this.cmbMachines);
            this.pnlInput.Location = new System.Drawing.Point(13, 13);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Padding = new System.Windows.Forms.Padding(8);
            this.pnlInput.Size = new System.Drawing.Size(384, 278);
            this.pnlInput.TabIndex = 1;
            // 
            // cmbRecipeDuration
            // 
            this.cmbRecipeDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRecipeDuration.DropDownHeight = 128;
            this.cmbRecipeDuration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbRecipeDuration.FormattingEnabled = true;
            this.cmbRecipeDuration.IntegralHeight = false;
            this.cmbRecipeDuration.Location = new System.Drawing.Point(189, 207);
            this.cmbRecipeDuration.Name = "cmbRecipeDuration";
            this.cmbRecipeDuration.Size = new System.Drawing.Size(181, 26);
            this.cmbRecipeDuration.TabIndex = 2;
            this.cmbRecipeDuration.SelectedIndexChanged += new System.EventHandler(this.cmbRecipeDuration_SelectedIndexChanged);
            // 
            // txtItemsPerSec
            // 
            this.txtItemsPerSec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemsPerSec.Location = new System.Drawing.Point(189, 112);
            this.txtItemsPerSec.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemsPerSec.Multiline = true;
            this.txtItemsPerSec.Name = "txtItemsPerSec";
            this.txtItemsPerSec.Size = new System.Drawing.Size(181, 24);
            this.txtItemsPerSec.TabIndex = 13;
            this.txtItemsPerSec.TextChanged += new System.EventHandler(this.txtItemsPerSec_TextChanged);
            // 
            // lblItemsPerSec
            // 
            this.lblItemsPerSec.AutoSize = true;
            this.lblItemsPerSec.Location = new System.Drawing.Point(12, 112);
            this.lblItemsPerSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsPerSec.Name = "lblItemsPerSec";
            this.lblItemsPerSec.Size = new System.Drawing.Size(94, 24);
            this.lblItemsPerSec.TabIndex = 5;
            this.lblItemsPerSec.Text = "Items/sec";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeading.Font = new System.Drawing.Font("Minecraftia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 12);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(8);
            this.lblHeading.Size = new System.Drawing.Size(358, 58);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Create Mod Calculator";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInputDelay
            // 
            this.lblInputDelay.AutoSize = true;
            this.lblInputDelay.Location = new System.Drawing.Point(12, 240);
            this.lblInputDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputDelay.Name = "lblInputDelay";
            this.lblInputDelay.Size = new System.Drawing.Size(102, 24);
            this.lblInputDelay.TabIndex = 11;
            this.lblInputDelay.Text = "Input Delay";
            // 
            // txtInputDelay
            // 
            this.txtInputDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInputDelay.Location = new System.Drawing.Point(189, 240);
            this.txtInputDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputDelay.Multiline = true;
            this.txtInputDelay.Name = "txtInputDelay";
            this.txtInputDelay.Size = new System.Drawing.Size(181, 24);
            this.txtInputDelay.TabIndex = 10;
            // 
            // lblRecipeDuration
            // 
            this.lblRecipeDuration.AutoSize = true;
            this.lblRecipeDuration.Location = new System.Drawing.Point(12, 207);
            this.lblRecipeDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeDuration.Name = "lblRecipeDuration";
            this.lblRecipeDuration.Size = new System.Drawing.Size(136, 24);
            this.lblRecipeDuration.TabIndex = 9;
            this.lblRecipeDuration.Text = "Recipe Duration";
            // 
            // lblStackSize
            // 
            this.lblStackSize.AutoSize = true;
            this.lblStackSize.Location = new System.Drawing.Point(12, 176);
            this.lblStackSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStackSize.Name = "lblStackSize";
            this.lblStackSize.Size = new System.Drawing.Size(92, 24);
            this.lblStackSize.TabIndex = 7;
            this.lblStackSize.Text = "Stack Size";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(12, 144);
            this.lblRPM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(40, 24);
            this.lblRPM.TabIndex = 6;
            this.lblRPM.Text = "RPM";
            // 
            // txtStackSize
            // 
            this.txtStackSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStackSize.Location = new System.Drawing.Point(189, 176);
            this.txtStackSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtStackSize.Multiline = true;
            this.txtStackSize.Name = "txtStackSize";
            this.txtStackSize.Size = new System.Drawing.Size(181, 24);
            this.txtStackSize.TabIndex = 4;
            // 
            // txtRPM
            // 
            this.txtRPM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRPM.Location = new System.Drawing.Point(189, 144);
            this.txtRPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtRPM.Multiline = true;
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(181, 24);
            this.txtRPM.TabIndex = 2;
            this.txtRPM.TextChanged += new System.EventHandler(this.txtRPM_TextChanged);
            // 
            // cmbMachines
            // 
            this.cmbMachines.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMachines.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMachines.FormattingEnabled = true;
            this.cmbMachines.Location = new System.Drawing.Point(12, 78);
            this.cmbMachines.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.Size = new System.Drawing.Size(358, 26);
            this.cmbMachines.TabIndex = 1;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.cmbMachines_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 559);
            this.Controls.Add(this.pnlInput);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Minecraftia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Create Mod Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cmbMachines;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.TextBox txtStackSize;
        private System.Windows.Forms.Label lblStackSize;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblItemsPerSec;
        private System.Windows.Forms.Label lblRecipeDuration;
        private System.Windows.Forms.Label lblInputDelay;
        private System.Windows.Forms.TextBox txtInputDelay;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtItemsPerSec;
        private System.Windows.Forms.ComboBox cmbRecipeDuration;
    }
}

