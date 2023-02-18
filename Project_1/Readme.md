# Chương trình quản lý và thu thập dữ liệu khách hàng
*Nguyễn Kim Hùng, MSSV: 20200260*


# 1. Yêu cầu
[SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) phiên bản 2022 hoặc mới hơn,
chọn phiên bản phù hợp với hệ điều hành và cấu hình máy tính của bạn.

[SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) phiên bản 2019 hoặc mới hơn.

### IDE khuyến nghị để chạy chương trình: [Visual Studio IDEA](https://visualstudio.microsoft.com/fr/downloads/) phiên bản 2022 hoặc mới hơn.

*Nếu phiên bản hiện tại thấp hơn phiên bản yêu cầu, vui lòng cập nhật lên phiên bản mới nhất.*

# 2. Cấu hình SQL Server 

Kích hoạt tài khoản xác thực SQL Server

Đảm bảo rẳng khởi động lại dịch vụ SQL Server sau khi cấu hình.

### 2.1. Thay đổi Authentication mode:

Thực hiện theo từng bước dưới đây để sử dụng SQL Server Authentication.

1. Đăng nhập vào SQL Server sử dụng SQL Server Management Studio (SSMS). Nếu chưa từng cấu hình trước đó, 
vui lòng kích hoạt `Windows Authentication` in the "Authentication", click chọn `OK`.
2. Chuột phải vào `Tên SQL Server` của bạn, mở `Properties`.
3. Trên trang `Server Properties`, click chọn `Security`. Kích hoạt `SQL Server and Windows Authentication` in the "Authentication".
4. Dưới "Server Proxy Account", click chọn `Enable Proxy Account`, tại "Proxy Account" ghi `sa` và tạo một `mật khẩu` bảo mật, sau đó click `OK`.

### 2.2 Kích hoạt tài khoản SQL Server Authentication:

1. Kết nối tới giao diện SQL Server bằng cách sử dụng SQL Server Management Studio (SSMS) và chọn `Security` > mở thư mục `Logins`.
2. Click phải chuột vào tài khoản `sa`, mở `Properties`.
3. Ở đầu trang `Status`, bật cài đặt "Login" cho "Account". Click chọn `OK`.
4. `Restart` và `login` tới giao diện SQL Server trong SSMS sử dụng chế độ `SQL Server Authentication` với tài khoản được tạo. Nếu xảy ra lỗi, thử `restart` lại máy.

### 2.3 Kích hoạt giao thức TCP/IP
1. Mở SQL Server Configuration Management: `Windows` > *tìm kiếm* configuration > chọn `SQL Server Configuration Management`.
   Nếu bạn không tìm thấy, đi tới `Windows` > `Run` > Thêm đường dẫn `C:\Windows\SysWOW64\SQLServerManager16.msc` và nhấn `OK`, có thể tham khảo thêm từ [SQL Server Configuration Management](https://learn.microsoft.com/en-us/sql/relational-databases/sql-server-configuration-manager?view=sql-server-ver16).
2. Chọn `SQL Server Network Configuration` tab, chọn `the protocol of the SQL Server` giao diện hiện tại đang sử dung (thông thường dịch vụ ở trạng thái Running State).
3. Click phải chuột vào `TCP/IP protocol`, mở `Properties`, thay đổi kích hoạt cài đặt thành `Yes`.
4. Đi tới `ID Addresses` tab, trong cài đặt "IPAll" (ở cuối trang), chỉnh kiểu `1433` trong TCP Port. click chọn `OK`.

# 3. Chạy chương trình

### 3.1. Tạo cơ sở dữ liệu

`Mở` SQL Server Management Studio (SSMS) > `Login` > `New Query` > _thực thi file [Project1_DB.sql](/Project1_DB.sql)_

### 3.2. Chỉnh sửa đường dẫn tới Database

Đi tới [file config](App.config) chỉnh sửa theo tên server của bạn

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