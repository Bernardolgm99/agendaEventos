CREATE DATABASE Agenda
GO

USE Agenda
GO

CREATE TABLE Evento(
id int identity (1,1) primary key,
nome varchar (50),
data datetime)