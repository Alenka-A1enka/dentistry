
namespace Бережливый_стоматолог
{
    partial class AgeForm
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
            this.secondButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.authorsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondButton
            // 
            this.secondButton.BackColor = System.Drawing.Color.Silver;
            this.secondButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondButton.Location = new System.Drawing.Point(395, 236);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(152, 90);
            this.secondButton.TabIndex = 11;
            this.secondButton.Text = "2 период \r\n";
            this.secondButton.UseVisualStyleBackColor = false;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.Silver;
            this.firstButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstButton.Location = new System.Drawing.Point(138, 236);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(152, 90);
            this.firstButton.TabIndex = 10;
            this.firstButton.Text = "1 период\r\n";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(129, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выберите возрастной период пациента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Бережливый стоматолог";
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
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorsButton
            // 
            this.authorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsButton.Location = new System.Drawing.Point(78, 479);
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(129, 35);
            this.authorsButton.TabIndex = 6;
            this.authorsButton.Text = "Авторы";
            this.authorsButton.UseVisualStyleBackColor = true;
            this.authorsButton.Click += new System.EventHandler(this.authorsButton_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(272, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authorsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgeForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button authorsButton;
        private System.Windows.Forms.Button button2;
    }
}