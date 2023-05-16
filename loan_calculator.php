<?php

function calculate_personal_loan_repayment($loan_amount, $interest_rate, $loan_term) {
    $monthly_interest_rate = $interest_rate / 12;
    $num_payments = $loan_term * 12;
    $monthly_repayment = ($loan_amount + ($loan_amount * $monthly_interest_rate * $num_payments)) / ($num_payments);
    return round($monthly_repayment, 2);
}

function calculate_car_loan_repayment($car_price, $down_payment, $interest_rate, $loan_term) {
    $loan_amount = $car_price - $down_payment;
    $monthly_interest_rate = $interest_rate / 12;
    $num_payments = $loan_term * 12;
    // Calculate the monthly repayment amount using the formula
    $monthly_repayment = ($loan_amount * $monthly_interest_rate * pow(1 + $monthly_interest_rate, $num_payments)) / (pow(1 + $monthly_interest_rate, $num_payments) - 1);
    return round($monthly_repayment,2);
}

function calculate_home_loan_repayment($home_price, $down_payment, $interest_rate, $loan_term) {
    $loan_amount = $home_price - $down_payment;
    $monthly_interest_rate = $interest_rate / 12;
    $num_payments = $loan_term * 12;  
    // Calculate the monthly repayment amount using the formula
    $monthly_repayment = ($loan_amount * $monthly_interest_rate) / (1 - pow(1 + $monthly_interest_rate, -$num_payments));
    return round($monthly_repayment,2);
}

function calculate_education_loan_repayment($loan_amount, $interest_rate, $loan_term, $grace_period) {
    $loan_amount_remaining = $loan_amount;
    $monthly_interest_rate = $interest_rate / 12;
    $num_payments = ($loan_term - $grace_period) * 12;
    // Calculate the monthly repayment amount using the formula
    $monthly_repayment = ($loan_amount_remaining * $monthly_interest_rate) / (1 - pow(1 + $monthly_interest_rate, -$num_payments));  
    return round($monthly_repayment,2);
}


