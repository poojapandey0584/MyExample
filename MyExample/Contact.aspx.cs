using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyExample
{
    public partial class Contact : Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            try {

                Customer[] customers = new Customer[];
                GetCustomers();
            } catch(Exception ex)
            {

            }
        }

        void GetCustomers()
        {
            try {

                using (var client = new HttpClient())
                {
                    //client.BaseAddress = new Uri("https://localhost:44333/");
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    ////GET Method  
                    //var response = await client.GetAsync("api/customer");
                    //if (response.IsSuccessStatusCode)
                    //{
                       
                    //    var cust = await response.Content.ReadAsAsync<Customer>();
                    //    //Console.WriteLine("Id:{0}\tName:{1}", department.DepartmentId, department.DepartmentName);
                    //    //Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Internal server Error");
                    //}
                    var responseTask = client.GetAsync("https://localhost:44333/");
                    responseTask.Wait();

                    HttpResponseMessage result = responseTask.Result;

                    var response =  client.GetAsync("api/customer");
                    var resultString = await result.Content.ReadAsStringAsync()
                    if (response.IsSuccessStatusCode)
                    {
                        var cust = await response.Content.ReadAsAsync<Department>();
                        Console.WriteLine("Id:{0}\tName:{1}", department.DepartmentId, department.DepartmentName);
                        Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }
                }

            } catch(Exception ex)
            {

            }
        }
    }
}