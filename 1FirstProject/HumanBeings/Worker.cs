using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanBeings
{
    public class Worker : Humans
    {
        public int wage { get; set; }
        public int hours_worked { get; set; }

        public Worker(int wages, int hours, string firstname, string lastname)
        {
            wage = wages;
            hours_worked = hours;
            first_name = firstname;
            last_name = last_name;
        }

        public void calculate_hourly_wage(int wages, int hours, string name)
        {
            double hourly_pay = wage / hours_worked;
        }

        public static int[] sort_wages(int[] wages)
        {
            int temp_variable;
            for (int i = 0; i < wages.Length; i++)
            {
                for (int j = i+1; j < wages.Length; j++)
                {
                    if (wages[i] < wages[j])
                    {
                        temp_variable = wages[i];
                        wages[i] = wages[j];
                        wages[j] = temp_variable;
                    }
                }
                
            }
            return wages;
        }
    }
}
