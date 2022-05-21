
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.le1 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.h1 = new System.Windows.Forms.RadioButton();
            this.l1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helperToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.startItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeStars.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.typeStars.Location = new System.Drawing.Point(393, 209);
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
            this.sizeStarsNumber.Size = new System.Drawing.Size(690, 82);
            this.sizeStarsNumber.TabIndex = 8;
            this.sizeStarsNumber.Text = "240";
            this.sizeStarsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // draw
            // 
            this.draw.BackColor = System.Drawing.Color.Orchid;
            this.draw.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.draw.ForeColor = System.Drawing.Color.Lime;
            this.draw.Location = new System.Drawing.Point(0, 28);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(44, 43);
            this.draw.TabIndex = 9;
            this.draw.Text = "НАРИСОВАТЬ";
            this.draw.UseVisualStyleBackColor = false;
            this.draw.Visible = false;
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
            this.button1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(38, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "СИРИУС";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(0, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Открыть в word";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(38, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "pause";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(104, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 47);
            this.button4.TabIndex = 15;
            this.button4.Text = "stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // le1
            // 
            this.le1.AutoSize = true;
            this.le1.BackColor = System.Drawing.Color.SlateBlue;
            this.le1.Location = new System.Drawing.Point(6, 94);
            this.le1.Name = "le1";
            this.le1.Size = new System.Drawing.Size(17, 16);
            this.le1.TabIndex = 4;
            this.le1.UseVisualStyleBackColor = false;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.BackColor = System.Drawing.Color.SlateBlue;
            this.r1.Checked = true;
            this.r1.Location = new System.Drawing.Point(209, 89);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(17, 16);
            this.r1.TabIndex = 16;
            this.r1.TabStop = true;
            this.r1.UseVisualStyleBackColor = false;
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.Color.SlateBlue;
            this.h1.Location = new System.Drawing.Point(107, 20);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(17, 16);
            this.h1.TabIndex = 17;
            this.h1.UseVisualStyleBackColor = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.SlateBlue;
            this.l1.Location = new System.Drawing.Point(107, 147);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(17, 16);
            this.l1.TabIndex = 18;
            this.l1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.r1);
            this.groupBox1.Controls.Add(this.h1);
            this.groupBox1.Controls.Add(this.le1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(503, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 173);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Location = new System.Drawing.Point(26, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 51);
            this.button6.TabIndex = 21;
            this.button6.Text = "←";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.Location = new System.Drawing.Point(84, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 47);
            this.button7.TabIndex = 22;
            this.button7.Text = "↓";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Crimson;
            this.button8.Location = new System.Drawing.Point(145, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 51);
            this.button8.TabIndex = 0;
            this.button8.Text = "→";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Location = new System.Drawing.Point(84, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 46);
            this.button5.TabIndex = 20;
            this.button5.Text = "↑";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton3,
            this.toolStripSeparator1,
            this.toolStripSplitButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1245, 27);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helperToolStripMenuItem1});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton3.Text = "toolStripSplitButton3";
            this.toolStripSplitButton3.ButtonClick += new System.EventHandler(this.toolStripSplitButton3_ButtonClick);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "about";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helperToolStripMenuItem1
            // 
            this.helperToolStripMenuItem1.Name = "helperToolStripMenuItem1";
            this.helperToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.helperToolStripMenuItem1.Text = "helper";
            this.helperToolStripMenuItem1.Click += new System.EventHandler(this.helperToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.drawToolStripMenuItem.Text = "Нарисовать звезду";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.wordToolStripMenuItem.Text = "Открыть в word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startItem,
            this.pauseItem,
            this.stopItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // startItem
            // 
            this.startItem.Name = "startItem";
            this.startItem.Size = new System.Drawing.Size(224, 26);
            this.startItem.Text = "Сириус";
            this.startItem.Click += new System.EventHandler(this.сириусToolStripMenuItem_Click);
            // 
            // pauseItem
            // 
            this.pauseItem.Name = "pauseItem";
            this.pauseItem.Size = new System.Drawing.Size(224, 26);
            this.pauseItem.Text = "Pause";
            this.pauseItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopItem
            // 
            this.stopItem.Name = "stopItem";
            this.stopItem.Size = new System.Drawing.Size(224, 26);
            this.stopItem.Text = "Stop";
            this.stopItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1245, 662);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.typeStars.ResumeLayout(false);
            this.typeStars.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton le1;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton h1;
        private System.Windows.Forms.RadioButton l1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helperToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem startItem;
        private System.Windows.Forms.ToolStripMenuItem pauseItem;
        private System.Windows.Forms.ToolStripMenuItem stopItem;
    }
}

