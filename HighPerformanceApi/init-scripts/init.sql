CREATE DATABASE HighPerfDb;
GO

USE HighPerfDb;
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);
GO

INSERT INTO Users (Name, Email) VALUES ('Lebogang', 'lebogang@example.com');
GO