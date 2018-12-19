create proc DangNhap @UserName nvarchar(50) , @PassWord nvarchar(50)
as
select * from Login where UserName = @UserName and PassWord = @PassWord
go

execute DangNhap YukiHai , asdasd123
go 
create proc ThemMon @TenMon nvarchar(50) , @DanhMuc nvarchar(50), @GiaTien int, @HinhAnh image , @MoTa nvarchar(1000)
as
insert into Menu values (@TenMon,@DanhMuc,@GiaTien,@HinhAnh,@MoTa)
go

create proc LayTatCaDanhMuc 
as
select distinct DanhMuc from Menu 
go

select * from Menu where DanhMuc = 'Coffe'