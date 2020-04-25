using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApplicantService 
    {
        void ApplyForMask(Person person); //public kullanılmaz

        //generic list 
        List<Person> GetList();

        bool CheckPerson(Person person);
      
    }
}
