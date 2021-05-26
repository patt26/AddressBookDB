create database Address_Book
use Address_Book

create table Address_Book1
(
 id int identity (1,1) primary key,
 FirstName varchar(150) not null,
 LastName varchar (150) not null,
 Address varchar (200) not null,
 City varchar (100) not null,
 State varchar (100) not null,
 ZIP_Code varchar(6)  not null,
 Phone_Number varchar(13)  not null,
 Email_ID varchar (50) not null
)
select * from Address_Book1

insert into Address_Book1 values
('Hannah', 'Annois','Buenos Aires 9134','Portland','Pennsylvania','972405','7242405628','hnoice@yep.co.in'),
('Keith' , 'Burgess','4170  Old Dear Lane','Diamond','Oregon','975722','8457917396','keithbur@hotmail.com'),
('James','Barnes','4716 Farm Meadow Drive','St Michaels','Los Santos','864511','9288105505','v7wzjuo0fu@temporary-mail.net'),
('Robert','Johnson','2112  Marigold Lane','Fort Lauderdale','Meryland','336311','3053893665','0vq3qmis40es@temporary-mail.net'),
('Nandin','Sethi','99 , Vijaykar Wadi, S V Road, Opp I B P Petrol Pump, Malad (west)',' Mumbai','Maharashtra','400064','02228885287','37p4vbp29ra@temporary-mail.net');
select * from Address_Book1

update Address_Book1 set Phone_Number='0227896583' , Email_ID= 'Nandinsethi28@hotmail.com' where FirstName='Nandin';
select * from Address_Book1

delete from Address_Book1 where LastName='Barnes';
select * from Address_Book1

select FirstName ,LastName from Address_Book1 where State='oregon';
select * from Address_Book1

select count(FirstName) from Address_Book1 where city='portland'
select * from Address_Book1

select * from Address_Book1 where State='oregon' order by FirstName
select * from Address_Book1

alter table Address_Book1 add Book_Name char(50), Type char(50)
select * from Address_Book1
update Address_Book1 set Book_Name='Relative' where FirstName='Keith' or FirstName='Robert';
update Address_Book1 set Book_Name='Office',Type='Professional' where State= 'Maharashtra'
update Address_Book1 set Book_name='School',Type='Friend' where City='Portland'
update Address_Book1 set type='Family' where ZIP_Code='336311'
select * from Address_Book1

select count (FirstName) from Address_Book1 where type='friend'
select * from Address_Book1

insert into Address_Book1 values
('Jhon','Adams','26 Las Santos','Avenu5','Cleavland','268493','597384268','adamsJ@reddit.com','Collage','Teacher')
select * from Address_Book1