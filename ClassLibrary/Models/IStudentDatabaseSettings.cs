using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public interface IStudentDatabaseSettings
    {
        string StudentsCollectionName { get; set; }

        string ConnectionString { get; set; }

        string DataBaseName { get; set; }
        //"StudentsCollectionName": "Students",
        //"ConnectionString": "<connection string here>",
        //"DataBaseName" :  "Studentdb"
    }
}
