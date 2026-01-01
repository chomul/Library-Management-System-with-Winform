namespace FirstFormApplication
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox4 = new System.Windows.Forms.GroupBox();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { 도서관리ToolStripMenuItem, 사용자관리ToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(739, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem
            // 
            도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            도서관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            도서관리ToolStripMenuItem.Text = "도서 관리";
            도서관리ToolStripMenuItem.Click += 도서관리ToolStripMenuItem_Click;
            // 
            // 사용자관리ToolStripMenuItem
            // 
            사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
            사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            사용자관리ToolStripMenuItem.Text = "사용자 관리";
            사용자관리ToolStripMenuItem.Click += 사용자관리ToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(20, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(315, 155);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도서관 현황";
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(133, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 27);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(75, 60);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 27);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(89, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(112, 27);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(6, 124);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(204, 16);
            label4.TabIndex = 3;
            label4.Text = "연체 중인 도서의 수 : ";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(6, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(204, 32);
            label3.TabIndex = 2;
            label3.Text = "대출 중인 도서의 수 : ";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(6, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(204, 32);
            label2.TabIndex = 1;
            label2.Text = "사용자 수 : \r\n";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(6, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(204, 32);
            label1.TabIndex = 0;
            label1.Text = "전체 도서 수 : \r\n";
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(133, 124);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 27);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new System.Drawing.Point(366, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(345, 156);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "대여/반납";
            // 
            // label11
            // 
            label11.Location = new System.Drawing.Point(6, 113);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(71, 23);
            label11.TabIndex = 10;
            label11.Text = "사용자 ID";
            // 
            // label10
            // 
            label10.Location = new System.Drawing.Point(6, 74);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(71, 23);
            label10.TabIndex = 9;
            label10.Text = "도서 이름";
            // 
            // label9
            // 
            label9.Location = new System.Drawing.Point(6, 38);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(71, 23);
            label9.TabIndex = 7;
            label9.Text = "Isbn";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(269, 65);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(70, 27);
            button2.TabIndex = 8;
            button2.Text = "반납";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            button1.Location = new System.Drawing.Point(269, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 27);
            button1.TabIndex = 7;
            button1.Text = "대여";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(83, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(175, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(83, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(175, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(83, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(175, 23);
            textBox1.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new System.Drawing.Point(20, 201);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(689, 163);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "도서 현황";
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new System.Drawing.Point(6, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(678, 134);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new System.Drawing.Point(20, 370);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(689, 163);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "사용자 현황";
            // 
            // dataGridView2
            // 
            dataGridView2.Location = new System.Drawing.Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(678, 134);
            dataGridView2.TabIndex = 1;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(739, 549);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Location = new System.Drawing.Point(15, 15);
            MainMenuStrip = menuStrip1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
    }
}
