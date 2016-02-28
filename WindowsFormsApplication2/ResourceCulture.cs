using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ResourceCulture
    {
        static CultureInfo cultureInfo;
        /// <summary>
        /// Set current culture by name
        /// </summary>
        /// <param name="name">name</param>
        public static void SetCurrentCulture(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "en-US";
            }

            cultureInfo = new CultureInfo(name);
        }

        /// <summary>
        /// Get string by id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>current language string</returns>
        public static string GetString(string id)
        {
            string strCurLanguage = "";

            try
            {
                ResourceManager rm = new ResourceManager("WindowsFormsApplication2.Resource", Assembly.GetExecutingAssembly());
                strCurLanguage = rm.GetString(id, cultureInfo);
            }
            catch
            {
                strCurLanguage = "No id:" + id + ", please add.";
            }

            return strCurLanguage;
        }
    }

}
