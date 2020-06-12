using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SHA3;

namespace KursSha3
{
	public partial class Main : Form
	{
		string[] extensions = { ".rtf", ".txt" };
		private static int[] security = new int[] { 224, 256, 384, 512 };
		private static string hashFunction = "";
		private string choosePath;

		public static Main instance = null;

		private Main Singelton()
		{
			if (instance == null)
			{
				instance = this;
			}

			return instance;
		}

		public Main()
		{
			InitializeComponent();
			Singelton();
			radioButton4.Checked = true;
		}

		private void HeshButton_Click(object sender, EventArgs e)
		{
			Hash_TextBox1.Clear();
			Hash_TextBox1.BackColor = Color.White;

			Hash_TextBox1.AppendText(FormatOutput(Get_SHA3_Hash(Text_TextBox.Text)));
		}

		private void CheskHashButton_Click(object sender, EventArgs e)
		{
			Hash_compare(FormatOutput(Get_SHA3_Hash(Text_TextBox.Text)));
		}

		private void ChangeAlgoritm(RadioButton rb)
		{
			hashFunction = rb.Text;
		}

		private string FormatOutput(HEX hexHach)
		{
			StringBuilder Sb = new StringBuilder();
			Sb.Append("SHA3 - " + hashFunction + "\n");
			string Text = hexHach;
			Text = Text.ToUpper();
			for (int i = 0; i < Text.Length; i += 3)
			{
				Text = Text.Insert(i, " ");
			}

			Sb.Append(Text + "\n");

			return Sb.ToString();
		}

		public static HEX Get_SHA3_Hash(string Text)
		{
			string temp = hashFunction;
			UInt16 security = Convert.ToUInt16(temp);
			return Sha3.SHA3(Text, security);
		}

		public static HEX Get_SHA3_Hash(FileStream fs)
		{
			UInt16 security = Convert.ToUInt16(hashFunction.Substring(hashFunction.Length - 3, 3));
			return Sha3.SHA3(fs, security);
		}

		private void Hash_compare(string hash)
		{
			if (Hash_TextBox1.Text == hash)
			{
				Hash_TextBox1.BackColor = Color.Green;
			}
			else
			{
				Hash_TextBox1.BackColor = Color.Pink;
			}
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;

			ChangeAlgoritm(rb);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Hash_TextBox1.BackColor = Color.White;
			Hash_TextBox1.Clear();
			Text_TextBox.Clear();
		}

		private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Authors Au = new Authors();
			Au.ShowDialog();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutProgram Ab = new AboutProgram();
			Ab.ShowDialog();
		}

		private void отриматиХешToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HeshButton.PerformClick();
		}

		private void перевіритиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CheskHashButton.PerformClick();
		}

		private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			button1.PerformClick();
		}

		private void takeFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog OPF = new OpenFileDialog();
			FileController fileController = new FileController();
			if (OPF.ShowDialog() == DialogResult.OK)
			{
				FileInfo fileInfo = new FileInfo(OPF.FileName);
				double len_in_MiBs = fileInfo.Length / 1024 / 1024;
				if (len_in_MiBs > 100)
					MessageBox.Show("Файл занадто великий!", "Попередження");
				else
				{
					if (Array.Exists(extensions, extens => extens == fileInfo.Extension))
					{
						try
						{
							Text_TextBox.Text = File.ReadAllText(OPF.FileName);
						}
						catch (Exception ex)
						{
							fileController.ShowError(ex);
						}

					}
					else
					{
						try
						{
							using (FileStream fileStream = File.OpenRead(fileInfo.FullName))
							{
								byte[] array = new byte[fileStream.Length];
								fileStream.Read(array, 0, array.Length);
								Text_TextBox.Text = BitConverter.ToString(array);
							}
						}
						catch (Exception ex)
						{
							fileController.ShowError(ex);
						}
					}
				}
			}
		}

		private bool file_exist_check()
		{
			if (File.Exists(choosePath))
			{
				return true;
			}
			else
			{
				MessageBox.Show("Файл не существует!");
				return false;
			}
		}

		private void інструкціяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Instruction instruction = new Instruction();
			instruction.Show();
		}

		private void іНструкціяПоРоботіЗФайламиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileUsingInstruction fileInstruction = new FileUsingInstruction();
			fileInstruction.Show();
		}

        private void зберегтиХешToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter w = new StreamWriter(saveFileDialog.FileName, false))
                {
                    w.Write(Hash_TextBox1.Text);
                }
            }
        }
    }
}
