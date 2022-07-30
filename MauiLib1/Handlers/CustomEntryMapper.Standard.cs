using Microsoft.Maui.Handlers;

namespace MauiLib1.Handlers
{
   public partial class CustomViewHandler : ViewHandler<CustomView, object>
   {
      protected override object CreatePlatformView() => throw new NotImplementedException();

      public static void MapBackgroundColor(CustomViewHandler handler, CustomView view) { }
   }
}
