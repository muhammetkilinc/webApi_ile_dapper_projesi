using Api.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Core.DataAccess.Dapper;
using Api.Query.Entity;
using Core.ToolKit.Results;

namespace Api.Controllers
{
    [ApiController]
    public class KisiController : ControllerBase
    {
        private readonly IDbConnection _dbConnection;
        private IConfiguration _configuration;

        public KisiController(IDbConnection dbConnection, IConfiguration configuration)
        {
            _dbConnection = dbConnection;
            _configuration = configuration;
        }

        [HttpGet("api/kisi/list")]
        public async Task<IEnumerable<Kisi>> getKisilerAsync()
        {
            return await new DapperRepository(_dbConnection).QueryAsync<Kisi>(KisiQuery.GetKisiListesiSql);
        }

        [HttpGet("api/kisi/list/{Id}")]
        public async Task<IEnumerable<Kisi>> getKisilerAsync(int Id)
        {
            return await new DapperRepository(_dbConnection).QueryAsync<Kisi>(
                KisiQuery.GetKisiId, new { Id = Id }
                );
        }


        //SuccessDataResult tipinde dönüş sağlamak için;


        [HttpGet("api/kisi/listresulttype")]
        public async Task<IActionResult> getKisilerResultTypeAsync()
        {
            var datas = await new DapperRepository(_dbConnection).QueryAsync<Kisi>(KisiQuery.GetKisiListesiSql);
            var result = new SuccessDataResult<IEnumerable<Kisi>>(datas, datas.Count());
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        //API'nin kabul ettiği tip ve API'nin döneceği formatı belirleme ve HttpPost ile çalışma
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type= typeof(IDataResult<IEnumerable<Kisi>>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type= typeof(Core.ToolKit.Results.IResult))]
        [HttpPost("api/kisi/list/son")]
        public async Task<IActionResult> GetKisiListesiSon(TextKodRequest request)
        {
            var datas = await new DapperRepository(_dbConnection).QueryAsync<Kisi>(KisiQuery.GetKisiListesiSql);
            var result = new SuccessDataResult<IEnumerable<Kisi>>(datas, datas.Count());
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        //yeni bir kişi kaydetmek için insert api geliştireceğiz.
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<Kisi>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Core.ToolKit.Results.IResult))]
        [HttpPost("api/kisi/create")]
        public async Task<IActionResult> create(Kisi kisi)
        {
            var datas = await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<Kisi>(KisiQuery.InsertKisi, kisi);
            var result = new SuccessDataResult<Kisi>(datas);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        //yeni bir kişi kaydetmek için insert api geliştireceğiz.
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<Kisi>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Core.ToolKit.Results.IResult))]
        [HttpPost("api/kisi/create2")]
        public async Task<IActionResult> create2(Kisi kisi)
        {
            var datas = await new DapperRepository(_dbConnection).ExecuteAsync(KisiQuery.InsertKisi, kisi);
            var result = new SuccessDataResult<Kisi>(datas);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        //update
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<Kisi>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Core.ToolKit.Results.IResult))]
        [HttpPost("api/kisi/update/{Id}")]
        public async Task<IActionResult> update(int Id,[FromBody] Kisi kisi)
        {
            var kisiVarMi = await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<Kisi>(KisiQuery.GetKisiId, new { Id = Id });

            if (kisiVarMi == null)
            {
                return NotFound(ResultMessages.NoRecordsFound);
            }

            var datas = await new DapperRepository(_dbConnection).QueryFirstOrDefaultAsync<Kisi>(KisiQuery.UpdateKisi, kisi);
            var result = new SuccessDataResult<Kisi>(datas);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
