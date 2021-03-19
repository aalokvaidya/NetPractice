drop database StudentDb

create database StudentDb
use StudentDb

create table Student(
Id int primary key,
Name nvarchar(30) not null,
Age int not null,
Course nvarchar(50) not null,
Email nvarchar(30) unique not null,
Contact nvarchar(10) unique not null
)
select *from Student
insert into Student values(1,'Sam Dicosta',21,'PhD','sam@rock.com','9876543210')
insert into Student values(2,'Ravichandran Ashvin',35,'Bowling','r_naive@gmail.com','6565465432')
insert into Student values(3,'Rohit Sharma',45,'Batting','rohit@hitman.com','4545331325')
insert into Student values(4,'Virat Kohli',18,'Captaincy','kohli@king.com','7643213543')