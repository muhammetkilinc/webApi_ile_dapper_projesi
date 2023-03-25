using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Core.DataAccess.Dapper
{
    public interface IDapperRepository
    {
        //veri tabanı bağlantısı
        //bir adet kayıt getirmek için
        Task<TDto> QueryFirstOrDefaultAsync<TDto>(string sql, object param = null);

        //geriye liste döndürür.
        Task<IEnumerable<TDto>> QueryAsync<TDto>(string sql, object param = null);

        //eş zamanlı çalıştırmak için
        //aynı anda birden fazla sql çalıştırır.
        Task<SqlMapper.GridReader> GetMultipleAsync(string sql, object param = null);


        //delete, update, insert işlemlerinde çalışacak
        Task<int> ExecuteAsync(string sql, object param = null);
        
    }
}
