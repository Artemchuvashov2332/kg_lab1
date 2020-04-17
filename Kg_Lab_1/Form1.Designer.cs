namespace Kg_Lab_1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРястяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размываниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.структурныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.оттенкиСерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.линейноеРястяжениеToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.стеклоToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            this.точечныеToolStripMenuItem.Click += new System.EventHandler(this.точечныеToolStripMenuItem_Click);
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // линейноеРястяжениеToolStripMenuItem
            // 
            this.линейноеРястяжениеToolStripMenuItem.Name = "линейноеРястяжениеToolStripMenuItem";
            this.линейноеРястяжениеToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.линейноеРястяжениеToolStripMenuItem.Text = "Линейное рястяжение гистограммы";
            this.линейноеРястяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРястяжениеToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.волныToolStripMenuItem.Text = "Волны";
            this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.морфологияToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            this.матричныеToolStripMenuItem.Click += new System.EventHandler(this.матричныеToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // морфологияToolStripMenuItem
            // 
            this.морфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расширениеToolStripMenuItem,
            this.размываниеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.закрытиеToolStripMenuItem,
            this.структурныйЭлементToolStripMenuItem});
            this.морфологияToolStripMenuItem.Name = "морфологияToolStripMenuItem";
            this.морфологияToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.морфологияToolStripMenuItem.Text = "Морфология";
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.расширениеToolStripMenuItem.Text = "Расширение";
            // 
            // размываниеToolStripMenuItem
            // 
            this.размываниеToolStripMenuItem.Name = "размываниеToolStripMenuItem";
            this.размываниеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.размываниеToolStripMenuItem.Text = "Размывание";
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.открытиеToolStripMenuItem.Text = "Открытие";
            // 
            // закрытиеToolStripMenuItem
            // 
            this.закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            this.закрытиеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.закрытиеToolStripMenuItem.Text = "Закрытие";
            // 
            // структурныйЭлементToolStripMenuItem
            // 
            this.структурныйЭлементToolStripMenuItem.Name = "структурныйЭлементToolStripMenuItem";
            this.структурныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.структурныйЭлементToolStripMenuItem.Text = "Структурный элемент";
            this.структурныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.структурныйЭлементToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 294);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(611, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab1_ArtemChuvashov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРястяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размываниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem структурныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}

