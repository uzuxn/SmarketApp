create database UMarketDB


use UMarketDB
go
--------------------

create table tblUsers
(
userid int identity(1,1) primary key,
username varchar(50),
upass varchar(50),
uname varchar(50),
uphone varchar(50),
)
select * from tblUsers
insert into tblUsers values('Uzman','2797','Uzman Fairoos','0784818897')
insert into tblUsers values('Dewmi','1234','Dewmi Vihara','0711706976')
insert into tblUsers values('Ishira','2222','Ishira Ojitha','0792818897')

select userid,username,upass,uname,uphone from tblUsers where username='Uzman' and upass='2797'


create procedure sp_Userlog
(
@username varchar(50),
@upass varchar(50)
)
as
begin
select userid,username,upass,uname,uphone from tblUsers where username=@username and upass=@upass
end
go
select * from tblUsers
--------------

create table tblCategory
(
cateId int identity(1,1) primary key,
cateName varchar(50)
)

---------------

create procedure sp_loadCategory
(
@cateName varchar(50)
)
as
begin
select cateId as id,cateName as name from tblCategory where cateName like '%'+ @cateName +'%'
end
go
--------
select * from tblCategory
--------------
create procedure sp_addCategory
(
cateId int=0,
cateName varchar(50)
)
as
begin
insert into tblCategory(cateName) values (@cateName)
end
go
---------
create procedure sp_addCategory
(
@cateId int=0,
@cateName varchar(50)  
)
as
begin
insert into tblCategory (cateName) values (@cateName)
end
go
---------

select * from tblCategory
insert into tblCategory(cateName) values('Tea')
insert into tblCategory(cateName) values('Coffee')
insert into tblCategory(cateName) values('Milk Tea')

------------

create procedure sp_updateCategory
(
@cateId int=0,
@cateName varchar(50)=null
)
as
begin
update tblCategory set cateName=@cateName where cateId=@cateId
end
go
------
select * from tblCategory

create procedure sp_AddCate
(
@cateId int=0,
@cateName varchar(50)=null
)
as
begin
insert into tblCategory (cateName) values (@cateName)
end
go

-------
create procedure sp_UpdateCate
(
@cateId int=0,
@cateName varchar(50)=null
)
as
begin
update tblCategory set cateName=@cateName where cateId=@cateId
end
go

-------

create procedure sp_DeleteCate
(
@cateId int
)
as
begin
delete from tblCategory where cateId=@cateId
end
go

--------------

create table tblOrders
(
OrdId int identity(1,1) primary key,
OrdName varchar(50)
)
select * from tblOrders

--------

create procedure sp_AddOrd
(
@OrdId int = 0,
@OrdName varchar(50)
)
as
begin
Insert into tblOrders(OrdName) values(@OrdName)
end
go

-------------------

create procedure sp_UpdateOrd
(
@OrdId int = 0,
@OrdName varchar(50)
)
as
begin
Update tblOrders set OrdName=@OrdName where OrdId=@OrdId
end
go

----------

create procedure sp_DeleteOrd
(
@OrdId int = 0
)
as
begin
delete from tblOrders where OrdId=@OrdId
end
go

----------------

create table tblStaff
(
StaffId int identity(1,1) primary key,
SName varchar(50),
SPhone varchar(15),
SRole varchar(50)
)
select StaddId,SName,SPhone,SRole from tblStaff where SName

create procedure sp_AddStaff
(
@staffid int = 0,
@sname varchar(50),
@sphone varchar(15),
@srole varchar(50)
)
as
begin
insert into tblStaff(SName,SPhone,SRole) values (@sname,@sphone,@srole)
end
go

-----------

create procedure sp_UpdateStaff
(
@staffid int = 0,
@sname varchar(50)=null,
@sphone varchar(15)=null,
@srole varchar(50)=null

)
as
begin
Update tblStaff set SName=@sname,SPhone=@sphone,SRole=srole where StaffId=@staffid
end
go

-------------

create procedure sp_DeleteStaff
(
@staffid int = 0,
@sname varchar(50)=null,
@sphone varchar(15)=null,
@srole varchar(50)=null

)
as
begin
delete from tblStaff where StaffId=@staffid
end
go

-----------------

create table tblProducts
(
PId int identity(1,1) Primary key,
PName varchar(100),
PPrice float,
CategoryId int,
PImage image
)

------------------
select p.PId,p.PName,p.PPrice,p.CategoryId,p.PImage from tblProducts p inner join tblCategory c on c.cateId=p.CategoryId where p.PName

create procedure sp_AddProduct
(
@pid int = 0,
@pname varchar(100),
@pprice float,
@categoryid int,
@pimage image
)
as
begin
insert into tblProducts(PName,PPrice,CategoryId,PImage) values (@pname, @pprice, @categoryid,@pimage)
end
go

---------------

create procedure sp_UpdateProduct
(
@pid int = 0,
@pname varchar(100)=null,
@pprice float=null,
@categoryid int=null,
@pimage image=null
)
as
begin
Update tblProducts set PName=@pname,PPrice=@pprice,CategoryId=@categoryid,PImage=@pimage where PId=@pid
end
go


-----------------

create procedure sp_DeleteProduct
(
@pid int = 0 
)
as
begin
delete from tblProducts where PId=@pid
end
go

----------------

select p.PId,p.PName,p.PPrice,c.cateName,p.CategoryId,p.PImage from tblProducts p 
inner join tblCategory c on c.cateId=p.CategoryId where p.PName like '%" + txtsearch.Text + "%' 

select * from tblProducts