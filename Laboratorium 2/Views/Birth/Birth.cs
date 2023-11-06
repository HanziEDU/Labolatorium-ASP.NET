using Laboratorium_2.Models;

namespace Laboratorium_2.Views.Birth
{
    public class Birth
    {
        public DateTime birth { get; set; }
        public string? name { get; set; }

        public double Calculate()
        {
            return DateTime.Now.Year - birth.Year;
        }
    }
}
