import requests
import json

cep = input('Qual o cep? ')

ceps = requests.get(f'https://cep.awesomeapi.com.br/json/{cep}')

if ceps.status_code == 200:
    ceps = ceps.json()

    uf = ceps['state']
    cidade = ceps['city']
    bairro = ceps['district']
    logradouro = ceps['address_type']
    endereco = ceps['address_name']
    cep = ceps['cep']
    ddd = ceps['ddd']
    lat = ceps['lat']
    lon = ceps['lng']

    print(f'UF: {uf}')
    print(f'Cidade: {cidade}')
    print(f'Bairro: {bairro}')
    print(f'Endereço: {logradouro} {endereco}')
    print(f'CEP: {cep}')
    print(f'DDD: {ddd}')
    print(f'Latitude: {lat}')
    print(f'Longitude: {lon}')
else:
    print(ceps.encoding)