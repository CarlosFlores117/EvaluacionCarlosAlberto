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
Sueldo float,FechaIngreso dateCONSTRAINT RelacionFOREIGN KEY (Login) REFERENCES usuarios(Login)	ON UPDATE CASCADE	ON DELETE CASCADE)use EvaluacionBULK INSERT 	usuariosFROM 	'C:\Users\ALBERTO FLORES\Documents\Repost\testdevbackjr\Prueba_1\DatosPracticaSQL.csv'WITH (	FIELDTERMINATOR = ',',	ROWTERMINATOR='\n',	FIRSTROW =2)SELECT * FROM usuariosuse EvaluacionBULK INSERT 	empleadosFROM 	'C:\Users\ALBERTO FLORES\Documents\Repost\testdevbackjr\Prueba_1\DatosPracticaSQLEm.csv'WITH (	FIELDTERMINATOR = ',',	ROWTERMINATOR='\n',	FIRSTROW =2)SELECT * FROM empleadosDELETE from usuarios where userId LIKE'6' OR userId LIKE '7' or userId LIKE'9' OR userId LIKE'10'UPDATE empleados set empleados.Sueldo=empleados.Sueldo+(empleados.Sueldo*.10) where FechaIngreso LIKE '2000%' or FechaIngreso LIKE'2001%'Select Nombre, empleados.FechaIngreso from usuarios left join empleados on usuarios.userId=empleados.userId where empleados.Sueldo>10000 and usuarios.Paterno LIKE'T%' order by empleados.FechaIngreso ASCselect count(userId)usuario_cuenta from empleados where Sueldo>1200 group by Sueldo 