using Android.Widget;
using Microsoft.Maui.Handlers;

namespace MauiLib1.Handlers
{
   public partial class CustomViewHandler : ViewHandler<CustomView, Android.Views.View>
   {
      protected override EditText CreatePlatformView()
      {
         return new EditText(Context);
      }

      protected override void ConnectHandler(Android.Views.View nativeView)
      {
         base.ConnectHandler(nativeView);
      }

      protected override void DisconnectHandler(Android.Views.View nativeView)
      {
         base.DisconnectHandler(nativeView);
      }

      public static void MapBackgroundColor(CustomViewHandler handler, CustomView view) { }
   }
}