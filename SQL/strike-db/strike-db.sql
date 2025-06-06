-- Strike Database
CREATE DATABASE IF NOT EXISTS strike_db;


USE strike_db;

-- Create Terrorists Table
CREATE TABLE terrorists(
ID int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Name varchar(255),
TerroristRank int CHECK(TerroristRank BETWEEN 1 AND 5),
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
	
-- Add Terrorists
INSERT INTO terrorists (Name, TerroristRank, Status, Weapon1, Weapon2) VALUES
('Ali Hassan', 3, 1, 'AK-47', 'Grenade'),
('Omar Khalid', 5, 0, 'RPG', 'Pistol'),
('Yasir Mahmoud', 2, 1, 'SMG', 'Knife'),
('Kareem Al-Bashir', 4, 1, 'Sniper Rifle', 'Pistol'),
('Sami Al-Zein', 1, 0, 'AK-47', 'Molotov');

-- Add Weapons
INSERT INTO weapons (Name, PowerLevel) VALUES
('AK-47', 2),
('Grenade', 3),
('RPG', 3),
('Pistol', 1),
('SMG', 2),
('Knife', 1),
('Sniper Rifle', 3),
('Molotov', 2);

-- Add Intels
INSERT INTO intel (TerroristName, Location, GatheredAt, ConfidenceScore) VALUES
('Ali Hassan', 'Aleppo', '2025-05-01 12:00:00', 88),
('Omar Khalid', 'Mosul', '2025-04-22 15:30:00', 95),
('Yasir Mahmoud', 'Gaza City', '2025-05-10 09:45:00', 67),
('Kareem Al-Bashir', 'Kirkuk', '2025-05-03 18:20:00', 91),
('Sami Al-Zein', 'Damascus', '2025-05-05 14:00:00', 72);

-- Add Strikes
INSERT INTO strikes (TargetName, WeaponUsed, OfficerName, IntelSource, AmmoUsed, Result, StrikeTime) VALUES
('Ali Hassan', 'AK-47', 'Capt. John Reed', 'Intel #1', '30 rounds', 'Success', '2025-05-02 06:30:00'),
('Omar Khalid', 'RPG', 'Lt. Sarah Connor', 'Intel #2', '1 rocket', 'Failure', '2025-04-23 10:15:00'),
('Yasir Mahmoud', 'SMG', 'Maj. Alex Grant', 'Intel #3', '50 rounds', 'Success', '2025-05-11 08:00:00'),
('Kareem Al-Bashir', 'Sniper Rifle', 'Sgt. Maria Lopez', 'Intel #4', '1 shot', 'Success', '2025-05-04 17:00:00'),
('Sami Al-Zein', 'Molotov', 'Capt. Dan Miller', 'Intel #5', '1 bottle', 'Failure', '2025-05-06 12:45:00');

-- Show Terrorists
SELECT *
FROM terrorists;

-- Show Weapons
SELECT *
FROM weapons;

-- Show Intels
SELECT *
FROM intel;

-- Show Strikes
SELECT *
FROM strikes;