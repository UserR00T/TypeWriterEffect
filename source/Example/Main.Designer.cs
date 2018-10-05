namespace Example
{
    partial class Main
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
            this.ToggleBtn = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.ForceEnableBtn = new System.Windows.Forms.Button();
            this.DisposeBtn = new System.Windows.Forms.Button();
            this.ForceDisableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToggleBtn
            // 
            this.ToggleBtn.Location = new System.Drawing.Point(357, 140);
            this.ToggleBtn.Name = "ToggleBtn";
            this.ToggleBtn.Size = new System.Drawing.Size(75, 23);
            this.ToggleBtn.TabIndex = 0;
            this.ToggleBtn.Text = "Toggle";
            this.ToggleBtn.UseVisualStyleBackColor = true;
            this.ToggleBtn.Click += new System.EventHandler(this.ToggleBtn_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(12, 57);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(250, 30);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Click activate to start";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForceEnableBtn
            // 
            this.ForceEnableBtn.Location = new System.Drawing.Point(174, 140);
            this.ForceEnableBtn.Name = "ForceEnableBtn";
            this.ForceEnableBtn.Size = new System.Drawing.Size(85, 23);
            this.ForceEnableBtn.TabIndex = 2;
            this.ForceEnableBtn.Text = "Force enable";
            this.ForceEnableBtn.UseVisualStyleBackColor = true;
            this.ForceEnableBtn.Click += new System.EventHandler(this.ForceEnableBtn_Click);
            // 
            // DisposeBtn
            // 
            this.DisposeBtn.Location = new System.Drawing.Point(438, 140);
            this.DisposeBtn.Name = "DisposeBtn";
            this.DisposeBtn.Size = new System.Drawing.Size(75, 23);
            this.DisposeBtn.TabIndex = 3;
            this.DisposeBtn.Text = "Dispose";
            this.DisposeBtn.UseVisualStyleBackColor = true;
            this.DisposeBtn.Click += new System.EventHandler(this.DisposeBtn_Click);
            // 
            // ForceDisableBtn
            // 
            this.ForceDisableBtn.Location = new System.Drawing.Point(265, 140);
            this.ForceDisableBtn.Name = "ForceDisableBtn";
            this.ForceDisableBtn.Size = new System.Drawing.Size(86, 23);
            this.ForceDisableBtn.TabIndex = 4;
            this.ForceDisableBtn.Text = "Force disable";
            this.ForceDisableBtn.UseVisualStyleBackColor = true;
            this.ForceDisableBtn.Click += new System.EventHandler(this.ForceDisableBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 234);
            this.Controls.Add(this.ForceDisableBtn);
            this.Controls.Add(this.DisposeBtn);
            this.Controls.Add(this.ForceEnableBtn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.ToggleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Typewriter Effect";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleBtn;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button ForceEnableBtn;
        private System.Windows.Forms.Button DisposeBtn;
        private System.Windows.Forms.Button ForceDisableBtn;
    }
}

