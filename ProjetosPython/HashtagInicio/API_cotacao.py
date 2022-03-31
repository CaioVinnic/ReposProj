import requests
import json

cotacoes = requests.get('https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL')
cotacoes = cotacoes.json()
dollar = float(cotacoes['USDBRL']['bid'])
euro = float(cotacoes['EURBRL']['bid'])
bitcoin = float(cotacoes['BTCBRL']['bid'])

print(f'Dollar: R${dollar:,.2f}')
print(f'Euro: R${euro:,.2f}')
print(f'Bitcoin: R${bitcoin}')