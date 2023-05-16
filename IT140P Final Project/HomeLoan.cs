using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT140P_Final_Project
{
    [Activity(Label = "HomeLoan")]
    public class HomeLoan : Activity
    {

        Button calculateButton, backButton;
        EditText editText1, editText2, editText3, editText4;
        TextView output1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.home_loan);

            output1 = FindViewById<TextView>(Resource.Id.resultTextView);

            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            backButton = FindViewById<Button>(Resource.Id.backButton);

            editText1 = FindViewById<EditText>(Resource.Id.homePriceEditText);
            editText2 = FindViewById<EditText>(Resource.Id.downPaymentEditText);
            editText3 = FindViewById<EditText>(Resource.Id.interestRateEditText);
            editText4 = FindViewById<EditText>(Resource.Id.loanTermEditText);

            backButton.Click += delegate
            {
                this.Finish();
            };

            calculateButton.Click += this.HomeLoanService;

        }

        public void HomeLoanService(object sender, EventArgs e)
        {
            LoanService.SoapServiceTest soapLoanService = new LoanService.SoapServiceTest();

            float homePrice = float.Parse(editText1.Text);
            float downPayment = float.Parse(editText2.Text);
            float interestRate = float.Parse(editText3.Text);
            int loanTerm = int.Parse(editText4.Text);

            output1.Text = ("Pay " + soapLoanService.calculate_home_loan_repayment(homePrice, downPayment, interestRate, loanTerm).ToString() + " a month");

        }

    }
}