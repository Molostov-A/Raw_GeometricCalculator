# GeometricCalculator
Мини-библиотека для поставки внешним клиентам (для проверки использовал консольный интерфейс), которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно обращал внимание на:
- Легкость добавления других фигур
- Лёгкость добавления новых функций к каждому типу фигуры
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Добавил проверку на то, является ли треугольник прямоугольным
- Юнит-тесты (покрыты не все функции)
----
Добавил Web-Api, в которое можно отпралять json POST запрос в виде:
```json
{
    "values" : ["double", ...]
}
```
Получаем json ответ следующего типа
```json
{
    "type": "rectangle",
    "sides": [
        3,
        5
    ],
    "square": 15,
    "failedMassage": null
}
```
