CREATE TABLE Class(
  ClassID NUMBER(10) PRIMARY KEY NOT NULL,
  Name VARCHAR2(256),
  Description VARCHAR2(256)
);
CREATE SEQUENCE class_seq
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER class_seq 
BEFORE INSERT ON Class 
FOR EACH ROW

BEGIN
  SELECT class_seq.NEXTVAL
  INTO   :new.ClassID
  FROM   dual;
END;

SELECT * FROM student FETCH FIRST 10 ROWS ONLY;
SELECT * FROM student WHERE studentid = '401';
SELECT * FROM student WHERE phys < 4;
SELECT * FROM student WHERE phys < 4 AND math < 4;
UPDATE student SET math = math + 1;
UPDATE student SET phys = phys + 1 WHERE phys < 4;
UPDATE student SET phys = phys + 1, math = math + 1  WHERE phys < 4 AND math < 4;
DELETE student WHERE studentid = '401';

SELECT COUNT(studentid) FROM student WHERE phys < 6;
SELECT COUNT(studentid) FROM student WHERE phys < 6 AND math < 6;
SELECT studentid , (math+ phys) as totalpoint FROM student;
SELECT SUM(math) as mathtotalpoin FROM student;
SELECT ROUND(AVG(math),2) as mathaveragepoint FROM student;
SELECT *FROM student ORDER BY math DESC FETCH FIRST 2 ROWS ONLY;
SELECT *FROM student ORDER BY phys ASC FETCH FIRST 2 ROWS ONLY;
SELECT *FROM student ORDER BY math DESC,phys DESC FETCH FIRST 2 ROWS ONLY;
SELECT class.classid , student.* from class LEFT JOIN student ON class.classid = student.classid ORDER BY studentid ASC;
SELECT classid,COUNT(studentid) as studentamount FROM student GROUP BY classid ORDER BY classid ASC;