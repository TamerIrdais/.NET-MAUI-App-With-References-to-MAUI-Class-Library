using Microsoft.Maui.Handlers;

namespace MauiLib1.Handlers
{
   public partial class CustomViewHandler
   {
      public static PropertyMapper<CustomView, CustomViewHandler> CustomViewMapper = new PropertyMapper<CustomView, CustomViewHandler>(ViewHandler.ViewMapper)
      {
         [nameof(CustomView.Background)] = MapBackgroundColor
      };

      public CustomViewHandler() : base(CustomViewMapper)
      {
      }

      public CustomViewHandler(PropertyMapper mapper = null) : base(mapper ?? CustomViewMapper)
      {
      }
   }
}
