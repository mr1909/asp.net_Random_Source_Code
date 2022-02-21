using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_elements.Sample
{
    public partial class DropDownList : System.Web.UI.Page
    {



        /// Create sql table:

        //Create table tblCity
        //(
        // CityId int primary key,
        // CityName nvarchar(50),
        // Country nvarchar(50)
        //)

        //Insert into tblCity values(101, 'Delhi', 'India')
        //Insert into tblCity values(102, 'London', 'UK')
        //Insert into tblCity values(103, 'New York', 'US')
        //Insert into tblCity values(104, 'Tokyo', 'Japan')



        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ListItem maleListItem = new ListItem("item3", "3");
                ListItem femaleListItem = new ListItem("item4", "4");

                DropDownList1.Items.Add(maleListItem);
                DropDownList1.Items.Add(femaleListItem);
            }


            if (!IsPostBack)
            {
                string CS = ConfigurationManager.ConnectionStrings["db1"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("Select CityId, CityName, Country from tblCity", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    DropDownList2.DataTextField = "CityName";
                    DropDownList2.DataValueField = "CityId";
                    DropDownList2.DataSource = rdr;
                    DropDownList2.DataBind();
                }
            }



            if (!IsPostBack)
            {
                //Create a new DataSet
                DataSet DS = new DataSet();
                //Read the xml data from the XML file using ReadXml() method
                DS.ReadXml(Server.MapPath("~/Assets/XML/dropdownlist.xml"));
                DropDownList3.DataTextField = "CountryName";
                DropDownList3.DataValueField = "CountryId";
                DropDownList3.DataSource = DS;
                DropDownList3.DataBind();
                ListItem li = new ListItem("Select", "-1");
                DropDownList3.Items.Insert(0, li);
            }

            /////////////////////////////////////////////////


            if (!IsPostBack)
            {
                PopulateContinentsDropDownList();
            }


        }

        private void PopulateContinentsDropDownList()
        {
            ddlContinents.DataSource = GetData("spGetContinents", null);
            ddlContinents.DataBind();

            ListItem liContinent = new ListItem("Select Continent", "-1");
            ddlContinents.Items.Insert(0, liContinent);

            ListItem liCountry = new ListItem("Select Country", "-1");
            ddlCountries.Items.Insert(0, liCountry);

            ListItem liCity = new ListItem("Select City", "-1");
            ddlCities.Items.Insert(0, liCity);

            ddlCountries.Enabled = false;
            ddlCities.Enabled = false;
        }

        private DataSet GetData(string SPName, SqlParameter SPParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (SPParameter != null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);
            }
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;
        }

        protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinents.SelectedValue == "-1")
            {
                ddlCities.SelectedIndex = 0;
                ddlCountries.SelectedIndex = 0;
                ddlCities.Enabled = false;
                ddlCountries.Enabled = false;
            }
            else
            {
                ddlCountries.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ContinentId";
                parameter.Value = ddlContinents.SelectedValue;

                ddlCountries.DataSource = GetData("spGetCountriesByContinentId", parameter);
                ddlCountries.DataBind();

                ListItem liCountry = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, liCountry);

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedValue == "-1")
            {
                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
            else
            {
                ddlCities.Enabled = true;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CountryId";
                parameter.Value = ddlCountries.SelectedValue;

                ddlCities.DataSource = GetData("spGetCitiesByCountryId", parameter);
                ddlCities.DataBind();

                ListItem liCity = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, liCity);
            }
        }
















    }
}


