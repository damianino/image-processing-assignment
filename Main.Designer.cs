namespace ImageProcessing
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинаризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЛапласаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методРобертсаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методСопелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(530, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripDropDownButton1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1042, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.негативToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.бинаризацияToolStripMenuItem,
            this.шумToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.выделениеГраницToolStripMenuItem,
            this.яркостьToolStripMenuItem,
            this.контрастностьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.негативToolStripMenuItem.Text = "Негатив";
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
            // 
            // бинаризацияToolStripMenuItem
            // 
            this.бинаризацияToolStripMenuItem.Name = "бинаризацияToolStripMenuItem";
            this.бинаризацияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.бинаризацияToolStripMenuItem.Text = "Бинаризация";
            this.бинаризацияToolStripMenuItem.Click += new System.EventHandler(this.бинаризацияToolStripMenuItem_Click);
            // 
            // шумToolStripMenuItem
            // 
            this.шумToolStripMenuItem.Name = "шумToolStripMenuItem";
            this.шумToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шумToolStripMenuItem.Text = "Шум";
            this.шумToolStripMenuItem.Click += new System.EventHandler(this.шумToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повышениеРезкостиToolStripMenuItem,
            this.размытиеИзображенияToolStripMenuItem});
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.фильтрацияToolStripMenuItem.Text = "Фильтрация";
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            this.повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            this.повышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.повышениеРезкостиToolStripMenuItem.Text = "Повышение резкости";
            this.повышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеРезкостиToolStripMenuItem_Click);
            // 
            // размытиеИзображенияToolStripMenuItem
            // 
            this.размытиеИзображенияToolStripMenuItem.Name = "размытиеИзображенияToolStripMenuItem";
            this.размытиеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.размытиеИзображенияToolStripMenuItem.Text = "Размытие изображения";
            this.размытиеИзображенияToolStripMenuItem.Click += new System.EventHandler(this.размытиеИзображенияToolStripMenuItem_Click);
            // 
            // выделениеГраницToolStripMenuItem
            // 
            this.выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методЛToolStripMenuItem,
            this.методЛапласаToolStripMenuItem,
            this.методРобертсаToolStripMenuItem,
            this.методСопелаToolStripMenuItem});
            this.выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            this.выделениеГраницToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            // 
            // методЛToolStripMenuItem
            // 
            this.методЛToolStripMenuItem.Name = "методЛToolStripMenuItem";
            this.методЛToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.методЛToolStripMenuItem.Text = "Метод Кирша";
            this.методЛToolStripMenuItem.Click += new System.EventHandler(this.методЛToolStripMenuItem_Click);
            // 
            // методЛапласаToolStripMenuItem
            // 
            this.методЛапласаToolStripMenuItem.Name = "методЛапласаToolStripMenuItem";
            this.методЛапласаToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.методЛапласаToolStripMenuItem.Text = "Метод Лапласа";
            this.методЛапласаToolStripMenuItem.Click += new System.EventHandler(this.методЛапласаToolStripMenuItem_Click);
            // 
            // методРобертсаToolStripMenuItem
            // 
            this.методРобертсаToolStripMenuItem.Name = "методРобертсаToolStripMenuItem";
            this.методРобертсаToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.методРобертсаToolStripMenuItem.Text = "Метод Робертса";
            this.методРобертсаToolStripMenuItem.Click += new System.EventHandler(this.методРобертсаToolStripMenuItem_Click);
            // 
            // методСопелаToolStripMenuItem
            // 
            this.методСопелаToolStripMenuItem.Name = "методСопелаToolStripMenuItem";
            this.методСопелаToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.методСопелаToolStripMenuItem.Text = "Метод Сопела";
            this.методСопелаToolStripMenuItem.Click += new System.EventHandler(this.методСопелаToolStripMenuItem_Click);
            // 
            // яркостьToolStripMenuItem
            // 
            this.яркостьToolStripMenuItem.Name = "яркостьToolStripMenuItem";
            this.яркостьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.яркостьToolStripMenuItem.Text = "Яркость";
            this.яркостьToolStripMenuItem.Click += new System.EventHandler(this.яркостьToolStripMenuItem_Click);
            // 
            // контрастностьToolStripMenuItem
            // 
            this.контрастностьToolStripMenuItem.Name = "контрастностьToolStripMenuItem";
            this.контрастностьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.контрастностьToolStripMenuItem.Text = "Контрастность";
            this.контрастностьToolStripMenuItem.Click += new System.EventHandler(this.контрастностьToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинаризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЛапласаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методРобертсаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методСопелаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

