
# -*- coding: utf-8 -*-
#
#- alimentos -> Estoque mínimo: 50
#- bebidas -> Estoque mínimo: 75
#- limpeza -> Estoque mínimo: 30
#
#Se o produto tiver abaixo do estoque mínimo da categoria dele, o programa deve printar a mensagem "Solicitar {produto} à equipe de compras, temos apenas {unidades} em estoque"
#
#Exemplo: Se o usuário preenche os inputs com: bebidas, dolly, 90, o programa não deve exibir nenhuma mensagem.<br>
#Agora, se o usuário preenche os inputs com: bebidas, guaraná, 60, o programa deve exibir a mensagem "Solicitar guaraná à equipe de compras, temos apenas 60 unidades em estoque.
#
#Obs: lembre de usar o int() para transformar o número inserido pelo usuário no input de string para int.<br>
#Obs2: Caso o usuário não preencha alguma das 3 informações, o programa deve exibir uma mensagem para avisá-lo de preencher corretamente.

#seu código aqui

produto = input('Informe o nome do produto: ')
categoria = input('Informe a categoria: ')
estoque = input('Informe a qtdd em estoque: ')
estoque = estoque if estoque != '' else 0

#region validarInfo
def validarInfo() :
    if produto or categoria or estoque == 0:
        print('Favor preencher os dados corretamente')
#endregion

def verifEstoque(produto, categoria, estoque) :
    if categoria == 'alimento' and estoque < 50 or categoria == 'bebida' and estoque < 75 or categoria == 'limpeza' and estoque < 30 :
        estoqueBaixo(produto, estoque)

def estoqueBaixo(produto, estoque) :
    print(f'Solicitar {produto} à equipe de compras, temos apenas {estoque} em estoque')

validarInfo()
verifEstoque(produto, categoria, estoque)
