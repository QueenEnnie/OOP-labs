# OOP Labs

Набор лабораторных работ по объектно-ориентированному программированию на C#. Каждая работа оформлена как отдельное консольное приложение с тестами на xUnit.

## Состав проекта

| Работа | Проект | Основные темы                                                             |
|--------| --- |---------------------------------------------------------------------------|
| 1      | Vending Machine | Инкапсуляция, валидация, логика покупки, unit-тесты                       |
| 2      | Course System | Интерфейсы, наследование, коллекции, доменная валидация                   |
| 3      | RPG Inventory | Фабрики, сервисы, правила инвентаря, экипировка                           |
| 4      | Order System | Работа с паттернами: Strategy, Factory Method, Decorator, State, Observer |

## Стек

- C#
- .NET 9
- xUnit

## Как запустить тесты

```bash
dotnet test "lab1/VendingMachine/VendingMachine.sln"
dotnet test "lab 2/CourseSystem/CourseSystem.sln"
dotnet test "lab 3/RolePlayingGameInventory/RolePlayingGameInventory.sln"
dotnet test "lab4/OrderSystem/OrderSystem.sln"
```

