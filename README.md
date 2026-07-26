# 📝 Todo School Project (C# Windows Forms)

Desktop Todo Application built with **C# WinForms** and **Guna2 UI Components**. This project features Role-Based Authentication (Admin & User roles), Task Management, and Dynamic UI/UX state handling.

---

## 🌟 Features
* **Role-Based Authentication:**
  * **Admin:** View all users, toggle user account statuses (Enable/Disable), and manage system-wide tasks.
  * **User:** Create, complete, and delete personal tasks.
* **Modern UI Design:** Styled with Guna2 controls, custom DataGridView cell formatting, and responsive grid layouts.
* **In-Memory Data Store:** Uses a centralized `DataStore` pattern for seamless demo and presentation without requiring an immediate database setup.

---

## 🚀 How to Run the Project (အသုံးပြုနည်း)

### Option 1: Open with Visual Studio (For Developers)
1. Clone or Download this repository as a ZIP file.
2. Extract the ZIP file.
3. Open `Todo_School_Project.sln` with **Visual Studio 2019/2022**.
4. Restore NuGet Packages if prompted (for Guna2 UI).
5. Press **`F5`** or click **Start** to run the app.

### Option 2: Run directly from Executable (.exe)
1. Navigate to `Todo_School_Project/bin/Debug/` (or `Release/`).
2. Run `Todo_School_Project.exe`.

---

## 🔑 Demo Login Credentials (စမ်းသပ်ရန် အကောင့်များ)

| Role       | Username   | Password |
| :---       | :---       | :---     |
| **Admin**  | `admin`    | `123`    |
| **User 1** | `mgmg`     | `123`    |
| **User 2** | `aungaung` | `123`    |

---

## 🛠️ Built With
* **Language:** C# (.NET Framework)
* **UI Framework:** Windows Forms (WinForms) & Guna2 UI
* **Architecture:** In-Memory Architecture (Prepared for ADO.NET / SQL Server integration)
