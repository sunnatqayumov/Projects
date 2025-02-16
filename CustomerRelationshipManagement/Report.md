# OOP Tamoyillari
**Ushbu loyiha OOP (Object-Oriented Programming) tamoyillari asosida ishlab chiqilgan va quyidagi tamoyillarni o'z ichiga oladi:**

# 1. Abstraktsiya (Abstraction)
**Abstraktsiya orqali loyiha murakkabliklarini yashirish va faqat zaruriy funksiyalarni taqdim etish maqsadga olingan. Person abstrakt sinfi umumiy xususiyatlar va metodlarni taqdim etadi. Bu sinf CRMdagi barcha elementlar (Mijozlar, Mahsulotlar va hokazolar) uchun umumiy qoidalarga ega bo'lib, har bir turdagi element o'ziga xos xususiyatlarni taqdim etadi.**

`Kod misoli`
```
public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Position { get; set; }
}
```


# 2. Inkapsulyatsiya (Encapsulation)
**Inkapsulyatsiya ma'lumotlarni yashirish va ularga kirish huquqini cheklash orqali amalga oshirilgan. Customer va Employee sinflaridagi xususiyatlar private yoki protected darajada o'rnatilgan bo'lib, ularga faqat get/setlar orqali kirish mumkin.**

`Kod misoli`
```
public class Customer : Person, ISalable
{
    public string IDSerialNumber { get; set; }
    public string Company { get; set; }
    public decimal TotalSales { get; set; }

    public Customer(string firstName, string lastName, string email, string position, string idSerialNumber, string company)
        : base(firstName, lastName, email, position)
    {
        IDSerialNumber = idSerialNumber;
        Company = company;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {Email} - Lavozim: {Position} - ID: {IDSerialNumber} - Kompaniya: {Company} - Savdo soni: {TotalSales}";
    }
}
```


# 3. Meros olish (Inheritance)
**Meros olish orqali biz bir xil xususiyatlarga ega bo'lgan sinflarni takrorlamaslik uchun umumiy sinfdan voris olish imkoniyatidan foydalandik. Person sinfi kutubxona elementlarining umumiy xususiyatlarini o'z ichiga oladi, shuningdek, bu sinfdan Customer va Employee sinflari vorislik qiladi va umumiy xususiyatlarni oladi.**

`Kod misoli`
```
public class Customer : Person, ISalable
{
    
}
```

# 4. Polimorfizm (Polymorphism)
**Polimorfizm orqali biz bir xil metodni turli xil sinflarda har xil ko'rinishda ishlatishga muvaffaq bo'ldik. Masalan, Person sinfidagi DisplayInfo() metodini Customer va Employee sinflarida qayta yozib, ularning o'ziga xos ma'lumotlarini ko'rsatamiz.**

`Kod misoli`
```
public override void DisplayInfo()
{
    Console.WriteLine($"Name: {FirstName} LastName {LastName}, email: {Email}, Position: {Position}");
}
```

# 5. Interfeyslar va Explicit Implementations
**Loyihada interfeyslar ham qo'llangan. Masalan, ISalable interfeysi kutubxona elementlarini boshqarish uchun ishlatiladi. Explicit interface implementation orqali interfeys metodlarini faqat kerakli joyda chaqiramiz.**

`Kod misoli`
```
public interface ISalable
{
    void AddSale(decimal amount);
    decimal GetSales();
}
```

### E'tiboringiz uchun raxmat.