--Setup database and tables required

--Create databwse named trainer_search_db
CREATE DATABASE trainer_search_db;

--to switch /use database...or make current db
USE trainer_search_db;

CREATE TABLE trainer
(
    id integer primary key identity(1,1) NOT NULL,
    name varchar(255) NOT NULL,
    skill varchar(512) NOT NULL,
    place varchar(126)  NOT NULL
);

-- T o know more details about table trainer
sp_help trainer;

--to display the table

select * from trainer

--insert by single line
INSERT INTO trainer(name , skill, place) VALUES('mishel','c#', 'Kottayam');
--insert by multiline 
INSERT INTO trainer(name , skill, place) VALUES('mahesh','c#', 'Mysore'),('sanjay','management', 'Trivandrum')


INSERT INTO trainer(name , skill, place) VALUES('mishel','c#', 'Kottayam');

--delete the duplicate trainer

DELETE FROM trainer WHERE ID = 4

--TO DELETE   TWO TRAINERS  ID IN(2,3) V IE ID IS EITHER 2 OR 3

DELETE FROM trainer WHERE ID IN(2,3)

--UPDATE THE SKILL BASED ON ID
UPDATE trainer SET skill= 'C# with WPF' WHERE ID=1
select * from trainer

--SPECIFIC COLUMN SELECTION
SELECT NAME,PLACE FROM trainer 

--TO DROP ATABLE  -BEFORE DFROP TABLE DELETE ALL TRAINERS FIRST
--DROP TABLE trainer
