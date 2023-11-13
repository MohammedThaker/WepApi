using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class oops
    {

        private int Orderid;
        private int Orderno;
        private string DataOrderd;
        private string Datacreated;
        private string Status;
        private string Costuomername;
        private const string Pattern = @"^([a-zA-Z])+$";
        private const string Patterndate = @"^\d{1,2}/\d{1,2}/\d{4}$";
        public oops()
        {

        }

        public void setorderid(int i, int N, string da, string dc, string s, string cost)
        {

            if (i > 0)
                Orderid = i;
            else Console.WriteLine("Error Order Id shud be >0");
            //  if (N > 0)
            Orderno = N;
            if (validatedate(da) == true)
                DataOrderd = da;
            else Console.WriteLine("Error date");
            Datacreated = dc;
            Status = s;
            if (validateName(cost) == true)
                Costuomername = cost;
            else Console.WriteLine("Error name");
        }



        public static bool validateName(string name)
        {

            Regex r = new Regex(Pattern);

            return r.IsMatch(name);
        }
        public static bool validatedate(string date)
        {

            Regex r = new Regex(Patterndate);

            return r.IsMatch(date);
        }


        public string getorderid()
        {
            string alldata;

            alldata = "ID:" + Orderid + "\n";
            alldata += "No Order:" +Orderno + "\n";
            alldata += "Data Orderd:" + DataOrderd + "\n";
            alldata += "Data created:" + Datacreated + "\n";
            alldata += "Status:" +Status + "\n";
            alldata += "Costuomer Name:" + Costuomername + "\n";


            Console.WriteLine(alldata);

            return alldata;
        }




    }
}
