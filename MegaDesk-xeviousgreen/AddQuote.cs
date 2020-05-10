using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk_xeviousgreen
{
    public partial class AddQuote : Form
    {

#pragma warning disable CS0169 // The field 'AddQuote.width' is never used
        decimal width;
#pragma warning restore CS0169 // The field 'AddQuote.width' is never used
#pragma warning disable CS0169 // The field 'AddQuote.depth' is never used
        decimal depth;
#pragma warning restore CS0169 // The field 'AddQuote.depth' is never used
#pragma warning disable CS0169 // The field 'AddQuote.drawers' is never used
        decimal drawers;
#pragma warning restore CS0169 // The field 'AddQuote.drawers' is never used
#pragma warning disable CS0169 // The field 'AddQuote.time' is never used
        decimal time;
#pragma warning restore CS0169 // The field 'AddQuote.time' is never used

        decimal material;

        decimal surfaceArea;

        int deliveryPrice;

        int materialPrice;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainMenu f2 = new MainMenu();
            f2.ShowDialog();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        public void TotalCalc_Click(object sender, EventArgs e)
        {



            surfaceArea = width * depth;

            width = widthDown.Value;

             depth = depthDown.Value;

             drawers = drawsDown.Value;

             time = timeDown.Value;
           

       if(time == '3')
            {

                if (surfaceArea <= 1000)
                { deliveryPrice = 60; }
                if (surfaceArea >= 1000 && surfaceArea < 2000)
                { deliveryPrice = 70; }
                if (surfaceArea >= 2000)
                { deliveryPrice = 80; }
            }
       else if( time == '5')
            {

                if (surfaceArea <= 1000)
                { deliveryPrice = 40; }
                if (surfaceArea >= 1000 && surfaceArea < 2000)
                { deliveryPrice = 50; }
                if (surfaceArea >= 2000)
                { deliveryPrice = 60; }
            }
            else if (time == '7')
            {

                if (surfaceArea <= 1000)
                { deliveryPrice = 30; }
                if (surfaceArea >= 1000 && surfaceArea < 2000)
                { deliveryPrice = 35; }
                if (surfaceArea >= 2000)
                { deliveryPrice = 40; }
            }

                else 
                {
                    deliveryPrice = 0;
                }




            material = matDown.Value;

            if(material == '1')
            { materialPrice = 200; }

            if (material == '2')
            { materialPrice = 100; }

            if (material == '3')
            { materialPrice = 50; }

            if (material == '4')
            { materialPrice = 300; }

            if (material == '5')
            { materialPrice = 125; }

            decimal totalAmount = surfaceArea + deliveryPrice + (drawers * 50) + materialPrice;

             decimal amount = totalAmount;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeDown_ValueChanged(object sender, EventArgs e)
        {
            if (time != 3 || time != 5 || time != 7 || time != 14)
                { timeDown.BackColor = Color.Red; }
            else { timeDown.BackColor = Color.White; }

        }
    }
}
