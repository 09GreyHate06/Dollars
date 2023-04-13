using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dollars
{
    public static class Utils
    {
        public static readonly int CS_DROPSHADOW = 0x20000;

        public static string RemoveAllExceptNumbers(string text)
        {
            return new string(text.Where(c => '0' <= c && c <= '9').ToArray());
        }

        public static string RemoveAllExceptFloats(string text)
        {
            return new string(text.Where(c => c == '.' || ('0' <= c && c <= '9')).ToArray());
        }

        public static string ConcatCategories(ProductCategory cat)
        {
            List<ProductCategory> parents = DB.PrdCategoriesDB.GetParents(cat);
            StringBuilder sb = new StringBuilder();
            for (int i = parents.Count - 1; i >= 0; i--)
            {
                sb.Append(parents[i].Category + " \\ ");
            }

            return sb.Append(cat.Category).ToString();
        }

        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        public static string DisplayCash(double m)
        {
            string res = Math.Round(m, 2, MidpointRounding.ToEven).ToString();
            int index = res.IndexOf('.');
            if (index >= 0)
            {
                string resSubStr = res.Substring(index + 1);
                if(resSubStr.Length == 1)
                {
                    res += "0";
                }
            }
            else
            {
                res += ".00";
            }

            return res;
        }

        public static byte[] GetImageData(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.GetBuffer();
        }

        public static Image GetImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        public static string ConcatFullname(string firstName, string middleInitial, string lastName)
        {
            return firstName + (string.IsNullOrWhiteSpace(middleInitial) ? " " : " " + middleInitial + ". ") + lastName;
        }
    }
}
