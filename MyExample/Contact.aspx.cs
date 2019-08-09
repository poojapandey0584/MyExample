using Model.Model;
using Newtonsoft.Json;
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

                
                GetCustomers();
            } catch(Exception ex)
            {

            }
        }

        void GetCustomers()
        {
            try {

                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44333/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                   
                    var response = client.GetAsync("api/customer").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = response.Content.ReadAsStringAsync().Result;
                        List<Customer> cust = JsonConvert.DeserializeObject<List<Customer>>(responseString);
                        GridView1.DataSource = cust;
                        GridView1.DataBind();
                    }
                }

              

            } catch(Exception ex)
            {

            }
        }
    }
}