using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursSha3
{
	abstract class CustomErrHandler: Exception
	{
		public abstract void ShowError();
		public abstract void ShowError(Exception exception);
	}
}
