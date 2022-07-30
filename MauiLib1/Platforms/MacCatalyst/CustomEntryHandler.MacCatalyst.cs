using Microsoft.Maui.Handlers;
using UIKit;

namespace MauiLib1.Handlers
{
   public partial class CustomViewHandler : ViewHandler<CustomView, UIView>
   {
      protected override UIView CreatePlatformView() => throw new NotImplementedException();

      public static void MapBackgroundColor(CustomViewHandler handler, CustomView view) { }
   }
}