using ClassLibrary.Models;
using MongoDB.Driver;

namespace ClassLibrary.DataAccess
{
    public class Dbconnection : IDbconnection
    {
        private IMongoCollection<Student> _students;

        public Dbconnection(IMongoClient client, IStudentDatabaseSettings databaseSettings)
        {
            var database = client.GetDatabase(databaseSettings.DataBaseName);
            _students = database.GetCollection<Student>(databaseSettings.StudentsCollectionName);
        }

        public async Task<Student> CreateAsync(Student student)
        {
            await _students.InsertOneAsync(student);
            return student;
        }


    }
}
