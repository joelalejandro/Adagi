using Dicse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi
{
    public class TranslationConfig
    {
        public static void ConfigureTranslations(Translator t)
        {
            // Load a translation file.
            t.LoadFromFile("~/Translations/es-ar.json");

            // Set a default language.
            t.DestinationLanguage = "es-ar";
        }
    }
}