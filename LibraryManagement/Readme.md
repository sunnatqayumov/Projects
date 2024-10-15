Assalamu alaykum
# LibraryManagement Loyiha

## Kompilatsiya va ishga tushirish:
    1. Loyiha papkasiga o'ting:
`cd LibraryManagement` 
 
    2. Loyihani kompilatsiya qilish uchun quyidagi buyruqni ishga tushiring:
`dotnet build`

    3. Loyihani ishga tushirish uchun quyidagi buyruqni kiriting:
`dotnet run`


## Foydalanish qo'llanmasi:
Loyihaning asosiy funksionalliklari: kitoblar ro'yxatini boshqarish, yangi kitob qo'shish, kitob ma'lumotlarini yangilash va o'chirish imkoniyatlarini ta'minlaydi.

### Asosiy buyruqlar:
- Kitob qo'shish: foydalanuvchidan kitob ma'lumotlarini kiritish va ro'yxatga qo'shish.
- Kitoblarni ko'rish: mavjud kitoblar ro'yxatini ko'rish.
- Kitobni yangilash va o'chirish: ma'lum bir kitobni yangilash yoki ro'yxatdan o'chirish.

## Xatoliklar va ularning ma'nosi:
- `NullReferenceException`: Bunday xatolik, agar obyekt e'lon qilingan bo'lsa, ammo unga qiymat berilmagan bo'lsa yuzaga keladi. Bu xatoni hal qilish uchun obyektni null emasligiga ishonch hosil qiling.
- `IndexOutOfRangeException`: Bu xatolik massiv yoki ro'yxat elementiga kirishda noto'g'ri indeksdan foydalanilganda yuzaga keladi. Indeksning to'g'riligini tekshirish kerak.