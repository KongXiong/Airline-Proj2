using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace test
{
    public class login_pass
    {

        public string enterLogin()
        {
            Console.WriteLine("Enter Login.");
            string login = Console.ReadLine();
            return login;
        }
        string enterPassword()
        {
            Console.WriteLine("Enter Password.");
            string pass = Console.ReadLine();
            return pass;
        }
        public bool readFile(string nameIn, string passIn)
        {
            string json = File.ReadAllText(@"logandpass.json");
            List<user> psgInfo = JsonConvert.DeserializeObject<List<user>>(json);

            bool valid = false;

            foreach (user name in psgInfo)
            {
                if (nameIn == name.Username)
                {
                    if (passIn == name.Password)
                    {
                        valid = true;
                        return valid;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else
                {
                    valid = false;
                }
            }
                    return valid;
        }
    }
}
