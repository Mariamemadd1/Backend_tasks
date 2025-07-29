CREATE DATABASE final
use final

create table Employee(
id int primary key identity,
email varchar(30),
name varchar(30),
salary int,
DeptId int
)

create table Department(
DeptId int Primary key identity(10,10),
DeptName varchar(30)
)

alter table Employee 
add foreign key(DeptId) references Department(DeptId) on update cascade
on delete set null

create table admins(
AdminId int primary key identity,
email varchar(30),
pass varchar(30),
empId int references Employee(id)  on update cascade
on delete set null
)

create table customers(
customerId int primary key identity,
fullname varchar(60),
address Varchar(60),
phone varchar(60),
gender varchar(6),
pass varchar(20)
)

create table orders(
orderId int primary key identity,
customerId int references customers(customerId),
productId int,
date date,
amount int

)

create table products(
productId int primary key identity,
ProductName varchar(30),
category varchar(30),
price int
)

alter table orders 
add foreign key(productId) references products(productId)
