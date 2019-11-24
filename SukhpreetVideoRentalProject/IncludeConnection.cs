using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace SukhpreetVideoRentalProject
{
    public class IncludeConnection
    {
        //Conn Instance Object of SQl Connection Class   
        SqlConnection includeconn;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=LAPTOP-NI9FNBTG\\SQLEXPRESS02;Initial Catalog=SukhpreetVideo;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand includecmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader includeDReader;

        /* method to add delete or update the database table ,here we have use the concept of the oops like calling the method
         * of another class in the main method 
        */
        public void add(String includeQuery) {
            includeconn = new SqlConnection(conStr);
            includeconn.Open();
            includecmd = new SqlCommand(includeQuery, includeconn);
            includecmd.ExecuteNonQuery();
            includeconn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public int CountEntries(String qry)
        {
            DataTable tbl = new DataTable();


            includeconn = new SqlConnection(conStr);

            includeconn.Open();
            includecmd = new SqlCommand(qry, includeconn);

            includeDReader = includecmd.ExecuteReader();

            tbl.Load(includeDReader);

            includeconn.Close();

            return tbl.Rows.Count-1;
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable DataEntries(String qry)
        {
            DataTable tbl = new DataTable();


            includeconn = new SqlConnection(conStr);

            includeconn.Open();
            includecmd = new SqlCommand(qry, includeconn);

            includeDReader = includecmd.ExecuteReader();

            tbl.Load(includeDReader);

            includeconn.Close();

            return tbl;
        }


        // reset the filed of the customer for better performance 
        public String resetCustomer()
        {
            return "";
        }
    }
}
