using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    public class Note
    {
        public DateTime Date;
        private bool iscomExp;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Balance { get; set; }
        public bool IsComExp
        {

            get { return iscomExp; }
            set
            {
                iscomExp = false;
                if (Balance >= 0) iscomExp = true;
                else Balance *= (-1);
            }
        }


        public Note(DateTime date, string name, string type, int balance, bool isComExp)
        {
            Date = date;
            Name = name;
            Type = type;
            Balance = balance;
            IsComExp = isComExp;
        }
    }
}
