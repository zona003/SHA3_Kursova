using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursSha3
{
	public partial class Instruction : Form
	{
		int pageCounter = 0;
		InstrRes[] instrRes = new InstrRes[3];

		public Instruction()
		{
			InitializeComponent();
			instrRes[0].image = Properties.Resources._05;
			instrRes[0].describe = "Після запуску програми перед вами зявилось головне вікно. Зліва ви побачите 3 кнопки що відповідають за операції хешування, перевірки хешу та очистки текстових полів. Під ними знаходяться 4 радіо кнопки для вибору довжини хешу.";
			instrRes[1].image = Properties.Resources._03;
			instrRes[1].describe = "Після того як ви введете текст у велике поле зліва або відкриєте файл (див. інструкцію роботи з файлами) ви можете отримати хеш від данник відображених у відповідному полі.";
			instrRes[2].image = Properties.Resources._06;
			instrRes[2].describe = "Отриманий хеш буде відображений в низу форми. Після натискання кнопки перевірити, колір фону поля, в якому знаходиться отримане хеш значення зміниться на зелене якщо хеші співпадають, та червоне якщо ні.";
			button2.Enabled = false;
		}


		public struct InstrRes
		{
			public Image image { get; set; }
			public string describe { get; set; }

		}

		public void ShowInst(PictureBox bp, Label text, int counter, InstrRes[] source)
		{
			bp.Image = source[counter].image;
			text.Text = source[counter].describe;
		}

		private void Instruction_Load(object sender, EventArgs e)
		{
			ShowInst(pictureBox1,label1, pageCounter, instrRes);
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
	}
}
