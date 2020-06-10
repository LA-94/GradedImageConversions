# GradedImageConversions
Данная программа реализованна в рамках лабораторной работы, решающая задачу по преобразованию изображений на С# с графическим интерфейсом со следующими требованиями:
  1. Преобразование изображения в негатив
  2. Логарифмическое преобразование (ввод константы "с" осуществляется с клавиатуры)
  3. Степенные преобразования (гамма-коррекция) (ввод константы "c" и "γ" осуществляется с клавиатуры)
  4. Кусочно-линейные функции преобразований (вырезание диапазона яркостей):
      - Первый подход состоит в отображении всех тех уровней, которые представляют интерес, некоторым одним значением (скажем, белым), а всех остальных уровней — другим (скажем, черным), в результате это дает двухградационное изображение.
      - Второй подход, повышает (или понижает) яркость точек из выбранного диапазона, но сохраняет яркости фона и остальных точек изображения.
