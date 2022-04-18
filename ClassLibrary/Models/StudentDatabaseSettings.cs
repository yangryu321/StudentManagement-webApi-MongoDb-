using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class StudentDatabaseSettings : IStudentDatabaseSettings
    {
        public string StudentsCollectionName { get; set; } = string.Empty;

        public string ConnectionString { get; set; } = string.Empty;

        public string DataBaseName { get; set; } = string.Empty;
    }
}
