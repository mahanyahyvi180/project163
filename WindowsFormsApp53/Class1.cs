using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp53
{
    public class student
    {
        private string cd;
        public string DateofBorn
        {
            get { return cd; }
            set
            {

                System.Globalization.PersianCalendar P = new System.Globalization.PersianCalendar();

                cd = P.GetYear(DateTime.Parse(value)).ToString() + "/" + P.GetMonth(DateTime.Parse(value)).ToString() + P.GetDayOfMonth(DateTime.Parse(value)).ToString();
            }


        }

    }
}
