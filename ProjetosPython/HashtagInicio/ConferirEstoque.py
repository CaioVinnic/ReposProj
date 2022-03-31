produtos = ['tv', 'celular', 'tablet', 'mouse', 'teclado', 'geladeira', 'forno']
estoque = [100, 150, 100, 120, 70, 180, 80]

prod = input('Qual o produto? ').casefold()

if prod in produtos :
    i = produtos.index(prod)
    est = estoque[i]
    print(f'A quantidade em estoque de {prod} é: {est}')
else :
    print('Esse produto nao existe na lista.')