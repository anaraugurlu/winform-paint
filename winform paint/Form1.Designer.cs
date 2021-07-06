
namespace winform_paint
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
            this.emptyRadiobtn = new System.Windows.Forms.RadioButton();
            this.fillRadiobtn = new System.Windows.Forms.RadioButton();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.heightTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.figureCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // emptyRadiobtn
            // 
            this.emptyRadiobtn.AutoSize = true;
            this.emptyRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptyRadiobtn.Location = new System.Drawing.Point(198, 316);
            this.emptyRadiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.emptyRadiobtn.Name = "emptyRadiobtn";
            this.emptyRadiobtn.Size = new System.Drawing.Size(133, 35);
            this.emptyRadiobtn.TabIndex = 26;
            this.emptyRadiobtn.TabStop = true;
            this.emptyRadiobtn.Text = "EMPTY";
            this.emptyRadiobtn.UseVisualStyleBackColor = true;
            // 
            // fillRadiobtn
            // 
            this.fillRadiobtn.AutoSize = true;
            this.fillRadiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillRadiobtn.Location = new System.Drawing.Point(57, 316);
            this.fillRadiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.fillRadiobtn.Name = "fillRadiobtn";
            this.fillRadiobtn.Size = new System.Drawing.Size(94, 35);
            this.fillRadiobtn.TabIndex = 25;
            this.fillRadiobtn.TabStop = true;
            this.fillRadiobtn.Text = "FILL";
            this.fillRadiobtn.UseVisualStyleBackColor = true;
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBtn.Location = new System.Drawing.Point(199, 227);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(135, 52);
            this.selectBtn.TabIndex = 24;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Color";
            // 
            // heightTxtb
            // 
            this.heightTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightTxtb.Location = new System.Drawing.Point(199, 170);
            this.heightTxtb.Margin = new System.Windows.Forms.Padding(4);
            this.heightTxtb.Name = "heightTxtb";
            this.heightTxtb.Size = new System.Drawing.Size(132, 34);
            this.heightTxtb.TabIndex = 22;
            this.heightTxtb.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "Height";
            // 
            // widthTxtb
            // 
            this.widthTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthTxtb.Location = new System.Drawing.Point(199, 120);
            this.widthTxtb.Margin = new System.Windows.Forms.Padding(4);
            this.widthTxtb.Name = "widthTxtb";
            this.widthTxtb.Size = new System.Drawing.Size(132, 34);
            this.widthTxtb.TabIndex = 20;
            this.widthTxtb.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Width";
            // 
            // figureCombobox
            // 
            this.figureCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.figureCombobox.FormattingEnabled = true;
            this.figureCombobox.Location = new System.Drawing.Point(58, 55);
            this.figureCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.figureCombobox.Name = "figureCombobox";
            this.figureCombobox.Size = new System.Drawing.Size(273, 38);
            this.figureCombobox.TabIndex = 18;
            this.figureCombobox.SelectedIndexChanged += new System.EventHandler(this.figureCombobox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 606);
            this.Controls.Add(this.emptyRadiobtn);
            this.Controls.Add(this.fillRadiobtn);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightTxtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTxtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.figureCombobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton emptyRadiobtn;
        private System.Windows.Forms.RadioButton fillRadiobtn;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heightTxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTxtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox figureCombobox;
    }
}

