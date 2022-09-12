namespace ImageProcessing
{
    partial class Noise
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
            this.noiseLevel = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grayscale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // noiseLevel
            // 
            this.noiseLevel.LargeChange = 10;
            this.noiseLevel.Location = new System.Drawing.Point(12, 42);
            this.noiseLevel.Maximum = 100;
            this.noiseLevel.Name = "noiseLevel";
            this.noiseLevel.Size = new System.Drawing.Size(436, 56);
            this.noiseLevel.TabIndex = 0;
            this.noiseLevel.Scroll += new System.EventHandler(this.noiseLevel_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность шума:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grayscale
            // 
            this.grayscale.AutoSize = true;
            this.grayscale.Location = new System.Drawing.Point(16, 104);
            this.grayscale.Name = "grayscale";
            this.grayscale.Size = new System.Drawing.Size(225, 21);
            this.grayscale.TabIndex = 5;
            this.grayscale.Text = "Перевеести в оттенки серого";
            this.grayscale.UseVisualStyleBackColor = true;
            // 
            // Noise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 184);
            this.Controls.Add(this.grayscale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noiseLevel);
            this.Name = "Noise";
            this.Text = "Noise";
            ((System.ComponentModel.ISupportInitialize)(this.noiseLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar noiseLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox grayscale;
    }
}