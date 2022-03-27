
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.typeStars = new System.Windows.Forms.GroupBox();
            this.variants = new System.Windows.Forms.Button();
            this.colorStars = new System.Windows.Forms.Button();
            this.sizeStars = new System.Windows.Forms.Label();
            this.sizeStarsNumber = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.typeStars.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Impact", 17F);
            this.radioButton1.ForeColor = System.Drawing.Color.Violet;
            this.radioButton1.Location = new System.Drawing.Point(136, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 40);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 ВАРИАНТ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Impact", 17F);
            this.radioButton2.ForeColor = System.Drawing.Color.Violet;
            this.radioButton2.Location = new System.Drawing.Point(136, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 40);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "2 ВАРИАНТ";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Impact", 17F);
            this.radioButton3.ForeColor = System.Drawing.Color.Violet;
            this.radioButton3.Location = new System.Drawing.Point(136, 132);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 40);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "3 ВАРИАНТ";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // typeStars
            // 
            this.typeStars.BackColor = System.Drawing.Color.Transparent;
            this.typeStars.Controls.Add(this.radioButton3);
            this.typeStars.Controls.Add(this.radioButton1);
            this.typeStars.Controls.Add(this.radioButton2);
            this.typeStars.Font = new System.Drawing.Font("Impact", 16F);
            this.typeStars.ForeColor = System.Drawing.Color.Fuchsia;
            this.typeStars.Location = new System.Drawing.Point(393, 188);
            this.typeStars.Name = "typeStars";
            this.typeStars.Size = new System.Drawing.Size(435, 187);
            this.typeStars.TabIndex = 3;
            this.typeStars.TabStop = false;
            this.typeStars.Text = "ВЫБРАТЬ ТИП ЗВЕЗДЫ";
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
            // 
            // colorStars
            // 
            this.colorStars.BackColor = System.Drawing.Color.Magenta;
            this.colorStars.Font = new System.Drawing.Font("Impact", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorStars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.colorStars.Location = new System.Drawing.Point(851, 114);
            this.colorStars.Name = "colorStars";
            this.colorStars.Size = new System.Drawing.Size(325, 319);
            this.colorStars.TabIndex = 5;
            this.colorStars.Text = "ЦВЕТ ЗВЕЗДЫ";
            this.colorStars.UseVisualStyleBackColor = false;
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
            this.sizeStarsNumber.BackColor = System.Drawing.Color.Fuchsia;
            this.sizeStarsNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.sizeStarsNumber.Location = new System.Drawing.Point(264, 547);
            this.sizeStarsNumber.Multiline = true;
            this.sizeStarsNumber.Name = "sizeStarsNumber";
            this.sizeStarsNumber.Size = new System.Drawing.Size(681, 82);
            this.sizeStarsNumber.TabIndex = 8;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1236, 662);
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

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox typeStars;
        private System.Windows.Forms.Button variants;
        private System.Windows.Forms.Button colorStars;
        private System.Windows.Forms.Label sizeStars;
        private System.Windows.Forms.TextBox sizeStarsNumber;
        private System.Windows.Forms.Button draw;
    }
}

