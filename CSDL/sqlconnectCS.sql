--tao bang
-- them cot
-- them du lieu
-- update du lieu
-- delete du lieu

--tao csdl
create database QLySV
go

use QLySV
go
--tao bang SV
create table SV(
	id int not null identity,
	msv int not null primary key,
	ten nvarchar(50) not null ,
	lop nvarchar(5)
	)

	go
--tao bang diem

create table diem(
	
	msv int not null primary key,
	diemToan float,
	diemVan float,
	constraint FK_msv foreign key (msv) references SV(msv)--rang buoc khoa ngoai
	)
	go

	insert into SV
	values(92351, 'Thanh', 'CNT')

	insert into SV
	values(92468, 'Manh', 'CNT')

	insert into diem 
	values(92351, 10, 10)

	insert into diem
	values(92468, 10, 10)
	select * from SV

	select count(*) from SV where msv = '92351' and ten = 'Thanh'
	--sql injection






