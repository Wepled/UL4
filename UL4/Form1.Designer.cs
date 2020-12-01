
namespace UL4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moveOnce = new System.Windows.Forms.Button();
            this.startStop = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // moveOnce
            // 
            this.moveOnce.Location = new System.Drawing.Point(1077, 12);
            this.moveOnce.Name = "moveOnce";
            this.moveOnce.Size = new System.Drawing.Size(156, 39);
            this.moveOnce.TabIndex = 1;
            this.moveOnce.Text = "Move once";
            this.moveOnce.UseVisualStyleBackColor = true;
            this.moveOnce.Click += new System.EventHandler(this.moveOnce_Click);
            // 
            // startStop
            // 
            this.startStop.Location = new System.Drawing.Point(1077, 81);
            this.startStop.Name = "startStop";
            this.startStop.Size = new System.Drawing.Size(156, 42);
            this.startStop.TabIndex = 2;
            this.startStop.Text = "Start/Stop";
            this.startStop.UseVisualStyleBackColor = true;
            this.startStop.Click += new System.EventHandler(this.startStop_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1077, 768);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(156, 44);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 823);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.startStop);
            this.Controls.Add(this.moveOnce);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button moveOnce;
        private System.Windows.Forms.Button startStop;
        private System.Windows.Forms.Button Close;

    }
}

