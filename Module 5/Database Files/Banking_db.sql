create database banking_database;
use banking_database;

CREATE TABLE UserData (
  Bank_Account_Number INT,
  Email_ID VARCHAR(200),
  Name VARCHAR(200),
  Address VARCHAR(200),
  Phone_Number INT,
  Username VARCHAR(200),
  Password VARCHAR(200),
  DOB Date,
  Balance Float,
  CIBIL_Score Float,
  Profile_Image MEDIUMBLOB,
  Signature MEDIUMBLOB,
  Primary Key (Bank_Account_Number)
);



CREATE TABLE TransactionLog (
  Transaction_ID INT AUTO_INCREMENT PRIMARY KEY,
  Bank_Account_Number INT,
  Involved_Bank_Account_Number INT,
  Type_of_Transaction VARCHAR(200),
  Amount Float,
  Date_Time Datetime,
  Description VARCHAR(200)
);

CREATE TABLE LoanPlans (
  Loan_Plan_ID INT,
  Loan_Type VARCHAR(200),
  Amount VARCHAR(200),
  Interest_Rate Float,
  Description VARCHAR(200),
  Period Datetime,
  Primary Key (Loan_Plan_ID)
);

CREATE TABLE LoanManagement (
  LoanPlanID INT,
  Bank_Account_Number INT,
  Start_Date Date
);

CREATE TABLE QueryLog (
  Query_ID INT AUTO_INCREMENT PRIMARY KEY,
  Bank_Account_Number INT,
  Type_of_Query VARCHAR(200),
  Day Date,
  Query Varchar(200),
  Status VARCHAR(200),
  Reply VARCHAR(200)
);



CREATE TABLE CreditDebitCard (
  CardNumber INT,
  Bank_Account_Number INT,
  Type VARCHAR(200),
  CIBIL_Score Float,
  Expiry_Date Date,
  Cvv INT,
  Primary Key (CardNumber)
);

CREATE TABLE Admindata (
  Username VARCHAR(200),
  Password VARCHAR(200),
  Primary Key (Username)
);

Insert Into TransactionLog(Bank_Account_Number,Involved_Bank_Account_Number,Type_of_Transaction,Amount,Date_Time,Description) Values
(1,2,'Hello',1200,'2022-03-30','nanana');

drop database banking_database;

