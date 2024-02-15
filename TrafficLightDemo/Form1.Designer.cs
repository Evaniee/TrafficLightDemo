namespace TrafficLightDemo
{
    partial class Form1
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
            this.pb_area = new System.Windows.Forms.PictureBox();
            this.tmr_state = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_area)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_area
            // 
            this.pb_area.Location = new System.Drawing.Point(12, 12);
            this.pb_area.Name = "pb_area";
            this.pb_area.Size = new System.Drawing.Size(776, 426);
            this.pb_area.TabIndex = 0;
            this.pb_area.TabStop = false;
            this.pb_area.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_area_Paint);
            // 
            // tmr_state
            // 
            this.tmr_state.Enabled = true;
            this.tmr_state.Interval = 1000;
            this.tmr_state.Tick += new System.EventHandler(this.tmr_state_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_area);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_area)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_area;
        private System.Windows.Forms.Timer tmr_state;
    }
}

