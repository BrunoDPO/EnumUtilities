using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace System
{
    /// <summary>
    /// Helper class that adds to enums (and consequently to all ValueType elements) an extension method called Description
    /// </summary>
    public static class EnumUtilities
    {
        /// <summary>
        /// Extension method that gets the description of a given value
        /// </summary>
        public static string Description<T>(this T val) where T : struct, IComparable, IFormattable, IConvertible
        {
            return typeof(T).IsEnum ? EnumUtilities<T>.GetDescription(val) : val.ToString();
        }
    }

    /// <summary>
    /// Helper class that gives enums the ability to have descriptions associated to its values in collections
    /// </summary>
    /// <typeparam name="T">This parameter must be an enumerate type</typeparam>
    public static class EnumUtilities<T> where T : struct, IComparable, IFormattable, IConvertible
    {
        /// <summary>
        /// Static constructor that validates the structure being passed to it
        /// </summary>
        static EnumUtilities()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException(string.Format("Type '{0}' is not an enumerate type.", typeof(T).FullName), "T");
        }

        /// <summary>
        /// Gets the description of a given enumeration value
        /// </summary>
        public static string GetDescription(T val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : val.ToString();
        }

        /// <summary>
        /// Gets all descriptions as an array of strings
        /// </summary>
        public static string[] GetDescriptionArray()
        {
            var values = Enum.GetValues(typeof(T));
            string[] descriptions = new string[values.Length];

            for (int i = 0; i < values.Length; i++)
                descriptions[i] = GetDescription((T)values.GetValue(i));

            return descriptions;
        }

        /// <summary>
        /// Builds a non-typed name and value collection with description as name and enumeration as value
        /// </summary>
        public static NameValueCollection GetNameValueCollection()
        {
            var values = Enum.GetValues(typeof(T));
            var collection = new NameValueCollection(values.Length);

            for (int i = 0; i < values.Length; i++)
                collection.Add(GetDescription((T)values.GetValue(i)), values.GetValue(i).ToString());

            return collection;
        }

        /// <summary>
        /// Builds a typed dictionary, with enumeration as key and description as value
        /// </summary>
        public static Dictionary<T, string> GetDictionary()
        {
            var values = Enum.GetValues(typeof(T));
            var dictionary = new Dictionary<T, string>(values.Length);

            for (int i = 0; i < values.Length; i++)
                dictionary.Add((T)values.GetValue(i), GetDescription((T)values.GetValue(i)));

            return dictionary;
        }
    }
}
