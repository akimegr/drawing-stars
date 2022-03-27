
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
            this.variants = new System.Windows.Forms.Button();
            this.colorStars = new System.Windows.Forms.Button();
            this.sizeStars = new System.Windows.Forms.Label();
            this.sizeStarsNumber = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.var4 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            this.sizeStarsNumber.Text = "100";
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
    }
}

