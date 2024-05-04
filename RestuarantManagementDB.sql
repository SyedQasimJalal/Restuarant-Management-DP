use RestaurantManagementDB;

create table FoodType(
id int primary key identity(1,1),
food_type varchar(20)
);

create table food(
food_id int primary key identity(1,1),
food_name varchar(30),
food_type int,
foreign key(food_type) references FoodType(id),
price float
);

create table customer_order(
cus_ord_id int primary key identity(1,1),
customer_id int,
order_id int,
);

create table order(
o_id int primary key identity(1,1),
total_price float,
);