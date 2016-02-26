namespace CSPG220_FinalProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSpanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toItalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toItalianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toEnglishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toSpanishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toSpanishToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toItalianToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toEnglishToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toItalianToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.italianToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toEnglishToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toSpanishToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Eng2Span = new System.Windows.Forms.Button();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.Span2Eng = new System.Windows.Forms.Button();
            this.Eng2Ital = new System.Windows.Forms.Button();
            this.Ital2Eng = new System.Windows.Forms.Button();
            this.Span2Ital = new System.Windows.Forms.Button();
            this.Ital2Span = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.addEng2Span = new System.Windows.Forms.CheckBox();
            this.addEng2Ital = new System.Windows.Forms.CheckBox();
            this.addSpan2Eng = new System.Windows.Forms.CheckBox();
            this.addSpan2Ital = new System.Windows.Forms.CheckBox();
            this.addItal2Eng = new System.Windows.Forms.CheckBox();
            this.addItal2Span = new System.Windows.Forms.CheckBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem,
            this.italianToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toSpanishToolStripMenuItem,
            this.toItalianToolStripMenuItem});
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // toSpanishToolStripMenuItem
            // 
            this.toSpanishToolStripMenuItem.Name = "toSpanishToolStripMenuItem";
            this.toSpanishToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toSpanishToolStripMenuItem.Text = "To Spanish";
            this.toSpanishToolStripMenuItem.Click += new System.EventHandler(this.toSpanishToolStripMenuItem_Click);
            // 
            // toItalianToolStripMenuItem
            // 
            this.toItalianToolStripMenuItem.Name = "toItalianToolStripMenuItem";
            this.toItalianToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toItalianToolStripMenuItem.Text = "To Italian";
            this.toItalianToolStripMenuItem.Click += new System.EventHandler(this.toItalianToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEnglishToolStripMenuItem,
            this.toItalianToolStripMenuItem1});
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.spanishToolStripMenuItem.Text = "Espanol";
            // 
            // toEnglishToolStripMenuItem
            // 
            this.toEnglishToolStripMenuItem.Name = "toEnglishToolStripMenuItem";
            this.toEnglishToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.toEnglishToolStripMenuItem.Text = "A Ingles";
            this.toEnglishToolStripMenuItem.Click += new System.EventHandler(this.toEnglishToolStripMenuItem_Click);
            // 
            // toItalianToolStripMenuItem1
            // 
            this.toItalianToolStripMenuItem1.Name = "toItalianToolStripMenuItem1";
            this.toItalianToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.toItalianToolStripMenuItem1.Text = "Al Italiano";
            this.toItalianToolStripMenuItem1.Click += new System.EventHandler(this.toItalianToolStripMenuItem1_Click);
            // 
            // italianToolStripMenuItem
            // 
            this.italianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEnglishToolStripMenuItem1,
            this.toSpanishToolStripMenuItem1});
            this.italianToolStripMenuItem.Name = "italianToolStripMenuItem";
            this.italianToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.italianToolStripMenuItem.Text = "Italiano";
            // 
            // toEnglishToolStripMenuItem1
            // 
            this.toEnglishToolStripMenuItem1.Name = "toEnglishToolStripMenuItem1";
            this.toEnglishToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toEnglishToolStripMenuItem1.Text = "Di Inglese";
            this.toEnglishToolStripMenuItem1.Click += new System.EventHandler(this.toEnglishToolStripMenuItem1_Click);
            // 
            // toSpanishToolStripMenuItem1
            // 
            this.toSpanishToolStripMenuItem1.Name = "toSpanishToolStripMenuItem1";
            this.toSpanishToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toSpanishToolStripMenuItem1.Text = "Allo Spagnolo";
            this.toSpanishToolStripMenuItem1.Click += new System.EventHandler(this.toSpanishToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.spanishToolStripMenuItem1,
            this.italianToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.addToolStripMenuItem.Text = "Add Word";
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toSpanishToolStripMenuItem2,
            this.toItalianToolStripMenuItem2});
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem1.Text = "English";
            // 
            // toSpanishToolStripMenuItem2
            // 
            this.toSpanishToolStripMenuItem2.Name = "toSpanishToolStripMenuItem2";
            this.toSpanishToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toSpanishToolStripMenuItem2.Text = "To Spanish";
            this.toSpanishToolStripMenuItem2.Click += new System.EventHandler(this.toSpanishToolStripMenuItem2_Click);
            // 
            // toItalianToolStripMenuItem2
            // 
            this.toItalianToolStripMenuItem2.Name = "toItalianToolStripMenuItem2";
            this.toItalianToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toItalianToolStripMenuItem2.Text = "To Italian";
            this.toItalianToolStripMenuItem2.Click += new System.EventHandler(this.toItalianToolStripMenuItem2_Click);
            // 
            // spanishToolStripMenuItem1
            // 
            this.spanishToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEnglishToolStripMenuItem2,
            this.toItalianToolStripMenuItem3});
            this.spanishToolStripMenuItem1.Name = "spanishToolStripMenuItem1";
            this.spanishToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.spanishToolStripMenuItem1.Text = "Espanol";
            // 
            // toEnglishToolStripMenuItem2
            // 
            this.toEnglishToolStripMenuItem2.Name = "toEnglishToolStripMenuItem2";
            this.toEnglishToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toEnglishToolStripMenuItem2.Text = "A Ingles";
            this.toEnglishToolStripMenuItem2.Click += new System.EventHandler(this.toEnglishToolStripMenuItem2_Click);
            // 
            // toItalianToolStripMenuItem3
            // 
            this.toItalianToolStripMenuItem3.Name = "toItalianToolStripMenuItem3";
            this.toItalianToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toItalianToolStripMenuItem3.Text = "Al Italiano";
            this.toItalianToolStripMenuItem3.Click += new System.EventHandler(this.toItalianToolStripMenuItem3_Click);
            // 
            // italianToolStripMenuItem1
            // 
            this.italianToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEnglishToolStripMenuItem3,
            this.toSpanishToolStripMenuItem3});
            this.italianToolStripMenuItem1.Name = "italianToolStripMenuItem1";
            this.italianToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.italianToolStripMenuItem1.Text = "Italiano";
            // 
            // toEnglishToolStripMenuItem3
            // 
            this.toEnglishToolStripMenuItem3.Name = "toEnglishToolStripMenuItem3";
            this.toEnglishToolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.toEnglishToolStripMenuItem3.Text = "Di Inglese";
            this.toEnglishToolStripMenuItem3.Click += new System.EventHandler(this.toEnglishToolStripMenuItem3_Click);
            // 
            // toSpanishToolStripMenuItem3
            // 
            this.toSpanishToolStripMenuItem3.Name = "toSpanishToolStripMenuItem3";
            this.toSpanishToolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.toSpanishToolStripMenuItem3.Text = "Allo Espagnolo";
            this.toSpanishToolStripMenuItem3.Click += new System.EventHandler(this.toSpanishToolStripMenuItem3_Click);
            // 
            // Eng2Span
            // 
            this.Eng2Span.Enabled = false;
            this.Eng2Span.Location = new System.Drawing.Point(300, 185);
            this.Eng2Span.Margin = new System.Windows.Forms.Padding(2);
            this.Eng2Span.Name = "Eng2Span";
            this.Eng2Span.Size = new System.Drawing.Size(128, 46);
            this.Eng2Span.TabIndex = 2;
            this.Eng2Span.Text = "Translate";
            this.Eng2Span.UseVisualStyleBackColor = true;
            this.Eng2Span.Visible = false;
            this.Eng2Span.Click += new System.EventHandler(this.Eng2Span_Click);
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.Color.Silver;
            this.rtb1.Enabled = false;
            this.rtb1.Font = new System.Drawing.Font("Felix Titling", 24F);
            this.rtb1.Location = new System.Drawing.Point(74, 79);
            this.rtb1.Margin = new System.Windows.Forms.Padding(2);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(566, 79);
            this.rtb1.TabIndex = 4;
            this.rtb1.Text = "";
            this.rtb1.Visible = false;
            // 
            // Span2Eng
            // 
            this.Span2Eng.Enabled = false;
            this.Span2Eng.Location = new System.Drawing.Point(300, 185);
            this.Span2Eng.Margin = new System.Windows.Forms.Padding(2);
            this.Span2Eng.Name = "Span2Eng";
            this.Span2Eng.Size = new System.Drawing.Size(128, 46);
            this.Span2Eng.TabIndex = 5;
            this.Span2Eng.Text = "Translate";
            this.Span2Eng.UseVisualStyleBackColor = true;
            this.Span2Eng.Visible = false;
            this.Span2Eng.Click += new System.EventHandler(this.Span2Eng_Click);
            // 
            // Eng2Ital
            // 
            this.Eng2Ital.Enabled = false;
            this.Eng2Ital.Location = new System.Drawing.Point(300, 185);
            this.Eng2Ital.Margin = new System.Windows.Forms.Padding(2);
            this.Eng2Ital.Name = "Eng2Ital";
            this.Eng2Ital.Size = new System.Drawing.Size(128, 46);
            this.Eng2Ital.TabIndex = 6;
            this.Eng2Ital.Text = "Translate";
            this.Eng2Ital.UseVisualStyleBackColor = true;
            this.Eng2Ital.Visible = false;
            this.Eng2Ital.Click += new System.EventHandler(this.Eng2Ital_Click);
            // 
            // Ital2Eng
            // 
            this.Ital2Eng.Enabled = false;
            this.Ital2Eng.Location = new System.Drawing.Point(300, 185);
            this.Ital2Eng.Margin = new System.Windows.Forms.Padding(2);
            this.Ital2Eng.Name = "Ital2Eng";
            this.Ital2Eng.Size = new System.Drawing.Size(128, 46);
            this.Ital2Eng.TabIndex = 7;
            this.Ital2Eng.Text = "Translate";
            this.Ital2Eng.UseVisualStyleBackColor = true;
            this.Ital2Eng.Visible = false;
            this.Ital2Eng.Click += new System.EventHandler(this.Ital2Eng_Click);
            // 
            // Span2Ital
            // 
            this.Span2Ital.Enabled = false;
            this.Span2Ital.Location = new System.Drawing.Point(300, 185);
            this.Span2Ital.Margin = new System.Windows.Forms.Padding(2);
            this.Span2Ital.Name = "Span2Ital";
            this.Span2Ital.Size = new System.Drawing.Size(128, 46);
            this.Span2Ital.TabIndex = 8;
            this.Span2Ital.Text = "Translate";
            this.Span2Ital.UseVisualStyleBackColor = true;
            this.Span2Ital.Visible = false;
            this.Span2Ital.Click += new System.EventHandler(this.Span2Ital_Click);
            // 
            // Ital2Span
            // 
            this.Ital2Span.Enabled = false;
            this.Ital2Span.Location = new System.Drawing.Point(300, 185);
            this.Ital2Span.Margin = new System.Windows.Forms.Padding(2);
            this.Ital2Span.Name = "Ital2Span";
            this.Ital2Span.Size = new System.Drawing.Size(128, 46);
            this.Ital2Span.TabIndex = 9;
            this.Ital2Span.Text = "Translate";
            this.Ital2Span.UseVisualStyleBackColor = true;
            this.Ital2Span.Visible = false;
            this.Ital2Span.Click += new System.EventHandler(this.Ital2Span_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(300, 235);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtb2
            // 
            this.rtb2.BackColor = System.Drawing.Color.Silver;
            this.rtb2.Enabled = false;
            this.rtb2.Font = new System.Drawing.Font("Felix Titling", 24F);
            this.rtb2.Location = new System.Drawing.Point(74, 309);
            this.rtb2.Margin = new System.Windows.Forms.Padding(2);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(566, 79);
            this.rtb2.TabIndex = 11;
            this.rtb2.Text = "";
            this.rtb2.Visible = false;
            // 
            // addEng2Span
            // 
            this.addEng2Span.AutoSize = true;
            this.addEng2Span.Location = new System.Drawing.Point(0, 350);
            this.addEng2Span.Margin = new System.Windows.Forms.Padding(2);
            this.addEng2Span.Name = "addEng2Span";
            this.addEng2Span.Size = new System.Drawing.Size(15, 14);
            this.addEng2Span.TabIndex = 12;
            this.addEng2Span.UseVisualStyleBackColor = true;
            this.addEng2Span.Visible = false;
            // 
            // addEng2Ital
            // 
            this.addEng2Ital.AutoSize = true;
            this.addEng2Ital.Location = new System.Drawing.Point(18, 350);
            this.addEng2Ital.Margin = new System.Windows.Forms.Padding(2);
            this.addEng2Ital.Name = "addEng2Ital";
            this.addEng2Ital.Size = new System.Drawing.Size(15, 14);
            this.addEng2Ital.TabIndex = 13;
            this.addEng2Ital.UseVisualStyleBackColor = true;
            this.addEng2Ital.Visible = false;
            // 
            // addSpan2Eng
            // 
            this.addSpan2Eng.AutoSize = true;
            this.addSpan2Eng.Location = new System.Drawing.Point(0, 373);
            this.addSpan2Eng.Margin = new System.Windows.Forms.Padding(2);
            this.addSpan2Eng.Name = "addSpan2Eng";
            this.addSpan2Eng.Size = new System.Drawing.Size(15, 14);
            this.addSpan2Eng.TabIndex = 14;
            this.addSpan2Eng.UseVisualStyleBackColor = true;
            this.addSpan2Eng.Visible = false;
            // 
            // addSpan2Ital
            // 
            this.addSpan2Ital.AutoSize = true;
            this.addSpan2Ital.Location = new System.Drawing.Point(18, 373);
            this.addSpan2Ital.Margin = new System.Windows.Forms.Padding(2);
            this.addSpan2Ital.Name = "addSpan2Ital";
            this.addSpan2Ital.Size = new System.Drawing.Size(15, 14);
            this.addSpan2Ital.TabIndex = 15;
            this.addSpan2Ital.UseVisualStyleBackColor = true;
            this.addSpan2Ital.Visible = false;
            // 
            // addItal2Eng
            // 
            this.addItal2Eng.AutoSize = true;
            this.addItal2Eng.Location = new System.Drawing.Point(0, 396);
            this.addItal2Eng.Margin = new System.Windows.Forms.Padding(2);
            this.addItal2Eng.Name = "addItal2Eng";
            this.addItal2Eng.Size = new System.Drawing.Size(15, 14);
            this.addItal2Eng.TabIndex = 16;
            this.addItal2Eng.UseVisualStyleBackColor = true;
            this.addItal2Eng.Visible = false;
            // 
            // addItal2Span
            // 
            this.addItal2Span.AutoSize = true;
            this.addItal2Span.Location = new System.Drawing.Point(18, 396);
            this.addItal2Span.Margin = new System.Windows.Forms.Padding(2);
            this.addItal2Span.Name = "addItal2Span";
            this.addItal2Span.Size = new System.Drawing.Size(15, 14);
            this.addItal2Span.TabIndex = 17;
            this.addItal2Span.UseVisualStyleBackColor = true;
            this.addItal2Span.Visible = false;
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.Silver;
            this.lblInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInput.Font = new System.Drawing.Font("Felix Titling", 24F);
            this.lblInput.Location = new System.Drawing.Point(74, 79);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(565, 78);
            this.lblInput.TabIndex = 18;
            this.lblInput.Text = "Make A Selection";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Silver;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Felix Titling", 24F);
            this.lblDisplay.Location = new System.Drawing.Point(74, 309);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(565, 78);
            this.lblDisplay.TabIndex = 19;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(300, 235);
            this.btnSpeak.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(128, 46);
            this.btnSpeak.TabIndex = 20;
            this.btnSpeak.Text = "Pronounce";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 418);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.addItal2Span);
            this.Controls.Add(this.addItal2Eng);
            this.Controls.Add(this.addSpan2Ital);
            this.Controls.Add(this.addSpan2Eng);
            this.Controls.Add(this.addEng2Ital);
            this.Controls.Add(this.addEng2Span);
            this.Controls.Add(this.rtb2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Ital2Span);
            this.Controls.Add(this.Span2Ital);
            this.Controls.Add(this.Ital2Eng);
            this.Controls.Add(this.Eng2Ital);
            this.Controls.Add(this.Span2Eng);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.Eng2Span);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Overfield";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSpanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toItalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toItalianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toEnglishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toSpanishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button Eng2Span;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Button Span2Eng;
        private System.Windows.Forms.Button Eng2Ital;
        private System.Windows.Forms.Button Ital2Eng;
        private System.Windows.Forms.Button Span2Ital;
        private System.Windows.Forms.Button Ital2Span;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toSpanishToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toItalianToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toEnglishToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toItalianToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem italianToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toEnglishToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toSpanishToolStripMenuItem3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.CheckBox addEng2Span;
        private System.Windows.Forms.CheckBox addEng2Ital;
        private System.Windows.Forms.CheckBox addSpan2Eng;
        private System.Windows.Forms.CheckBox addSpan2Ital;
        private System.Windows.Forms.CheckBox addItal2Eng;
        private System.Windows.Forms.CheckBox addItal2Span;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnSpeak;
    }
}

