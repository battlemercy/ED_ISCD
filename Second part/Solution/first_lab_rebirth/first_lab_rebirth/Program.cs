// Генератор поставщиков данных 
using System;
using System.Configuration;
using System.Data.Common;

namespace DataProvidersGenerator
{
    class Program
    {
        static void Main(string[] args)
        {      // Получение строки подключения и поставщика из App.config
            string dp = ConfigurationManager.AppSettings["provider"];
            string cnStr = ConfigurationManager.AppSettings["conStr"];

            // Получение генератора поставщика df
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);

            // Получение объекта "подключение" (через df)
            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("Connection object: " + cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                // Создание объекта "команда" (через df)
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Command Object: " + cmd.GetType().Name);
                cmd.Connection = cn;

                // cmd.CommandText = strSQL + "TableName";
                string strSQL = "Select * From "; // шаблон для ЧТЕНИЯ ТАБЛИЦЫ

                // Вывод парка машин с помощью объекта "чтение данных" dr
                cmd.CommandText = strSQL + "Cars";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Data Reading Object: " + dr.GetType().Name);
                    Console.WriteLine("\n Autopark: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID car - {0} \n | Type Car - {1} \n | License Number - {2} \n | Amount of passengers - {3} \n", 
                            dr[0], dr[1], dr[2], dr[3]);
                }

                // Вывод списка водителей
                cmd.CommandText = strSQL + "Drivers";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Drivers: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID driver - {0} \n | Name - {1} \n | Rights - {2} \n | Works/Rests - {3} \n", 
                            dr[0], dr[1], dr[2], dr[3]);
                }

                // Вывод маршрутов (водитель-авто)
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
                // Output table "Users" (Name "User" is a reserved keyword, which can not used for name the table.)
                cmd.CommandText = strSQL + "Users";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Users: ");
                    while (dr.Read())
                        Console.WriteLine("-> ID user - {0} \n | Full name - {1} \n | Login - {2} \n | Password - {3} \n | Pin-code - {4} \n", 
                            dr[0], dr[1], dr[2], dr[3], dr[4]);
                }
                Console.ReadKey();

            }
        }
    }
}