namespace Circuit_Simulator
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAND = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(118, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(954, 587);
            this.panel.TabIndex = 0;
            // 
            // buttonAND
            // 
            this.buttonAND.Location = new System.Drawing.Point(12, 12);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(100, 50);
            this.buttonAND.TabIndex = 1;
            this.buttonAND.UseVisualStyleBackColor = true;
            // 
            // buttonOR
            // 
            this.buttonOR.Location = new System.Drawing.Point(12, 68);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(100, 50);
            this.buttonOR.TabIndex = 2;
            this.buttonOR.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.buttonOR);
            this.Controls.Add(this.buttonAND);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuit Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.Button buttonOR;

    }
}

