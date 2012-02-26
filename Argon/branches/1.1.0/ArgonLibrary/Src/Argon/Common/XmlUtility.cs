using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Argon.Common
{
    public static class XmlUtility
    {
        /// <summary>
        /// Writes the attribute if present.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="value">The value.</param>
        public static void WriteAttributeIfPresent(XmlTextWriter writer, string attributeName, string value)
        {
            if (value != null)
            {
                writer.WriteAttributeString(attributeName, value);
            }
        }

        /// <summary>
        /// Reads the attribute if present.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ReadAttributeIfPresent(XmlTextReader reader, string attributeName, string value)
        {
            string ret;

            ret = reader.GetAttribute(attributeName);
            if (ret == null) ret = value;
            return ret;

        }
    }
}
