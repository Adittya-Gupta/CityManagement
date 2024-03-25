create database emaildatabase;
use emaildatabase;

CREATE TABLE UserData (
  Username varchar(100),
  Password varchar(100),
  Primary Key (Username)
);

CREATE TABLE EmailsData (
  Email_From varchar(100),
  Email_To varchar(100),
  Subject varchar(100),
  Content varchar(1000),
  Draft Int
);
