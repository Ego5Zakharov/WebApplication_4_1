using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication_4_1.Models;

namespace WebApplication_4_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        [HttpGet("Euro-Tenge Transfer")]
        public string CurrencyEuroTenge(double euroCnt,double euroCourse)
        {
            var euroTransfer = euroCnt * euroCourse;

            return $"Конвертация евро - тенге: {euroTransfer}";
        }

        [HttpGet("Dollar-Tenge Transfer")]
        public string CurrencyDollarTenge(double dollarCnt, double dollarCourse)
        {
            var dollarTransfer = dollarCnt * dollarCourse;

            return $"Конвертация доллар - тенге: {dollarTransfer}";
        }

        [HttpGet("Rub-Tenge Transfer")]
        public string CurrencyRubTenge(double rubCnt, double rubCourse)
        {
            var rubTransfer = rubCnt * rubCourse;

            return $"Конвертация рубль - тенге: {rubTransfer}";
        }

        [HttpGet("Som-Tenge Transfer")]
        public string CurrencySomTenge(double somCnt, double somCourse)
        {
            var somTransfer = somCnt * somCourse;

            return $"Конвертация сом - тенге: {somTransfer}";
        }

        [HttpGet("Sterling-Tenge Transfer")]
        public string CurrencySterlingTenge(double sterlingCnt, double sterlingCourse)
        {
            var sterlingTransfer = sterlingCnt * sterlingCourse;

            return $"Конвертация стерлинг - тенге: {sterlingTransfer}";
        }

        static List<Person> persons = new List<Person>()
        {
            new Person {Id = 1 , BalanceInTenge = 500000, FIO =  "EgorZakharovPavlovich1" },
            new Person {Id = 2 , BalanceInTenge = 1500000, FIO = "EgorZakharovPavlovich2" },
            new Person {Id = 3 , BalanceInTenge = 7500000, FIO = "EgorZakharovPavlovich3" }
        };

        [HttpGet("Human ID")]
        public Person GetPizzaByID(int humanId)
        {
            return persons.FirstOrDefault(h => h.Id == humanId);
        }
    }
}
