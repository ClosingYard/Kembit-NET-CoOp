using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DapperGET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ErrorController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<Error>>> GetAllEvents()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var errors = await connection.QueryAsync<Error>("select * from processor.events");
            return Ok(errors);
        }

        
    }
}
