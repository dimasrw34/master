using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestDB
{
    class Program
    {
        //строку вынести в файл настройки и зашифровать
        static string connectionString = @"Data Source=DEVCOMP;Initial Catalog=DEVBASE;Integrated Security=True;Pooling=True";

        static void Main(string[] args)
        {
            //Console.Write("Введите имя пользователя:");
            //string name = Console.ReadLine();

            //Console.Write("Введите возраст пользователя:");
            //int age = Int32.Parse(Console.ReadLine());

            //AddUser(name, age);
            //Console.WriteLine();
            GetUnits();

            Console.Read();
        }
        // добавление пользователя
        private static void AddUser(string name, int age)
        {
            // название процедуры
            string sqlExpression = "sp_InsertUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                // параметр для ввода возраста
                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = age
                };
                command.Parameters.Add(ageParam);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                //var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        // вывод всех пользователей
        private static void GetUnits()
        {
            // название процедуры
            string sqlExpression = "GetUnits";

            // создаем дата сет и адаптер
            DataSet ds = new DataSet();
            SqlDataAdapter sda;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
            
                sda = new SqlDataAdapter(command);
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count>0)
                    {
                    Console.WriteLine("{0}\t{1}\t{2}", 
                                        ds.Tables[0].Columns[0].Caption, 
                                        ds.Tables[0].Columns[1].Caption, 
                                        ds.Tables[0].Columns[2].Caption);

                        
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            //здесь будет заполнение данными бизнес-объекта
                            int id = (int)(dr.ItemArray[0]);
                            string name = (string)(dr.ItemArray[1]);
                            string sname = (string)(dr.ItemArray[2]);
                            Console.WriteLine("{0} \t{1} \t{2}", id, name, sname);
                        }
                    
                }

                Console.WriteLine(connectionString);


            }
        }
    }
}
