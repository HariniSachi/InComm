﻿using System.Web.Http;
using System.Web.Mvc;

namespace Incomm.Sachi.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}