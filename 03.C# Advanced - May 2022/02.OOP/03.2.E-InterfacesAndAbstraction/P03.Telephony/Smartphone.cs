using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string number)
        {
            return $"Calling... {number}";
        }

        public string BrowseSite(string site)
        {
            return $"Browsing: {site}!";
        }
    }
}
