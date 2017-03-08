create database ColorGrid

use ColorGrid

create table Admin_Login
(Username varchar(20),
Password varchar(20))

insert into Admin_Login values('Admin','Admin')

select * from Admin_Login

create table Client_Details
(CID varchar(5) Primary Key,
CName varchar(30),
CAddress varchar(50),
CMobile varchar(10),
CEmail varchar(50),
CBusiness varchar(20),
CComments varchar(50))

create table Liablities
(LID varchar(5) Primary Key,
CID varchar(5),
LType varchar(20),
LSDate varchar(10),
LEDate varchar(10),
LAmount numeric(10),
LTAmount numeric(10))

create table Assest
(AID varchar(5) Primary Key,
CID varchar(5),
AType varchar(20),
ASDate varchar(10),
AEDate varchar(10),
AAmount numeric(10),
RAmount numeric(10))

select * from Client_Details

create table ColorLogin
(Username varchar(20),
Col1 numeric(1),
Col2 numeric(1),
Col3 numeric(1),
Col4 numeric(1),
Col5 numeric(1),
Col6 numeric(1),
Col7 numeric(1),
Col8 numeric(1))

select * from ColorLogin
