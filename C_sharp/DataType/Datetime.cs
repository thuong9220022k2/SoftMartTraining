using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.DataType
{
    public class DatetimeHandler
    {
        public string GetCurrentDate()
        {
            var currentDate = DateTime.Now;
            var dayOfWeek = currentDate.DayOfWeek;
            var day = currentDate.Day;
            var month = currentDate.Month;
            var year = currentDate.Year;
            var result = $"Hôm nay là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }

        public string GetCurrentTime(DateTime currentDate)
        {
            var dayOfWeek = currentDate.DayOfWeek;
            var day = currentDate.Day;
            var month = currentDate.Month;
            var year = currentDate.Year;
            var result = $"Hôm nay là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }

        public string GetTomorrowDate()
        {
            var currentDate = DateTime.Now;
            var tomorrowDate = currentDate.AddDays(1);
            var dayOfWeek = tomorrowDate.DayOfWeek;
            var day = tomorrowDate.Day;
            var month = tomorrowDate.Month;
            var year = tomorrowDate.Year;
            var result = $"Hom sau là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }

        public string GetYesterday()
        {
            var currentDate = DateTime.Now;
            var yesterday = currentDate.AddDays(-1);
            var dayOfWeek = yesterday.DayOfWeek;
            var day = yesterday.Day;
            var month = yesterday.Month;
            var year = yesterday.Year;
            var result = $"Hom qua là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }

        public string CheckDatetime(DateTime date)
        {
            if (date.Date == DateTime.Now.Date)
            {
                var message = Notify.Today;
                return message;
            }
            else if (date.Date == DateTime.Now.AddDays(-1).Date)
            {
                var message = Notify.Yesterday;
                return message;
            }
            else if (date.Date == DateTime.Now.AddDays(1).Date)
            {
                var message = Notify.Tomorrow;
                return message;
            }
            else
            {
                var message = Notify.OtherDay;
                return message;
            }
        }

        public string ConvertDatetime(DateTime date)
        {
            // Hiển thị ngày dưới dạng: Ngày/tháng/năm. VD:18/03/2014
            // Hiển thị ngày dưới dạng: Năm/tháng/ngày. VD: 2014/03/18
            // Hiển thị ngày dưới dạng: Tháng/năm. VD: 03/2014
            // Hiển thị ngày dưới dạng: Tháng-năm. VD: 03-2014
            var day = date.Day;
            var month = date.Month;
            var year = date.Year;
            var result = $"{day}/{month}/{year}"; // other datatime format can do like that .
            return result;
        }
        public string GetDayOfWeek()
        {
            var currentDate = DateTime.Now;
            var datetime = currentDate.AddDays(-10);
            var dayOfWeek = datetime.DayOfWeek;
            var result = $"10 Hom trc là thu {dayOfWeek}";
            return result;
        }

        public string GetLastDayOfMonth()
        {
            var currentDate = DateTime.Now;
            var lastDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));
            var dayOfWeek = lastDayOfMonth.DayOfWeek;
            var day = lastDayOfMonth.Day;
            var month = lastDayOfMonth.Month;
            var year = lastDayOfMonth.Year;
            var result = $"Ngày cuối cùng của tháng là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }
        public string GetLastDayOfYear()
        {
            var currentDate = DateTime.Now;
            var lastDayOfYear = new DateTime(currentDate.Year, 12, 31);
            var dayOfWeek = lastDayOfYear.DayOfWeek;
            var day = lastDayOfYear.Day;
            var month = lastDayOfYear.Month;
            var year = lastDayOfYear.Year;
            var result = $"Ngày cuối cùng của năm là thu {dayOfWeek} , ngày {day}  tháng {month}  năm {year}";
            return result;
        }

        public string GetDistanceBetweenTwoDate(DateTime date1, DateTime date2)
        {
            var distance = date1 - date2;
            var result = $"Khoảng cách giữa 2 ngày là {distance.Days} ngày";
            return result;
        }

    }
}