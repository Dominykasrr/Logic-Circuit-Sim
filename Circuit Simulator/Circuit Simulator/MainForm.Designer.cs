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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAND = new System.Windows.Forms.Button();
            this.pbStaticSource = new System.Windows.Forms.PictureBox();
            this.pbAnd = new System.Windows.Forms.PictureBox();
            this.pbOr = new System.Windows.Forms.PictureBox();
            this.pbNot = new System.Windows.Forms.PictureBox();
            this.pbDynamicSource = new System.Windows.Forms.PictureBox();
            this.pbSink = new System.Windows.Forms.PictureBox();
            this.timerDrawLineToCur = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaticSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDynamicSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).BeginInit();
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
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
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
            // pbStaticSource
            // 
            this.pbStaticSource.Location = new System.Drawing.Point(13, 68);
            this.pbStaticSource.Name = "pbStaticSource";
            this.pbStaticSource.Size = new System.Drawing.Size(100, 50);
            this.pbStaticSource.TabIndex = 3;
            this.pbStaticSource.TabStop = false;
            this.pbStaticSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStaticSource_MouseDown);
            // 
            // pbAnd
            // 
            this.pbAnd.Location = new System.Drawing.Point(13, 237);
            this.pbAnd.Name = "pbAnd";
            this.pbAnd.Size = new System.Drawing.Size(100, 50);
            this.pbAnd.TabIndex = 3;
            this.pbAnd.TabStop = false;
            this.pbAnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbAnd_MouseDown);
            // 
            // pbOr
            // 
            this.pbOr.Location = new System.Drawing.Point(12, 293);
            this.pbOr.Name = "pbOr";
            this.pbOr.Size = new System.Drawing.Size(100, 50);
            this.pbOr.TabIndex = 3;
            this.pbOr.TabStop = false;
            this.pbOr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbOr_MouseDown);
            // 
            // pbNot
            // 
            this.pbNot.Location = new System.Drawing.Point(12, 349);
            this.pbNot.Name = "pbNot";
            this.pbNot.Size = new System.Drawing.Size(100, 50);
            this.pbNot.TabIndex = 3;
            this.pbNot.TabStop = false;
            this.pbNot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbNot_MouseDown);
            // 
            // pbDynamicSource
            // 
            this.pbDynamicSource.Location = new System.Drawing.Point(12, 124);
            this.pbDynamicSource.Name = "pbDynamicSource";
            this.pbDynamicSource.Size = new System.Drawing.Size(100, 50);
            this.pbDynamicSource.TabIndex = 3;
            this.pbDynamicSource.TabStop = false;
            this.pbDynamicSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDynamicSource_MouseDown);
            // 
            // pbSink
            // 
            this.pbSink.Location = new System.Drawing.Point(13, 181);
            this.pbSink.Name = "pbSink";
            this.pbSink.Size = new System.Drawing.Size(100, 50);
            this.pbSink.TabIndex = 4;
            this.pbSink.TabStop = false;
            this.pbSink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSink_MouseDown);
            // 
            // timerDrawLineToCur
            // 
            this.timerDrawLineToCur.Tick += new System.EventHandler(this.timerDrawLineToCur_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.pbSink);
            this.Controls.Add(this.pbNot);
            this.Controls.Add(this.pbOr);
            this.Controls.Add(this.pbAnd);
            this.Controls.Add(this.pbDynamicSource);
            this.Controls.Add(this.pbStaticSource);
            this.Controls.Add(this.buttonAND);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circuit Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbStaticSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDynamicSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.PictureBox pbStaticSource;
        private System.Windows.Forms.PictureBox pbAnd;
        private System.Windows.Forms.PictureBox pbOr;
        private System.Windows.Forms.PictureBox pbNot;
        private System.Windows.Forms.PictureBox pbDynamicSource;
        private System.Windows.Forms.PictureBox pbSink;
        private System.Windows.Forms.Timer timerDrawLineToCur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;

    }
}

