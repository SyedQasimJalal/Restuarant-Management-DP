using Restaurant_Management_System_DP.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Factory_Method
{
    internal class ConcreteRegularCustomer : ICustomerRegistration
    {
        private SqlConnection connection= DatabaseConnectionSingleton.GetInstance().Connection;
        private SqlCommand command;
        public bool RegisterCustomer(string name, string email, string password)
        {
            //connection.Open();

            command= new SqlCommand("insert into customer(name, email, password, is_premium) values('"+name+"','"+email+"','"+password+"',1)", connection);
            int result = command.ExecuteNonQuery();

            if(result == 0)
            {
                return false;
            }
            return true;
        }
    }
}
