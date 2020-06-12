using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursSha3.Instruction;

namespace KursSha3
{
	public partial class FileUsingInstruction : Form
	{
		int pageCounter = 0;
		InstrRes[] instrRes = new InstrRes[3];

		public FileUsingInstruction()
		{
			InitializeComponent();
			instrRes[0].image = Properties.Resources._02;
			instrRes[0].describe = "Для того щоб відкрити файл необхідно натиснути вкладку 'Файл' в лівому верхньому куті, та обрати довільний файл. Максимальний розмір 100 МБ";
			instrRes[1].image = Properties.Resources._04;
			instrRes[1].describe = "Якщо обраний текстовий файл формату .txt або .rtf, на головній формі буде відображено текст, що знаходится в них.";
			instrRes[2].image = Properties.Resources._03;
			instrRes[2].describe = "Усі інші файли будуть відображені у байтовому вигляді.";
			button2.Enabled = false;
		}

		public void ShowInst(PictureBox bp, Label text, int counter, InstrRes[] source)
		{
			bp.Image = source[counter].image;
			text.Text = source[counter].describe;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pageCounter++;
			ShowInst(pictureBox1, label1, pageCounter, instrRes);
			if (pageCounter == instrRes.Length - 1)
			{
				button1.Enabled = false;
			}
			else
			{
				button1.Enabled = true;
				button2.Enabled = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			pageCounter--;
			ShowInst(pictureBox1, label1, pageCounter, instrRes);
			if (pageCounter == 0)
			{
				button2.Enabled = false;
			}
			else
			{
				button2.Enabled = true;
				button1.Enabled = true;
			}
		}

		private void FileUsingInstruction_Load(object sender, EventArgs e)
		{
			ShowInst(pictureBox1, label1, pageCounter, instrRes);
		}
	}
}
