﻿using System;

namespace DevHobby.Common
{
    /// <summary>
    /// Zapewnia logowanie
    /// </summary>
    public static class LogowanieService
    {
        /// <summary>
        /// Loguje akcje
        /// </summary>
        /// <param name="akcja">akcja do zalogowania</param>
        /// <returns></returns>
        public static string Logowanie(string akcja)
        {
            var tekstDoZalogowania = "Akcja: " + akcja;
            Console.WriteLine(tekstDoZalogowania);

            return tekstDoZalogowania;
        }
    }
}
