"""
Реализовать функцию my_func(), которая принимает три позиционных аргумента,
и возвращает сумму наибольших двух аргументов.
"""


def my_func(arg1, arg2, arg3):
    order = [arg1, arg2, arg3]
    total = []
    m_1 = max(order)
    total.append(m_1)
    order.remove(m_1)
    m_2 = max(order)
    total.append(m_2)
    print(sum(total))


my_func(10, -4, 5)
