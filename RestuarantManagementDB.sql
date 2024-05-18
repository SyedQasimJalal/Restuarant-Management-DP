create database RestaurantManagementDB;

use RestaurantManagementDB;

create table customer(
customer_id int primary key identity(1,1),
name varchar(50) not null,
email varchar(50) not null,
password varchar(100) not null,
);

drop table FoodType;
drop table food;


create table food_type(
id int primary key identity(1,1),
food_type varchar(20)
);

create table food(
food_id int primary key identity(1,1),
food_name varchar(30),
food_type int,
foreign key(food_type) references food_type(id) on delete cascade on update cascade,
price float
);

create table customer_order(
cus_ord_id int primary key identity(1,1),
customer_id int,
order_id int,
foreign key (customer_id) references customer(customer_id) on delete cascade on update cascade,
);

create table [order](
o_id int primary key identity(1,1),
total_price float,
);


