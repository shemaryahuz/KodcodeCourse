-- The solution to the murder mystery

-- Use the murder_mystery database
USE murder_mystery;

-- 1. Find all the reports about dead in the hospitol_report table (to see dethh and time frame of teath)
SELECT *
FROM hospital_report
WHERE diagnosis LIKE "%dead%";

-- 2. Find visits of dead people (to see who were in the mansion at the time he dead)
SELECT *
FROM visits
WHERE personId IN(2, 4, 45, 50);

-- Now I found that the personId 2 and personId 50 where in the mansion at the death time

-- 3. Find contant about 2 and 50 in the journal
SELECT *
FROM journal
WHERE subjectId IN(2, 50);

-- Now I found that the authorId 12 wrote he want to kill subjectId 2

-- 4. Find visits of personId 12
SELECT *
FROM visits
WHERE personId = 12;

-- Now I found that personId 12 were in roomId 4 with personId 2
-- At the time: 2025-06-02 10:03:00 - 2025-06-02 10:16:00

-- 5. Find information about them in people
SELECT *
FROM people
WHERE id IN(2, 12);

-- Now I found the name of 2 is Ari Levinson and the name of 12 is Eitan Klein

-- 6. Find room name
SELECT *
FROM mansion
WHERE roomId = 4;

-- Now I found the name of the room is Kitchen

-- 7. Find the objects in the roomId 4 that they are a weapon
SELECT *
FROM objects o
JOIN room_objects ro ON o.objectId = ro.objectId
WHERE roomId = 4 AND isWeapon;

-- 8. Find the weapon that Eitan is its owner
SELECT *
FROM people_belongings
WHERE personId = 12;

-- I see that Eitan's objects not exist in the Kitchen, but i can find if he has weapon in his objects

-- 9. Find a weapon in Eitan Klein's objects
SELECT *
FROM objects
WHERE objectId IN(5, 91, 97, 127) AND isWeapon;

-- Like I found in the hospital repot Ari Levinson were murded by Stabbing
-- so Now I know that the weapon that Eitan Klein used was Ice Pick objectId 127

-- 


