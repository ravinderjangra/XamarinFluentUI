using System;
using System.Runtime.InteropServices;
using UIKit;

namespace FluentUI.Visual.Platform.iOS
{
    internal static class PlatformUtils
    {
		public static UIViewController GetTopViewController([Optional]UIViewController viewController)
		{
			if (viewController == null)
				viewController = UIApplication.SharedApplication.KeyWindow.RootViewController;

			if (viewController is UINavigationController navigationController)
				return GetTopViewController(navigationController.VisibleViewController);

			if (viewController is UITabBarController tabBarController)
				return GetTopViewController(tabBarController.SelectedViewController);

			if (viewController.PresentedViewController != null)
				return GetTopViewController(viewController.PresentedViewController);

			return viewController;
		}
	}
}
