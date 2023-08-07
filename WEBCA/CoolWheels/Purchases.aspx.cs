using System;
using System.Data;
using System.Data.SqlClient;

namespace CoolWheels
{
    public partial class Purchases : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\webdev.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPurchases();
            }
        }

        private void LoadPurchases()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Purchases", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    purchasesGridView.DataSource = dt;
                    purchasesGridView.DataBind();
                }
            }
            catch (Exception ex)
            {
               Response.Write("<script>alert('Purchases failed to load');</script>");
            }
        }
    }
}
