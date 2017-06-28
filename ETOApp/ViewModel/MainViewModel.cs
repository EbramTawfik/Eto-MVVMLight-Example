using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace ETOApp
{
	public class MainViewModel : ViewModelBase
	{
		public MainViewModel()
		{



		}


		ObservableCollection<string> _usersList;
		public ObservableCollection<string> UserList
		{
			get
			{
				if (_usersList == null)
				{
					_usersList = new ObservableCollection<string>() { "Name 1", "Name 2", "Name 3" };
				}

				return _usersList;
			}
			set
			{
				_usersList = value;
				RaisePropertyChanged(() => UserList);
			}
		}
	}
}
