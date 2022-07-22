CREATE DATABASE SoftUni

USE SoftUni

CREATE TABLE Students
(
   Id INT PRIMARY KEY IDENTITY NOT NULL,
   FirstName NVARCHAR(50),
   LastName NVARCHAR(50),
   Age INT,
   Grade DECIMAL(3, 2)
)