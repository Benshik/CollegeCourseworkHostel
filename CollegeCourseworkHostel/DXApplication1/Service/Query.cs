using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeCourseworkHostel.Service
{
    static class Query
    {
        // запросы для клиентов
        public static string SelectAllClients = "SELECT * from VFullClientInformation";
        public static string ClientInformation = "SELECT * from VClientInformation";

        public static string GetClientById = @"SELECT * from Client where id = {0}";

        public static string UpdateClient = "UPDATE client SET FirstName = '{0}', SecondName = '{1}', MiddleName = '{2}', Birthday = '{3}', Gender = '{4}' where id = {5}";

        public static string InsertClient = @"INSERT INTO client (FirstName, SecondName, MiddleName, Birthday, Gender)
                                             VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";



        // запросы для бронирование клиентов спальных мест     

        public static string AllReservedPlaces = "SELECT * from VGuestBedsAccounting";

        public static string SelectRoomsWithEmptyBed = @"select DISTINCT Room from Couchette where Couchette.idСouchette not in (
                                                                            select idСouchette from VBisyBedLoad
                                                                            where('{0}'  BETWEEN DateArrival  AND DateDeparture) 
                                                                            and('{1}' BETWEEN DateArrival  AND DateDeparture))";

        public static string SelectFreeBedByDate = @"select DISTINCT Bed from Couchette where Couchette.Room = {0}
                                                                    AND Couchette.idСouchette not in ( select idСouchette from VBisyBedLoad  
                                                        where ('{1}' BETWEEN DateArrival AND DateDeparture)
                                                                and('{2}' > DateArrival AND DateDeparture))";

        public static string selectIDCouchette = @"SELECT idСouchette from Couchette where Room = {0} and bed = {1}";

        public static string insertNewReserv = @"insert into GuestBedsAccounting(idClient, idCouchete, Cost, DateArrival, DateDeparture) VALUES({0},{1}, {2}, '{3}', '{4}')";


        // запросы для отчета спальных мест
        public static string SelectBisySleepPlaces = @"select distinct room as'№ комнаты' from VBisyBedLoad";

        public static string SelectFreeRoom = @"select DISTINCT room as '№ комнаты'  from Couchette where idСouchette not in (select idСouchette from VBisyBedLoad)";

        public static string SelectFreeBedByRoom = @"select DISTINCT Bed as '№ кровати' from Couchette where Couchette.Room = {0}
                                                                    AND Couchette.idСouchette not in ( select idСouchette from VBisyBedLoad)";
        public static string SelectBusyBedByRoom= @"select Bed as '№ кровати', DateArrival as 'C:', DateDeparture as 'ПО:' from VBisyBedLoad  where room = {0} ";

        // запрос дял прдсчета дохода
       // public static string SelectBusyBedByRm = @"select * from VGuestBedsAccounting where {} BETWEEN  \"Дата заезда\"  and  \"Дата отъезда\""; 

    }
}