using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allan.Language.Detection;
using System.Globalization;

namespace FirstProjectIntegration
{
    class Displayer
    {
        public static void DisplayLanuguage()
        {
            var chaineToBeClassed = "hello";
            var languages = Detector.DetectLanguage(chaineToBeClassed);
            var topLanguage = languages.OrderBy(l => l.Distance).First();
            var langString = new CultureInfo(topLanguage.Language.Code).DisplayName;
            Console.WriteLine(langString);
        }
    }
}
