
namespace TicTacToe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_againstComputer = new System.Windows.Forms.RadioButton();
            this.rb_1x1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.varning_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вітаю в грі \"Хрестики-нулики\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перш ніж розпочати гру, оберіть режим:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "(його можна змінити в Налаштуваннях)";
            // 
            // rb_againstComputer
            // 
            this.rb_againstComputer.AutoSize = true;
            this.rb_againstComputer.Location = new System.Drawing.Point(159, 178);
            this.rb_againstComputer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rb_againstComputer.Name = "rb_againstComputer";
            this.rb_againstComputer.Size = new System.Drawing.Size(220, 24);
            this.rb_againstComputer.TabIndex = 3;
            this.rb_againstComputer.TabStop = true;
            this.rb_againstComputer.Text = "Гра проти комп`ютера";
            this.rb_againstComputer.UseVisualStyleBackColor = true;
            // 
            // rb_1x1
            // 
            this.rb_1x1.AutoSize = true;
            this.rb_1x1.Location = new System.Drawing.Point(159, 226);
            this.rb_1x1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rb_1x1.Name = "rb_1x1";
            this.rb_1x1.Size = new System.Drawing.Size(113, 24);
            this.rb_1x1.TabIndex = 4;
            this.rb_1x1.TabStop = true;
            this.rb_1x1.Text = "Гра 1 на 1";
            this.rb_1x1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(182, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Розпочати гру";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // varning_label
            // 
            this.varning_label.AutoSize = true;
            this.varning_label.ForeColor = System.Drawing.Color.Red;
            this.varning_label.Location = new System.Drawing.Point(155, 341);
            this.varning_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.varning_label.Name = "varning_label";
            this.varning_label.Size = new System.Drawing.Size(236, 20);
            this.varning_label.TabIndex = 6;
            this.varning_label.Text = "Будь ласка, оберіть режим";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 374);
            this.Controls.Add(this.varning_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rb_1x1);
            this.Controls.Add(this.rb_againstComputer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перед тим як розпочати...";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_againstComputer;
        private System.Windows.Forms.RadioButton rb_1x1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label varning_label;
    }
}