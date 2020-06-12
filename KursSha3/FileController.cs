using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursSha3
{
	class FileController : CustomErrHandler
	{
		public override void ShowError()
		{
			MessageBox.Show("Сталася невідома помилка!","Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public override void ShowError(Exception exception)
		{
			MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
