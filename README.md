# Entity Framework ile Finans Yönetim Sistemi
Bu proje, kişisel finans yönetimi için bir veritabanı sistemidir. Kullanıcıların harcamalarını, faturalarını ve banka işlemlerini yönetmelerine yardımcı olur. 

## Kullanılan Teknolojiler

⁕Veritabanı Yönetim Sistemi: SQL Server

⁕Programlama Dili: C#

⁕ORM: Entity Framework(Database First)

## Veritabanı Modelleri

Veritabanı aşağıdaki tabloları içermektedir:

⁕Users: Kullanıcı bilgilerini saklar (UserId, UserName, Password)

⁕Categories: Harcama kategorilerini içerir (CategoryId, CategoryName)

⁕Spendings: Harcamalar tablosu (SpendingId, SpendingTitle, SpendingAmount, SpendingDate, CategoryId)

⁕Bills: Fatura bilgilerini saklar (BillId, BillTitle, BillAmount, BillPeriod)

⁕Banks: Banka hesap bilgilerini içerir (BankId, BankAccountNumber, BankTitle, BankBalance)

⁕BankProcesses: Banka işlemlerini içerir (BankProcessId, Description, ProcessDate, ProcessType, Amount, BankId)

## Ekran Görüntüleri
### Login Formu
![image](https://github.com/user-attachments/assets/fa6f2657-8bde-4870-9932-27fa1dcff5bd)

### Yeni Kayıt Formu
![image](https://github.com/user-attachments/assets/c6aa68ba-f31a-460f-9958-44a7e32b68e5)

### Ödemeler/Faturalar Formu
![image](https://github.com/user-attachments/assets/cb89bde4-2b91-4baa-9eab-fa3ca9c9aa5e)

### Dashboard Formu
![image](https://github.com/user-attachments/assets/ac8cc9eb-054a-4cab-a975-aa8c3b3a4c6e)

### Banka Hareketleri Formu
![image](https://github.com/user-attachments/assets/8495e055-e120-40a4-8458-e5ed22129333)

### Bankalar Formu
![image](https://github.com/user-attachments/assets/baa2b41b-bf17-43f4-bd2a-0bc9e01e74d1)

### Kategoriler Formu
![image](https://github.com/user-attachments/assets/10e518c1-b129-40a5-af34-25116c70f7f5)

### Giderler Formu
![image](https://github.com/user-attachments/assets/1022b495-00d7-462d-b0b1-109195d17265)



