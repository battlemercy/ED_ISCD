// Генератор поставщиков данных
using System;
using System.Configuration;
using System.Data.Common;
using System.Text;
using System.IO;

namespace команды_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получение строки подключения и поставщика из App.config  //
            string dp = ConfigurationManager.AppSettings["provider"];   // подключение
            string cnStr = ConfigurationManager.AppSettings["conStr"];  // к
                                                                        // Базе Данных
            // Получение генератора поставщика df                       //
            DbProviderFactory df = DbProviderFactories.GetFactory(dp);  //

            // Получение объекта "подключение" (через df)
            using (DbConnection cn = df.CreateConnection())
            {
                Console.WriteLine("Объект подключения: " + cn.GetType().Name);
                cn.ConnectionString = cnStr;
                cn.Open();

                // Создание объекта "команда" (через df)
                DbCommand cmd = df.CreateCommand();
                Console.WriteLine("Объект команды: " + cmd.GetType().Name);
                cmd.Connection = cn;

                // вводим все исходные данные через SELECT
                string strSQL = "Select * From ";
                // cmd.CommandText = strSQL + "TableName";

                // Вывод парка машин с помощью объекта "чтение данных" dr
                cmd.CommandText = strSQL + "Cars";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("Объект чтения данных: " + dr.GetType().Name);
                    Console.WriteLine("\n Автопарк");
                    while (dr.Read())
                        Console.WriteLine("-> ID авто-{0} | ТипАвто-{1} | госномер-{2} | число пассажиров-{3}", dr[0], dr[1], dr[2], dr[3]);
                }

                // Вывод списка водителей
                cmd.CommandText = strSQL + "Drivers";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Водители");
                    while (dr.Read())
                        Console.WriteLine("-> ID водителя-{0} | Фамилия_имя-{1} | права-{2} | работа/выходной-{3}", dr[0], dr[1], dr[2], dr[3]);
                }

                // Вывод маршрутов (водитель-авто)
                cmd.CommandText = strSQL + "Routes";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Маршруты");
                    while (dr.Read())
                        Console.WriteLine("-> ID маршрута-{0} | Номер маршрута-{1} | ID авто-{2} | ID водителя-{3}", dr[0], dr[1], dr[2], dr[3]);
                }

                // Вывод список платежей
                cmd.CommandText = strSQL + "Payments";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Платежи:");
                    while (dr.Read())
                        Console.WriteLine("-> ID платежа-{0} | Дата-{1} | Категория-{2} | Наименование платежа-{3} | Количество-{4} | Цена-{5} | Стоимость-{6}", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                }

                // Вывод список пользователей
                cmd.CommandText = strSQL + "Users";
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n Пользователи:");
                    while (dr.Read())
                        Console.WriteLine("-> ID пользователя-{0} | ФИО-{1} | Логин-{2} | Пароль-{3} | Пин-код-{4}", dr[0], dr[1], dr[2], dr[3], dr[4]);
                }

                // Найти в БД водителей и авто, закрепленные за конкретными маршрутами
                Console.WriteLine("\n Водитель-автомобиль");
                string task_str = "SELECT Drivers.Name, Cars.Typecar " + "FROM Routes JOIN Cars on Cars.IDcar = Routes.IDcar " + "JOIN Drivers on Drivers.IDdr = Routes.IDdr " + "WHERE Routes.IDrout in (1,2,3)";
                cmd.CommandText = task_str;
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"Водитель {dr[0]} на {dr[1]}");
                    }
                }

                // Команды Insert, Delete
                try
                {
                    string nm = "5";
                    Console.WriteLine("\n Удаление записи о водителе с заданным ID, вставка новой записи о водителе");
                    string task_Delete = "Delete from Drivers where IDdr = " + nm + ";";
                    string task_Insert = "Insert into Drivers values (" + nm + ", N'Петров Александр', 'D', 'false');";
                    string task_GetDataD = "Select * from Drivers;";
                    cmd.CommandText = task_Delete + task_Insert + task_GetDataD;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("-> {0} | {1} | {2} | {3}", dr[0], dr[1], dr[2], dr[3]);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Попытка вставки новой записи о водителе с уже заданным ID");
                }

                // Команда Update
                Console.WriteLine("\n  Изменение номера маршрута");
                string task_Update = "Update Routes set Number = '7' where IDrout = 2;";
                string task_GetDataR = "Select * from Routes;";
                cmd.CommandText = task_Update + task_GetDataR;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("-> {0} | {1} | {2} | {3}", dr[0], dr[1], dr[2], dr[3]);
                    }
                }

                // Задача: вывести список пользователей и сделанные ими платежи.
                Console.WriteLine("\n Список пользователей и их платежи: ");
                string task_userspay = "SELECT Payments.Date, Users.FIO, Payments.PaymentName, Payments.Amount, Payments.Price " + "FROM Payments JOIN Users on Payments.IDpay = Users.ID ";
                cmd.CommandText = task_userspay;
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine($"\n{dr[0]} пользователь {dr[1]} совершил платёж {dr[2]} в количестве {dr[3]} на сумму {dr[4]} рублей;");
                    }
                }

                // Задание: добавить программно(кодом) 5 новых пользователей и 5 новых платежей.
                /*try
                {*/
                    Console.WriteLine("\n Добавляем новых пользователей: ");
                    string task_DeleteUsers = "Delete from Users where ID <= 5;";
                    string task_InsertUsers = "Insert into Users values ('1', N'Чесноков Максим Василиевич', 'MAX321', '1337ABC', '1337');" +
                    "Insert into Users values ('2', N'Логинов Эльбрус Елизарович', 'EL228', 'ZYX1488', '1488');" +
                    "Insert into Users values ('3', N'Савин Тамерлан Русланович', '123TAM789', '6JO9KE0', '0188');" +
                    "Insert into Users values ('4', N'Ермолов Вячеслав Марселевич', 'VyaChik', 'FOOT32BOOL2', '9325');" +
                    "Insert into Users values ('5', N'Федосов Родион Никитич', 'MamaRODI', '1337ONARODILA228', '2481');";
                    string task_GettingDataUsers = "Select * From Users";
                    cmd.CommandText = task_DeleteUsers + task_InsertUsers + task_GettingDataUsers;
                    using (var dr = cmd.ExecuteReader())
                    { 
                    while (dr.Read())
                        {
                            Console.WriteLine("-> ID пользователя-{0} | ФИО-{1} | Логин-{2} | Пароль-{3} | Пин код-{4}", dr[0], dr[1], dr[2], dr[3], dr[4]);
                        }
                    }

                    Console.WriteLine("\n Добавляем новые платежи: ");
                    string task_DeletePayments = "Delete from Users where IDpay >= 65;";
                    string task_InsertPayments = "Insert into Payments values (65, '23.11.2016', N'Электроника', N'Колонка Алиса', '1', '5000', '5000');" +
                    "Insert into Payments values (66, '04.11.2016', N'Электроника', N'Часы', '1', '3000', '3000');" +
                    "Insert into Payments values (67, '08.11.2016', N'Электроника', 'IPhone 11 PRO', '1', '90000', '90000');" +
                    "Insert into Payments values (68, '15.11.2016', N'Электроника', N'Наушники', '1', '15000', '15000');" +
                    "Insert into Payments values (69, '10.11.2016', N'Электроника', N'Игровая приставка Sega Mega Drive', '2', '2000', '4000');";
                    string task_GettingDataPayments = "Select * From Payments";
                    cmd.CommandText = task_DeletePayments + task_InsertPayments + task_GettingDataPayments;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine("-> ID платежа-{0} | Дата платежа-{1} | Категория платежа-{2} | Наименование платежа-{3} | Количество-{4} | Стоимость-{5} | Сумма-{6}", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
                        }
                    }
                    /*
                } */
                /*catch
                {
                    Console.WriteLine("Попытка вставки новой записи о пользователе или платеже с уже заданным ID");
                }*/


                cn.Close(); // закрыть соединение

                StreamReader sr; // поток для чтения
                StreamWriter sw; // поток для записи
                const int NmaxZap = 10; // макс.число записей

                try
                {
                    // Чтение из файла
                    // связывание с файлом, кодировка символов Юникода
                    sr = new StreamReader("info.txt",UTF8Encoding.Default);
                    string [] d = new string[NmaxZap];
                    string t = sr.ReadLine(); // чтение первой (0-й) строки
                    int i = 0; // счетчик строк
                    while ((t!=null)&&(i<d.Length)) // Чтение из файла не более чем NmaxZap
                    {
                        Console.WriteLine(t); // на экран (для контроля)
                        d[i++]= t; // в массив
                        t = sr.ReadLine(); // чтение остальных строк
                    }
                    sr.Close(); // закрытие файла "info.txt" для чтения

                d[i] = "седьмая строка"; // добавим строку
                                         // Запись в файл:
                FileInfo fi = new FileInfo("result.txt"); // информация о файле
                    if (fi.Exists)
                        sw = fi.AppendText(); // открыть поток для добавления
                    else
                        sw = fi.CreateText(); // или поток для записи
                    for (int j = 0; j <= i; j++)
                        sw.WriteLine(d[j].ToString()); // запись строк в файл
                    sw.Close();
                }
                catch (Exception ex) // обработка исключений (например, если нет файла "info.txt")
                {
                    Console.WriteLine("Нет файла для чтения!"+ ex);
                }

                Console.ReadKey();
            }
        }
    }
}
