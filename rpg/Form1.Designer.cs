
namespace rpg
{
  partial class Form1
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.btn_confirm = new System.Windows.Forms.Button();
      this.btn_roll = new System.Windows.Forms.Button();
      this.btn_reset = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "STRENGTH";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(123, 41);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(123, 84);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "DEXTERITY";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(123, 128);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 128);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "CONSTITUTION";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(123, 170);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(100, 20);
      this.textBox4.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 170);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "INTELLIGENCE";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(123, 213);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(100, 20);
      this.textBox5.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(27, 213);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "WISDOM";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(123, 253);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(100, 20);
      this.textBox6.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(17, 260);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "CHARISMA";
      // 
      // btn_confirm
      // 
      this.btn_confirm.Enabled = false;
      this.btn_confirm.Location = new System.Drawing.Point(713, 415);
      this.btn_confirm.Name = "btn_confirm";
      this.btn_confirm.Size = new System.Drawing.Size(75, 23);
      this.btn_confirm.TabIndex = 12;
      this.btn_confirm.Text = "CONFIRM";
      this.btn_confirm.UseVisualStyleBackColor = true;
      this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
      // 
      // btn_roll
      // 
      this.btn_roll.Location = new System.Drawing.Point(263, 31);
      this.btn_roll.Name = "btn_roll";
      this.btn_roll.Size = new System.Drawing.Size(75, 23);
      this.btn_roll.TabIndex = 13;
      this.btn_roll.Text = "ROLL";
      this.btn_roll.UseVisualStyleBackColor = true;
      this.btn_roll.Click += new System.EventHandler(this.button2_Click);
      // 
      // btn_reset
      // 
      this.btn_reset.Location = new System.Drawing.Point(713, 380);
      this.btn_reset.Name = "btn_reset";
      this.btn_reset.Size = new System.Drawing.Size(75, 23);
      this.btn_reset.TabIndex = 14;
      this.btn_reset.Text = "RESET";
      this.btn_reset.UseVisualStyleBackColor = true;
      this.btn_reset.Click += new System.EventHandler(this.button3_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(556, 84);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(232, 121);
      this.listBox1.TabIndex = 15;
      this.listBox1.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.btn_reset);
      this.Controls.Add(this.btn_roll);
      this.Controls.Add(this.btn_confirm);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btn_confirm;
    private System.Windows.Forms.Button btn_roll;
    private System.Windows.Forms.Button btn_reset;
    private System.Windows.Forms.ListBox listBox1;
  }
}

