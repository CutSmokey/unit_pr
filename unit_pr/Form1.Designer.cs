namespace unit_pr
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
            this.genderbg = new System.Windows.Forms.GroupBox();
            this.famalerb = new System.Windows.Forms.RadioButton();
            this.malerb = new System.Windows.Forms.RadioButton();
            this.armgb = new System.Windows.Forms.GroupBox();
            this.armtime = new System.Windows.Forms.TextBox();
            this.armtimelb = new System.Windows.Forms.Label();
            this.fmgb = new System.Windows.Forms.GroupBox();
            this.dtimetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmwrkgb = new System.Windows.Forms.GroupBox();
            this.multilbtb = new System.Windows.Forms.TextBox();
            this.multilb = new System.Windows.Forms.Label();
            this.worktimetb = new System.Windows.Forms.TextBox();
            this.worktimelb = new System.Windows.Forms.Label();
            this.resoultbtn = new System.Windows.Forms.Button();
            this.rsl = new System.Windows.Forms.Label();
            this.genderbg.SuspendLayout();
            this.armgb.SuspendLayout();
            this.fmgb.SuspendLayout();
            this.tmwrkgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderbg
            // 
            this.genderbg.Controls.Add(this.famalerb);
            this.genderbg.Controls.Add(this.malerb);
            this.genderbg.Location = new System.Drawing.Point(17, 18);
            this.genderbg.Name = "genderbg";
            this.genderbg.Size = new System.Drawing.Size(177, 62);
            this.genderbg.TabIndex = 6;
            this.genderbg.TabStop = false;
            this.genderbg.Text = "Пол";
            // 
            // famalerb
            // 
            this.famalerb.AutoSize = true;
            this.famalerb.Checked = true;
            this.famalerb.Location = new System.Drawing.Point(6, 39);
            this.famalerb.Name = "famalerb";
            this.famalerb.Size = new System.Drawing.Size(72, 17);
            this.famalerb.TabIndex = 1;
            this.famalerb.TabStop = true;
            this.famalerb.Text = "Женский";
            this.famalerb.UseVisualStyleBackColor = true;
            this.famalerb.CheckedChanged += new System.EventHandler(this.malerb_CheckedChanged);
            // 
            // malerb
            // 
            this.malerb.AutoSize = true;
            this.malerb.Location = new System.Drawing.Point(6, 19);
            this.malerb.Name = "malerb";
            this.malerb.Size = new System.Drawing.Size(71, 17);
            this.malerb.TabIndex = 0;
            this.malerb.Text = "Мужской";
            this.malerb.UseVisualStyleBackColor = true;
            this.malerb.CheckedChanged += new System.EventHandler(this.malerb_CheckedChanged);
            // 
            // armgb
            // 
            this.armgb.Controls.Add(this.armtime);
            this.armgb.Controls.Add(this.armtimelb);
            this.armgb.Location = new System.Drawing.Point(17, 86);
            this.armgb.Name = "armgb";
            this.armgb.Size = new System.Drawing.Size(177, 97);
            this.armgb.TabIndex = 7;
            this.armgb.TabStop = false;
            this.armgb.Text = "Служба в армии";
            // 
            // armtime
            // 
            this.armtime.Location = new System.Drawing.Point(9, 49);
            this.armtime.Name = "armtime";
            this.armtime.Size = new System.Drawing.Size(150, 20);
            this.armtime.TabIndex = 8;
            this.armtime.Text = "0";
            this.armtime.TextChanged += new System.EventHandler(this.armtime_TextChanged);
            // 
            // armtimelb
            // 
            this.armtimelb.AutoSize = true;
            this.armtimelb.Location = new System.Drawing.Point(6, 16);
            this.armtimelb.Name = "armtimelb";
            this.armtimelb.Size = new System.Drawing.Size(156, 26);
            this.armtimelb.TabIndex = 8;
            this.armtimelb.Text = "Сколько лёт было проведено\r\nв армии ";
            // 
            // fmgb
            // 
            this.fmgb.Controls.Add(this.dtimetb);
            this.fmgb.Controls.Add(this.label1);
            this.fmgb.Location = new System.Drawing.Point(17, 161);
            this.fmgb.Name = "fmgb";
            this.fmgb.Size = new System.Drawing.Size(177, 97);
            this.fmgb.TabIndex = 9;
            this.fmgb.TabStop = false;
            this.fmgb.Text = "Декретный отпуск";
            // 
            // dtimetb
            // 
            this.dtimetb.Location = new System.Drawing.Point(6, 64);
            this.dtimetb.Name = "dtimetb";
            this.dtimetb.Size = new System.Drawing.Size(150, 20);
            this.dtimetb.TabIndex = 8;
            this.dtimetb.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сколько лёт было проведено \r\nв декретном отпуск \r\n(не более 6 лет)";
            // 
            // tmwrkgb
            // 
            this.tmwrkgb.Controls.Add(this.multilbtb);
            this.tmwrkgb.Controls.Add(this.multilb);
            this.tmwrkgb.Controls.Add(this.worktimetb);
            this.tmwrkgb.Controls.Add(this.worktimelb);
            this.tmwrkgb.Location = new System.Drawing.Point(200, 18);
            this.tmwrkgb.Name = "tmwrkgb";
            this.tmwrkgb.Size = new System.Drawing.Size(272, 74);
            this.tmwrkgb.TabIndex = 8;
            this.tmwrkgb.TabStop = false;
            this.tmwrkgb.Text = "Рабочее время";
            // 
            // multilbtb
            // 
            this.multilbtb.Location = new System.Drawing.Point(156, 49);
            this.multilbtb.Name = "multilbtb";
            this.multilbtb.Size = new System.Drawing.Size(106, 20);
            this.multilbtb.TabIndex = 15;
            this.multilbtb.Text = "0";
            // 
            // multilb
            // 
            this.multilb.AutoSize = true;
            this.multilb.Location = new System.Drawing.Point(15, 52);
            this.multilb.Name = "multilb";
            this.multilb.Size = new System.Drawing.Size(119, 13);
            this.multilb.TabIndex = 14;
            this.multilb.Text = "Коэффициент баллов ";
            // 
            // worktimetb
            // 
            this.worktimetb.Location = new System.Drawing.Point(156, 23);
            this.worktimetb.Name = "worktimetb";
            this.worktimetb.Size = new System.Drawing.Size(106, 20);
            this.worktimetb.TabIndex = 9;
            this.worktimetb.Text = "0";
            // 
            // worktimelb
            // 
            this.worktimelb.AutoSize = true;
            this.worktimelb.Location = new System.Drawing.Point(15, 26);
            this.worktimelb.Name = "worktimelb";
            this.worktimelb.Size = new System.Drawing.Size(135, 13);
            this.worktimelb.TabIndex = 1;
            this.worktimelb.Text = "Кол-во отработанных лет";
            // 
            // resoultbtn
            // 
            this.resoultbtn.Location = new System.Drawing.Point(200, 98);
            this.resoultbtn.Name = "resoultbtn";
            this.resoultbtn.Size = new System.Drawing.Size(272, 25);
            this.resoultbtn.TabIndex = 9;
            this.resoultbtn.Text = "Результат";
            this.resoultbtn.UseVisualStyleBackColor = true;
            this.resoultbtn.Click += new System.EventHandler(this.resoultbtn_Click);
            // 
            // rsl
            // 
            this.rsl.AutoSize = true;
            this.rsl.Location = new System.Drawing.Point(200, 126);
            this.rsl.Name = "rsl";
            this.rsl.Size = new System.Drawing.Size(0, 13);
            this.rsl.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 268);
            this.Controls.Add(this.fmgb);
            this.Controls.Add(this.rsl);
            this.Controls.Add(this.resoultbtn);
            this.Controls.Add(this.tmwrkgb);
            this.Controls.Add(this.armgb);
            this.Controls.Add(this.genderbg);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчёт пенсии";
            this.genderbg.ResumeLayout(false);
            this.genderbg.PerformLayout();
            this.armgb.ResumeLayout(false);
            this.armgb.PerformLayout();
            this.fmgb.ResumeLayout(false);
            this.fmgb.PerformLayout();
            this.tmwrkgb.ResumeLayout(false);
            this.tmwrkgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox genderbg;
        private System.Windows.Forms.RadioButton famalerb;
        private System.Windows.Forms.RadioButton malerb;
        private System.Windows.Forms.GroupBox armgb;
        private System.Windows.Forms.TextBox armtime;
        private System.Windows.Forms.Label armtimelb;
        private System.Windows.Forms.GroupBox tmwrkgb;
        private System.Windows.Forms.TextBox multilbtb;
        private System.Windows.Forms.Label multilb;
        private System.Windows.Forms.TextBox worktimetb;
        private System.Windows.Forms.Label worktimelb;
        private System.Windows.Forms.Button resoultbtn;
        private System.Windows.Forms.Label rsl;
        private System.Windows.Forms.GroupBox fmgb;
        private System.Windows.Forms.TextBox dtimetb;
        private System.Windows.Forms.Label label1;
    }
}

