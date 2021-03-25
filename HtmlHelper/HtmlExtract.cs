﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlHelper
{
    public class HtmlExtract
    {
        public async Task<List<string>> CallURL(String url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode(); //200 response
            string responseBody = await response.Content.ReadAsStringAsync();
            List<string> listValues = seperateValues(responseBody);
            return listValues;
        }

        public List<string> seperateValues(string s)
        {
            List<string> list = new List<string>();
            string regexImgSrc = @"<img[^>]*?src\s*=\s*[""']?([^'"" >]+?)[ '""][^>]*?>";
            MatchCollection collection = Regex.Matches(s, regexImgSrc, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
            foreach (Match item in collection)
            {
                string reference = item.Groups[1].Value;
                list.Add(reference);
            }
            return list;
        }
    }
}
