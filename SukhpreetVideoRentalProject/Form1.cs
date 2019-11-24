using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SukhpreetVideoRentalProject
{
    public partial class Form1 : Form 
    {
        String command = "";
        int customer = 0,rental=0,Movie=0;
        IncludeConnection include = new IncludeConnection();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CName_Leave(object sender, EventArgs e)
        {
            if (CName.Text.ToString().Equals(""))
            {
                Err.SetError(CName, "Can't Leave Blank");
            }
            else {
                Err.Clear();    
            }
        }

        private void CMobile_Leave(object sender, EventArgs e)
        {
            if (CMobile.Text.ToString().Equals(""))
            {
                Err.SetError(CMobile, "Can't Leave Blank");
            }
            else
            {
                Err.Clear();
            }
        }

        private void CAddress_Leave(object sender, EventArgs e)
        {
            if (CAddress.Text.ToString().Equals(""))
            {
                Err.SetError(CAddress, "Can't Leave Blank");
            }
            else
            {
                Err.Clear();
            }
        }

        private void CAdd_Click(object sender, EventArgs e)
        {
            if (CName.Text.ToString().Equals("") && CMobile.Text.ToString().Equals("") && CAddress.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all the Details of the Customer");
            }
            else {
                //command to add the record in the database for register the customer details in the database 
                command = "insert into CustomerRecord values('"+CName.Text.ToString()+"','"+CMobile.Text.ToString()+"','"+CAddress.Text.ToString()+"')";
                // calling the method of the another class to perform the command 
                include.add(command);
                MessageBox.Show("Customer Record is saved in the data base table ");
                //resett the field of the customer 
                CName.Text = include.resetCustomer(); CMobile.Text = include.resetCustomer(); CAddress.Text = include.resetCustomer();
                reset();
            }
        }

        private void RIssue_Click(object sender, EventArgs e)
        {
            if (CustomerPK.Text.ToString().Equals("") && MoviePK.Text.ToString().Equals(""))
            {
                MessageBox.Show("select the movie and register customer ");
            }
            else {
                //count the movie on the rental which is booked on the movie if the customer have 2 movie then he can't anymore 
                command = "select * from RentalRecord where Customer_FK='"+CustomerPK.Text.ToString()+"' and ReturnDate='booked'";
                int booking = include.CountEntries(command);
                if (booking == 2)
                {
                    MessageBox.Show("Sorry You already have 2 Movie on rent so can't take any more ");
                }
                else {
                    // count the copies of the movie 
                    command = "select * from MovieRecord where PK_Movie_Id='" + MoviePK.Text.ToString() + "'";
                    DataTable tbl = new DataTable();
                    tbl = include.DataEntries(command);
                    //get the copies of the movie from the data Entries
                    int countMovie =Convert.ToInt32(tbl.Rows[tbl.Rows.Count-1]["VCopies"].ToString());

                    //get the value how much  movie  is already is send on rent 
                    command = "select * from RentalRecord where Movie_FK='"+MoviePK.Text.ToString()+"' and ReturnDate='booked'";
                    int bookedCount = include.CountEntries(command);

                    //compare the value of no of copies to the booked movie
                    if (bookedCount < countMovie)
                    {
                        // if the condition is true then store the record in the data base table 
                        command = "insert into RentalRecord values ('" + CustomerPK.Text.ToString() + "','" + MoviePK.Text.ToString() + "','" + IssueVideoDT.Text.ToString() + "','booked')";
                        include.add(command);
                        MessageBox.Show("Movie is issued on rent ");
                        CustomerPK.Text = include.resetCustomer(); MoviePK.Text = include.resetCustomer();
                        reset();

                    }
                    else {

                        // if the condition is false then the error message will display 
                        MessageBox.Show("All  the Caste of the Movie is send on the rent ");
                    }



                }




            }

        }

        private void CustomerPK_Leave(object sender, EventArgs e)
        {
            if (CustomerPK.Text.ToString().Equals(""))
            {
                Err.SetError(CustomerPK, "fetch the id of the Customer ");
            }
            else {
                Err.Clear();
            }
        }

        private void MoviePK_Leave(object sender, EventArgs e)
        {
            if (MoviePK.Text.ToString().Equals(""))
            {
                Err.SetError(MoviePK, "fetch the id of the Movie ");
            }
            else
            {
                Err.Clear();
            }
        }

        private void Vtitle_Leave(object sender, EventArgs e)
        {
            if (Vtitle.Text.ToString().Equals(""))
            {
                Err.SetError(Vtitle, "Fill the title of the movie ");
            }
            else
            {
                Err.Clear();
            }

        }

        private void VRatting_Leave(object sender, EventArgs e)
        {
            if (VRatting.Text.ToString().Equals(""))
            {
                Err.SetError(VRatting, "Fill the Ratting  of the movie ");
            }
            else
            {
                Err.Clear();
            }
        }

        private void VYear_Leave(object sender, EventArgs e)
        {
            if (VYear.Text.ToString().Equals(""))
            {
                Err.SetError(VYear, "Fill the Year  of the movie ");
            }
            else
            {
                Err.Clear();

                try
                {

                    //dislay the cost of the price of the video after adding the year of the video
                    DateTime dateNow = DateTime.Now;

                    int Currentyear = dateNow.Year;

                    int diffYear = Currentyear - Convert.ToInt32(VYear.Text.ToString());
                    // MessageBox.Show(diff.ToString());
                    if (diffYear >= 5)
                    {
                        Vcost.Text = "2";
                    }
                    if (diffYear >= 0 && diffYear < 5)
                    {
                        Vcost.Text = "5";
                    }

                }
                catch (Exception ex)
                {

                }
            }

        }

        private void VCopies_Leave(object sender, EventArgs e)
        {
            if (VCopies.Text.ToString().Equals(""))
            {
                Err.SetError(VCopies, "Fill the No of copies available  in the store  ");
            }
            else
            {
                Err.Clear();
            }
        }

        private void VPlot_Leave(object sender, EventArgs e)
        {
            if (VPlot.Text.ToString().Equals(""))
            {
                Err.SetError(VPlot, "Fill the details of the movie");
            }
            else
            {
                Err.Clear();
            }
        }

        private void VGenre_Leave(object sender, EventArgs e)
        {
            if (VGenre.Text.ToString().Equals(""))
            {
                Err.SetError(VGenre, "Fill the details of the movie");
            }
            else
            {
                Err.Clear();
            }
        }

        private void VAdd_Click(object sender, EventArgs e)
        {
            if (Vtitle.Text.ToString().Equals("") && VRatting.Text.ToString().Equals("") && VYear.Text.ToString().Equals("") && VCopies.Text.ToString().Equals("") && VPlot.Text.ToString().Equals("") && VGenre.Text.ToString().Equals(""))
            {
                MessageBox.Show("FIll all the details properly ");
            }
            else {
                command = "insert into MovieRecord values('"+Vtitle.Text.ToString()+"','"+VRatting.Text.ToString()+"','"+VYear.Text.ToString()+"','"+Vcost.Text.ToString()+"','"+VCopies.Text.ToString()+"','"+VPlot.Text.ToString()+"','"+VGenre.Text.ToString()+"')";
                include.add(command);
                MessageBox.Show("Movie Details are saved in the movie table ");
                reset();
            }
        }

        private void CDelete_Click(object sender, EventArgs e)
        {
            if (CName.Text.ToString().Equals("") && CMobile.Text.ToString().Equals("") && CAddress.Text.ToString().Equals("") && CustomerPK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Customer to delete his details  ");
            }
            else {
                command = "select * from RentalRecord where Customer_FK='"+CustomerPK.Text.ToString()+"' and ReturnDate='booked'";
                MessageBox.Show("" + include.CountEntries(command));
                if (include.CountEntries(command) <= 0)
                {
                    command = "";
                    command = "delete from CustomerRecord where PK_id="+Convert.ToInt32(CustomerPK.Text.ToString())+"";
                    include.add(command);
                    MessageBox.Show("Customer Record is deleted");
                    reset();
                }
                else {
                    MessageBox.Show("you already have Movie on rent ");
                }
            }

        }

        public void reset() {
            CustomerPK.Text = "";
            MoviePK.Text = "";

            CName.Text = "";
            CMobile.Text = "";
            CAddress.Text = "";

            Vtitle.Text = "";
            VRatting.Text = "";
            VYear.Text = "";
            Vcost.Text = "0";
                VCopies.Text = "";
            VPlot.Text = "";
            VGenre.Text = "";
            RentPK.Text = "";

        }
        private void CUpdate_Click(object sender, EventArgs e)
        {
            if (CName.Text.ToString().Equals("") && CMobile.Text.ToString().Equals("") && CAddress.Text.ToString().Equals("") && CustomerPK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Customer to Update  his details  ");
            }
            else
            {
                command = "update CustomerRecord set Name='"+CName.Text.ToString()+"', Contact='"+CMobile.Text.ToString()+"',Address='"+CAddress.Text.ToString()+"' where PK_id=" + Convert.ToInt32(CustomerPK.Text.ToString()) + "";
                include.add(command);
                MessageBox.Show("Customer Record is Updated ");
                reset();
            }

            }

        private void RDelete_Click(object sender, EventArgs e)
        {
            if (RentPK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the rental movie to delete the details from the record ");
            }
            else {

                command = "select * from RentalRecord where PK_Rent_ID='" +RentPK.Text.ToString() + "' and ReturnDate='booked'";
                if (include.CountEntries(command) <= 0)
                {
                    command = "";
                    command = "delete from RentalRecord where PK_Rent_ID=" + Convert.ToInt32(RentPK.Text.ToString()) + "";
                    include.add(command);
                    MessageBox.Show("Rental Movie Record is deleted");
                    reset();
                }
                else
                {
                    MessageBox.Show("this movie is already booked so can't delete  ");
                }

            }

        }

        private void delVideo_Click(object sender, EventArgs e)
        {
            if (MoviePK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Movie to delete from the record ");
            }
            else {
                command = "select * from RentalRecord where Movie_FK='" + MoviePK.Text.ToString() + "' and ReturnDate='booked'";
                if (include.CountEntries(command) <= 0)
                {
                    command = "";
                    command = "delete from MovieRecord where PK_Movie_Id=" + Convert.ToInt32(MoviePK.Text.ToString()) + "";
                    include.add(command);
                    MessageBox.Show(" Movie Record is deleted");
                    reset();
                }
                else
                {
                    MessageBox.Show("this movie is already booked so can't delete  ");
                }

            }
        }

        private void updateVideo_Click(object sender, EventArgs e)
        {
            if (MoviePK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Movie to delete from the record ");
            }
            else
            {
                command = "update MovieRecord set VTitle='"+Vtitle.Text.ToString()+"',VRatting='"+VRatting.Text.ToString()+"',VYear='"+VYear.Text.ToString()+"',VCost='"+Vcost.Text.ToString()+"',VCopies='"+VCopies.Text.ToString()+"',VPlot='"+VPlot.Text.ToString()+"',VGenre='"+VGenre.Text.ToString()+"' where PK_Movie_Id=" + Convert.ToInt32(MoviePK.Text.ToString()) + "";
                include.add(command);
                MessageBox.Show(" Movie Record is Updated");
                reset();

            }
         }

        private void RReturn_Click(object sender, EventArgs e)
        {

            if (RentPK.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the book Movie to return ");
            }
            else {
                //get the current Date from the Computer using the date class
                int cost = 0;
                // count the cost of the table of the specific movie from the database table 
                command = "select * from MovieRecord where PK_Movie_Id='"+MoviePK.Text.ToString()+"'";
                DataTable tbl = new DataTable();
                tbl = include.DataEntries(command);

                // transfer the value to the cost 
                cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["VCost"]);



                DateTime new_date = DateTime.Now;

                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(IssueVideoDT.Text.ToString());


                //get the difference in the days fromat
                String Daysdiff = (new_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



                int Price = Convert.ToInt32(DaysInterval) * cost;

                //update  the record and display the cost of the total rental details 
                command = "update RentalRecord set Customer_FK='"+CustomerPK.Text.ToString()+"',Movie_FK='"+MoviePK.Text.ToString()+"', IssueDate='"+IssueVideoDT.Text.ToString()+"',ReturnDate='"+ReturnVideoDT.Text.ToString()+"' where PK_Rent_ID='"+Convert.ToInt32(RentPK.Text.ToString())+"'";
                include.DataEntries(command);
                CustomerPK.Text = include.resetCustomer(); MoviePK.Text = include.resetCustomer();
                RentPK.Text = "";

                MessageBox.Show("Your total Charges is $"+cost);

                reset();

            }
        }

        private void btnCustomerRecord_Click(object sender, EventArgs e)
        {
            try {
                //select the data entries from the Customer Record 
                command = "select * from CustomerRecord ";

                DataTable tbl = new DataTable();
                tbl = include.DataEntries(command);
                Record.DataSource = tbl;
                customer=1;
                rental = 0;
                Movie = 0;
                

            }
            catch (Exception ex) {
                    
            }

        }

        private void Record_DoubleClick(object sender, EventArgs e)
        {
            //get the record from the rental  table
            if (rental>=1) {
                //display the details in the text field
                MessageBox.Show("Rental Record ");
                RentPK.Text= Record.CurrentRow.Cells[0].Value.ToString();
                CustomerPK.Text = Record.CurrentRow.Cells[1].Value.ToString();
                MoviePK.Text= Record.CurrentRow.Cells[2].Value.ToString();
                IssueVideoDT.Text=Record.CurrentRow.Cells[3].Value.ToString();

                rental = 0;
            }

            // get the record from the movie table 
            if (Movie>=1) {
                //display the details in the text field
                MessageBox.Show("Video Record ");
                MoviePK.Text= Record.CurrentRow.Cells[0].Value.ToString();

                Vtitle.Text= Record.CurrentRow.Cells[1].Value.ToString();
                VRatting.Text= Record.CurrentRow.Cells[2].Value.ToString();
                VYear.Text= Record.CurrentRow.Cells[3].Value.ToString();
                Vcost.Text= Record.CurrentRow.Cells[4].Value.ToString();
                VCopies.Text= Record.CurrentRow.Cells[5].Value.ToString();
                VPlot.Text= Record.CurrentRow.Cells[6].Value.ToString();
                VGenre.Text= Record.CurrentRow.Cells[7].Value.ToString();


                Movie = 0;
            }

            //get the record of the customer from data grid view 
            if (customer>=1) {
                //display the details in the text field
                MessageBox.Show("CUstomer ");
                CustomerPK.Text= Record.CurrentRow.Cells[0].Value.ToString();
                CName.Text= Record.CurrentRow.Cells[1].Value.ToString();
                CMobile.Text= Record.CurrentRow.Cells[2].Value.ToString();
                CAddress.Text= Record.CurrentRow.Cells[3].Value.ToString();

                customer = 0;
            }


        }

        private void btnBestCustomer_Click(object sender, EventArgs e)
        {

            DataTable tblData = new DataTable();
            tblData =include.DataEntries("select * from CustomerRecord ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = include.DataEntries("select * from RentalRecord where Customer_FK=" + Convert.ToInt32(tblData.Rows[x]["PK_id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Customer Name is ==" + Title);


        }

        private void btnBestMovie_Click(object sender, EventArgs e)
        {
            DataTable tblData = new DataTable();
            tblData =include.DataEntries("select * from MovieRecord ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =include.DataEntries("select * from RentalRecord where Movie_FK=" + Convert.ToInt32(tblData.Rows[x]["PK_Movie_Id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["VTitle"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Video Movie Title is ==" + Title);

        }

        private void btnLoadCustomer_Click(object sender, EventArgs e)
        {
            CustomerGRP.Visible = true;
        }

        private void btnLoadRental_Click(object sender, EventArgs e)
        {
            RentalGRP.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieGrp.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRentalRecord_Click(object sender, EventArgs e)
        {
            try
            {

                //select the data entries from the Rental Record 
                command = "select * from RentalRecord ";

                DataTable tbl = new DataTable();
                tbl = include.DataEntries(command);
                Record.DataSource = tbl;
                rental=1;
                Movie = 0;
                customer = 0;

            }
            catch (Exception ex)
            {

            }
        }

        private void btnVideoRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //select the data entries from the Movie Record 
                command = "select * from MovieRecord ";

                DataTable tbl = new DataTable();
                tbl = include.DataEntries(command);
                Record.DataSource = tbl;
                Movie=1;
                rental = 0;
               
                customer = 0;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
