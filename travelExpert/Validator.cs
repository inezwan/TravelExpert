using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travelExpert
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        /// <summary>
        /// Checks for presence in input textbox.
        /// </summary>
        /// <param name="value">textbox.Text</param>
        /// <param name="name">Tag</param>
        /// <returns></returns>
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Checks length of input
        /// </summary>
        /// <param name="value">Value read from textboxt</param>
        /// <param name="name">Textbox Tag</param>
        /// <param name="num">Number of characters constraint</param>
        /// <returns></returns>
        public static string IsMoreThanNumber(string value, string name, int num)
        {
            string msg = "";
            if (value.Length > num)
            {
                msg += name + $" should be less than {num} characters." + LineEnd;
            }
            return msg;
        }
        /// <summary>
        /// Checks length of decimal
        /// </summary>
        /// <param name="value">Value read from textboxt</param>
        /// <param name="name">Textbox Tag</param>
        /// <returns></returns>
        public static string IsDecimalLength(string value, string name)
        {
            string msg = "";
            if ((value.IndexOf(".") != -1) & (Decimal.TryParse(value, out _)))
                if (value.Split(".")[0].Length > 17)
                    msg += name + " should be less than 18 characters." + LineEnd;
            if ((value.IndexOf(".") == -1) & (Decimal.TryParse(value, out _)))
                if (value.Length > 17)
                    msg += name + " should be less than 18 characters." + LineEnd;
            return msg;
        }

        /// <summary>
        /// Checks if number is a decimal.
        /// </summary>
        /// <param name="value">Value read from textboxt</param>
        /// <param name="name">Textbox Tag</param>
        /// <returns></returns>
        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        /// <summary>
        /// Check to see that the input is a date
        /// </summary>
        /// <param name="value">Value read from textboxt</param>
        /// <param name="name">Textbox Tag</param>
        /// <returns></returns>
        public static string IsDate(string value, string name)
        {
            string msg = "";
            if (!DateTime.TryParse(value, out _))
            {
                msg += name + " must be a valid date." + LineEnd;
            }
            return msg;
        }

        public static string IsLessThanBase(string commision, string basePrice, string name)
        {
            string msg = "";
            if (Convert.ToDecimal(commision)>Convert.ToDecimal(basePrice))
            { msg += name + " must be less than Base Price." + LineEnd; }
            return msg;
        }

        public static string CheckDate(DateTime startDate, DateTime endDate)
        {
            string msg = "";
            if (startDate < DateTime.Today)
            {
                msg += "Start date cannot be in the past.";
               
            }
            if (endDate <= startDate)
            {
                msg += "End date must be greater than start date.";
               
            }
            return msg;
        }
    }
}
