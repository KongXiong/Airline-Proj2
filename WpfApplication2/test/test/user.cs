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
    public class user
    {
        public string Username;
        public string Password;
        List<user> userList = new List<user>();
        List<user> passwd = new List<user>();
        public user(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public void generateUser(List<user> name)
        {
            //user man = new user("admin", "admin");
            //userList.Add(man);

            //string json = File.ReadAllText("logandpass.json");
            //passwd = JsonConvert.DeserializeObject<List<user>>(json);
            //userList.AddRange(passwd);

            string json = JsonConvert.SerializeObject(name);
            File.WriteAllText("logandpass.json", json);
        }
    }
}
