using Microsoft.AspNetCore.Mvc;

namespace charpYolo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShaHexController : ControllerBase
    {
        //ShaHex controller implements SHA to HEX

        // GET: /ShaHex
        [HttpGet]
        public async Task<string> Get()
        {
            string filePath = Helper.Util.getfilesFolderPath+"SHA_Wikipedia.txt"; //you can test with file: 100MB.BIN or other in the Files folder

            byte[] SHAresult = await cSharpYoloLibrary.ShaHex.calculateSHaAsync(filePath);
            string SHAresultToHex = await cSharpYoloLibrary.ShaHex.toHexAsync(SHAresult);
            return cSharpYoloLibrary.ShaHex.toHex(cSharpYoloLibrary.ShaHex.calculateSHA(filePath));
        }

    }
}
