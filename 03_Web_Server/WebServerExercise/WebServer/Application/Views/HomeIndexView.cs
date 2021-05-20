﻿namespace WebServer.Application.Views
{
    using Server.Contracts;
    using System.IO;

    using static Server.Constants;

    public class HomeIndexView : IView
    {
        public string View()
            => File.ReadAllText(HtmlPath + "\\index.html");
    }
}
