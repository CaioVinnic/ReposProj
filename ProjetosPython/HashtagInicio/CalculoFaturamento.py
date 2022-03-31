meses = ['jan', 'fev', 'mar', 'abr', 'mai', 'jun', 'jul', 'ago', 'set', 'out', 'nov', 'dez']
vendas_1sem = [25000, 29000, 22200, 17750, 15870, 19900]
vendas_2sem = [19850, 20120, 17540, 15555, 49051, 9650]

vendas_1sem.extend(vendas_2sem)
print(f'A maior venda foi de: R$ {max(vendas_1sem):,.2f}')
print(f'A menor venda foi de: R$ {min(vendas_1sem):,.2f}')

meses = ['jan', 'fev', 'mar', 'abr', 'mai', 'jun', 'jul', 'ago', 'set', 'out', 'nov', 'dez']
vendas_1sem = [25000, 29000, 22200, 17750, 15870, 19900]
vendas_2sem = [19850, 20120, 17540, 15555, 49051, 9650]

vendas_1sem.extend(vendas_2sem)
max_valor = max(vendas_1sem)
min_valor = min(vendas_1sem)

imax = vendas_1sem.index(max_valor)
imin = vendas_1sem.index(min_valor)

print(f'O melhor mes de vendas foi em {meses[imax].upper()} com R${max_valor:,.2f}')
print(f'O pior mes de vendas foi em {meses[imin].upper()} com R${min_valor:,.2f}')

tot_fat = sum(vendas_1sem)
percent = max_valor / tot_fat

print(f'O faturamento total do ano foi R${tot_fat:,.2f} e o mes de {meses[imax].upper()} teve {percent:.2%} na participação.')

top3 = vendas_1sem.copy()
top3.sort()

print(f'Top 1: R${top3[-1]:,.2f}')
print(f'Top 2: R${top3[-2]:,.2f}')
print(f'Top 3: R${top3[-3]:,.2f}')
