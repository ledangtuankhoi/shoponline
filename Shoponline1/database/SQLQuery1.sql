use ShopOnline
go
CREATE TABLE Banners (
    id bigint IDENTITY(1,1) PRIMARY KEY,
    title nvarchar(255) NOT NULL,
    content ntext,
    action varchar(10) NOT NULL CHECK (action IN('blog', 'product', 'brand')),
	hide bit default 'true',
	img nvarchar(50) not null,
	status varchar(10) not null check (status in('banner','promo','slider')),
	[order] int 
	)
go
create table Brands(
	id bigint identity(1,1) primary key,
	name nvarchar(50),
	logo varchar(50),
	img varchar(50),
	description ntext,
	[order] int,
	hide bit default 'true'
)
go
create table Footers(
	sumary ntext,
	title nvarchar(50),
	icon varchar(50),
	link ntext,
	hide int
)

