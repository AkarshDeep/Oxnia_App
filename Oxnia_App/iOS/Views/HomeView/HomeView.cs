using System;
using MvvmCross.Platform;
using UIKit;

namespace Oxnia_App.iOS
{
	public partial class HomeView : BaseView
	{
		public HomeView() 
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			SetUpView();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void SetUpView()
		{
			this.Title = "Oxnia";
			this.NavigationController.NavigationBarHidden = false;
			this.NavigationController.NavigationBar.BarTintColor = UIColor.FromRGB(19, 150, 242);
			this.NavigationController.NavigationBar.TintColor = UIColor.White;

			UIButton menuButton = new UIButton(UIButtonType.Custom);
			menuButton.SetImage(UIImage.FromBundle("Menu-icon.png"), UIControlState.Normal);

			UIImage image = UIImage.FromFile("Menu-icon.png");

			image = image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);


			this.NavigationItem.SetLeftBarButtonItem(
				new UIBarButtonItem(image
					, UIBarButtonItemStyle.Plain
					, (sender, args) =>
					{
						{
							//var messengere = Mvx.Resolve<IMvxMessenger>();
							//messengere.Publish(new ToggleFlyoutMenuMessage(this));
						}

					})
				, true);

		}
	}
}

