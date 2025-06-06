/* The solution to the murder mystery */

-- Use the murder_mystery database
USE murder_mystery;

/* 
Step 1:
To find the dead people in the hospital reports. To see who is dead, how, and when
*/

-- Select all the reports in the hospitol_report table with the word 'dead'
SELECT *
FROM hospital_report
WHERE diagnosis LIKE "%dead%";
/*
Now I know about four pepole that daied - personId 2, 4, 45, 50
*/


/* 
Step 2:
To see when the dead people were in the mansion in a visit
*/
-- Select visits of personId 2, 4, 45, 50
SELECT *
FROM visits
WHERE personId IN(2, 4, 45, 50);
/*
Now I found that the personId 2 and personId 50 where in the mansion at their death time
*/

/*
Step 3:
Find content about 2 and 50 in the journal
*/
-- Select fields about subjectId 2 and 50
SELECT *
FROM journal
WHERE subjectId IN(2, 50);
/*
Now I found that the authorId 12 wrote he want to kill subjectId 2
*/

/*
Step 4:
To see who was in the mansion with personId 2 in the visit that he died.
*/
-- Select visits in the time from 2025-06-02 09:58:00 to 2025-06-02 10:16:00
SELECT *
FROM visits
WHERE timeOfEntry BETWEEN '2025-06-02 09:58:00' AND '2025-06-02 10:16:00'
OR timeOfLeaving BETWEEN '2025-06-02 09:58:00' AND '2025-06-02 10:16:00';
/*
Now I found that personId 12 were in roomId 4 with personId 2
At the time: 2025-06-02 10:03:00 - 2025-06-02 10:16:00
*/


/*
Step 5:
Find the objects that personId is its owner
*/
SELECT *
FROM people_belongings
WHERE personId = 12;
/*
Now I found that personId has four objects objectId 5, 91, 97, 127
*/

/*
Step 6:
Find which object of persomId is a weapon
*/
-- Select objects with objectId in 5, 91, 97, 127  
SELECT *
FROM objects
WHERE objectId IN(5, 91, 97, 127) AND isWeapon;
/*
Now I see that 5, 97, 127 are a weapon.
But I know from the hospitol report, 
That personId 2 died by stab wounds
So I know that probably personId 12 killed him with object 127,
Which is a weapon with the name ice pick and the type stabbing
*/

/*
Step 7:
Find why persomId 12 killed personId 2
*/
-- Select content in journal with subjectId and authorId in 2, 12
SELECT *
FROM journal
WHERE authorId IN(2, 12) AND subjectId IN(2, 12);
/*
Now I found a story:
personId 2 played his harmonica loudly every morning with the window open.
His neighbor personid 12 couldn’t stand the noise and got more and more angry until he want to kill him.
So this was the motive of the killer
*/

/*
 Step 8:
 Find information about the killer and the victim
 */
 -- Select the people with id 2, 12
SELECT *
FROM people
WHERE id IN(2, 12);
/*
Now I found the name of the victim is Ari Levinson (Journalist)
and the name of the killer is Eitan Klein (Antique Dealer)
*/

/*
Step 9:
Find the name of the room that the killer and victim were
*/
-- Select room with id 4
SELECT *
FROM mansion
WHERE roomId = 4;
/*
Now I found the name of the room is Kitchen
*/

/*
Solution summary:
a. Killer: id - 12. firstName - Eitan. lastName - Klein. proffession - Journalist.
b. victim: id - 2. firstName - Ari. lastName - Levinson. proffession - Antique Dealer.
c. room: roomId - 4. roomName - Kitchen. roomSize - 42.
d. time: 2025-06-02 10:03:00 - 2025-06-02 10:16:00.
e. weapon: objectId - 127. objectName - Ice Pick. weaponType - Stabbing.
f. motive: The killer Eitan was driven mad by the loud harmonica music from his neighbor Ari every day.
