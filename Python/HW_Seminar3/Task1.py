"""
Реализовать функцию, принимающую два числа (позиционные аргументы) и
выполняющую их деление. Числа запрашивать у пользователя, предусмотреть
обработку ситуации деления на ноль.
"""


def my_func(args1, args2):
    try:
        res = args1 / args2
        return res
    except ZeroDivisionError:
        return "Do not divide by zero!"


print(my_func(int(input("Enter the divisible: ")), int(input("Enter the "
                                                             "divisor:"))))
