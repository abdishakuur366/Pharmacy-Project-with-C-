create database Employees
use Employees

create table emp
(
empfName varchar(30),
empsName varchar(30),
emplName varchar(30),
empPhone int,
empGender varchar(30),
empSalary money,
empShift varchar(30)
)
select * from emp

create proc spAddNewEmp
@fname varchar(30),@sname varchar(30),@lname varchar(30),@phone int,@gender varchar(30),@salary money,@shift varchar(30)
as
Begin
insert into emp(empfName,empsName,emplName,empPhone,empGender,empSalary,empShift)
values(@fname,@sname,@lname,@phone,@gender,@salary,@shift)
End