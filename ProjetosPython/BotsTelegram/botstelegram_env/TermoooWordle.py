#!/usr/local/bin/python
# encoding: utf-8

import telebot
from datetime import datetime, date

token = "5165551642:AAHQejAdV-ksPFnCI-pmR73AzZPixaG0znE"
bot = telebot.TeleBot(token)

#bot.delete_webhook()
bot.set_webhook()

@bot.message_handler(commands=["termooo"])
def word(mensagem):
    
    d1 = datetime.strptime('2022-01-01', '%Y-%m-%d')
    hoje = date.today().strftime('%Y-%m-%d')
    d2 = datetime.strptime(hoje, '%Y-%m-%d')
    index = abs((d2 - d1).days)

    with open("palavras_termooo.txt","r", encoding="utf-8") as file:
        linhas = file.read().split(',')

    for i, linha in enumerate(linhas, start=1):
        if i == index:
            wrd = linha.split()

    msg = "A palavra de hoje é: "

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)

    bot.send_message(mensagem.chat.id, msg + str(wrd).replace("[","").replace("]","").replace("'","").upper())
   
@bot.message_handler(commands=["wordle"])
def word(mensagem):
    
    d1 = datetime.strptime('2021-06-18', '%Y-%m-%d')
    hoje = date.today().strftime('%Y-%m-%d')
    d2 = datetime.strptime(hoje, '%Y-%m-%d')
    index = abs((d2 - d1).days) + 3

    with open("palavras_wordle.txt","r", encoding="utf-8") as file:
        linhas = file.read().split(',')

    for i, linha in enumerate(linhas, start=1):
        if i == index:
            wrd = linha.split()

    msg = "The word today is: "

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)

    bot.send_message(mensagem.chat.id, msg + str(wrd).replace("[","").replace("]","").replace("'","").upper())


def verificar(mensagem):
    return True

@bot.message_handler(func=verificar)
def responder(mensagem):
    txt = """Hello! Send /wordle for the day's word.
Olá! Envie /termooo para a palavra do dia."""

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)
    
    bot.reply_to(mensagem, txt)

bot.polling()