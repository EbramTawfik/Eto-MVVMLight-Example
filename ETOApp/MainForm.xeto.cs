using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace ETOApp
{
	public class MainForm : Form
	{
		int i = 3;
		MainViewModel vm;
		public MainForm()
		{
			XamlReader.Load(this);
			vm = new MainViewModel();
			DataContext = vm;
			var list = this.FindChild<ListBox>("myList");

			list.BindDataContext(c => c.DataStore, (MainViewModel m) => m.UserList);
		}

		protected void HandleClickMe(object sender, EventArgs e)
		{
			i++;
			vm.UserList.Add("Name "+i);
		}

		protected void HandleQuit(object sender, EventArgs e)
		{
			Application.Instance.Quit();
		}
	}
}
