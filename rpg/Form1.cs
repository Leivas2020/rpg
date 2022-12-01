using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
  public partial class Form1 : Form
  {
    int index = 0;
    int numOfResets = 3;
    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      switch (index)
      {
        case 0:
          textBox1.Text = Roll().ToString();
          break;
        case 1:
          textBox2.Text = Roll().ToString();
          break;
        case 2:
          textBox3.Text = Roll().ToString();
          break;
        case 3:
          textBox4.Text = Roll().ToString();
          break;
        case 4:
          textBox5.Text = Roll().ToString();
          break;
        case 5:
          textBox6.Text = Roll().ToString();
          break;
      }
      btn_roll.Location = new Point(btn_roll.Location.X, btn_roll.Location.Y + textBox1.Height);
      index++;
      if (index > 5)
      {
        btn_confirm.Enabled = true;
      }
    }

    int Roll()
    {
      Random rand = new Random();
      int sum = 0;

      for (int i = 0; i < 3; i++)
      {
        sum += rand.Next(1, 6);
      }
      return sum;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (numOfResets > 0)
      {
        listBox1.Visible = false;
        index = 0;
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
        textBox5.Text = "";
        textBox6.Text = "";
        btn_roll.Location = new Point(btn_roll.Location.X, textBox1.Location.Y + textBox1.Height);
      }
      btn_confirm.Enabled = false;
    }

    private void btn_confirm_Click(object sender, EventArgs e)
    {
      if (!listBox1.Visible)
      {
        if (listBox1.Items.Count > 0)
        {
          listBox1.Items.Clear();
        }

        player p = new player(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text),
          int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));
        listBox1.Visible = true;

        if (int.Parse(textBox1.Text) >= 9)
        {
          listBox1.Items.Add("fighter");
        }
        if (int.Parse(textBox2.Text) >= 9)
        {
          listBox1.Items.Add("thief");
        }
        if (int.Parse(textBox4.Text) >= 9)
        {
          listBox1.Items.Add("mage");
        }
        if (int.Parse(textBox5.Text) >= 9)
        {
          listBox1.Items.Add("priest");
        }
      }
      else
      {
        if (listBox1.Text=="mage")
        {
          mage player = new mage();
        }
        else if (listBox1.Text=="warrior")
        {
          warrior player = new warrior();
        }
        else if (listBox1.Text == "thief")
        {
          thief player = new thief();
        }
        else if (listBox1.Text == "priest")
        {
          priest player = new priest();
        }
        else
        {
          MessageBox.Show("NO CLASS SELECTED");
        }
      }


    }
  }
}
