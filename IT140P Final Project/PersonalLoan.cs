﻿using Android.App;
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
    [Activity(Label = "PersonalLoan")]
    public class PersonalLoan : Activity
    {

        Button calculateButton, backButton;
        EditText editText1, editText2, editText3;
        TextView output1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.personal_loan);
            

            output1 = FindViewById<TextView>(Resource.Id.resultTextView);

            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            backButton = FindViewById<Button>(Resource.Id.backButton);

            editText1 = FindViewById<EditText>(Resource.Id.loanAmountEditText);
            editText2 = FindViewById<EditText>(Resource.Id.interestRateEditText);
            editText3 = FindViewById<EditText>(Resource.Id.loanTermEditText);

            backButton.Click += delegate
            {
                this.Finish();
            };

            calculateButton.Click += this.PersonalLoanService;

        }

        public void PersonalLoanService(object sender, EventArgs e)
        {
            LoanService.SoapServiceTest soapLoanService = new LoanService.SoapServiceTest();
            try
            {
                float loanAmount = float.Parse(editText1.Text);
                float interestRate = float.Parse(editText2.Text);
                int loanTerm = int.Parse(editText3.Text);

                output1.Text = ("Pay " + soapLoanService.calculate_personal_loan_repayment(loanAmount, interestRate, loanTerm).ToString() + " a month");
            }
            catch (FormatException)
            {
                DisplayErrorMessage("Invalid inputs. Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }

        private void DisplayErrorMessage(string errorMessage)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetTitle("Error");
            builder.SetMessage(errorMessage);
            builder.SetPositiveButton("OK", (sender, args) => { });
            builder.Create().Show();
        }

    }
}