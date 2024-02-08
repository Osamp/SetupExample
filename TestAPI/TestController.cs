using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilityLibraries;

namespace UtilityLibraries
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("{x}")]
        public bool TestMethod(string param = "world", [FromRoute]int x = 1)
        {
            string cc = String.Empty;

            for(int i =0; i < x; i++)
            {
               cc = String.Concat(cc, string.Concat("Hello", param));
            }

            return param.StartsWithUpper();
        }

        public string Get()
        {
            return "Get Method";
        }
    }
}
