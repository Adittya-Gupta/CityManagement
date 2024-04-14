create database newsdatabase;

use newsdatabase;
CREATE TABLE NewsData (
  News_ID INT AUTO_INCREMENT PRIMARY KEY,
  Published_On ENUM('Festivals and Election','Education and Health','Transport and Communication','Employment and Services','Promotion and Advertisement','Main','None'),
  Headline varchar(500),
  Publisher varchar(500),
  Type ENUM('Festivals and Election','Education and Health','Transport and Communication','Employment and Services','Promotion and Advertisement'),
  Date date,
  Content varchar(5000),
  Image LONGBLOB
);


-- 0 --> Fest
-- 1 --> Edu + Health
-- 2 --> Transport + Comm
-- 3 --> Employment
-- 4 --> Promo
-- 5 --> Main page

CREATE TABLE PublishmentPage (
  News_ID INT,
  Published_On ENUM('Festivals and Election','Education and Health','Transport and Communication','Employment and Services','Promotion and Advertisement','Main','None')
);

CREATE TABLE Admindata (
  Username varchar(50),
  Password varchar(50),
  Primary Key (username)
);

drop table NewsData;

drop database newsdatabase;

create database Temp;
use Temp;

create Table data(
		ID INT AUTO_INCREMENT PRIMARY KEY,
        image BLOB
);

drop database temp;
