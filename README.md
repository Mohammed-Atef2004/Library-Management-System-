# 📚 Library Management System Web Application

A full-featured Library Management System built using **ASP.NET Core MVC** with **role-based access control**, supporting full **CRUD operations** for managing books.

---

## 🚀 Features

- 🧑‍💼 **Admin Role**:
  - Add new books
  - Edit existing book details
  - Delete books
  - View all books

- 👤 **User Role**:
  - View list of books
  - View book details

- 🔐 **Authentication & Authorization**:
  - Role-based access control
  - Session-based login system

- 💡 Clean and modern Bootstrap 5 UI
- 📦 Responsive design (works across desktop, tablet, and mobile)

---

## 🛠️ Built With

- [ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [Bootstrap 5](https://getbootstrap.com/)
- C#
- HTML, Razor Pages

---

## 🖼️ Screenshots

> You can upload screenshots to GitHub and reference them here:

[Home Page]<img width="1329" height="617" alt="image" src="https://github.com/user-attachments/assets/f7154e53-2dc0-43bb-bf72-dc331f128b9d" />
[Register Page] <img width="1337" height="604" alt="image" src="https://github.com/user-attachments/assets/f1721340-f347-463f-8798-4b0f695e9143" />
[Login Page] <img width="1337" height="605" alt="image" src="https://github.com/user-attachments/assets/4a0cd54c-d306-4880-af72-1c7f9111a091" />
[Book List]<img width="1345" height="606" alt="image" src="https://github.com/user-attachments/assets/4435e75a-1f03-4820-8e69-cf065b94cda3" />


---

## 📂 Project Structure

```bash
Library-Management-System/
│
├── Controllers/
│   └── AccountController.cs
│   └── BookController.cs
|   └── HomeController.cs
│
├── Models/
│   └── User.cs
│   └── Book.cs
│
├── Views/
│   └── Account/
│   └── Book/
│   └── Shared/
│   └── Home/
│
├── wwwroot/
│
├── appsettings.json
└── Program.cs
```

---

## ⚙️ Setup & Run Locally

1. **Clone the repo**

```bash
git clone https://github.com/Mohammed-Atef2004/Library-Management-System-.git
```

2. **Open in Visual Studio**

3. **Run the application** using IIS Express or `dotnet run`.

4. **Default Roles:**
   - Admin (can create, edit, delete)
   - User (can only view)

> You may initialize the database manually or seed it with data using EF migrations.

---

## 📌 TODOs / Future Enhancements

- ✅ Add search and filter functionality
- ✅ Hash passwords for better security
- ⏳ Implement registration confirmation via email
- ⏳ Add pagination to book list
- ⏳ Deploy to Azure or render.com

---

## 🙋 Author

**Mohammed Atef Moselhy**  
📧 mohammed_atef.1@gmail.com  
🔗 [LinkedIn](https://www.linkedin.com/in/mohammed-atef-/)  
🔗 [GitHub](https://github.com/Mohammed-Atef2004)
---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
