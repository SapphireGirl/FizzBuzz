using FizzBuzz.Core.Models;
using FizzBuzz.Core.Repositories;
using FizzBuzz.Core.Repositories.EntityFramework;
using Microsoft.Data.SqlClient;

namespace FizzBuzz.Core.Services
{
    public class DbServices : IDbServices
    {
        private readonly IRepository _repository;
        public DbServices(IRepository repo)
        {
            _repository = repo;
        }

        public void AddFbToDb(string result)
        {

            //var blogs = _context.
            //    .FromSqlInterpolated($"EXECUTE dbo.FbProcedure {result}")
            //    .ToList();

            try
            {
                using (var dbContext = new FBContext())
                {
                    var user = new SqlParameter("user", "johndoe");

                    // ToDo:

                    //var rowsAffected = dbContext.Database.
                    //    .FromSql("EXECUTE dbo.GetMostPopularBlogsForUser @filterByUser=@user", user)
                    //    .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
