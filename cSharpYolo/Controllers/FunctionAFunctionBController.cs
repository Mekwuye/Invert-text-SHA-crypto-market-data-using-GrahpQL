using Microsoft.AspNetCore.Mvc;

namespace charpYolo.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    public class FunctionAFunctionBController : ControllerBase
    {
        cSharpYoloLibrary.FunctionAFunctionB functionAfunctionB;

        public FunctionAFunctionBController()
        {
            functionAfunctionB = new cSharpYoloLibrary.FunctionAFunctionB();
        }

        // GET: <FunctionAFunctionBController>
        [HttpGet]
        public async Task< string> Get()
        {
            await    functionAfunctionB.execute();
            return functionAfunctionB.getAllProcessedDataLog();
        }

    

   

       
    }
}
