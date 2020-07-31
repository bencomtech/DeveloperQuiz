using System;
using System.Globalization;

namespace DeveloperQuiz
{
    public class Quiz1
    {
        private const string Format = "yyyyMMdd";

        public bool IsOverlapped(string beginDate1, string endDate1, string beginDate2, string endDate2)
        {
            DateTime beginDateTime1 = DateTime.ParseExact(beginDate1, Format, CultureInfo.InvariantCulture);
            DateTime endDateTime1 = DateTime.ParseExact(endDate1, Format, CultureInfo.InvariantCulture);

            DateTime beginDateTime2 = DateTime.ParseExact(beginDate2, Format, CultureInfo.InvariantCulture);
            DateTime endDateTime2 = DateTime.ParseExact(endDate2, Format, CultureInfo.InvariantCulture);

            return beginDateTime1 < endDateTime2 && beginDateTime2 < endDateTime1;
        }
    }
}
