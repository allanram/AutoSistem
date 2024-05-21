using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext
{
    public abstract class DataBase
    {
        public DataBase() 
        {
            string Conexao = @".\SQLEXPRESS; Initial Catalog = AutomovelFrabric; Persist Security Info = True; User ID = sa; Password = sql2022";
        }
    }
}
