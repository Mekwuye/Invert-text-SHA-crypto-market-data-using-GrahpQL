using Microsoft.AspNetCore.Mvc;

namespace charpYolo.Controllers
{
#pragma warning disable CS8603 // Possible null reference return. //why i disabled this is because null reference are already explictly handled where implemented

    [Route("[controller]")]
    [ApiController]
    public class InvertController : ControllerBase
    {
        // GET: /invert
        [HttpGet]
        public async  Task< string> Get()
        {
            //for test, use the overloaded method that accept text as paramenter: cSharpYoloLibrary.Invert.invertPlainText("invert me")
            return await  cSharpYoloLibrary.Invert.invertPlainText();
        }


    }
}
