
namespace adofai.gg_level
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.levelBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.levelcur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // levelBtn
            // 
            this.levelBtn.Font = new System.Drawing.Font("godoMaum", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelBtn.Location = new System.Drawing.Point(159, 129);
            this.levelBtn.Name = "levelBtn";
            this.levelBtn.Size = new System.Drawing.Size(144, 76);
            this.levelBtn.TabIndex = 0;
            this.levelBtn.Text = "시작";
            this.levelBtn.UseVisualStyleBackColor = true;
            this.levelBtn.Click += new System.EventHandler(this.levelBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("godoMaum", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(433, 91);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "얼불춤 레벨 추천";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // levelcur
            // 
            this.levelcur.BackColor = System.Drawing.SystemColors.Control;
            this.levelcur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.levelcur.Font = new System.Drawing.Font("godoMaum", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levelcur.Location = new System.Drawing.Point(45, 211);
            this.levelcur.Name = "levelcur";
            this.levelcur.ReadOnly = true;
            this.levelcur.Size = new System.Drawing.Size(370, 68);
            this.levelcur.TabIndex = 3;
            this.levelcur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("godoMaum", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "사용법";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.levelcur);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.levelBtn);
            this.Name = "Form1";
            this.Text = "얼불춤 레벨 추천";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button levelBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox levelcur;
        private System.Windows.Forms.Button button1;
    }
}

