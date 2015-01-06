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
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbAnd = new System.Windows.Forms.PictureBox();
            this.pbOr = new System.Windows.Forms.PictureBox();
            this.pbNot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AllowDrop = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(118, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(954, 587);
            this.panel.TabIndex = 0;
            this.panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // buttonAND
            // 
            this.buttonAND.Location = new System.Drawing.Point(12, 12);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(100, 50);
            this.buttonAND.TabIndex = 1;
            this.buttonAND.UseVisualStyleBackColor = true;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.Location = new System.Drawing.Point(12, 68);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(100, 50);
            this.buttonOR.TabIndex = 2;
            this.buttonOR.UseVisualStyleBackColor = true;
            // 
            // pbSource
            // 
            this.pbSource.Location = new System.Drawing.Point(13, 125);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(100, 100);
            this.pbSource.TabIndex = 3;
            this.pbSource.TabStop = false;
            // 
            // pbAnd
            // 
            this.pbAnd.Location = new System.Drawing.Point(12, 231);
            this.pbAnd.Name = "pbAnd";
            this.pbAnd.Size = new System.Drawing.Size(100, 100);
            this.pbAnd.TabIndex = 3;
            this.pbAnd.TabStop = false;
            this.pbAnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseDown);
            // 
            // pbOr
            // 
            this.pbOr.Location = new System.Drawing.Point(13, 337);
            this.pbOr.Name = "pbOr";
            this.pbOr.Size = new System.Drawing.Size(100, 100);
            this.pbOr.TabIndex = 3;
            this.pbOr.TabStop = false;
            // 
            // pbNot
            // 
            this.pbNot.Location = new System.Drawing.Point(13, 443);
            this.pbNot.Name = "pbNot";
            this.pbNot.Size = new System.Drawing.Size(100, 100);
            this.pbNot.TabIndex = 3;
            this.pbNot.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.pbNot);
            this.Controls.Add(this.pbOr);
            this.Controls.Add(this.pbAnd);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.buttonOR);
            this.Controls.Add(this.buttonAND);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuit Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbAnd;
        private System.Windows.Forms.PictureBox pbOr;
        private System.Windows.Forms.PictureBox pbNot;

    }
}

