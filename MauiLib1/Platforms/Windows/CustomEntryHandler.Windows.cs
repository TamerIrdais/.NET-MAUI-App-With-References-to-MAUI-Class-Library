using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Maui.Platform;

namespace MauiLib1.Handlers
{
   public partial class CustomViewHandler : ViewHandler<CustomView, FrameworkElement>
   {
      protected override FrameworkElement CreatePlatformView()
      {
         System.Diagnostics.Debug.WriteLine("[DEBUG] - CreatePlatformView");
         return new Canvas();
      }

      protected override void ConnectHandler(FrameworkElement platformView)
      {
         System.Diagnostics.Debug.WriteLine("[DEBUG] - ConnectHandler");
         base.ConnectHandler(platformView);
      }

      protected override void DisconnectHandler(FrameworkElement platformView)
      {
         System.Diagnostics.Debug.WriteLine("[DEBUG] - DisconnectHandler");
         base.DisconnectHandler(platformView);
      }

      public static void MapBackgroundColor(CustomViewHandler handler, CustomView view)
      {
         System.Diagnostics.Debug.WriteLine("[DEBUG] - MapBackgroundColor");
         (handler.PlatformView as Canvas).Background = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Blue);
      }
   }
}