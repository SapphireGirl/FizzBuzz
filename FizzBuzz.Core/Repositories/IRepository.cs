using FizzBuzz.Core.Models;

namespace FizzBuzz.Core.Repositories
{
    // The need for the interface is for implementing 2 types of repositories
    // 1. Dapper
    // 2. Entity Framework
    public interface IRepository
    {
        void insertFizzBuzz();
    }
}
