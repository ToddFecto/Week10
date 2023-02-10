/* Lab 13.1 Northwind DB */
use northwind;

select * from customer; # 1

select distinct(country) from customer; # 2

select * from customer where companyName like 'Customer CC%'; # 3 similar example

select * from orderdetail where orderDetailId < 101; # 4  select * from orderdetail where orderId = 10248 order by orderdetailId desc limit 1;
SELECT * FROM orderdetail WHERE orderDetailId <= (SELECT MAX(orderDetailId)) ORDER BY orderDetailId DESC LIMIT 10;

select * from customer where postalCode = '1010' or postalCode = '3012' or postalCode = '12209' or postalCode = '05023'; # 5  ...in ('1010', '3012', '12209', '05023');

select * from salesorder where shipRegion is not null; # 6

select * from customer order by country, city; # 7

insert into customer (companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, mobile, email, fax)
	values ('Customer CCXXG', 'Tom Jones', 'Owner', '1234 Sunset Blvd.', 'Las Vegas', 'NV', '88901', 'USA', '(702) 555-0123', null , null, null); # 8  can use the right-click on the customer field 
select * from customer where contactName = 'Tom Jones'; # 8 check

select * from salesorder where shipCountry = 'France'; # 9 initial data pull - all shipRegion = null
update salesorder set shipRegion = 'EuroZone' where shipCountry = 'France'; # 9 all shipRegion = EuroZone after

select * from orderdetail where quantity = 1; # 10 initial pull - quantity = 1 (17 listed)
delete from orderdetail where quantity = 1; # 10 quantity = null

select avg(quantity), max(quantity), min(quantity) from orderdetail; # 11  select avg(quantity) as Average, max(quantity) as Maximum, min(quantity) as Minimum from orderdetail;

select orderId, avg(quantity), max(quantity), min(quantity) from orderdetail group by orderId; # 12
select orderId, avg(quantity), max(quantity), min(quantity) from orderdetail group by orderId;

select * from salesorder;
select custID from salesorder where orderId = '10290'; # 13? error should be salesorder and not orderdetail

select * from salesorder inner join customer; # 14 blanks returned
select * from customer left join salesorder on salesorder.orderId = customer.custId; # 14 order half null
select * from customer right join salesorder on salesorder.orderId = customer.custId; # 14 order half null

/* for # 15 */
select * from employee where city = 'London';
select * from salesorder;
select * from salesorder join employee on salesorder.employeeId = employee.employeeId; # 15
select * from salesorder join employee on salesorder.employeeId = employee.employeeId where city = 'London'; # 15
select salesorder.*, employee.lastname from salesorder join employee on salesorder.employeeId = employee.employeeId where city = 'London'; # 15
select salesorder.orderId, employee.lastname from salesorder join employee on salesorder.employeeId = employee.employeeId where city = 'London'; # 15

select * from salesorder;
select * from salesorder where orderId = 10248;
update salesorder set employeeId = null where orderId = 10248;

select * from salesorder join employee on salesorder.employeeId = employee.employeeId; /* inner join */
select * from salesorder left outer join employee on salesorder.employeeId = employee.employeeId;

/* # 16 */
select * from salesorder; # 16
select * from product;
select * from salesorder;
select * from orderdetail;
select * from orderdetail join salesorder on salesorder.orderId = orderdetail.orderId;
select * from orderdetail join salesorder on salesorder.orderId = orderdetail.orderId join product on product.productid = orderdetail.productid;
select * from orderdetail join salesorder on salesorder.orderId = orderdetail.orderId join product on product.productid = orderdetail.productid where product.discontinued = 1;
select salesorder.orderId, salesorder.shipname from orderdetail join salesorder on salesorder.orderId = orderdetail.orderId join product on product.productid = orderdetail.productid where product.discontinued = 1;
select salesorder.orderId, salesorder.shipname 
from orderdetail 
join salesorder on salesorder.orderId = orderdetail.orderId 
join product on product.productid = orderdetail.productid 
where product.discontinued = 1
order by orderId; # has two 10387 orders
select distinct(salesorder.orderId), salesorder.shipname 
from orderdetail 
join salesorder on salesorder.orderId = orderdetail.orderId 
join product on product.productid = orderdetail.productid 
where product.discontinued = 1
order by orderId; # eliminates the duplicate 10387 order

select * from employee; # 17 initial pull from employee list
select firstName from employee where mgrId is null; #17

select * from employee where firstName = 'Andrew'; # 18? null returned no Andrew listed

/* Bonus questions */
select * from customer; # 1

select * from customer where city = 'London' or city = 'Paris'; # 2

select distinct(city) from customer; # 3

/* #4 */
select distinct(firstname) from employee order by firstname ASC;
select distinct(firstname) from employee order by firstname DESC;

select avg(salary) from employee; # 5 - error no salary column in employee table

select firstname, lastname from employee where salary = max(salary); # 6 - error no salary column in employee table
select firstname, lastname from employee where city = 'London';

select * from  employee where education = 'BA'; # 7 - error no column heading for education level

/* # 8 */ 
select * from orderdetail;
select sum(quantity * unitPrice) orderTotal from orderdetail where orderId = 10248; # for single order
select sum(quantity * unitPrice) orderTotal from orderdetail; # total of all orders combined
select sum(quantity * unitPrice) orderTotal, orderId from orderdetail group by orderId; # total for each order ASC by orderId
select sum(quantity * unitPrice) orderTotal, orderId from orderdetail group by orderId order by orderTotal DESC;
select sum(quantity * unitPrice) orderTotal, orderId from orderdetail group by orderId order by orderTotal ASC;

/* # 9 */
select * from employee where hireDate > 1/1/2003; # ?

/* # 10 */
#how many years an employee has been working in years

/* # 11 */
select * from product;
select productId, unitsInStock from product order by unitsInStock ASC; # field is null
select productId, unitsInStock from product order by unitsInStock DESC; # field is null

/* # 12 */
select * from product where unitsInStock < 6; # field is null

/* # 13 */
select * from product where discontinued = 1;
select productName from product where discontinued = 1;

/* # 14 */
select * from product where productName Like '%Tofu%'; # returns null

/* # 15? */
select * from product;
select productName from product where productName = max(unitPrice);
select max(unitPrice) from product;

/* # 16? */
select * from employee where hireDate > 1/1/1993; # ?

/* # 17 */
select * from employee;
select * from employee where titleOfCourtesy = 'Ms.' or titleOfCourtesy = 'Mrs.';

/* # 18 */
select * from employee where phone like '%206%';
