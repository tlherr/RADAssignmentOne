/**
 * Students: Nathan Siu and Thomas Herr
 * Date: 10/9/2015
 * Purpose: This program allows a user to configure an iphone and acccessories and view the changes in cost
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeAssignmentOne
{
    public partial class iPhonePurchaseForm : Form
    {

        double cost = 0;
        double accessoryCost = 0;
        double subTotal = 0;
        double total = 0;

        const int IPHONE_SIX_SIXTEEN_GIGABYTES = 749;
        const int IPHONE_SIX_SIXTYFOUR_GIGABYTES = 859;
        const int IPHONE_SIX_ONE_HUNDRED_TWENTY_EIGHT_GIGABYTES = 969;

        const int IPHONE_SIX_S_SIXTEEN_GIGABYTES = 969;
        const int IPHONE_SIX_S_SIXTYFOUR_GIGABYTES = 1099;
        const int IPHONE_SIX_S_ONE_HUNDRED_TWENTY_EIGHT_GIGABYTES = 1229;

        const int APPLE_CARE_PROTECTION_PLAN = 99;
        const int LEATHER_CASE = 49;
        const int SCREEN_PROTECTOR = 29;


        public iPhonePurchaseForm()
        {
            InitializeComponent();
        }

        private void iPhonePurchaseForm_Load(object sender, EventArgs e)
        {
            //Set the initial value and formatting of the trade in text box
            tradeInTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", cost);
        }

        private void calculateBaseCost()
        {
            if (sixteenGigabyteRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    cost = IPHONE_SIX_SIXTEEN_GIGABYTES;
                }
                else if (iPhoneSixSRadioButton.Checked)
                {
                    cost = IPHONE_SIX_S_SIXTEEN_GIGABYTES;
                }

            }
            else if (sixtyFourGigabyteRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    cost = IPHONE_SIX_SIXTYFOUR_GIGABYTES;
                }
                else if (iPhoneSixSRadioButton.Checked)
                {
                    cost = IPHONE_SIX_S_SIXTYFOUR_GIGABYTES;
                }

            }
            else if (oneHundredTwentyEightGigabyteRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    cost = IPHONE_SIX_ONE_HUNDRED_TWENTY_EIGHT_GIGABYTES;
                }
                else if (iPhoneSixSRadioButton.Checked)
                {
                    cost = IPHONE_SIX_S_ONE_HUNDRED_TWENTY_EIGHT_GIGABYTES;
                }

            }

            basePriceTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", cost);

        }

        private void calculateSubtotal()
        {
            subTotal = cost + accessoryCost;
            subtotalTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", subTotal);
        }


        /**
         * Click event for Space Grey Radio Button
         */
        private void spaceGreyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (iPhoneSixRadioButton.Checked || iPhoneSixSRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6_gray_select_2014_GEO_US;
                }

                if(iPhoneSixSRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6p_gray_select_2014_GEO_US;
                }

            }
        }

        /**
         * Click event for the Gold Radio Button
         */
        private void goldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (iPhoneSixRadioButton.Checked || iPhoneSixSRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6s_rosegold_select_2015;
                }

                if (iPhoneSixSRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6s_gold_select_2015;
                }

            }
        }

        private void silverRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (iPhoneSixRadioButton.Checked || iPhoneSixSRadioButton.Checked)
            {
                if (iPhoneSixRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6_silver_select_2014_GEO_US;
                }

                if (iPhoneSixSRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6p_silver_select_2014_GEO_US;
                }

            }
        }

        private void iPhoneSixRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(spaceGreyRadioButton.Checked || goldRadioButton.Checked || silverRadioButton.Checked)
            {
                if (spaceGreyRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6_silver_select_2014_GEO_US;
                }

                if (silverRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6_silver_select_2014_GEO_US;
                }

                if (goldRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6s_rosegold_select_2015;
                }
            }

            this.calculateBaseCost();
        }

        private void iPhoneSixSRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (spaceGreyRadioButton.Checked || goldRadioButton.Checked || silverRadioButton.Checked)
            {
                if (spaceGreyRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6p_gray_select_2014_GEO_US;
                }
                else if (silverRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6p_silver_select_2014_GEO_US;
                }
                else if (goldRadioButton.Checked)
                {
                    iPhonePictureBox.Image = Properties.Resources.iphone6s_rosegold_select_2015;
                }
            }

            this.calculateBaseCost();
        }

        private void sixteenGigabyteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.calculateBaseCost();
            this.calculateSubtotal();
        }

        private void sixtyFourGigabyteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.calculateBaseCost();
            this.calculateSubtotal();
        }

        private void oneHundredTwentyEightGigabyteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.calculateBaseCost();
            this.calculateSubtotal();
        }

        private void appleCareProtectionPlanCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (appleCareProtectionPlanCheckbox.Checked)
            {
                accessoryCost += APPLE_CARE_PROTECTION_PLAN;
            }
            else
            {
                accessoryCost -= APPLE_CARE_PROTECTION_PLAN;
            }

            accessoriesTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", accessoryCost);
            this.calculateSubtotal();
        }

        private void leatherCaseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (leatherCaseCheckbox.Checked)
            {
                accessoryCost += LEATHER_CASE;
            }
            else
            {
                accessoryCost -= LEATHER_CASE;
            }

            accessoriesTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", accessoryCost);
            this.calculateSubtotal();
        }

        private void screenProtectorCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (screenProtectorCheckbox.Checked)
            {
                accessoryCost += SCREEN_PROTECTOR;
            }
            else
            {
                accessoryCost -= SCREEN_PROTECTOR;
            }

            accessoriesTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", accessoryCost);
            this.calculateSubtotal();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            //NEEDS TRY CATCH
            var taxAmount = (subTotal - Double.Parse(tradeInTextBox.Text))*0.13;
            total = (subTotal - Double.Parse(tradeInTextBox.Text)) + taxAmount;

            totalTextBox.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", total);


        }


    }
}
