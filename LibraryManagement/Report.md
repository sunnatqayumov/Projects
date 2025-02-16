OOP Tamoyillari
Ushbu loyiha OOP (Object-Oriented Programming) tamoyillari asosida ishlab chiqilgan va quyidagi tamoyillarni o'z ichiga oladi:

1. Abstraktsiya (Abstraction)
Abstraktsiya orqali loyiha murakkabliklarini yashirish va faqat zaruriy funksiyalarni taqdim etish maqsadga olingan. LibraryItem abstrakt sinfi umumiy xususiyatlar va metodlarni taqdim etadi. Bu sinf kutubxonadagi barcha elementlar (kitoblar, jurnallar va hokazolar) uchun umumiy qoidalarga ega bo'lib, har bir turdagi element o'ziga xos xususiyatlarni taqdim etadi.

`Kod misoli`
public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }

    public abstract void DisplayInfo();
}


2. Inkapsulyatsiya (Encapsulation)
Inkapsulyatsiya ma'lumotlarni yashirish va ularga kirish huquqini cheklash orqali amalga oshirilgan. Book va Magazine sinflaridagi xususiyatlar private yoki protected darajada o'rnatilgan bo'lib, ularga faqat get/setlar orqali kirish mumkin.

`Kod misoli`
public class Book : LibraryItem, IBorrowable, ISearchable
{
    private bool isBorrowed;
    
    public bool IsBorrowed
    {
        get { return isBorrowed; }
        private set { isBorrowed = value; }
    }
    
    void IBorrowable.Borrow() { }
    void IBorrowable.Return() { }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Title} by {Author}, Published in {PublicationYear}. ISBN: {ISBN}");
    }
}


3. Meros olish (Inheritance)
Meros olish orqali biz bir xil xususiyatlarga ega bo'lgan sinflarni takrorlamaslik uchun umumiy sinfdan voris olish imkoniyatidan foydalandik. LibraryItem sinfi kutubxona elementlarining umumiy xususiyatlarini o'z ichiga oladi, shuningdek, bu sinfdan Book va Magazine sinflari vorislik qiladi va umumiy xususiyatlarni oladi.

`Kod misoli`
public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Magazine: {Title}, Issue: {IssueNumber}, Published in {PublicationYear}. ISBN: {ISBN}");
    }
}


4. Polimorfizm (Polymorphism)
Polimorfizm orqali biz bir xil metodni turli xil sinflarda har xil ko'rinishda ishlatishga muvaffaq bo'ldik. Masalan, LibraryItem sinfidagi DisplayInfo() metodini Book va Magazine sinflarida qayta yozib, ularning o'ziga xos ma'lumotlarini ko'rsatamiz.

`Kod misoli`
public override void DisplayInfo()
{
    Console.WriteLine($"{Title} by {Author}, Published in {PublicationYear}. ISBN: {ISBN}");
}


5. Interfeyslar va Explicit Implementations
Loyihada interfeyslar ham qo'llangan. Masalan, IBorrowable va ISearchable interfeyslari kutubxona elementlarini boshqarish uchun ishlatiladi. Explicit interface implementation orqali interfeys metodlarini faqat kerakli joyda chaqiramiz.

`Kod misoli`
public interface IBorrowable
{
    void Borrow();
    void Return();
}

public class Book : LibraryItem, IBorrowable, ISearchable
{
    void IBorrowable.Borrow()
    {
        // Borrow
    }

    void IBorrowable.Return()
    {
        // Return
    }
}


6. Metod Overloading va Overriding
Library sinfida AddItem() metodini overload qilish orqali bir nechta element qo'shish imkoniyatini taqdim etamiz. Book va Magazine sinflarida ToString() metodini overriding qilish orqali ularning batafsil ma'lumotlarini ko'rsatish imkonini yaratamiz.

`Kod misoli`
public void AddItem(Book book)
{
    books.Add(book);
}

public void AddItem(Magazine magazine)
{
    magazines.Add(magazine);
}

public override string ToString()
{
    return $"{Title} by {Author}, ISBN: {ISBN}";
}
