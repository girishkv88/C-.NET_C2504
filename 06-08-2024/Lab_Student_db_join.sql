create database sample_db;

use sample_db;
--created the student table we use if exist  to check the table already exist or not.if not exist the query runs inside begin and end.


--SELECT *  FROM sys.tables;

IF NOT EXISTS(
    SELECT * FROM sys.tables WHERE name = 'student' 
)
BEGIN
CREATE TABLE Student (
    id INT IDENTITY  PRIMARY KEY,
    firstName NVARCHAR(50) NOT NULL,
    lastName NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) NOT NULL UNIQUE,
   );
END

--we can also write using  object_id(tablename) it will show id if table exist else show NULL

IF OBJECT_ID('dbo.subject') IS NULL
BEGIN
CREATE TABLE subject (
    id INT IDENTITY  PRIMARY KEY,
    name NVARCHAR(100) NOT NULL UNIQUE,
     );
END

--created the mark table with proimary key  and foreign key

IF OBJECT_ID('dbo.mark') IS NULL
BEGIN
CREATE TABLE mark (
    id INT IDENTITY  PRIMARY KEY,
    student_id INT NOT NULL ,
    subject_id INT NOT NULL ,
    mark INT NOT NULL ,
    CONSTRAINT FK_Student FOREIGN KEY (student_id) REFERENCES STUDENT(id),
    CONSTRAINT FK_Subject FOREIGN KEY (subject_id) REFERENCES SUBJECT(id)
     );
END

INSERT INTO Student (firstName, lastName, email)
VALUES 
    ('John', 'Doe', 'john.doe@example.com'),
    ('Jane', 'Smith', 'jane.smith@example.com'),
    ('Alice', 'Johnson', 'alice.johnson@example.com');


INSERT INTO subject (name)
VALUES 
    ('Mathematic'),
    ('Physics'),
    ('Chemistry');

INSERT INTO mark (student_id, subject_id, mark)
VALUES 
    (1, 1, 85),  -- John Doe, Mathematics
    (1, 2, 90),  -- John Doe, Physics
    (2, 1, 88),  -- Jane Smith, Mathematics
    (2, 3, 92),  -- Jane Smith, Chemistry
    (3, 2, 79),  -- Alice Johnson, Physics
    (3, 3, 84);  -- Alice Johnson, Chemistry




select * from student
select * from subject 
select * from mark

--SUB QUERY
select * from mark where student_id=(select id from student where email='john.doe@example.com');

--QUESTION :show full details in student table and marks table
--notes--

SELECT student.id AS student_id, mark.id As mark_id,
student.firstname, student.lastname, mark.mark, mark.subject_id 
FROM student 
INNER JOIN mark
ON student_id=mark.student_id;


--after insearting the new student and left join will display that too but not by the inner join
SELECT student.id AS student_id, mark.id As mark_id,
student.firstname, student.lastname, mark.mark, mark.subject_id 
FROM student 
LEFT JOIN mark
ON student.student_id=mark.student_id;

--cobine all 3 tables using inner join 2 times
SELECT student.id AS student_id, mark.id As mark_id,
student.firstname, student.lastname, mark.mark, mark.subject_id, subject.name
FROM student 
INNER JOIN mark ON student.id=mark.id
INNER JOIN subject ON mark.id=subject.id;
