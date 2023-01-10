number = int(input('Enter a positive integer:'))
num_m = number % 10
while number >= 1:
    number = number // 10
    if number % 10 > num_m:
        num_m = number % 10
    if number > 9:
        continue
    else:
        print(f'Maximum digit in a number: {num_m}')
        break
