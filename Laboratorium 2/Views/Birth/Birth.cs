using Laboratorium_2.Models;

namespace Laboratorium_2.Views.Birth
{
    public class Birth
    {
        public DateTime birth { get; set; }
        public string? name { get; set; }

        public double Calculate()
        {
            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - birth.Year;

            if (currentDate.Month < birth.Month || (currentDate.Month == birth.Month && currentDate.Day < birth.Day))
            {
                years--;
            }

            return years;
        }
    }
}
