
namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.граПротиКомпютераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гра1На1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.lbl_1Player = new System.Windows.Forms.Label();
            this.lbl_2Player = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_winCount = new System.Windows.Forms.Label();
            this.o_winCount = new System.Windows.Forms.Label();
            this.darw_Count = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(345, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.граПротиКомпютераToolStripMenuItem,
            this.гра1На1ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.gameToolStripMenuItem.Text = "Налаштування";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.newGameToolStripMenuItem.Text = "Нова гра";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // граПротиКомпютераToolStripMenuItem
            // 
            this.граПротиКомпютераToolStripMenuItem.Name = "граПротиКомпютераToolStripMenuItem";
            this.граПротиКомпютераToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.граПротиКомпютераToolStripMenuItem.Text = "Гра проти комп\'ютера";
            this.граПротиКомпютераToolStripMenuItem.Click += new System.EventHandler(this.граПротиКомпютераToolStripMenuItem_Click);
            // 
            // гра1На1ToolStripMenuItem
            // 
            this.гра1На1ToolStripMenuItem.Name = "гра1На1ToolStripMenuItem";
            this.гра1На1ToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.гра1На1ToolStripMenuItem.Text = "Гра 1 на 1";
            this.гра1На1ToolStripMenuItem.Click += new System.EventHandler(this.гра1На1ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.helpToolStripMenuItem.Text = "Довідка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.aboutToolStripMenuItem.Text = "Про програму";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(15, 32);
            this.A1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 92);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // A2
            // 
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(120, 33);
            this.A2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 92);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // A3
            // 
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(225, 33);
            this.A3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 92);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // B3
            // 
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3.Location = new System.Drawing.Point(225, 130);
            this.B3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 92);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // B2
            // 
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2.Location = new System.Drawing.Point(120, 130);
            this.B2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 92);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // B1
            // 
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1.Location = new System.Drawing.Point(15, 129);
            this.B1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 92);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // C3
            // 
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(225, 228);
            this.C3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 92);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // C2
            // 
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(120, 228);
            this.C2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 92);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // C1
            // 
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(15, 226);
            this.C1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 92);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_mouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.button_mouseLeave);
            // 
            // lbl_1Player
            // 
            this.lbl_1Player.AutoSize = true;
            this.lbl_1Player.Location = new System.Drawing.Point(14, 340);
            this.lbl_1Player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_1Player.Name = "lbl_1Player";
            this.lbl_1Player.Size = new System.Drawing.Size(97, 17);
            this.lbl_1Player.TabIndex = 10;
            this.lbl_1Player.Text = "Гравець 1 (Х)";
            // 
            // lbl_2Player
            // 
            this.lbl_2Player.AutoSize = true;
            this.lbl_2Player.Location = new System.Drawing.Point(222, 340);
            this.lbl_2Player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_2Player.Name = "lbl_2Player";
            this.lbl_2Player.Size = new System.Drawing.Size(99, 17);
            this.lbl_2Player.TabIndex = 11;
            this.lbl_2Player.Text = "Гравець 2 (О)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Нічия";
            // 
            // x_winCount
            // 
            this.x_winCount.AutoSize = true;
            this.x_winCount.Location = new System.Drawing.Point(52, 362);
            this.x_winCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x_winCount.Name = "x_winCount";
            this.x_winCount.Size = new System.Drawing.Size(16, 17);
            this.x_winCount.TabIndex = 13;
            this.x_winCount.Text = "0";
            // 
            // o_winCount
            // 
            this.o_winCount.AutoSize = true;
            this.o_winCount.Location = new System.Drawing.Point(271, 362);
            this.o_winCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.o_winCount.Name = "o_winCount";
            this.o_winCount.Size = new System.Drawing.Size(16, 17);
            this.o_winCount.TabIndex = 14;
            this.o_winCount.Text = "0";
            // 
            // darw_Count
            // 
            this.darw_Count.AutoSize = true;
            this.darw_Count.Location = new System.Drawing.Point(159, 362);
            this.darw_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.darw_Count.Name = "darw_Count";
            this.darw_Count.Size = new System.Drawing.Size(16, 17);
            this.darw_Count.TabIndex = 15;
            this.darw_Count.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 394);
            this.Controls.Add(this.darw_Count);
            this.Controls.Add(this.o_winCount);
            this.Controls.Add(this.x_winCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_2Player);
            this.Controls.Add(this.lbl_1Player);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_1Player;
        private System.Windows.Forms.Label lbl_2Player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label x_winCount;
        private System.Windows.Forms.Label o_winCount;
        private System.Windows.Forms.Label darw_Count;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem граПротиКомпютераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гра1На1ToolStripMenuItem;
    }
}

