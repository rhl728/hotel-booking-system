namespace Hotel_Booking
{
    public partial class Form1 : Form
    {
        public static double total = 0;
        public static double price;

        public void Calculate()
        {
            string item = cmbRt.SelectedItem.ToString();

            double days = Convert.ToDouble(txtNod.Text);
            double rooms = Convert.ToDouble(txtNof.Text);


            if (item == "Single")
            {
                if (rooms <= 10)
                {
                    price = rooms * 5000 * days;


                }
                else
                {
                    MessageBox.Show("Single rooms are not available at the moment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }


            }
            else if (item == "Double")
            {

                if (rooms <= 7)
                {
                    if (days > 5)
                    {
                        price = rooms * 7500 * 0.95 * days;

                    }
                    else
                    {
                        price = rooms * 7500 * days;

                    }
                }
                else
                {
                    MessageBox.Show("Double rooms are not available at the moment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (item == "Family")
            {

                if (rooms <= 4)
                {
                    price = rooms * 8000 * days;
                }
                else
                {
                    MessageBox.Show("Family rooms are not available at the moment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (rooms <= 2)
                {
                    if (days > 5)
                    {
                        price = rooms * 12500 * 0.88 * days;

                    }
                    else
                    {
                        price = rooms * 12500 * days;

                    }
                }
                else
                {
                    MessageBox.Show("Suites rooms are not available at the moment.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }



        }
        public Form1()
        {
            InitializeComponent();

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbRt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        public void Clr()
        {

            txtNod.Text = String.Empty;
            txtNof.Text = String.Empty;
            txtTc.Text = String.Empty;
            cmbRt.Text = String.Empty;

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            price = 0;
            total = 0;
            Clr();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void cmbYn_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbYn.SelectedItem.ToString() == "Yes")
            {

                Calculate();
                total = total + price;
                Clr();


            }
            else
            {
                Calculate();
                total = total + price;

            }
        }

        private void btnCtp_Click(object sender, EventArgs e)
        {
            if (cmbYn.SelectedItem.ToString() == "No")
            {
                txtTc.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Do you want to do an another booking?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}