namespace FastFoodSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.rtb_Ready = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_Received = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_WaitClient = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Cook = new System.Windows.Forms.NumericUpDown();
            this.lbl_timer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WaitClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Временной интервал поступления заказов (секунд)";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 400);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(164, 38);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Пуск";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // rtb_Ready
            // 
            this.rtb_Ready.Location = new System.Drawing.Point(624, 25);
            this.rtb_Ready.Name = "rtb_Ready";
            this.rtb_Ready.Size = new System.Drawing.Size(164, 413);
            this.rtb_Ready.TabIndex = 2;
            this.rtb_Ready.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Готово";
            // 
            // rtb_Received
            // 
            this.rtb_Received.Location = new System.Drawing.Point(454, 25);
            this.rtb_Received.Name = "rtb_Received";
            this.rtb_Received.Size = new System.Drawing.Size(164, 413);
            this.rtb_Received.TabIndex = 4;
            this.rtb_Received.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поступившие заказы";
            // 
            // nud_WaitClient
            // 
            this.nud_WaitClient.Location = new System.Drawing.Point(303, 9);
            this.nud_WaitClient.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_WaitClient.Name = "nud_WaitClient";
            this.nud_WaitClient.Size = new System.Drawing.Size(151, 20);
            this.nud_WaitClient.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Временной интервал для повара (секунд)";
            // 
            // nud_Cook
            // 
            this.nud_Cook.Location = new System.Drawing.Point(303, 35);
            this.nud_Cook.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Cook.Name = "nud_Cook";
            this.nud_Cook.Size = new System.Drawing.Size(151, 20);
            this.nud_Cook.TabIndex = 8;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(195, 413);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(33, 13);
            this.lbl_timer.TabIndex = 11;
            this.lbl_timer.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.nud_Cook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_WaitClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_Received);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_Ready);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_WaitClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.RichTextBox rtb_Ready;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_Received;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_WaitClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Cook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
    }
}

