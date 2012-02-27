using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
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
