using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
//SOLID yazılımda kodlamanın standartlarıdır. Yazılım günlük hayatın programlanmasıdır.
//1.katman her iş bloğu sadece ve sadece bir işi yapar
//entities varlıgı tutar, business katmanında genelde if blogu kullanılır.

