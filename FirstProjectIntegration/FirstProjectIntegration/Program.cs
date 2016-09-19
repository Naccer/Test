﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allan.Language.Detection;

namespace FirstProjectIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var chaineToBeClassed = "hello";
            var languages = Detector.DetectLanguage(chaineToBeClassed);
            var topLanguage = languages.OrderBy(l => l.Distance).First();
            var langString = new CultureInfo(topLanguage.Language.Code).DisplayName;
            Console.WriteLine(langString);
        }
    }
}
