﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(km956216MIS4200.Startup))]
namespace km956216MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
