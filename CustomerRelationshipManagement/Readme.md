# Assalamu alaykum
## CRM Management consol loyiha

### Tushuntirish:
Bu loyiha mijozlar va ularning savdolarini boshqarish uchun yaratilgan CRM tizimi.

### Loyihani Kompilatsiya Qilish va Ishga Tushirish:
Kodni ishga tushirishdan avval `Spectre.Console`ni terminal orqali loyihaga qoshilgan bo'lishi kerak.

# Ishga tushirish:
1. loyiha papkasiga oting:
```bash
cd CustomerRelationshipManagement
```

2. Loyihani kompilatsiya qilish uchun quyidagi buyruqni ishga tushiring:
```bash
dotnet build
```

3. Loyihani ishga tushirish uchun quyidagi buyruqni kiriting:
```bash
dotnet run
```

# Loyihani ishlatish qo'llanmasi:

### Bosh menyu:
 - `Mijozlar`: Mijozlarni qo'shish, yangilash va o'chirish mumkin.
 - `mahsulotlar`: Mahsulotlar va savdolarni boshqarish va savdoni yangilash mumkin.
 - `Mijozlarni ko'rish`: Ro'yxatdagi barcha mijozlarni ko'rish.
 - `Mahsulotlarni ko'rish`: Mahsulotlar haqida ma'lumotlarni ko'rish.
 - `Qidirish`: Mijozlarni ism, familiya, email yoki ID seria raqami bo'yicha qidirish.
 - `Muhim savdolar`: muhim savdolarni ko'rsatish va savdolarni narx bo'yicha saralash.
 - `chiqish`: Tizimdan butunlay chiqish.

### Ichma-ich menyu:
Har bir bo'limni tanlash uchun kursor tugmalaridan foydalaning va kerakli joyda `Enter` tugmasini bosing.

1. *Mijozlar*
 - `Mijozlarni qo'shish:` Mijozning ismi, familiyasi, email pochtasi, ID seriya raqami, Kompaniya nomini kiritishingiz kerak bo'ladi.
 - `Mijoz yangilash:` Yangilanishi kerak bo'lgan mijozning emailini kiritasiz. `Mijozni qo'shish`dagi har bir maydon uchun yangi qiymat kiritasiz.
 - `Mijoz o'chirish:` O'chirilishi kerak bo'lgan mijozning emailini kiritasiz.
2. *Mahsulotlar*
 - `Savdoni ro'yxatdan o'tkazish:` Savdosi ro'yxatga olinishi kerak bo'lganmijozning emailini kiritiladi, mahsulotning miqdori kiritiladi.
 - `Savdoni yangilash: ` Yangilanishi kerak bo'lgan mahsulot nomi kiritiladi.
3. *Mijozlarni ko'rish*
 - Barcha ro'yxatga olingan mijozlarni Jadval ko'rinishida `spectre.Console` orqali chiqariladi.
4. *Mahsulotlarni ko'rish*
 - Barcha ro'yxatga olingan mahsulotlarni Jadval ko'rinishida `Spectre.Console` orqali chiqariladi.
5. *Qidirish*
 - Mijozni ismi, familiyasi, email adresi yoki ID seriya raqami orqali qidirish.
6. *Muhim savdolar*
 - Eng narxi qimmat savdolar haqida ma'lumot.
7. *Chiqish*
 - Dasturdan chiqish.

# Loyihada yuzaga kelgan muammolar:

1. *Mahsulotlarni ko'rish menyusida hali kamchiliklari bor.*
2. *Muhim savdolar menyusida ham hali kamchiliklari bor.*

### E'tiboringiz uchun raxmat.