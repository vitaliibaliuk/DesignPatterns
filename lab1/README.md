# Lab 1 code review
## 1.DRY 
В проєкті я забезпечив відсутність повторень в коді, використовуючи класи та методи в класах
## 2.KISS 
Структура в проєкті є простою, відсутні ускладнення
## 3.SOLID
Класи відкриті для розширення та закриті для змін
## 4.YAGNI
Кожен клас і метод, що є в проєкті, використовується відповідно до Технічного завдання. Методи, які не використовуються або є зайвими, відсутні.
## 5.Composition Over Inheritance
Замість успадкування використовується компілювання класів, використовуючи об'єкти класу як поля в більших класах. Приклад композиції у класі [Warehouse](./lab1/.vs/lab1task/lab1task/lab1classes/Warehouse.cs#L11C1-L17C10)
## 6.Program to Interfaces not Implementations
В проєкті не використовуються інтерфейси, оскільки проєкт не потребує великої гнучкості
## 7.Fail Fast
При створенні кожного класу, відбувалася його перевірка для забезпечення її ефективності
