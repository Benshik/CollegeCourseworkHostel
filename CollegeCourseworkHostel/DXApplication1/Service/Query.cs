using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCourseworkHostel.Service
{
    static class Query
    {
        public static string SelectAllClients = "SELECT * from Client";
        public static string ClientInformation = "SELECT * from VClientInformation";
        public static string GetClientById = @"SELECT * from Client where id = {0}";

        public static string UpdateClient = "UPDATE client SET FirstName = '{0}', SecondName = '{1}', MiddleName = '{2}', Birthday = '{3}', Gender = '{4}' where id = {5}";

        public static string InsertClient = @"INSERT INTO client (FirstName, SecondName, MiddleName, Birthday, Gender)
                                             VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
    }
}