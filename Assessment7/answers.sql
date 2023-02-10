/* create the database - orgchart */
create database orgchart;
use orgchart;

/* Create Table persons */
create table persons(
  person_id int not null,
  first_name varchar(30),
  last_name varchar(30),
  city varchar(30),
  leader_id int,
  primary key(person_id)
);

/* Insert info into persons table */
insert into persons (person_id, first_name, last_name, city, leader_id) values (1,'Riley','Shirk','Ann Arbor',5);
insert into persons (person_id, first_name, last_name, city, leader_id) values (2,'Tia','Kansas','Detroit',5);
insert into persons (person_id, first_name, last_name, city, leader_id) values (4,'Hemory','Phifer','Detroit',5);
insert into persons (person_id, first_name, last_name, city) values (5,'Russ','Thomas','');
insert into persons (person_id, first_name, last_name, city) values (6,'Montana','Greyerbiehl','New York');

/* select * from persons; - used to test data in persons table to make sure it matches provided table */

/* create table roles */
create table roles(
  role_id int auto_increment,
  role_title varchar(100),
  primary key(role_id)
);

/* Insert info into roles table */
insert into roles (role_title) values ('Senior Business Program Manager');
insert into roles (role_title) values ('Associate Business Program Manager');
insert into roles (role_title) values ('Team Leader');
insert into roles (role_title) values ('Director');

/* select * from roles; - used to test data in roles table to make sure it matches provided table */

/* update Tia to Tiia */
update persons set first_name = 'Tiia' where person_id = 2;

/* add the column role_id (int) to the persons table */
alter table persons add column role_id int after leader_id;
alter table persons add Constraint fk_role_id foreign key fk__role (role_id) references roles(role_id);

/* update role_id data into persons table */
update persons set role_id = 2 where person_id = 1;
update persons set role_id = 1 where person_id = 2;
update persons set role_id = 1 where person_id = 4;
update persons set role_id = 3 where person_id = 5;
update persons set role_id = 4 where person_id = 6;

/* test role_id constraint */
/* update persons set role_id = 8 where person_id = 6; */

/* select distinc cities except null and output to view_cities */
select distinct(city) view_cities from persons where city is not null;

/* select/join persons firs name, last name and job/role title */
select persons.first_name, persons.last_name, roles.role_title from persons join roles on roles.role_id = persons.role_id;

/* add my job title info to the roles table and my personal info to the persons table */
insert into roles (role_title) values ('Associate Software Engineer In Training');
insert into persons (person_id, first_name, last_name, city, leader_id, role_id) values (7,'Todd','Fecto','Vermilion',6,5);

/* add the column state varchar(15) to the persons table */
alter table persons add column state varchar(15) after city;

/* update state data into persons table */
update persons set state = 'MI' where person_id = 1;
update persons set state = 'MI' where person_id = 2;
update persons set state = 'MI' where person_id = 4;
update persons set state = 'MI' where person_id = 5;
update persons set state = 'NY' where person_id = 6;
update persons set state = 'OH' where person_id = 7;

/* final test of data in persons table */
/* select * from persons; */