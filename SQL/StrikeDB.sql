-- Strike Database

-- Create Strike DataBase
CREATE DATABASE strike_db;

USE strike_db;

-- Create Terrorists Table
CREATE TABLE terrorists(
ID int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name varchar(255),
Rank int,
Status boolean,
Weapon1 varchar(255),
Weapon2 varchar(255)
);

-- Create Weapons Table
CREATE TABLE weapons(
ID int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name varchar(255),
PowerLevel int CHECK(PowerLevel BETWEEN 1 AND 3)
);

-- Create Intel Table
CREATE TABLE intel(
    ID int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    TerroristName varchar(255),
    Location varchar(255),
    GatheredAt datetime,
    ConfidenceScore int CHECK(ConfidenceScore BETWEEN 1 AND 100)
    );
	
-- Create Strikes Table
CREATE TABLE strikes(
    ID int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    TargetName varchar(255),
    WeaponUsed varchar(255),
    OfficerName varchar(255),
    IntelSource varchar(255),
    AmmoUsed varchar(255),
    Result varchar(255),
    StrikeTime datetime
    )