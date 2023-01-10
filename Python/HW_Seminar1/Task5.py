revenue = float(input("Enter the company's revenue:"))
costs = float(input("Enter the company's costs:"))
if revenue > costs:
    print(f'Фирма работает в прибыль, выручка составила:{revenue / costs}')
    staff = int(input('Enter the number of employees:'))
    print(f'Прибыль на одного сотрудника составила: {revenue / staff}')
elif revenue == costs:
    print('Фирма работает в ноль')
else:
    print('Фирма работает в убыток')
