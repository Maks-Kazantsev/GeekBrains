"""
Реализовать формирование списка, используя функцию range() и возможности
генератора. В список должны войти четные числа от 100 до 1000
(включая границы). Необходимо получить результат вычисления произведения всех
элементов списка.
Подсказка: использовать функцию reduce().

"""
from functools import reduce


def my_func(el_p, el):
    return el_p * el


print(
    f'List of even values: {[el for el in range(99, 1001) if el % 2 == 0]}')
print(
    f'The result of calculating the product of all the elements of the list:'
    f' {reduce(my_func, [el for el in range(99, 1001) if el % 2 == 0])}')


