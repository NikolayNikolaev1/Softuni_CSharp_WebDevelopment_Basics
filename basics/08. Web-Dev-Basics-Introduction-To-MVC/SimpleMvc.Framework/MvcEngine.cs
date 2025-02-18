﻿namespace SimpleMvc.Framework
{
    using System;
    using System.Reflection;
    using WebServer;
    public class MvcEngine
    {
        public static void Run(WebServer server)
        {
            RegisterAssemblyName();
            RegisterControllersData();
            RegisterModelsData();
            RegisterViewsData();

            try
            {
                server.Run();
            }
            catch (Exception e)
            {
                //Log errors
                Console.WriteLine(e.Message);
            }
        }

        private static void RegisterAssemblyName()
            => MvcContext.Get.AssemblyName = Assembly
            .GetEntryAssembly()
            .GetName()
            .Name;

        private static void RegisterControllersData()
        {
            MvcContext.Get.ControllersFolder = "Controllers";
            MvcContext.Get.ControllersSuffix = "Controller";
        }

        private static void RegisterModelsData()
            => MvcContext.Get.ModelsFolder = "Models";

        private static void RegisterViewsData()
            => MvcContext.Get.ViewsFolder = "Views";
    }
}
