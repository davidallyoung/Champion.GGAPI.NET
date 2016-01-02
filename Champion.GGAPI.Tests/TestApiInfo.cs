using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champion.GGAPI.Tests
{
    public static class TestApiInfo
    {
        public static string ApiKey = ConfigurationManager.AppSettings["apiKey"];

    }
}
