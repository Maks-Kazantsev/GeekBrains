"""
Создать список и заполнить его элементами различных типов данных.
Реализовать скрипт проверки типа данных каждого элемента.
Использовать функцию type() для проверки типа. Элементы списка можно
не запрашивать у пользователя, а указать явно, в программе.
"""

lists = [1, '2', True, 3.1]
for ind, el in enumerate(lists):
    print(ind, type(el))
