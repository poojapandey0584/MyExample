using System;
using System.Data;

namespace Model.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Customer() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        public Customer(IDataReader reader)
        {
            this.Id = reader["ID"].ToString();
            this.FName = reader["FName"].ToString();
            this.LName = reader["LName"].ToString();
            this.Address = reader["Address"].ToString();
            this.Email = reader["Email"].ToString();
            this.Telephone = reader["Telephone"].ToString();
            
        }
    }
}
