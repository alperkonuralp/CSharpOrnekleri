using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_CS_Indexer
{
    public static class CommonOperations
    {
        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="s">string türünde sayı</param>
        /// <param name="def">default değer</param>
        /// <returns></returns>
        public static int GetInt32(string s, int def)
        {
            int i;
            return int.TryParse(s, out i) ? i : def;
        }

        /// <summary>
        /// Gets the int32.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns></returns>
        public static int? GetInt32(string s)
        {
            int i;
            return int.TryParse(s, out i) ? (int?)i : null;
        }
    }
}
