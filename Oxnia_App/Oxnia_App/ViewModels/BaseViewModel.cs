using System;
using MvvmCross.Core.ViewModels;

namespace Oxnia_App
{
	public class BaseViewModel : MvxViewModel
	{
		public BaseViewModel()
		{
		}

		private long id;
		public long Id
		{
			get { return this.id; }
			set { this.id = value; this.RaisePropertyChanged(() => this.Id); }
		}

		private string title = string.Empty;
		public string Title
		{
			get { return this.title; }
			set { this.title = value; this.RaisePropertyChanged(() => this.Title); }
		}
	}
}

