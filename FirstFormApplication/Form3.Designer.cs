using System.ComponentModel;

namespace FirstFormApplication;

partial class Form3
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
        dataGridView1 = new System.Windows.Forms.DataGridView();
        groupBox2 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dataGridView1);
        groupBox1.Location = new System.Drawing.Point(18, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(287, 586);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "사용자 현황";
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(6, 22);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(275, 558);
        dataGridView1.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(button3);
        groupBox2.Controls.Add(button2);
        groupBox2.Controls.Add(button1);
        groupBox2.Controls.Add(textBox2);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(textBox1);
        groupBox2.Controls.Add(label1);
        groupBox2.Location = new System.Drawing.Point(323, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(319, 137);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "사용자 추가/수정/삭제";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(16, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(108, 23);
        label1.TabIndex = 0;
        label1.Text = "사용자 ID";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(130, 24);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(100, 23);
        textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(130, 53);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(100, 23);
        textBox2.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(16, 56);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(108, 23);
        label2.TabIndex = 2;
        label2.Text = "이름";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(18, 98);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 4;
        button1.Text = "추가";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(99, 98);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 5;
        button2.Text = "수정";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(180, 98);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(75, 23);
        button3.TabIndex = 6;
        button3.Text = "삭제";
        button3.UseVisualStyleBackColor = true;
        // 
        // Form3
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(654, 609);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Text = "Form3";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    #endregion
}