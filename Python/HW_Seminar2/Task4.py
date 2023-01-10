"""
Пользователь вводит строку из нескольких слов, разделённых пробелами. Вывести
каждое слово с новой строки. Строки необходимо пронумеровать.
Если в слово длинное, выводить только первые 10 букв в слове.
"""
user_str = input('enter the line: ')
my_word = []
number = 1
for el in range(user_str.count(' ') + 1):
    my_word = user_str.split()
    if len(str(my_word)) <= 10:
        print(f'{number} {my_word[el]}')
        number += 1
    else:
        print(f'{number} {my_word[el][0:10]}')
        number += 1
