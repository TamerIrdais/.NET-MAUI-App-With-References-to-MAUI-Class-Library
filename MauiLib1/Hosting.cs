//*************************************************************
// Copyright (c) 1991-2022 LEAD Technologies, Inc.
// All Rights Reserved.
//*************************************************************

using MauiLib1.Handlers;

namespace MauiLib1.Hosting
{
   public static class AppHostBuilderExtensions
   {
      public static MauiAppBuilder UseMauiLib(this MauiAppBuilder builder)
      {
         return builder.ConfigureMauiHandlers(delegate (IMauiHandlersCollection handlers)
         {
            handlers.AddHandler<CustomView, CustomViewHandler>();
         });
      }
   }
}