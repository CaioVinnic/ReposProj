import random
import ClearConsole as cls

Players = ["Vinnic", "Drisdian", "Rene", "Dadico", "Gizao",
        "Leeoba", "Perna", "Jubira", "Anderson", "Witsel"]

Teams = ["PSG", "Man. City", "Juventus", "Real Madrid", "Bayern",
      "Barcelona", "Chelsea", "Liverpool", "Atl. Madrid", "Man. Untd."]

def validInscricao(list_p, list_t):
    if len(list_p) == len(list_t):
          valid = True
    else:
       print('Lista de jogadores diferente do tamanho de lista de times.')
       valid = False
    return valid

def randomizarLista(listaRdm):
    rdm = random.sample(listaRdm, len(listaRdm))
    return rdm

valid = validInscricao(Players, Teams)

#region tela
#cls.clearConsole()
#print("=== Qual o tipo de torneio? ===")
#print("1 - Fase de Grupos (32 times)")
#print("2 - Fase de Grupos (16 times)")
#print("3 - Fase de Grupos (8 times)")
#print("4 - Oitavas de Final (16 times)")
#print("5 - Quartas de Final (8 times)")
#print("6 - Gerar confronto 1 vs 1")
#op = input()
#cls.clearConsole()
#endregion tela

def gerarGrupos():
    x = int(len(Players)/2)
    rdmPlayers = randomizarLista(Players)
    rdmTeams = randomizarLista(Teams)
    
    print('='*7, 'GRUPO A', '='*7)
    for i in range(x):
        print(f'{rdmPlayers[i]} ({rdmTeams[i]})')

    print('\n')
    print('='*7, 'GRUPO B', '='*7)
    for i in range(x):
        print(f'{rdmPlayers[i+x]} ({rdmTeams[i+x]})')

if valid:
    gerarGrupos()

