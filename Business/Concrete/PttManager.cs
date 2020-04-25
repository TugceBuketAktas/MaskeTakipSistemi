using Business.Abstract;
using Entities.Concrete;
using System;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //constructor oluşturucu demek .new yapıldığında önce çalışır.
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person) //bir operasyon yazdık.
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirsName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirsName + " için Maske verilemedi");
            }

        }

    }
}
