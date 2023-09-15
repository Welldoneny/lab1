using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Bank_Library
{
    public class Bank_Account
    {
        //First name of bank account owner
        private string first_name;
        //Last name of bank account owner
        private string last_name;

        private int amount_of_checks;
        //List with bank account owner's checks
        private List<Check> checks = new List<Check>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of the check</param>
        /// <param name="s">sum of the credit</param>
        /// <param name="t">time of the credit</param>
        public void credit(int  id, int s, int t)
        {
            checks[id].MakeCredit(s, t);
        }

        /// <summary>
        /// returns name of bank account owner
        /// </summary>
        /// <returns>string firstname+lastname</returns>
        public string Name()
        {
            return first_name + " " + last_name;
        }

        /// <summary>
        /// Constructor for bank account
        /// </summary>
        /// <param name="fn">first name</param>
        /// <param name="ln">last name</param>
        public Bank_Account(string fn, string ln)
        {
            first_name = fn;
            last_name = ln;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id of the check</param>
        /// <param name="m">money to add</param>
        public void TopUp(int id, int m)
        {
            checks[id].AddMoney(m);
        }

        /// <summary>
        /// minus money
        /// </summary>
        /// <param name="i">id of the check</param>
        /// <param name="m">money to minus</param>
        public  void minys (int i, int m)
        {
            checks[i].MinusMoney(m);
        }

        /// <summary>
        /// creates new bank check
        /// </summary>
        /// <param name="n">name of check</param>
        /// <param name="m">money to check</param>
        public void Create_Check(string n, int m)
        {
            checks.Add(new Check(n, m));
        }

        /// <summary>
        /// print all checks if you have, or "You dont have any check"
        /// </summary>
        /// <returns>string with checks</returns>
        public string ShowChecks()
        {
            string res = string.Empty;
            for (int i = 0; i < checks.Count(); i++)
            {
                res += checks[i].GetStatus() + "\n";
            }
            if (res == string.Empty)
            {
                return "You dont have any checks";
            }
            return res;
        }

        /// <summary>
        /// show amount of money on the check
        /// </summary>
        /// <param name="i">id of a check</param>
        public string GetMoneyOnTheCheck(int i)
        {
            return checks[i].GetMoney();
        }
    }

    /// <summary>
    /// Nested class, is using to store info about bank check
    /// </summary>
    class Check
    {
        //id counter
        private static int id = 0;
        //unique id
        private int selfId;
        //name of check
        private string name;
        //money on the check
        private int money;

        public void MakeCredit(int sum, int time)
        {

        }

        /// <summary>
        /// Constructor for bank check
        /// </summary>
        /// <param name="n">name of check</param>
        /// <param name="m">money to check</param>
        public Check(string n, int m)
        {
            selfId = id++;
            name = n;
            money = m;
        }

        /// <summary>
        /// Use to get info about check
        /// </summary>
        /// <returns>string name+selfId</returns>
        public string GetStatus()
        {
            return "Ваш банковский счёт - " + name + "\t id:" + selfId;
        }

        /// <summary>
        /// is using to get a money on the check
        /// </summary>
        /// <returns>money</returns>
        public string GetMoney()
        {
            return Convert.ToString(money);
        }
        
        /// <summary>
        /// use to minus money on the check
        /// </summary>
        /// <param name="m">money</param>
        public void MinusMoney(int m)
        {
            money -= m;
        }

        /// <summary>
        /// use to add money
        /// </summary>
        /// <param name="m">money to add</param>
        public void AddMoney(int m)
        {
            this.money += m;
        }
    }
}
