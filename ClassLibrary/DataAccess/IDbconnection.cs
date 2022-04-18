using ClassLibrary.Models;

namespace ClassLibrary.DataAccess
{
    public interface IDbconnection
    {
        Task<Student> CreateAsync(Student student);
    }
}