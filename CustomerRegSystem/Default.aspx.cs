using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

      LoadRecord();
        
    }
    
    SqlConnection con = new SqlConnection("Data Source=CUSTOM-MSI-3300\\SQLEXPRESS;Initial Catalog=db_crs;Integrated Security=True");

    protected void Button1_Click(object sender, EventArgs e)
    {

        con.Open();
        SqlCommand comm = new SqlCommand("Insert into tb_customer values('" + int.Parse(TextBox1.Text) + "','" + TextBox2.Text + "','" + DropDownList1.SelectedValue + "','" + double.Parse(TextBox6.Text) + "','" + double.Parse(TextBox5.Text) + "','" + TextBox7.Text + "')", con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
        
    }
    void LoadRecord()
    {
        SqlCommand comm = new SqlCommand("select * from tb_customer", con);
        SqlDataAdapter sda = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("Update tb_customer set CustomerName = '" + TextBox2.Text + "' , State = '" + DropDownList1.SelectedValue + "' , Age = '" + double.Parse(TextBox6.Text) + "' , Contact = '" + double.Parse(TextBox5.Text) + "' , Password = '" + TextBox7.Text + "' where CustomerIC = '" + int.Parse(TextBox1.Text) + "'" , con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("Delete tb_customer where CustomerIC = '" + int.Parse(TextBox1.Text) + "'", con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
    }
}