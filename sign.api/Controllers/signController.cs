using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sign.core.entity;
using sign.core.rebosatory;

namespace sign.api.Controllers
{

    public class signController : baseController
    {
        private readonly igenericreposatory<signup> _signrepo;

        public signController(igenericreposatory<signup> signrepo)
        {
            _signrepo = signrepo;
        }


        [HttpPost("InsertSign")]
        public async Task<bool> Insert(signup signup)
        {
            try
            {
                await _signrepo.InsertAsync(signup);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //[HttpGet("{Id}")]
        //public async Task<ActionResult<signup>> getbyid(int Id)
        //{

        //    var productbyid = await _signrepo.GetByIdasync(Id);
        //     return Ok(productbyid);
        //}

        //[HttpGet("getall")]
        //public async Task<ActionResult<IEnumerable<signup>>> getAllusers()
        //{
        //    var gatall = await _signrepo.GetAllasync();
        //    return Ok(gatall);
        //}



    }
}
