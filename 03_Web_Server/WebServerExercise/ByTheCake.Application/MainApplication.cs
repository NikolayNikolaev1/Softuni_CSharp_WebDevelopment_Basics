﻿namespace ByTheCake.Application
{
    using ByTheCake.Data;
    using Controllers;
    using WebServer.Server.Contracts;
    using WebServer.Server.Routing.Contracts;

    public class MainApplication : IApplication
    {
        ByTheCakeDbContext context;

        public MainApplication(ByTheCakeDbContext context)
        {
            this.context = context;
        }

        public void Start(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig
                .Get("/", req => new HomeController().Index());
            appRouteConfig
                .Get("/about", req => new HomeController().About());
            appRouteConfig
                .Get("/register", req => new UserController(this.context).Register());
            appRouteConfig
                .Post("/register", req => new UserController(this.context).Register(req));
            appRouteConfig
                .Get("/login", req => new UserController(this.context).Login());
            appRouteConfig
                .Post("/login", req => new UserController(this.context).Login(req));
            appRouteConfig
                .Post("/logout", req => new UserController(this.context).Logout(req));
            appRouteConfig
                .Get("/profile", req => new UserController(this.context).Profile(req));
            appRouteConfig
                .Get("/add", req => new CakeController(this.context).Add());
            appRouteConfig
                .Post("/add", req => new CakeController(this.context).Add(req));
            appRouteConfig
                .Get("/cakeDetails/{(?<id>[0-9]+)}", req => new CakeController(this.context).Details(req));
            appRouteConfig
                .Get("/search", req => new CakeController(this.context).Search(req));
            appRouteConfig
                .Get("/shopping/add/{(?<id>[0-9]+)}", req => new ShoppingController().AddToCart(req));
            appRouteConfig
                .Get("/cart", req => new ShoppingController().Index(req));
            appRouteConfig
                .Get("/success", req => new ShoppingController().Success());
            appRouteConfig
                .Post("/order", req => new ShoppingController().Order(req));
        }
    }
}
