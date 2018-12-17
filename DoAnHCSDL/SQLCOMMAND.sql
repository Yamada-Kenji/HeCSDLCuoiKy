create proc DangNhap @UserName nvarchar(50) , @PassWord nvarchar(50)
as
select * from Login where UserName = @UserName and PassWord = @PassWord
go

execute DangNhap YukiHai , asdasd123
go 
alter proc ThemMon @MaMon nvarchar(50) ,@TenMon nvarchar(50) , @DanhMuc nvarchar(50), @GiaTien int, @HinhAnh image , @MoTa nvarchar(1000)
as
insert into Menu values (@MaMon,@TenMon,@DanhMuc,@GiaTien,@HinhAnh,@MoTa)
go

alter proc LayTatCaDanhMuc 
as
select distinct DanhMuc from Menu 
go

alter proc LayThongTinMonAn @DanhMuc nvarchar(50)
as
select * from Menu where DanhMuc like @DanhMuc
go
select * from Menu
