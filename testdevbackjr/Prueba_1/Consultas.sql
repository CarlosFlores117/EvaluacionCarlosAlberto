CREATE DATABASE Evaluacion
use Evaluacion
CREATE TABLE usuarios(userId INT IDENTITY(1,1) NOT NULL,
Login varchar(100)primary key
,Nombre varchar(100)
,Paterno varchar(100)
,Materno varchar(100))

CREATE TABLE empleados(
userId INT IDENTITY(1,1),
Login varchar(100),
Sueldo float,