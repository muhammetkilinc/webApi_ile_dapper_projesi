using Api.Models.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Core.DataAccess.Dapper;

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
            var result = await new DapperRepository(_dbConnection).QueryAsync<Kisi>("SELECT * FROM Kisi");
            return result;
        }


    }
}
