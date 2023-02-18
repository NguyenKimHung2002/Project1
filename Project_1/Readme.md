Chương trình quản lý và thu thập dữ liệu khách hàng
Nguyễn Kim Hùng, MSSV: 20200260

1. Yêu cầu
SQL Server phiên bản 2022 hoặc mới hơn, chọn phiên bản phù hợp với hệ điều hành và cấu hình máy tính của bạn.

SQL Server Management Studio (SSMS) phiên bản 2019 hoặc mới hơn.

IDE khuyến nghị để chạy chương trình: Visual Studio IDEA phiên bản 2022 hoặc mới hơn.
Nếu phiên bản hiện tại thấp hơn phiên bản yêu cầu, vui lòng cập nhật lên phiên bản mới nhất.

2. Cấu hình SQL Server
Kích hoạt tài khoản xác thực SQL Server

Đảm bảo rẳng khởi động lại dịch vụ SQL Server sau khi cấu hình.

2.1. Thay đổi Authentication mode:
Thực hiện theo từng bước dưới đây để sử dụng SQL Server Authentication.

Đăng nhập vào SQL Server sử dụng SQL Server Management Studio (SSMS). Nếu chưa từng cấu hình trước đó, vui lòng kích hoạt Windows Authentication in the "Authentication", click chọn OK.
Chuột phải vào Tên SQL Server của bạn, mở Properties.
Trên trang Server Properties, click chọn Security. Kích hoạt SQL Server and Windows Authentication in the "Authentication".
Dưới "Server Proxy Account", click chọn Enable Proxy Account, tại "Proxy Account" ghi sa và tạo một mật khẩu bảo mật, sau đó click OK.
2.2 Kích hoạt tài khoản SQL Server Authentication:
Kết nối tới giao diện SQL Server bằng cách sử dụng SQL Server Management Studio (SSMS) và chọn Security > mở thư mục Logins.
Click phải chuột vào tài khoản sa, mở Properties.
Ở đầu trang Status, bật cài đặt "Login" cho "Account". Click chọn OK.
Restart và login tới giao diện SQL Server trong SSMS sử dụng chế độ SQL Server Authentication với tài khoản được tạo. Nếu xảy ra lỗi, thử restart lại máy.
2.3 Kích hoạt giao thức TCP/IP
Mở SQL Server Configuration Management: Windows > tìm kiếm configuration > chọn SQL Server Configuration Management. Nếu bạn không tìm thấy, đi tới Windows > Run > Thêm đường dẫn C:\Windows\SysWOW64\SQLServerManager16.msc và nhấn OK, có thể tham khảo thêm từ SQL Server Configuration Management.
Chọn SQL Server Network Configuration tab, chọn the protocol of the SQL Server giao diện hiện tại đang sử dung (thông thường dịch vụ ở trạng thái Running State).
Click phải chuột vào TCP/IP protocol, mở Properties, thay đổi kích hoạt cài đặt thành Yes.
Đi tới ID Addresses tab, trong cài đặt "IPAll" (ở cuối trang), chỉnh kiểu 1433 trong TCP Port. click chọn OK.
3. Chạy chương trình
3.1. Tạo cơ sở dữ liệu
Mở SQL Server Management Studio (SSMS) > Login > New Query > thực thi file Project1_DB.sql

3.2. Chỉnh sửa đường dẫn tới Database
Đi tới file config chỉnh sửa theo tên server của bạn

Ví dụ:
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
	<connectionStrings>
		<add name="conn" connectionString="server=LAPTOP-UAFG5AK0\KIMHUNG; database=Project1_DB; user id=sa; password=kimhung29042002"/>
	</connectionStrings>
</configuration>
```
