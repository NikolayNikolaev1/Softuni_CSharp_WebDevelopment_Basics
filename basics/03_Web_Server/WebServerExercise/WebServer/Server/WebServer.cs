﻿namespace WebServer.Server
{
    using Contracts;
    using Core;
    using Routing;
    using Routing.Contracts;
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading.Tasks;

    using static Constants;

    public class WebServer : IRunnable
    {
        private readonly int port;
        private readonly IServerRouteConfig serverRouteConfig;
        private readonly TcpListener tcpListener;
        private bool isRunning;

        public WebServer(int port, IAppRouteConfig routeConfig)
        {
            CoreValidator.ThrowIfNull(port, nameof(port));
            CoreValidator.ThrowIfNull(routeConfig, nameof(routeConfig));

            this.port = port;
            this.tcpListener = new TcpListener(IPAddress.Parse(IpAddress), port);
            this.serverRouteConfig = new ServerRouteConfig(routeConfig);
        }

        public void Run()
        {
            this.tcpListener.Start();
            this.isRunning = true;

            Console.WriteLine($"Server started. Listening to TCP clients at 127.0.0.1:{this.port}");

            Task task = Task.Run(this.ListenLoop);
            task.Wait();
        }

        private async Task ListenLoop()
        {
            while (this.isRunning)
            {
                Socket client = await this.tcpListener.AcceptSocketAsync();
                IConnectionHandler connectionHandler = new ConnectionHandler(client, this.serverRouteConfig);
                Task connection = connectionHandler.ProccessRequestAsync();
                connection.Wait();
            }
        }
    }
}
