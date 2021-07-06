using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Created by: Josh Thrash
//Date: 07/03/2021
//Purpose: This program accepts an number as input and allows user to pick specific unit of 
//          measure to convert that number to.

namespace MeasurmentConvertor
{
    public partial class MeasurementConvertor : Form
    {


        public MeasurementConvertor()
        {
            InitializeComponent();
        }


        //Function that allows input of all variables for each individual button except FahrtoCel
        private void ConversionFunc(ListBox lstBox, string unit, Label name, double formula)
        {

            if (lstBox.SelectedItem == unit)
            {
                name.Text = Convert.ToString(formula);
            }
        }


        //Function that converts input received to a double for the formulas
        private double DoubleConversion(TextBox input)
        {

            
            double converted = Convert.ToDouble(input.Text);
            return converted;
        }

        //Each individual button 43-136.  Some have listBoxes for different units of measure
        private void btnFahr_Click(object sender, EventArgs e)
        {
            double fahrFloat = DoubleConversion(fahrInput);
            double ConversionFormula = Math.Round(((fahrFloat - 32) * 5) / 9, 5);
            FahrConverted.Text = Convert.ToString(ConversionFormula);
        }

        private void btnInch_Click(object sender, EventArgs e)
        {
            double inchDouble = DoubleConversion(inchInput);
            double inchToMM = inchDouble * 25.4;
            double inchToCM = inchDouble * 2.54;
            double inchToMeter = inchDouble / 39.37;

            ConversionFunc(lstInch, "MM", InchConverted, Math.Round(inchToMM, 5));
            ConversionFunc(lstInch, "CM", InchConverted, Math.Round(inchToCM, 5));
            ConversionFunc(lstInch, "M", InchConverted, Math.Round(inchToMeter, 5));
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            double feetDouble = DoubleConversion(feetInput);
            
            double feetToMM = feetDouble * 304.8;
            double feetToCM = feetDouble * 30.48;
            double feetToMeter = feetDouble * .3048;

            ConversionFunc(lstFeet, "MM", FeetConverted, Math.Round(feetToMM, 5));
            ConversionFunc(lstFeet, "CM", FeetConverted, Math.Round(feetToCM, 5));
            ConversionFunc(lstFeet, "M", FeetConverted, Math.Round(feetToMeter, 5));
        }


        private void btnYard_Click(object sender, EventArgs e)
        {
            double yardDouble = DoubleConversion(yardInput);

            double yardToMM = yardDouble * 914.4;
            double yardToCM = yardDouble * 91.44;
            double yardToMeter = yardDouble * .9144;

            ConversionFunc(lstYard, "MM", YardConverted, Math.Round(yardToMM, 5));
            ConversionFunc(lstYard, "CM", YardConverted, Math.Round(yardToCM, 5));
            ConversionFunc(lstYard, "M", YardConverted, Math.Round(yardToMeter, 5));
        }

        private void btnQuart_Click(object sender, EventArgs e)
        {
            double quartDouble = DoubleConversion(quartInput);

            double quartToML = quartDouble * 946.353;
            double quartToLiter = quartDouble * .946353;

            ConversionFunc(lstQuart, "ML", QuartConverted, Math.Round(quartToML, 5));
            ConversionFunc(lstQuart, "L", QuartConverted, Math.Round(quartToLiter, 5));
        }

        private void btnGallon_Click(object sender, EventArgs e)
        {
            double gallonDouble = DoubleConversion(gallonInput);

            double gallonToML = gallonDouble * 3785.41;
            double gallonToLiter = gallonDouble * 3.78541;

            ConversionFunc(lstGallon, "ML", GallonConverted, Math.Round(gallonToML, 5));
            ConversionFunc(lstGallon, "L", GallonConverted, Math.Round(gallonToLiter, 5));
        }

        private void btnOunce_Click(object sender, EventArgs e)
        {
            double ounceDouble = DoubleConversion(ounceInput);

            double ounceToMG = ounceDouble * 28349.5;
            double ounceToGram = ounceDouble * 28.3495;
            double ounceToKG = ounceDouble * .0283495;

            ConversionFunc(lstOunce, "MG", OunceConverted, Math.Round(ounceToMG, 5));
            ConversionFunc(lstOunce, "G", OunceConverted, Math.Round(ounceToGram, 5));
            ConversionFunc(lstOunce, "KG", OunceConverted, Math.Round(ounceToKG, 5));
        }

        private void btnPound_Click(object sender, EventArgs e)
        {
            double poundDouble = DoubleConversion(poundInput);

            double poundToMG = poundDouble * 453592;
            double poundToGram = poundDouble * 453.592;
            double poundToKG = poundDouble * .453592;

            ConversionFunc(lstPound, "MG", PoundConverted, Math.Round(poundToMG, 5));
            ConversionFunc(lstPound, "G", PoundConverted, Math.Round(poundToGram, 5));
            ConversionFunc(lstPound, "KG", PoundConverted, Math.Round(poundToKG, 5));
        }



        //Clear button that clears all input textBoxes and output Labels upon button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            Label[] labels = new Label[] {FahrConverted, InchConverted, FeetConverted, YardConverted, QuartConverted,
                                            GallonConverted, OunceConverted, PoundConverted};
            TextBox[] textBoxes = new TextBox[] {fahrInput, inchInput, feetInput, yardInput, gallonInput, ounceInput,
                                            quartInput, poundInput};

            foreach(var label in labels)
            {
                label.Text = "";
            }

            foreach(var textBox in textBoxes)
            {
                textBox.Clear();
            }
           
        }

    }
}
