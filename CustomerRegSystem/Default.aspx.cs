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

    protected void Button4_Click(object sender, EventArgs e)
    {
        SqlCommand comm = new SqlCommand("Select * from tb_customer where CustomerIC = '" + int.Parse(TextBox1.Text) + "'", con);
        SqlDataAdapter sd = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        sd.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        LoadRecord();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("Select * from tb_customer where CustomerIC = '" + int.Parse(TextBox1.Text) + "'", con);
        SqlDataReader reader = comm.ExecuteReader();
        while (reader.Read())
        {
            TextBox2.Text = reader.GetString(1);
            DropDownList1.SelectedValue = reader.GetValue(2).ToString();
            TextBox6.Text = reader.GetInt32(3).ToString(); 
            TextBox5.Text = reader.GetString(4);
            TextBox7.Text = reader.GetString(5);
        }
    }
}