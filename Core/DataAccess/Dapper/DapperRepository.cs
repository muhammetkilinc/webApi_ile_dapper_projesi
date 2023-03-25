using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Core.DataAccess.Dapper
{
    public class DapperRepository : IDapperRepository
    {
        //sadece Dapper içerisinde kullanılabilecek komut
        private readonly IDbConnection _dbConnection;
        public DapperRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<TDto> QueryFirstOrDefaultAsync<TDto>(string sql, object param = null)
        {
            return await _dbConnection.QueryFirstOrDefaultAsync<TDto>(sql, param);
        }

        public async Task<IEnumerable<TDto>> QueryAsync<TDto>(string sql, object param = null)
        {
            return await _dbConnection.QueryAsync<TDto>(sql, param);
        }

        public async Task<SqlMapper.GridReader> GetMultipleAsync(string sql, object param = null)
        {
            return await _dbConnection.QueryMultipleAsync(sql, param);
        }
        public async Task<int> ExecuteAsync(string sql, object param = null)
        {
            return await _dbConnection.ExecuteAsync(sql, param);
        }
    }
}
