// Генератор поставщиков данных 
using System;
using System.Configuration;
using System.Data.Common;
using System.Text;
using System.IO;

namespace ReadAndWriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {      // Getting lines of connection and provider from App.config
            string dp = ConfigurationManager.AppSettings["provider"];
            string cnStr = ConfigurationManager.AppSettings["conStr"];

            // Getting provider generator "df"
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            // Getting object "connection" (through "df")
            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("Connection object: " + cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                // Creating "command" object (through "df")
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Command Object: " + cmd.GetType().Name);
                cmd.Connection = cn;

                // cmd.CommandText = strSQL + "TableName";
                string strSQL = "Select * From "; // pattern for OUTPUT THE TABLE

                /*// Output autopark by "Data Reader" object "dr"
                cmd.CommandText = strSQL + "Cars";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Data Reading Object: " + dr.GetType().Name);
                    Console.WriteLine("\n Autopark: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID car - {0} \n | Type Car - {1} \n | License Number - {2} \n | Amount of passengers - {3} \n",
                            dr[0], dr[1], dr[2], dr[3]);
                }

                // Output list of drivers
                cmd.CommandText = strSQL + "Drivers";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Drivers: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID driver - {0} \n | Name - {1} \n | Rights - {2} \n | Works/Rests - {3} \n",
                            dr[0], dr[1], dr[2], dr[3]);
                }

                // Output routes (driver-car)
                cmd.CommandText = strSQL + "Routes";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Routes: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID routes - {0} \n | Route Number - {1} \n | ID car - {2} \n | ID driver - {3} \n",
                            dr[0], dr[1], dr[2], dr[3]);
                }
                // Output table "Pay"
                cmd.CommandText = strSQL + "Pay";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Payments: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID payment - {0} \n | Date - {1} \n | Category - {2} \n | NamePay - {3} \n | Amount - {4} \n | Cost - {5} \n | Sum - {6} \n",
                            dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                }
                // Output table "Users" (Name "User" is a reserved keyword, which can't be used for name the table.)
                cmd.CommandText = strSQL + "Users";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Users: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID user - {0} \n | Full name - {1} \n | Login - {2} \n | Password - {3} \n | Pin-code - {4} \n",
                            dr[0], dr[1], dr[2], dr[3], dr[4]);
                }*/

                Console.WriteLine("\n Driver-Car: ");
                string task_str = "SELECT Drivers.Name, Cars.Typecar " + 
                    "FROM Routes JOIN Cars on Cars.IDcar = Routes.IDcar " + 
                    "JOIN Drivers on Drivers.IDdr = Routes.IDdr " + 
                    "WHERE Routes.IDrout in (1,2,3)";
                cmd.CommandText = task_str;
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"Driver {dr[0]} on {dr[1]}");
                    }
                }

                // Commands Insert, Delete   
                /*try
                {*/
                    Console.WriteLine("\n Inserting new 5 users and new 5 payments: ");
                    string task_Delete = "Delete from Users where ID <= 5;" + "Delete from Pay where ID >= 60;";
                    string task_Insert = "Insert into Users values (1, [Petrov Alexander Alexeev], 'alex928', 'kYs12on08', 6823);" +
                                                                      "(2, [Hawken Moisey Petrovich], '28moisey_onme', 'take_on_me1', 1998);" +
                                                                      "(3, [Darkness Norman Maximovich], 'NormDark', 'DarknessIncreases', 2077);" +
                                                                      "(4, [Lightning Mireska Leonovna], 'Light_Mireska', 'Mireska7645', 7645);" + 
                                                                      "(5, [Darth Rose Konstantinovna], 'MissDarth', 'Your1Mistress', 1092);";
                    cmd.CommandText = task_Delete + task_Insert + (strSQL + "Users");
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("-> ID user - {0} \n | Full name - {1} \n | Login - {2} \n | Password - {3} \n | Pin-code - {4} \n",
                                                  dr[0], dr[1], dr[2], dr[3], dr[4]);
                        }
                    }
                    task_Insert = "Insert into Pay values" + "'60', '01.11.2016', 'Electronics', 'IPhone 10 pro', '1', '90000', '90000';" +
                                                             "'61', '03.11.2016', 'Electronics', 'TV SONY KDL-32WD603', '1', '20590', '20590';" +
                                                             "'62', '05.11.2016', 'Electronics', 'Video Player', '2', '1250', '2500';" +
                                                             "'63', '07.11.2016', 'Electronics', 'Music system', '1', '12000', '12000';" +
                                                             "'64', '09.11.2016', 'Electronics', 'Fax', '3', '5000', '15000';";
                    cmd.CommandText = task_Insert + (strSQL + "Pay");
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("-> ID payment - {0} \n | Date - {1} \n | Category - {2} \n | NamePay - {3} \n | Amount - {4} \n | Cost - {5} \n | Sum - {6} \n",
                                                        dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                        }
                    }

                /*}
                catch
                {
                    Console.WriteLine("Trying to write new note about driver with already defined ID!");
                }*/

                // Command Update 
                Console.WriteLine("\n Updating/changing number of route: ");
                string task_Update = "Update Routes set Number = '7' where IDrout = '2';";
                cmd.CommandText = task_Update + strSQL + "Routes";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("-> ID routes - {0} \n | Route Number - {1} \n | ID car - {2} \n | ID driver - {3} \n",
                        dr[0], dr[1], dr[2], dr[3]);
                    }
                }
                cn.Close(); // close connection 

                StreamReader sr; // stream for reading
                StreamWriter sw; // stream for writing
                const int NmaxZap = 10; // max amount of notes
                try
                {        // Reading from File
                         // Linking with File, encoding symbols Unicode
                    sr = new StreamReader("info.txt",UTF8Encoding.Default);
                    string [] d = new string[NmaxZap];

                string t = sr.ReadLine(); // reading first (zero) line/string
                    int i = 0; // count lines/string
                    while ((t!=null)&&(i<d.Length)) // Reading from file  no more, than NmaxZap
                    {
                        Console.WriteLine(t); // Output on screen (for control)
                        d[i++]= t; // to array
                        t = sr.ReadLine(); // reading other lines/string
                    }
                    sr.Close(); // closing a file "info.txt" for reading
                d[i] = "седьмая строка"; // adding a line
                                         // writing in file:
                    FileInfo fi = new FileInfo("result.txt"); // information about file
                    if (fi.Exists)
                        sw = fi.AppendText(); // to open a stream for adding 
                    else
                        sw = fi.CreateText(); // or stream for writing 
                    for (int j = 0; j <= i; j++)
                        sw.WriteLine(d[j].ToString()); // writing lines/string to file
                    sw.Close();
                }
                catch (Exception ex) // exception processing (example, if not exists а file "info.txt")
                {
                    Console.WriteLine("A file for reading not exist!"+ ex);
                }
                Console.ReadKey();

            }
        }
    }
}