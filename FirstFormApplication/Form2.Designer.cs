using System.ComponentModel;

namespace FirstFormApplication;

partial class Form2
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(button3);
        groupBox1.Controls.Add(button2);
        groupBox1.Controls.Add(button1);
        groupBox1.Controls.Add(textBox4);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBox3);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(24, 23);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(293, 194);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "도서 추가/수정/삭제";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(22, 40);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(101, 17);
        label1.TabIndex = 0;
        label1.Text = "Isbn";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(129, 37);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(104, 23);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(129, 66);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(104, 23);
        textBox2.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(22, 69);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(101, 17);
        label2.TabIndex = 2;
        label2.Text = "도서 이름";
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(129, 95);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(104, 23);
        textBox3.TabIndex = 5;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(22, 98);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(101, 17);
        label3.TabIndex = 4;
        label3.Text = "출판사";
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(129, 124);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(104, 23);
        textBox4.TabIndex = 7;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(22, 127);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(101, 17);
        label4.TabIndex = 6;
        label4.Text = "페이지";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(22, 160);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 8;
        button1.Text = "추가";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(103, 160);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 9;
        button2.Text = "수정";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(184, 160);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 10;
        button3.Text = "삭제";
        button3.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dataGridView1);
        groupBox2.Location = new System.Drawing.Point(24, 225);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(449, 229);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "도서 현황";
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(9, 21);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(434, 202);
        dataGridView1.TabIndex = 0;
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(499, 466);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Text = "Form2";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}