Hướng dẫn mở và chạy một project ASP.NET Web Forms đã tải xuống từ GitHub
  - Bước 1: Nhấp vào nút "Code" và chọn "Download ZIP" để tải xuống toàn bộ project dưới dạng file ZIP.
  - Bước 2: Giải nén file ZIP vào một thư mục trên máy tính của bạn.
  - Bước 3: Mở Visual Studio -> Chọn File -> Open -> Project/Solution.
  - Bước 4: Duyệt tới thư mục chứa project mà bạn vừa giải nén, chọn file .sln (solution file) và nhấp "Open".
  - Bước 5:  Khôi phục các gói NuGet (nếu cần)
      + Bước 5.1: Trong Solution Explorer, nhấp chuột phải vào Solution hoặc Project và chọn Manage NuGet Packages.
      + Bước 5.2: Nếu có thông báo cần khôi phục các gói, nhấp vào Restore để tải về các gói NuGet cần thiết cho project.
  - Bước 6: Nếu project kết nối với cơ sở dữ liệu, bạn có thể cần cập nhật chuỗi kết nối (connection string) trong file Web.config, Mở file Web.config và tìm mục <connectionStrings> để đảm bảo rằng thông tin kết nối là chính xác đối với môi trường của bạn.
  - Bước 7: Nhấp chuột phải vào Solution trong Solution Explorer và chọn Build Solution.
  - Bước 8: Nhấp vào nút IIS Express hoặc Local Machine (nút xanh lá cây trên thanh công cụ) để chạy project.

