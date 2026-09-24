# Nguyễn Duy Tuấn - 24810310492
## Login Form – Validation với ErrorProvider
## Bai 4.1

## Cấu trúc project

```
LoginFormApp/
├── Form1.cs              # Xử lý logic: show/hide password, validate, click events
├── Form1.Designer.cs     # Khai báo control, layout, AcceptButton/CancelButton
├── Program.cs            # Điểm khởi chạy ứng dụng
└── README.md
```

## Kết quả

- Bỏ trống ô Tên đăng nhập hoặc Mật khẩu rồi bấm Đăng nhập → hiện icon lỗi đỏ cạnh ô tương ứng.
- Nhập đủ thông tin, bấm Enter → đăng nhập; bấm Esc → thoát chương trình.
- Tick vào "Hiện mật khẩu" → ô mật khẩu hiện chữ thật thay vì dấu `*`.

<!-- Chèn ảnh chụp màn hình giao diện thực tế vào đây, ví dụ: -->
<img width="915" height="420" alt="Screenshot 2026-09-24 152615" src="https://github.com/user-attachments/assets/b88deee6-637e-4b1a-a568-d21e01b73f60" />

