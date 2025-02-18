﻿namespace WebServer.Server.Routing.Contracts
{
    using Enums;
    using Handlers;
    using HTTP.Contracts;
    using System;
    using System.Collections.Generic;

    public interface IAppRouteConfig
    {
        IDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes { get; }

        void AddRoute(string route, HttpRequestMethod method, RequestHandler httpHandler);

        void Get(string route, Func<IHttpRequest, IHttpResponse> handler);

        void Post(string route, Func<IHttpRequest, IHttpResponse> handler);
    }
}
