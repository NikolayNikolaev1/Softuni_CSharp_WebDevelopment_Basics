﻿namespace WebServer.Server.HTTP.Contracts
{
    using System.Collections.Generic;

    public interface IHttpCookieCollection : IEnumerable<IHttpCookie>
    {
        void Add(IHttpCookie cookie);

        void Add(string key, string value);

        bool ContainsKey(string key);

        IHttpCookie Get(string key);
    }
}
