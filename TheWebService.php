<?php
require 'nusoap/lib/nusoap.php';
require 'loan_calculator.php';

$server = new nusoap_server(); // Create a instance for soap server

$server->configureWSDL("Soap Service Test","urn:soaptest"); // Configure Web Services Description Language file

$server->register(
    "calculate_personal_loan_repayment", // name of function
    array("loan_amount" => "xsd:float", "interest_rate" => "xsd:float", "loan_term" => "xsd:int"), // input parameters
    array("return" => "xsd:float") // output parameters
);

$server->register(
    "calculate_car_loan_repayment", // name of function
    array("car_price" => "xsd:float", "down_payment" => "xsd:float", "interest_rate" => "xsd:float", "loan_term" => "xsd:int"), // input parameters
    array("return" => "xsd:float") // output parameters
);

$server->register(
    "calculate_home_loan_repayment", // name of function
    array("home_price" => "xsd:float", "down_payment" => "xsd:float", "interest_rate" => "xsd:float", "loan_term" => "xsd:int"), // input parameters
    array("return" => "xsd:float") // output parameters
);

$server->register(
    "calculate_education_loan_repayment", // name of function
    array("loan_amount" => "xsd:float", "interest_rate" => "xsd:float", "loan_term" => "xsd:int", "grace_period" => "xsd:int"), // input parameters
    array("return" => "xsd:float") // output parameters
);


$server->service(file_get_contents("php://input"));

?>