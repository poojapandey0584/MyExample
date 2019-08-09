using Model.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try {

                Customer cust = new Model.Model.Customer();
                cust.FName = txtFName.Text;
                cust.LName = txtLName.Text;
                cust.Address = txtAddress.Text;
                cust.Email = txtEmail.Text;
                cust.Telephone = txttelephone.Text;
                SaveCustomer(cust);

            } catch(Exception ex)
            {
            }
        }

        void SaveCustomer(Customer Cust)
        {
            try
            {

                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44333/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(Cust), Encoding.UTF8);
                    var response = client.PostAsync("api/customer", httpContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = response.Content.ReadAsStringAsync().Result;
                        txtFName.Text="";
                        txtLName.Text = "";
                        txtAddress.Text = "";
                        txtEmail.Text = "";
                        txttelephone.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}