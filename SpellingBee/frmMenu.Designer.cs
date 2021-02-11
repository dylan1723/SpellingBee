namespace SpellingBee
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Cyan;
            this.btnStart.Location = new System.Drawing.Point(242, 360);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 78);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRules
            // 
            this.lblRules.BackColor = System.Drawing.Color.ForestGreen;
            this.lblRules.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(65, 173);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(488, 169);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRead
            // 
            this.lblRead.BackColor = System.Drawing.Color.ForestGreen;
            this.lblRead.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.Location = new System.Drawing.Point(90, 42);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(440, 110);
            this.lblRead.TabIndex = 3;
            this.lblRead.Text = resources.GetString("lblRead.Text");
            this.lblRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRead;
    }
}

