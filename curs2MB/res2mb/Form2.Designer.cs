﻿
namespace res2mb
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.var1 = new System.Windows.Forms.RadioButton();
            this.var2 = new System.Windows.Forms.RadioButton();
            this.var3 = new System.Windows.Forms.RadioButton();
            this.typeStars = new System.Windows.Forms.GroupBox();
            this.var4 = new System.Windows.Forms.RadioButton();
            this.variants = new System.Windows.Forms.Button();
            this.colorStars = new System.Windows.Forms.Button();
            this.sizeStars = new System.Windows.Forms.Label();
            this.sizeStarsNumber = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.typeStars.SuspendLayout();
            this.SuspendLayout();
            // 
            // var1
            // 
            this.var1.AutoSize = true;
            this.var1.BackColor = System.Drawing.Color.Transparent;
            this.var1.Checked = true;
            this.var1.Font = new System.Drawing.Font("Impact", 17F);
            this.var1.ForeColor = System.Drawing.Color.Violet;
            this.var1.Location = new System.Drawing.Point(136, 39);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(156, 40);
            this.var1.TabIndex = 0;
            this.var1.TabStop = true;
            this.var1.Text = "1 ВАРИАНТ";
            this.var1.UseVisualStyleBackColor = false;
            this.var1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // var2
            // 
            this.var2.AutoSize = true;
            this.var2.BackColor = System.Drawing.Color.Transparent;
            this.var2.Font = new System.Drawing.Font("Impact", 17F);
            this.var2.ForeColor = System.Drawing.Color.Violet;
            this.var2.Location = new System.Drawing.Point(136, 86);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(160, 40);
            this.var2.TabIndex = 1;
            this.var2.Text = "2 ВАРИАНТ";
            this.var2.UseVisualStyleBackColor = false;
            // 
            // var3
            // 
            this.var3.AutoSize = true;
            this.var3.BackColor = System.Drawing.Color.Transparent;
            this.var3.Font = new System.Drawing.Font("Impact", 17F);
            this.var3.ForeColor = System.Drawing.Color.Violet;
            this.var3.Location = new System.Drawing.Point(136, 132);
            this.var3.Name = "var3";
            this.var3.Size = new System.Drawing.Size(160, 40);
            this.var3.TabIndex = 2;
            this.var3.Text = "3 ВАРИАНТ";
            this.var3.UseVisualStyleBackColor = false;
            // 
            // typeStars
            // 
            this.typeStars.BackColor = System.Drawing.Color.Transparent;
            this.typeStars.Controls.Add(this.var4);
            this.typeStars.Controls.Add(this.var3);
            this.typeStars.Controls.Add(this.var1);
            this.typeStars.Controls.Add(this.var2);
            this.typeStars.Font = new System.Drawing.Font("Impact", 16F);
            this.typeStars.ForeColor = System.Drawing.Color.Fuchsia;
            this.typeStars.Location = new System.Drawing.Point(393, 188);
            this.typeStars.Name = "typeStars";
            this.typeStars.Size = new System.Drawing.Size(435, 231);
            this.typeStars.TabIndex = 3;
            this.typeStars.TabStop = false;
            this.typeStars.Text = "ВЫБРАТЬ ТИП ЗВЕЗДЫ";
            // 
            // var4
            // 
            this.var4.AutoSize = true;
            this.var4.Font = new System.Drawing.Font("Impact", 17F);
            this.var4.ForeColor = System.Drawing.Color.Violet;
            this.var4.Location = new System.Drawing.Point(136, 179);
            this.var4.Name = "var4";
            this.var4.Size = new System.Drawing.Size(159, 40);
            this.var4.TabIndex = 3;
            this.var4.TabStop = true;
            this.var4.Text = "4 ВАРИАНТ";
            this.var4.UseVisualStyleBackColor = true;
            // 
            // variants
            // 
            this.variants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("variants.BackgroundImage")));
            this.variants.Font = new System.Drawing.Font("Impact", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variants.ForeColor = System.Drawing.Color.LavenderBlush;
            this.variants.Location = new System.Drawing.Point(44, 114);
            this.variants.Name = "variants";
            this.variants.Size = new System.Drawing.Size(325, 319);
            this.variants.TabIndex = 4;
            this.variants.Text = "ВАРИАНТЫ ЗВЁЗД";
            this.variants.UseVisualStyleBackColor = true;
            this.variants.Click += new System.EventHandler(this.variants_Click);
            // 
            // colorStars
            // 
            this.colorStars.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.colorStars.Font = new System.Drawing.Font("Impact", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorStars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorStars.Location = new System.Drawing.Point(851, 114);
            this.colorStars.Name = "colorStars";
            this.colorStars.Size = new System.Drawing.Size(325, 319);
            this.colorStars.TabIndex = 5;
            this.colorStars.Text = "ЦВЕТ ЗВЕЗДЫ";
            this.colorStars.UseVisualStyleBackColor = false;
            this.colorStars.Click += new System.EventHandler(this.colorStars_Click);
            // 
            // sizeStars
            // 
            this.sizeStars.AutoSize = true;
            this.sizeStars.BackColor = System.Drawing.Color.Transparent;
            this.sizeStars.Font = new System.Drawing.Font("Impact", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeStars.ForeColor = System.Drawing.Color.Fuchsia;
            this.sizeStars.Location = new System.Drawing.Point(401, 472);
            this.sizeStars.Name = "sizeStars";
            this.sizeStars.Size = new System.Drawing.Size(427, 72);
            this.sizeStars.TabIndex = 7;
            this.sizeStars.Text = "РАЗМЕР ЗВЕЗДЫ";
            // 
            // sizeStarsNumber
            // 
            this.sizeStarsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeStarsNumber.BackColor = System.Drawing.Color.Fuchsia;
            this.sizeStarsNumber.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeStarsNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.sizeStarsNumber.Location = new System.Drawing.Point(264, 547);
            this.sizeStarsNumber.Multiline = true;
            this.sizeStarsNumber.Name = "sizeStarsNumber";
            this.sizeStarsNumber.Size = new System.Drawing.Size(681, 82);
            this.sizeStarsNumber.TabIndex = 8;
            this.sizeStarsNumber.Text = "300";
            this.sizeStarsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.Orchid;
            this.draw.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.draw.ForeColor = System.Drawing.Color.Lime;
            this.draw.Location = new System.Drawing.Point(393, 31);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(435, 106);
            this.draw.TabIndex = 9;
            this.draw.Text = "НАРИСОВАТЬ";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(27, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "КОЛИЧЕСТВО ЗВЁЗД";
            // 
            // maxValue
            // 
            this.maxValue.BackColor = System.Drawing.Color.Fuchsia;
            this.maxValue.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxValue.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.maxValue.Location = new System.Drawing.Point(30, 511);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(120, 23);
            this.maxValue.TabIndex = 11;
            this.maxValue.Text = "1";
            this.maxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxValue.TextChanged += new System.EventHandler(this.maxValue_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(1047, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "СИРИУС";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(526, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Открыть в word";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1236, 662);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.sizeStarsNumber);
            this.Controls.Add(this.sizeStars);
            this.Controls.Add(this.colorStars);
            this.Controls.Add(this.variants);
            this.Controls.Add(this.typeStars);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.typeStars.ResumeLayout(false);
            this.typeStars.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton var1;
        private System.Windows.Forms.RadioButton var2;
        private System.Windows.Forms.RadioButton var3;
        private System.Windows.Forms.GroupBox typeStars;
        private System.Windows.Forms.Button variants;
        private System.Windows.Forms.Button colorStars;
        private System.Windows.Forms.Label sizeStars;
        private System.Windows.Forms.TextBox sizeStarsNumber;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.RadioButton var4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

