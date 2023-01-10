"""
Пользователь вводит месяц в виде целого числа от 1 до 12. Сообщить к какому
времени года относится месяц (зима, весна, лето, осень). Напишите решения
через list и через dict.
"""

# Решение через list

month_list = ['None', 'January', 'February', 'March', 'April', 'May', 'June',
              'July', 'August', 'September', 'October', 'November', 'December']
users_ent = int(input('Enter the month as an integer from 1 to 12: '))
if users_ent == 1:
    print(month_list[1])
elif users_ent == 2:
    print(month_list[2])
elif users_ent == 3:
    print(month_list[3])
elif users_ent == 4:
    print(month_list[4])
elif users_ent == 5:
    print(month_list[5])
elif users_ent == 6:
    print(month_list[6])
elif users_ent == 7:
    print(month_list[7])
elif users_ent == 8:
    print(month_list[8])
elif users_ent == 9:
    print(month_list[9])
elif users_ent == 10:
    print(month_list[10])
elif users_ent == 11:
    print(month_list[11])
elif users_ent == 12:
    print(month_list[12])
else:
    print('Does not exist')

# Решение через dict

# month = {1: 'January', 2: 'February', 3: 'March', 4: 'April', 5: 'May',
#          6: 'June', 7: 'July', 8: 'August', 9: 'September', 10: 'October',
#          11: 'November', 12: 'December'}
# users_ent = int(input('Enter the month as an integer from 1 to 12: '))
# if users_ent == 1:
#     print(month[1])
# elif users_ent == 2:
#     print(month[2])
# elif users_ent == 3:
#     print(month[3])
# elif users_ent == 4:
#     print(month[4])
# elif users_ent == 5:
#     print(month[5])
# elif users_ent == 6:
#     print(month[6])
# elif users_ent == 7:
#     print(month[7])
# elif users_ent == 8:
#     print(month[8])
# elif users_ent == 9:
#     print(month[9])
# elif users_ent == 10:
#     print(month[10])
# elif users_ent == 11:
#     print(month[11])
# elif users_ent == 12:
#     print(month[12])
# else:
#     print('Does not exist')
