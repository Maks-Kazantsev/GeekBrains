"""
Реализовать функцию, принимающую несколько параметров, описывающих данные
пользователя: имя, фамилия, год рождения, город проживания, email, телефон.
Функция должна принимать параметры как именованные аргументы. Реализовать
вывод данных о пользователе одной строкой.
"""

name2 = input('Input name: ')
surname2 = input('Input surname: ')
year2 = input('Input year: ')
city2 = input('Input city: ')
email2 = input('Input email: ')
phone2 = input('Input phone: ')


def func_info(name, surname, year, city, email, phone):
    return ' '.join([
        " Name:", name,
        "- Surname:", surname,
        "- Year:", year,
        "- City:", city,
        "- Email:", email,
        "- Phone:", phone, "."
    ])


print(func_info(name=name2, surname=surname2, year=year2, city=city2,
                email=email2, phone=phone2))
