namespace ProgressBarDz
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.btNext = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.tBAnswer4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(134, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(509, 65);
            this.Title.TabIndex = 0;
            this.Title.Text = "Анкета программиста";
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(32, 103);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(316, 20);
            this.Question.TabIndex = 1;
            this.Question.Text = "Вопрос 1:   Ваш стаж прогрмаммирования?";
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(32, 138);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(88, 19);
            this.Answer1.TabIndex = 2;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "Менее года";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(32, 172);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(44, 19);
            this.Answer2.TabIndex = 3;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "Год";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(32, 207);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(85, 19);
            this.Answer3.TabIndex = 4;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "Более года";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(215, 263);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(158, 30);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Далее";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(34, 240);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(100, 19);
            this.Answer4.TabIndex = 6;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "Свой вариант";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Visible = false;
            // 
            // tBAnswer4
            // 
            this.tBAnswer4.Location = new System.Drawing.Point(32, 270);
            this.tBAnswer4.Name = "tBAnswer4";
            this.tBAnswer4.Size = new System.Drawing.Size(167, 23);
            this.tBAnswer4.TabIndex = 7;
            this.tBAnswer4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBAnswer4);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label Question;
        private RadioButton Answer1;
        private RadioButton Answer2;
        private RadioButton Answer3;
        private Button btNext;
        private RadioButton Answer4;
        private TextBox tBAnswer4;
        private System.Windows.Forms.Timer timer1;
    }
}