﻿using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using OauthApi.Provider;
using Owin;
using System;
using System.Web.Http;

namespace ApiIvan.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            //this is very important line cross orgin source(CORS)it is used to enable cross-site HTTP requests  
            //For security reasons, browsers restrict cross-origin HTTP requests  
            app.UseCors(CorsOptions.AllowAll);

            var OAuthOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),//token expiration time  
                Provider = new OAuthProvider()
            };

            app.UseOAuthBearerTokens(OAuthOptions);
            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);//register the request  
        }
    }
}