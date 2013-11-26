using Microsoft.Web.WebPages.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            OAuthWebSecurity.RegisterFacebookClient("553039951437247", "0e81f151234c79357cca5897eebacceb");
            OAuthWebSecurity.RegisterTwitterClient("v3zIWGemIvt7nNCxIlmzGg", "Hu8FX5H0Vq8su10uqtK5NueRqHQwoYXo0tygJYTsoww");
            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}