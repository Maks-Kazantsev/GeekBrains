"""
Реализовать скрипт, в котором должна быть предусмотрена функция расчета
заработной платы сотрудника. В расчете необходимо использовать формулу:
(выработка в часах*ставка в час) + премия. Для выполнения расчета для
конкретных значений необходимо запускать скрипт с параметрами.
"""
from sys import argv

if len(argv) > 1:
    name_script, time_work, rate, bonus = argv
    time_work = int(time_work)
    rate = int(rate)
    bonus = int(bonus)
    print((time_work * rate) + bonus)
else:
    time_work = int(input("Enter time work: "))
    rate = int(input("Enter working rate: "))
    bonus = int(input("Enter bonus: "))
    print((time_work * rate) + bonus)
