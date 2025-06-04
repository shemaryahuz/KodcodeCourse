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
