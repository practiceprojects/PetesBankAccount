using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetesBankAccount
{
    class Customer
    {
        //trying to create lists of objects
        List<Checking> checkAccts = new List<Checking>();
        List<Saving> savAccts = new List<Saving>();

        public void SetChecking(Checking check)
        {
            checkAccts.Add(check);
        }
        public void SetSaving(Saving save)
        {
            savAccts.Add(save);
        }
        //Getting the objects is the list 
        public List<Checking> GetCheckAccount()
        {
            return checkAccts;
        }
        public List<Saving> GetSaveAccount()
        {
            return savAccts;
        }

        //check the checkAcct list object Name field against the user input and return that value

        public Checking GetChecking(string name)
        {

            return checkAccts.Where(x => x.Name == name).FirstOrDefault();
        }
        public Saving GetSaving(string name)
        {
            return savAccts.Where(x => x.Name == name).FirstOrDefault();
        }
        public string ConvertUsername(string name, int accttype)
        {

            if (accttype == 1)
            {
                return name += "ck";

            }
            else
            {
                return name += "sv";
            }
        }
    }
}