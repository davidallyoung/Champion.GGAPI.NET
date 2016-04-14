using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Champion.GGAPI.Exception
{
    public class ChampionGgApiException : System.Exception
    {
        public ChampionGgApiErrorCode Code { get; set; }

        public ChampionGgApiException()
        { 
        }

        public ChampionGgApiException(string message) : base(message)
        {     
        }

        public ChampionGgApiException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        public static ChampionGgApiException CreateForErrorCode(int code)
        {
            var errorCode = (ChampionGgApiErrorCode) code;
            var msg = $"{(int)code}: {code}";
            return new ChampionGgApiException(msg) {Code = errorCode};
        }
    }

    public enum ChampionGgApiErrorCode
    {
        JsonSerializationError = 0,
        BadRequest = 400,
        Forbidden = 403,
        DataNotFound = 404,
        ServerError = 500,
        Unavailable = 503
    }
}
