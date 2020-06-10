namespace GradedImageConversions
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.src_pic_box = new System.Windows.Forms.PictureBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.res_pic_box = new System.Windows.Forms.PictureBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.darkCheckBox = new System.Windows.Forms.CheckBox();
            this.negativeBtn = new System.Windows.Forms.RadioButton();
            this.logBtn = new System.Windows.Forms.RadioButton();
            this.gammaBtn = new System.Windows.Forms.RadioButton();
            this.monochromeBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.brightBtn = new System.Windows.Forms.RadioButton();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.src_pic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.res_pic_box)).BeginInit();
            this.filterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // src_pic_box
            // 
            this.src_pic_box.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.src_pic_box.Location = new System.Drawing.Point(12, 12);
            this.src_pic_box.Name = "src_pic_box";
            this.src_pic_box.Size = new System.Drawing.Size(400, 250);
            this.src_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.src_pic_box.TabIndex = 0;
            this.src_pic_box.TabStop = false;
            // 
            // convertBtn
            // 
            this.convertBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convertBtn.Location = new System.Drawing.Point(420, 481);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(183, 48);
            this.convertBtn.TabIndex = 13;
            this.convertBtn.Text = "Преобразовать";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // res_pic_box
            // 
            this.res_pic_box.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.res_pic_box.Location = new System.Drawing.Point(12, 279);
            this.res_pic_box.Name = "res_pic_box";
            this.res_pic_box.Size = new System.Drawing.Size(400, 250);
            this.res_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.res_pic_box.TabIndex = 5;
            this.res_pic_box.TabStop = false;
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openBtn.Location = new System.Drawing.Point(420, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(90, 24);
            this.openBtn.TabIndex = 9;
            this.openBtn.Text = "Открыть";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(513, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 24);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // aTextBox
            // 
            this.aTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBox.Location = new System.Drawing.Point(423, 437);
            this.aTextBox.MaxLength = 4;
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(87, 20);
            this.aTextBox.TabIndex = 13;
            this.aTextBox.Visible = false;
            this.aTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aTextBox_KeyPress);
            // 
            // bTextBox
            // 
            this.bTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTextBox.Location = new System.Drawing.Point(513, 437);
            this.bTextBox.MaxLength = 4;
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(90, 20);
            this.bTextBox.TabIndex = 14;
            this.bTextBox.Visible = false;
            this.bTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bTextBox_KeyPress);
            // 
            // aLabel
            // 
            this.aLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel.AutoSize = true;
            this.aLabel.ForeColor = System.Drawing.Color.Black;
            this.aLabel.Location = new System.Drawing.Point(420, 421);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(18, 13);
            this.aLabel.TabIndex = 15;
            this.aLabel.Text = "от";
            this.aLabel.Visible = false;
            // 
            // bLabel
            // 
            this.bLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLabel.AutoSize = true;
            this.bLabel.ForeColor = System.Drawing.Color.Black;
            this.bLabel.Location = new System.Drawing.Point(510, 421);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(19, 13);
            this.bLabel.TabIndex = 16;
            this.bLabel.Text = "до";
            this.bLabel.Visible = false;
            // 
            // darkCheckBox
            // 
            this.darkCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.darkCheckBox.AutoSize = true;
            this.darkCheckBox.Location = new System.Drawing.Point(422, 401);
            this.darkCheckBox.Name = "darkCheckBox";
            this.darkCheckBox.Size = new System.Drawing.Size(145, 17);
            this.darkCheckBox.TabIndex = 17;
            this.darkCheckBox.Text = "Затемнение диапазона";
            this.darkCheckBox.UseVisualStyleBackColor = true;
            this.darkCheckBox.Visible = false;
            // 
            // negativeBtn
            // 
            this.negativeBtn.AutoSize = true;
            this.negativeBtn.Checked = true;
            this.negativeBtn.Location = new System.Drawing.Point(16, 19);
            this.negativeBtn.Name = "negativeBtn";
            this.negativeBtn.Size = new System.Drawing.Size(67, 17);
            this.negativeBtn.TabIndex = 0;
            this.negativeBtn.TabStop = true;
            this.negativeBtn.Text = "Негатив";
            this.negativeBtn.UseVisualStyleBackColor = true;
            this.negativeBtn.CheckedChanged += new System.EventHandler(this.negativeBtn_CheckedChanged);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(16, 42);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(119, 17);
            this.logBtn.TabIndex = 1;
            this.logBtn.Text = "Логарифмический";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.CheckedChanged += new System.EventHandler(this.logBtn_CheckedChanged);
            // 
            // gammaBtn
            // 
            this.gammaBtn.AutoSize = true;
            this.gammaBtn.Location = new System.Drawing.Point(16, 65);
            this.gammaBtn.Name = "gammaBtn";
            this.gammaBtn.Size = new System.Drawing.Size(59, 17);
            this.gammaBtn.TabIndex = 2;
            this.gammaBtn.Text = "Гамма";
            this.gammaBtn.UseVisualStyleBackColor = true;
            this.gammaBtn.CheckedChanged += new System.EventHandler(this.gammaBtn_CheckedChanged);
            // 
            // monochromeBtn
            // 
            this.monochromeBtn.AutoSize = true;
            this.monochromeBtn.Location = new System.Drawing.Point(16, 104);
            this.monochromeBtn.Name = "monochromeBtn";
            this.monochromeBtn.Size = new System.Drawing.Size(121, 17);
            this.monochromeBtn.TabIndex = 3;
            this.monochromeBtn.Text = "Двухградационное";
            this.monochromeBtn.UseVisualStyleBackColor = true;
            this.monochromeBtn.CheckedChanged += new System.EventHandler(this.monochromeBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Изменение яркости диапазона";
            // 
            // brightBtn
            // 
            this.brightBtn.AutoSize = true;
            this.brightBtn.Location = new System.Drawing.Point(16, 127);
            this.brightBtn.Name = "brightBtn";
            this.brightBtn.Size = new System.Drawing.Size(68, 17);
            this.brightBtn.TabIndex = 4;
            this.brightBtn.Text = "Цветное";
            this.brightBtn.UseVisualStyleBackColor = true;
            this.brightBtn.CheckedChanged += new System.EventHandler(this.brightBtn_CheckedChanged);
            // 
            // filterBox
            // 
            this.filterBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBox.Controls.Add(this.brightBtn);
            this.filterBox.Controls.Add(this.label2);
            this.filterBox.Controls.Add(this.monochromeBtn);
            this.filterBox.Controls.Add(this.gammaBtn);
            this.filterBox.Controls.Add(this.logBtn);
            this.filterBox.Controls.Add(this.negativeBtn);
            this.filterBox.Location = new System.Drawing.Point(423, 42);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(183, 154);
            this.filterBox.TabIndex = 8;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Фильтры";
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorLabel.Enabled = false;
            this.errorLabel.Location = new System.Drawing.Point(13, 264);
            this.errorLabel.MaxLength = 4;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(586, 13);
            this.errorLabel.TabIndex = 19;
            this.errorLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 541);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.darkCheckBox);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.res_pic_box);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.src_pic_box);
            this.MaximumSize = new System.Drawing.Size(625, 580);
            this.MinimumSize = new System.Drawing.Size(625, 580);
            this.Name = "Form1";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.src_pic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.res_pic_box)).EndInit();
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.RadioButton brightBtn;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.CheckBox darkCheckBox;
        private System.Windows.Forms.TextBox errorLabel;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.RadioButton gammaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton logBtn;
        private System.Windows.Forms.RadioButton monochromeBtn;
        private System.Windows.Forms.RadioButton negativeBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.PictureBox res_pic_box;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox src_pic_box;

        #endregion
    }
}

