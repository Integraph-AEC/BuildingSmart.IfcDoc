using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfcDoc
{
	public partial class FormDatabase : Form
	{
		public FormDatabase()
		{
			InitializeComponent();
		}

		public string ConnectionString
		{
			get
			{
				return this.textBoxConnection.Text;
			}
		}
	}
}
