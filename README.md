# Login Form – Validation với ErrorProvider

Bài tập Windows Forms (C#): xây dựng form đăng nhập có ẩn/hiện mật khẩu, kiểm tra dữ liệu bắt buộc bằng `ErrorProvider`, và gán phím tắt Enter/Esc.

## Đề bài

Xây dựng Login Form có Validation ErrorProvider, ẩn mật khẩu, gán AcceptButton/CancelButton.

## Yêu cầu và cách đáp ứng

| Yêu cầu | Cách thực hiện |
|---|---|
| Giao diện gồm `txtUsername`, `txtPassword`, `chkShowPassword`, `btnLogin`, `btnExit`, `errorProvider` | Khai báo đầy đủ trong `Form1.Designer.cs` |
| Phím Enter kích hoạt `btnLogin`, phím Esc kích hoạt `btnExit` | `this.AcceptButton = btnLogin;` và `this.CancelButton = btnExit;` |
| Tick `chkShowPassword` → hiện mật khẩu | `chkShowPassword_CheckedChanged` set `UseSystemPasswordChar = false` |
| Bỏ tick → ẩn mật khẩu (`*`) | `UseSystemPasswordChar = true` |
| Không để trống Tên đăng nhập & Mật khẩu | `ValidateInputs()` dùng `errorProvider.SetError()` báo lỗi khi rỗng |

## Công nghệ

- C# / .NET Windows Forms

## Cấu trúc project

```
LoginFormApp/
├── Form1.cs              # Xử lý logic: show/hide password, validate, click events
├── Form1.Designer.cs     # Khai báo control, layout, AcceptButton/CancelButton
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Cách chạy

1. Mở Visual Studio → **File > New Project** → chọn **Windows Forms App (.NET)**.
2. Đặt tên project là `LoginFormApp` (trùng namespace trong code).
3. Thay nội dung 3 file `Form1.cs`, `Form1.Designer.cs`, `Program.cs` bằng code trong repo.
4. Nhấn **F5** để chạy.

## Kết quả

- Bỏ trống ô Tên đăng nhập hoặc Mật khẩu rồi bấm Đăng nhập → hiện icon lỗi đỏ cạnh ô tương ứng.
- Nhập đủ thông tin, bấm Enter → đăng nhập; bấm Esc → thoát chương trình.
- Tick vào "Hiện mật khẩu" → ô mật khẩu hiện chữ thật thay vì dấu `*`.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="915" height="420" alt="Screenshot 2026-09-24 152615" src="https://github.com/user-attachments/assets/b88deee6-637e-4b1a-a568-d21e01b73f60" />

