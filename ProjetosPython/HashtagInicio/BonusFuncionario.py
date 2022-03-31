vendasFunc = [1000, 770, 2700];
meta = 1000

def calcBonus(vendas) :
    if vendas >= meta : bonus = 0.1 * vendas
    else : bonus = 0
    return bonus

bonus1 = calcBonus(vendasFunc[0])
bonus2 = calcBonus(vendasFunc[1])
bonus3 = calcBonus(vendasFunc[2])

print(f'O funcionário 1 ganhou {bonus1} de bônus')
print(f'O funcionário 2 ganhou {bonus2} de bônus')
print(f'O funcionário 3 ganhou {bonus3} de bônus')

def calcBonus2(vendas) :
    if vendas >= 2000 : bonus = 0.15 * vendas
    elif vendas < 2000 and vendas >= 1000 :
        bonus = 0.10 * vendas
    else : bonus = 0
    return bonus

bonus1 = calcBonus2(vendasFunc[0])
bonus2 = calcBonus2(vendasFunc[1])
bonus3 = calcBonus2(vendasFunc[2])

print(f'O funcionário 1 ganhou {bonus1} de bônus')
print(f'O funcionário 2 ganhou {bonus2} de bônus')
print(f'O funcionário 3 ganhou {bonus3} de bônus')