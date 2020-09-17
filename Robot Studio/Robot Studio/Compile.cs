using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Studio
{
    public class Compiler
    {
        public Compiler()
        {

        }

        public string Data_Hex_Asc(string Data)
        {
            string Data1 = "";
            string sData = "";
            while (Data.Length > 0)
            //first take two hex value using substring.
            //then convert Hex value into ascii.
            //then convert ascii value into character.
            {
                Data1 = System.Convert.ToChar(System.Convert.ToUInt32(Data.Substring(0, 2), 16)).ToString();
                sData = sData + Data1;
                Data = Data.Substring(2, Data.Length - 2);
            }
            return sData;
        }
        public decimal Data_Decimal(string Data)
        {
            decimal value = Convert.ToDecimal(Data, CultureInfo.InvariantCulture);
            return value;
        }
        public string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
    }
}
