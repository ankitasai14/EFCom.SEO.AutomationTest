using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Rentals._02_Utility_Tier
{
    [TestClass]
    public static class CsvHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinStrings<T>(
        this IEnumerable<T> values, string separator)
        {
            var stringValues = values.Select(item =>
                (item == null ? string.Empty : item.ToString()));
            return string.Join(separator, stringValues.ToArray());
        }

    }
        
}

