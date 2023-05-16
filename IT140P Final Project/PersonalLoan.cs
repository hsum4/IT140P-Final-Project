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
    [Activity(Label = "PersonalLoan")]
    public class PersonalLoan : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.personal_loan);
            Button calculateButton, backButton;
            EditText editText1, editText2, editText3;

            calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            backButton = FindViewById<Button>(Resource.Id.backButton);

            editText1 = FindViewById<EditText>(Resource.Id.loanAmountEditText);
            editText2 = FindViewById<EditText>(Resource.Id.interestRateEditText);
            editText3 = FindViewById<EditText>(Resource.Id.loanTermEditText);

            backButton.Click += delegate
            {
                this.Finish();
            };

        }
    }
}