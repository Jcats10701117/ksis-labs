namespace Lab3
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
            this.ipConfig_button = new System.Windows.Forms.Button();
            this.dns_button = new System.Windows.Forms.Button();
            this.dns_textBox = new System.Windows.Forms.TextBox();
            this.broadcast_button = new System.Windows.Forms.Button();
            this.loopback_button = new System.Windows.Forms.Button();
            this.any_button = new System.Windows.Forms.Button();
            this.result_richTextBox = new System.Windows.Forms.RichTextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipConfig_button
            // 
            this.ipConfig_button.Location = new System.Drawing.Point(12, 12);
            this.ipConfig_button.Name = "ipConfig_button";
            this.ipConfig_button.Size = new System.Drawing.Size(397, 30);
            this.ipConfig_button.TabIndex = 0;
            this.ipConfig_button.Text = "ip config /all";
            this.ipConfig_button.UseVisualStyleBackColor = true;
            this.ipConfig_button.Click += new System.EventHandler(this.ipConfig_button_Click);
            // 
            // dns_button
            // 
            this.dns_button.Location = new System.Drawing.Point(12, 48);
            this.dns_button.Name = "dns_button";
            this.dns_button.Size = new System.Drawing.Size(397, 30);
            this.dns_button.TabIndex = 1;
            this.dns_button.Text = "dns";
            this.dns_button.UseVisualStyleBackColor = true;
            this.dns_button.Click += new System.EventHandler(this.dns_button_Click);
            // 
            // dns_textBox
            // 
            this.dns_textBox.Location = new System.Drawing.Point(12, 84);
            this.dns_textBox.Name = "dns_textBox";
            this.dns_textBox.Size = new System.Drawing.Size(397, 20);
            this.dns_textBox.TabIndex = 2;
            // 
            // broadcast_button
            // 
            this.broadcast_button.Location = new System.Drawing.Point(12, 153);
            this.broadcast_button.Name = "broadcast_button";
            this.broadcast_button.Size = new System.Drawing.Size(397, 30);
            this.broadcast_button.TabIndex = 3;
            this.broadcast_button.Text = "Broadcast";
            this.broadcast_button.UseVisualStyleBackColor = true;
            this.broadcast_button.Click += new System.EventHandler(this.broadcast_button_Click);
            // 
            // loopback_button
            // 
            this.loopback_button.Location = new System.Drawing.Point(12, 189);
            this.loopback_button.Name = "loopback_button";
            this.loopback_button.Size = new System.Drawing.Size(397, 30);
            this.loopback_button.TabIndex = 4;
            this.loopback_button.Text = "Loopback";
            this.loopback_button.UseVisualStyleBackColor = true;
            this.loopback_button.Click += new System.EventHandler(this.loopback_button_Click);
            // 
            // any_button
            // 
            this.any_button.Location = new System.Drawing.Point(12, 225);
            this.any_button.Name = "any_button";
            this.any_button.Size = new System.Drawing.Size(397, 30);
            this.any_button.TabIndex = 5;
            this.any_button.Text = "Any";
            this.any_button.UseVisualStyleBackColor = true;
            this.any_button.Click += new System.EventHandler(this.any_button_Click);
            // 
            // result_richTextBox
            // 
            this.result_richTextBox.Location = new System.Drawing.Point(415, 8);
            this.result_richTextBox.Name = "result_richTextBox";
            this.result_richTextBox.ReadOnly = true;
            this.result_richTextBox.Size = new System.Drawing.Size(552, 247);
            this.result_richTextBox.TabIndex = 6;
            this.result_richTextBox.Text = "";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(12, 116);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 25);
            this.error_label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 267);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.result_richTextBox);
            this.Controls.Add(this.any_button);
            this.Controls.Add(this.loopback_button);
            this.Controls.Add(this.broadcast_button);
            this.Controls.Add(this.dns_textBox);
            this.Controls.Add(this.dns_button);
            this.Controls.Add(this.ipConfig_button);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ipConfig_button;
        private System.Windows.Forms.Button dns_button;
        private System.Windows.Forms.TextBox dns_textBox;
        private System.Windows.Forms.Button broadcast_button;
        private System.Windows.Forms.Button loopback_button;
        private System.Windows.Forms.Button any_button;
        private System.Windows.Forms.RichTextBox result_richTextBox;
        private System.Windows.Forms.Label error_label;
    }
}

