using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model

{
    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static SqlParameter[] ToParameterArray(this Customer customer)
        {
            return new SqlParameter[] { new SqlParameter("@ID", customer.Id)
                                                , new SqlParameter("@FName", customer.FName)
                                                , new SqlParameter("@LName", customer.LName)
                                                , new SqlParameter("@Address", customer.Address)
                                                , new SqlParameter("@Email", customer.Email)
                                                , new SqlParameter("@Telephone", customer.Telephone)
                                                };
        }

    }

}
