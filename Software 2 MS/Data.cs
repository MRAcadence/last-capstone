using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Software_2_MS
{
    public class Data
    {
        private static string server = "database-2.cbgy0ky0q8vn.us-east-2.rds.amazonaws.com";
        private static string dbname = "database-2";
        //private static string servername = "Local instance MySQL80";
        private static string password = "Mm65001302";
        private static int userID;
        private static string userName = "root";
        //public static string conString = "SERVER=" + server + ";" + "DATABASE=" + dbname + ";" + "Uid=" + userName + ";" + "Pwd=" + password + ";" + "SslMode=None;AllowPublicKeyRetrieval=True;";
        public static string conString = "Server=database-2.cbgy0ky0q8vn.us-east-2.rds.amazonaws.com;Port=3306;Database=software_2;userID=admin;password=65001302;SslMode=Preferred;AllowPublicKeyRetrieval=True;";
        //gets the connection string for the database
        public static string getConString()
        {
            return conString;
        }

        //retrieves the user id 
        public static int getUserID()
        {
            return userID;
        }

        //sets the user id
        public static void setUserID(int currUserID)
        {
            userID = currUserID;
        }

        //retrieves the username
        public static string getUserName()
        {
            return userName;
        }

        //sets the username 
        public static void setUserName(string currUserName)
        {
            userName = currUserName;
        }

        //creates a dictionary call current appointments 
        private static Dictionary<int, Hashtable> currentAppointments = new Dictionary<int, Hashtable>();
        
        //pulls the appointments from the dictionary 
        public static Dictionary<int, Hashtable> getApp()
        {
            return currentAppointments;
        }

        //sets the appointments in the dictionary current appointments 
        public static void setAppointments(Dictionary<int, Hashtable> appointments)
        {
            currentAppointments = appointments;
        }

        // checks the user credentials to see if the user is valid and returns a 1 if the users credentials are valid 
        public static int userCheck(string user, string password)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            //sql command is susceptable to sql injection because it directly inerpolates the user and password parameters into the sql query
            MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user WHERE userName = '{user}' AND password = '{password}'", con);
            MySqlDataReader r = cmd.ExecuteReader();
            //returns 1 if the user credentials are valid
            if (r.HasRows)
            {
                r.Read();
                setUserID(Convert.ToInt32(r[0]));
                setUserName(Convert.ToString(r[1]));
                r.Close();
                con.Close();
                return 1;
            }
            else 
            {
                //if the credentials are not valid the connection closes and it returns a 0 to indicate the user could not be validated
                con.Close();
                return 0;
            }
            
        }

        //retrieves the datetime for the current universal time
        public static DateTime getTime()
        {
            return DateTime.Now.ToUniversalTime();
        }
        
        //converts the datetime value into a sql datevalue format
        public static string dateSqlFormat(DateTime dateValue)
        {
            string sqlDT = dateValue.ToString("yyyy-MM-dd HH:mm");
            return sqlDT;
        }


        //creates a new customer and inserts it into the database
        public static void addCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {
            string sqlDate = dateSqlFormat(dateTime);
            MySqlConnection con = new MySqlConnection(conString);
            //opens the connection with the database
            con.Open();
            MySqlTransaction trans = con.BeginTransaction();
            
            //query command for inserting the customer into the database 
            var q = "INSERT into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{id}', '{name}', '{addressId}', '{active}', '{dateSqlFormat(dateTime)}', '{user}', '{user}')";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //commits the transaction and closes the connection
            trans.Commit();
            con.Close();
        }

        //creates a new user and inserts it into the database 
        public static void addUser(int userId, string userName, string password, int active, DateTime dateTime, string user)
        {
            string sqlDate = dateSqlFormat(dateTime);
            MySqlConnection con = new MySqlConnection(conString);
            //opens the connection with the database
            con.Open();
            MySqlTransaction trans = con.BeginTransaction();

            //command for inserting the data into the database
            var q = "INSERT into user (userId, userName, password, active, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{userId}', '{userName}', '{password}', '{active}', '{dateSqlFormat(dateTime)}', '{user}', '{user}')";
          
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Transaction = trans;
            //commits the transaction and closes the connection
            cmd.ExecuteNonQuery();
            trans.Commit();
            con.Close();
        }
        
        //updates the user information for a user that is already in the database
        public static void updateUser(IDictionary<string, object> dictionary)
        {
            string user = getUserName();
            DateTime utc = getTime();
            int userId = getUserID();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //updates the userTable in the database 
            MySqlTransaction trans = con.BeginTransaction();
            var uQuery = $"UPDATE user" +
                $" SET userName = '{dictionary["userName"]}', password = '{dictionary["password"]}', active = '{dictionary["active"]}', lastUpdateBy = '{user}'" +
                $" WHERE userId = '{dictionary["userId"]}'";
           
            MySqlCommand cmd = new MySqlCommand(uQuery, con);
            cmd.Transaction = trans;
            //commits the transaction and closes the connection
            cmd.ExecuteNonQuery();
            trans.Commit();
            con.Close();
        }
        //updates the customer information for a customer that is already in the database
        public static void modifyCustomer(IDictionary<string, object> dictionary)
        {
            string user = getUserName();
            DateTime utc = getTime();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //updates the country table in the database
            MySqlTransaction trans = con.BeginTransaction();
            var cuQuery = $"UPDATE country" +
                $" SET country = '{dictionary["country"]}', lastUpdateBy = '{user}'" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
           
            MySqlCommand cmd = new MySqlCommand(cuQuery, con);
            cmd.Transaction = trans;
            //commits the transaction
            cmd.ExecuteNonQuery();
            trans.Commit();

            //updates the city table in the database
            trans = con.BeginTransaction();
            var cQuery = $"UPDATE city" +
                $" SET city = '{dictionary["city"]}', lastUpdateBy = '{user}'" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            
            cmd.CommandText = cQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            //committs the transaction
            cmd.ExecuteNonQuery();
            trans.Commit();

            //updates the address table in the database
            trans = con.BeginTransaction();
            var addQuery = $"UPDATE address" +
                $" SET address = '{dictionary["address"]}', lastUpdateBy = '{user}', postalCode = '{dictionary["postalCode"]}', phone = '{dictionary["phone"]}'" +
                $" WHERE addressID = '{dictionary["addressId"]}'";
            
            cmd.CommandText = addQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
           //committs the transaction
            cmd.ExecuteNonQuery();
            trans.Commit();

            //updates the customer table in the database
            trans = con.BeginTransaction();
            var custQuery = $"UPDATE customer" +
                $" SET customerName = '{dictionary["customerName"]}', lastUpdateBy = '{user}', active = '{dictionary["active"]}'" +
                $" WHERE customerId = '{dictionary["customerId"]}'";
            
            cmd.CommandText = custQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            //commits the transaction and closes the connection
            cmd.ExecuteNonQuery();
            trans.Commit();
            con.Close();
        }

        //returns a list with information of appointment based on appointmentId
        public static List<KeyValuePair<string, object>> getAppList(int appointmentId)
        {
            var appList = new List<KeyValuePair<string, object>>();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            var q = $"SELECT * FROM appointment WHERE appointmentId = {appointmentId}";

            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader rd = cmd.ExecuteReader();

            try
            {
                //reads and extracts the data from the database reader into a list of key value pairs for an appointment
                if (rd.HasRows)
                {
                    rd.Read();
                    appList.Add(new KeyValuePair<string, object>("appointmentId", rd[0]));
                    appList.Add(new KeyValuePair<string, object>("customerId", rd[1]));
                    appList.Add(new KeyValuePair<string, object>("title", rd[3]));
                    appList.Add(new KeyValuePair<string, object>("description", rd[4]));
                    appList.Add(new KeyValuePair<string, object>("location", rd[5]));
                    appList.Add(new KeyValuePair<string, object>("contact", rd[6]));
                    appList.Add(new KeyValuePair<string, object>("type", rd[7]));
                    appList.Add(new KeyValuePair<string, object>("start", rd[9]));
                    appList.Add(new KeyValuePair<string, object>("end", rd[10]));
                    rd.Close();
                }
                else
                {
                    return null;
                }
                return appList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //deletes a customer from the customer table in the database
        public static void custDelete(IDictionary<string, object> dictionary)
        {
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //deletes the customer from customer table
            var customerQuery = $"DELETE FROM customer WHERE customerId = '{dictionary["customerId"]}'";
            MySqlCommand cmd = new MySqlCommand(customerQuery, con);
            MySqlTransaction trans = con.BeginTransaction();

            cmd.CommandText = customerQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //commits the transaction
            trans.Commit();

            //deletes the customers address from address table
            trans = con.BeginTransaction();
            var aQuery = $"DELETE FROM address WHERE addressId = '{dictionary["addressId"]}'";
            
            cmd.CommandText = aQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //commits the transaction
            trans.Commit();

            //deletes the customers city from city table
            trans = con.BeginTransaction();
            var cQuery = $"DELETE FROM city WHERE cityId = '{dictionary["cityId"]}'";
            
            cmd.CommandText = cQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //commits the transaction
            trans.Commit();

            //deletes the customers country from country table
            trans = con.BeginTransaction();
            var cuQuery = $"DELETE FROM country WHERE countryId = '{dictionary["countryId"]}'";
            
            cmd.CommandText = cuQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //commits the transaction and closes the connection
            trans.Commit();
            con.Close();

        }

        //gets the customers id from the customer table in the database
        public static int getID(string table, string id)
        {
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            var q = $"SELECT max({id}) FROM {table}";

            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                rd.Read();
                if (rd[0] == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt32(rd[0]);
            }
            return 0;
        }
        //creates the country entry for the database
        public static int makeCountry(string country)
        {
            int ctryID = getID("country", "countryID") + 1;
            string user = getUserName();
            DateTime utc = getTime();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            MySqlTransaction trans = con.BeginTransaction();
            var query = "INSERT into country (countryID, country, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{ctryID}', '{country}', '{dateSqlFormat(utc)}', '{user}', '{user}')";
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
            return ctryID;
        }
        //creates the city entry for the database
        public static int makeCity(int countryID, string city)
        {
            int cID = getID("city", "cityID") + 1;
            string user = getUserName();
            DateTime utc = getTime();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            MySqlTransaction trans = con.BeginTransaction();
            var q = "INSERT into city (cityID, city, countryId, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{cID}', '{city}', '{countryID}', '{dateSqlFormat(utc)}', '{user}', '{user}')";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
            return cID;
        }
        //creates the address entry for the database by concatinating the location information all together to  form the address
        public static int makeAddress(int cityID, string address, string address2, string zipCode, string phone)
        {
            int addID = getID("address", "addressID") + 1;
            string userName = getUserName();
            DateTime utc = getTime();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            MySqlTransaction trans = con.BeginTransaction();
            var q = "INSERT into address (addressID, address, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                $"VALUES ('{addID}', '{address}','{address2}', '{cityID}', '{zipCode}', '{phone}', '{dateSqlFormat(utc)}', '{userName}', '{userName}')";
            
            MySqlCommand cmd = new MySqlCommand(q, con);

            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
            return addID;
        }

        //take customerId and return a list of all customer information from the database.
        public static List<KeyValuePair<string, object>> customerFinder(int customerID)
        {
            var list = new List<KeyValuePair<string, object>>();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var q = $"SELECT * FROM customer where customerId = {customerID}";
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader rd = cmd.ExecuteReader();
            
            try
            {
                //checks if the database has the specified information and if it does not it returns null 
                if (rd.HasRows)
                {
                    rd.Read();
                    list.Add(new KeyValuePair<string, object>("customerId", rd[0]));
                    list.Add(new KeyValuePair<string, object>("customerName", rd[1]));
                    list.Add(new KeyValuePair<string, object>("addressId", rd[2]));
                    list.Add(new KeyValuePair<string, object>("active", rd[3]));
                    rd.Close();
                }

                else
                {

                    return null;
                }
                var addID = list.First(kvp => kvp.Key == "addressId").Value;
                var addQuery = $"SELECT * FROM address WHERE addressId = {addID}";

                cmd.CommandText = addQuery;
                cmd.Connection = con;
               
                MySqlDataReader ar = cmd.ExecuteReader();
                if (ar.HasRows)
                {
                    ar.Read();
                    list.Add(new KeyValuePair<string, object>("address", ar[1]));
                    list.Add(new KeyValuePair<string, object>("cityId", ar[3]));
                    list.Add(new KeyValuePair<string, object>("postalCode", ar[4]));
                    list.Add(new KeyValuePair<string, object>("phone", ar[5]));
                    ar.Close();
                }

                var cID = list.First(kvp => kvp.Key == "cityId").Value;
                var cQuery = $"SELECT * FROM city WHERE cityId = {cID}";
                
                cmd.CommandText = cQuery;
                cmd.Connection = con;
                MySqlDataReader cr = cmd.ExecuteReader();
               
                if (cr.HasRows)
                {
                    cr.Read();
                    list.Add(new KeyValuePair<string, object>("city", cr[1]));
                    list.Add(new KeyValuePair<string, object>("countryId", cr[2]));
                    cr.Close();
                }

                var cuID = list.First(kvp => kvp.Key == "countryId").Value;
                var cuQuery = $"SELECT * FROM country WHERE countryId = {cuID}";
               
                cmd.CommandText = cuQuery;
                cmd.Connection = con;
                MySqlDataReader ccr = cmd.ExecuteReader();
                
                if (ccr.HasRows)
                {
                    ccr.Read();
                    list.Add(new KeyValuePair<string, object>("country", ccr[1]));
                    ccr.Close();
                }
                return list;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
                return null;
            }
        }

        //allows for the searching of a user in the database
        public static List<KeyValuePair<string, object>> findUser(int uId)
        {
            var listFinder = new List<KeyValuePair<string, object>>();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var q = $"SELECT * FROM user where userId = {userID}";
           
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            try
            {

                if (r.HasRows)
                {
                    r.Read();
                    listFinder.Add(new KeyValuePair<string, object>("userId", r[0]));
                    listFinder.Add(new KeyValuePair<string, object>("userName", r[1]));
                    listFinder.Add(new KeyValuePair<string, object>("password", r[2]));
                    listFinder.Add(new KeyValuePair<string, object>("active", r[3]));
                    r.Close();
                }
                return listFinder;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception);
                return null;
            }
        }

        //deletes the specified user from the database 
        public static void deleteUser(string userId)
        {
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //delets the user from the customer table
            var uQuery = $"DELETE FROM user WHERE userId = '{userId}'";
            MySqlCommand cmd = new MySqlCommand(uQuery, con);
            MySqlTransaction trans = con.BeginTransaction();
           
            cmd.CommandText = uQuery;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
        }

        //creates a new appointment tied to a customer
        public static void createApp(int custID, string title, string description, string location, string contact, string type, DateTime start, DateTime end)
        {
            int appID = getID("appointment", "appointmentId") + 1;
            int UserID = 1;
            string UserName = getUserName();
            DateTime utc = getTime();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            //query to insert the information that is needed into the database 
            MySqlTransaction trans = con.BeginTransaction();
            var query = $"INSERT into appointment (appointmentId, customerId, title, userId, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy)" +
                $"VALUES ('{appID}', '{custID}', '{title}', '{getUserID()}', '{description}', '{location}', '{contact}', '{type}', 'not needed', '{dateSqlFormat(start)}', '{dateSqlFormat(end)}', '{dateSqlFormat(utc)}', '{UserName}','{UserName}')";
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
        }

        //takes a dictionary of data supplied from text fields in form and saves to database
        public static void updateApp(IDictionary<string, object> dictionary)
        {
            string userName = getUserName();
            DateTime universal = getTime();
            DateTime startTime = Convert.ToDateTime(dictionary["start"]);
            DateTime endTime = Convert.ToDateTime(dictionary["end"]);
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            MySqlTransaction trans = con.BeginTransaction();
            var q = $"UPDATE appointment SET customerId = '{dictionary["customerId"]}', title = '{dictionary["title"]}', description = '{dictionary["description"]}', location = '{dictionary["location"]}', contact = '{dictionary["contact"]}', type = '{dictionary["type"]}',  start = '{dateSqlFormat(startTime.ToUniversalTime())}', end = '{dateSqlFormat(endTime.ToUniversalTime())}', url = '{dictionary["url"]}', lastUpdate = '{dateSqlFormat(universal)}',  lastUpdateBy = '{userName}' WHERE appointmentId = '{dictionary["appointmentId"]}'";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();

        }

        //pulls a list of users from the database
        public static List<KeyValuePair<string, object>> getUserList(int UserId)
        {
            var listUser = new List<KeyValuePair<string, object>>();
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var q = $"SELECT * FROM user WHERE userId = {UserId}";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
           
            try
            {
                if (r.HasRows)
                {
                    r.Read();
                    listUser.Add(new KeyValuePair<string, object>("userId", r[0]));
                    listUser.Add(new KeyValuePair<string, object>("userName", r[1]));
                    listUser.Add(new KeyValuePair<string, object>("password", r[3]));
                    listUser.Add(new KeyValuePair<string, object>("enabled", r[4]));
                    listUser.Add(new KeyValuePair<string, object>("location", r[5]));
                    r.Close();
                }
                else
                {
                    return null;
                }
                return listUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //method that will return true if the specified customer has an appointment in the database
        public static bool checkApp(string custID)
        {
            Console.WriteLine(custID);
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            var query = $"SELECT * FROM appointment where customerID = '{custID}'";
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            if (r.HasRows)
            {
                r.Read();
                return true;
            }
            return false;
        }

        //returns dictionary of next appointment containing information such as type of appointment, stat time of appointment, and the name 
        public static Dictionary<string, object> getNextApp()
        {
            Dictionary<string, object> nextApp = new Dictionary<string, object>();
            string universalOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            //var q = $"SELECT type,  start, (SELECT customerName from customer where customerId = appointment.customerId) as 'Name' from appointment where start > now() order by start";
            var q = $"SELECT type, start, (SELECT customerName FROM customer WHERE customerId = appointment.customerId) AS 'Name' FROM appointment WHERE start > CURRENT_TIMESTAMP ORDER BY start LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            if (r.HasRows)
            {
                r.Read();
                nextApp.Add("type", r[0]);
                nextApp.Add("start", Convert.ToDateTime(r[1]).ToLocalTime());
                nextApp.Add("name", r[2]);
            }
            return nextApp;
        }

        //returns the amount of times the given appointment time overlaps with existing appointments
        public static int overlap(DateTime start, DateTime end)
        {
            //opens the connection with the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var q = $"SELECT count(*) FROM `appointment` WHERE (('{dateSqlFormat(start.ToUniversalTime())}' > start and '{dateSqlFormat(start.ToUniversalTime())}' < end) or ('{dateSqlFormat(end.ToUniversalTime())}'> start and '{dateSqlFormat(end.ToUniversalTime())}' < end)) and end > now() order by  start limit 1;";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            if (r.HasRows)
            {
                r.Read();
                string count = r[0].ToString();
                int answer = count == "0" ? 0 : 1;
                return answer;
            }
            return 0;
        }

        // checks all of the appointments to make sure that no appointments are overlapping
        public static bool appOverlaps(DateTime start, DateTime end)
        {
            foreach (var app in Data.getApp().Values)
            {
                if (start < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < end)
                    return true;
            }
            return false;
        }

        //deletes appointments based on customer ID 
        public static void deleteCustomerApp(string custID)
        {
            //opens connection to the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var q = $"DELETE FROM appointment"+
                "WHERE customerId = '{custID}'";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlTransaction trans = con.BeginTransaction();
            
            cmd.CommandText = q;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
        }

        //deletes the selected appointment based on appointment id from the database
        public static void deleteApp(IDictionary<string, object> dictionary)
        {
            //opens connection to the database
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
           
            var query = $"DELETE FROM appointment WHERE appointmentId = '{dictionary["appointmentId"]}'";
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlTransaction trans = con.BeginTransaction();
            
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.Transaction = trans;
            cmd.ExecuteNonQuery();
            //committs the transaction adn closes the connection with the database
            trans.Commit();
            con.Close();
        }

        //creates a report of the number of appointments by month and then returns that report
        public static Dictionary<string, object> appByMonth(string type)
        {
            Dictionary<string, object> reportMonth = new Dictionary<string, object>();
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            var q = "SELECT DISTINCT " +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 1) as 'Jan'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 2) as 'Feb'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 3) as 'Mar'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 4) as 'Apr'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 5) as 'May'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 6) as 'Jun'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 7) as 'Jul'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 8) as 'Aug'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 9) as 'Sep'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 10) as 'Oct'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 11) as 'Nov'," +
                $" (select count(type) from appointment where type = '{type}' and MONTH(appointment.start) = 12) as 'Dec'" +
                " from appointment;";
           
            MySqlCommand cmd = new MySqlCommand(q, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            if (r.HasRows)
            {
                r.Read();
                reportMonth.Add("Jan", r[0]);
                reportMonth.Add("Feb", r[1]);
                reportMonth.Add("Mar", r[2]);
                reportMonth.Add("Apr", r[3]);
                reportMonth.Add("May", r[4]);
                reportMonth.Add("Jun", r[5]);
                reportMonth.Add("Jul", r[6]);
                reportMonth.Add("Aug", r[7]);
                reportMonth.Add("Sep", r[8]);
                reportMonth.Add("Oct", r[9]);
                reportMonth.Add("Nov", r[10]);
                reportMonth.Add("Dec", r[11]);
            }
            return reportMonth;

        }

        //fetches appointmetns filtered by users and returns the datable that it populates with the results
        public static DataTable getAppByUser(string userId)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //userName = getUserName();
            string q = $"SELECT title as 'Title', type as 'Type', description as 'Description', start as 'Start Time', end as 'End Time', createdBy as 'Consultant' FROM appointment where userId = '{userId}' ORDER BY start;";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            
            foreach (DataRow row in dt.Rows)
            {
                DateTime universalStart = Convert.ToDateTime(row["Start Time"]);
                DateTime universalEnd = Convert.ToDateTime(row["End Time"]);
                
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(universalStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(universalEnd);
            }
            con.Close();
            return dt;
        }

        //fetches list of appointments for a specific customer and adjusts the datetime values to local time zones and returns the results as a datatable
        public static DataTable getAppByCust(string id)
        {
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();

            //string q = $"SELECT title as 'Title', start as 'Start Time', end as 'End Time', location as 'Location', contact as 'Contact', type as 'Type', FROM appointment WHERE customerId = '{id}', ORDER BY start;";
            string q = $"SELECT title as 'Title', start as 'Start Time', end as 'End Time', location as 'Location', contact as 'Contact', type as 'Type' FROM appointment where customerId = '{id}' ORDER BY start;";
            
            MySqlCommand cmd = new MySqlCommand(q, con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            
            foreach (DataRow row in dt.Rows)
            {
                DateTime universalStart = Convert.ToDateTime(row["Start Time"]);
                DateTime universalEnd = Convert.ToDateTime(row["End Time"]);
                
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(universalStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(universalEnd);
            }
            con.Close();
            return dt;
        }

        //makes a report of the availible appointment types that are availible 
        public static Dictionary<string, object> appTypeCount()
        {
            Dictionary<string, object> reportType = new Dictionary<string, object>();
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            
            var query = "SELECT DISTINCT " +
                $" (select count(type) from appointment where type = 'Haircut') as 'Haircut'," +
                $" (select count(type) from appointment where type = 'Color') as 'Color'," +
                $" (select count(type) from appointment where type = 'Perm') as 'Perm'," +
                $" (select count(type) from appointment where type = 'Manicure') as 'Manicure'," +
                $" (select count(type) from appointment where type = 'Pedicure') as 'Pedicure'," +
                $" (select count(type) from appointment where type = 'Other') as 'Other'" +
                $" from appointment";
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader r = cmd.ExecuteReader();
            
            if (r.HasRows)
            {
                r.Read();
                reportType.Add("haircut", r[0]);
                reportType.Add("color", r[1]);
                reportType.Add("perm", r[2]);
                reportType.Add("manicure", r[3]);
                reportType.Add("pedicure", r[4]);
                reportType.Add("other", r[5]);
            }
            return reportType;

        }
    }
}
