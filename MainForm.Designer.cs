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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblRecipeDuration = new System.Windows.Forms.Label();
            this.txtRecipeDuration = new System.Windows.Forms.TextBox();
            this.lblStackSize = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblItemsPerSec = new System.Windows.Forms.Label();
            this.txtStackSize = new System.Windows.Forms.TextBox();
            this.txtItemsPerSec = new System.Windows.Forms.TextBox();
            this.txtRPM = new System.Windows.Forms.TextBox();
            this.cmbMachines = new System.Windows.Forms.ComboBox();
            this.lblInputDelay = new System.Windows.Forms.Label();
            this.txtInputDelay = new System.Windows.Forms.TextBox();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(150, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.lblInputDelay);
            this.pnlInput.Controls.Add(this.txtInputDelay);
            this.pnlInput.Controls.Add(this.lblRecipeDuration);
            this.pnlInput.Controls.Add(this.txtRecipeDuration);
            this.pnlInput.Controls.Add(this.lblStackSize);
            this.pnlInput.Controls.Add(this.lblRPM);
            this.pnlInput.Controls.Add(this.lblItemsPerSec);
            this.pnlInput.Controls.Add(this.txtStackSize);
            this.pnlInput.Controls.Add(this.txtItemsPerSec);
            this.pnlInput.Controls.Add(this.txtRPM);
            this.pnlInput.Controls.Add(this.cmbMachines);
            this.pnlInput.Controls.Add(this.btnCalculate);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(230, 360);
            this.pnlInput.TabIndex = 1;
            // 
            // lblRecipeDuration
            // 
            this.lblRecipeDuration.AutoSize = true;
            this.lblRecipeDuration.Location = new System.Drawing.Point(3, 115);
            this.lblRecipeDuration.Name = "lblRecipeDuration";
            this.lblRecipeDuration.Size = new System.Drawing.Size(84, 13);
            this.lblRecipeDuration.TabIndex = 9;
            this.lblRecipeDuration.Text = "Recipe Duration";
            // 
            // txtRecipeDuration
            // 
            this.txtRecipeDuration.Location = new System.Drawing.Point(104, 108);
            this.txtRecipeDuration.Name = "txtRecipeDuration";
            this.txtRecipeDuration.Size = new System.Drawing.Size(121, 20);
            this.txtRecipeDuration.TabIndex = 8;
            // 
            // lblStackSize
            // 
            this.lblStackSize.AutoSize = true;
            this.lblStackSize.Location = new System.Drawing.Point(3, 89);
            this.lblStackSize.Name = "lblStackSize";
            this.lblStackSize.Size = new System.Drawing.Size(58, 13);
            this.lblStackSize.TabIndex = 7;
            this.lblStackSize.Text = "Stack Size";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Location = new System.Drawing.Point(3, 63);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(31, 13);
            this.lblRPM.TabIndex = 6;
            this.lblRPM.Text = "RPM";
            // 
            // lblItemsPerSec
            // 
            this.lblItemsPerSec.AutoSize = true;
            this.lblItemsPerSec.Location = new System.Drawing.Point(3, 37);
            this.lblItemsPerSec.Name = "lblItemsPerSec";
            this.lblItemsPerSec.Size = new System.Drawing.Size(54, 13);
            this.lblItemsPerSec.TabIndex = 5;
            this.lblItemsPerSec.Text = "Items/sec";
            // 
            // txtStackSize
            // 
            this.txtStackSize.Location = new System.Drawing.Point(104, 82);
            this.txtStackSize.Name = "txtStackSize";
            this.txtStackSize.Size = new System.Drawing.Size(121, 20);
            this.txtStackSize.TabIndex = 4;
            // 
            // txtItemsPerSec
            // 
            this.txtItemsPerSec.Location = new System.Drawing.Point(104, 30);
            this.txtItemsPerSec.Name = "txtItemsPerSec";
            this.txtItemsPerSec.Size = new System.Drawing.Size(121, 20);
            this.txtItemsPerSec.TabIndex = 3;
            this.txtItemsPerSec.TextChanged += new System.EventHandler(this.txtItemsPerSec_TextChanged);
            // 
            // txtRPM
            // 
            this.txtRPM.Location = new System.Drawing.Point(104, 56);
            this.txtRPM.Name = "txtRPM";
            this.txtRPM.Size = new System.Drawing.Size(121, 20);
            this.txtRPM.TabIndex = 2;
            this.txtRPM.TextChanged += new System.EventHandler(this.txtRPM_TextChanged);
            // 
            // cmbMachines
            // 
            this.cmbMachines.FormattingEnabled = true;
            this.cmbMachines.Location = new System.Drawing.Point(3, 3);
            this.cmbMachines.Name = "cmbMachines";
            this.cmbMachines.Size = new System.Drawing.Size(141, 21);
            this.cmbMachines.TabIndex = 1;
            this.cmbMachines.SelectedIndexChanged += new System.EventHandler(this.cmbMachines_SelectedIndexChanged_1);
            // 
            // lblInputDelay
            // 
            this.lblInputDelay.AutoSize = true;
            this.lblInputDelay.Location = new System.Drawing.Point(3, 141);
            this.lblInputDelay.Name = "lblInputDelay";
            this.lblInputDelay.Size = new System.Drawing.Size(61, 13);
            this.lblInputDelay.TabIndex = 11;
            this.lblInputDelay.Text = "Input Delay";
            // 
            // txtInputDelay
            // 
            this.txtInputDelay.Location = new System.Drawing.Point(104, 134);
            this.txtInputDelay.Name = "txtInputDelay";
            this.txtInputDelay.Size = new System.Drawing.Size(121, 20);
            this.txtInputDelay.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 384);
            this.Controls.Add(this.pnlInput);
            this.Name = "MainForm";
            this.Text = "Create Mod Calculator";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cmbMachines;
        private System.Windows.Forms.TextBox txtItemsPerSec;
        private System.Windows.Forms.TextBox txtRPM;
        private System.Windows.Forms.TextBox txtStackSize;
        private System.Windows.Forms.Label lblStackSize;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblItemsPerSec;
        private System.Windows.Forms.Label lblRecipeDuration;
        private System.Windows.Forms.TextBox txtRecipeDuration;
        private System.Windows.Forms.Label lblInputDelay;
        private System.Windows.Forms.TextBox txtInputDelay;
    }
}

