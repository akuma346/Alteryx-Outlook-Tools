﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OutlookTools
{
    public static class Extensions
    {
        public static bool InnerBoolean(this XmlElement xml)
        {
            bool value = false;

            if (xml != null)
            {
                Boolean.TryParse(xml.InnerText, out value);

                return value;
            }

            return value;
        }

        public static int InnerInt(this XmlElement xml)
        {
            Int16 value = 4;

            if (xml != null)
            {
                Int16.TryParse(xml.InnerText, out value);

                return value;
            }

            return value;
        }

        public static string InnerString(this XmlElement xml)
        {
            return xml == null ? String.Empty : xml.InnerText;
        }
    }
}