
namespace Бережливый_стоматолог
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
            this.authorsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menButton = new System.Windows.Forms.Button();
            this.femaleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorsButton
            // 
            this.authorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsButton.Location = new System.Drawing.Point(78, 479);
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(129, 35);
            this.authorsButton.TabIndex = 0;
            this.authorsButton.Text = "Авторы";
            this.authorsButton.UseVisualStyleBackColor = true;
            this.authorsButton.Click += new System.EventHandler(this.authorsButton_Click);
            this.authorsButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.authorsButton.MouseLeave += new System.EventHandler(this.authorsButton_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(484, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бережливый стоматолог";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите пол пациента";
            // 
            // menButton
            // 
            this.menButton.BackColor = System.Drawing.Color.Silver;
            this.menButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menButton.Location = new System.Drawing.Point(137, 256);
            this.menButton.Name = "menButton";
            this.menButton.Size = new System.Drawing.Size(146, 51);
            this.menButton.TabIndex = 4;
            this.menButton.Text = "Мужской";
            this.menButton.UseVisualStyleBackColor = false;
            this.menButton.Click += new System.EventHandler(this.menButton_Click);
            // 
            // femaleButton
            // 
            this.femaleButton.BackColor = System.Drawing.Color.Silver;
            this.femaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleButton.Location = new System.Drawing.Point(388, 256);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(146, 51);
            this.femaleButton.TabIndex = 5;
            this.femaleButton.Text = "Женский";
            this.femaleButton.UseVisualStyleBackColor = false;
            this.femaleButton.Click += new System.EventHandler(this.femaleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 578);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.menButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authorsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button menButton;
        private System.Windows.Forms.Button femaleButton;
    }
}

