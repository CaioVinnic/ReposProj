from telebot import telebot
from datetime import datetime, date
from telegram.ext import *

token = "5212230889:AAEiAEfrX29l69M3Yo3-5QBOjG4ygiirKFU"
bot = telebot.TeleBot(token)

@bot.message_handler(commands=["Sorteio"])
def word(mensagem):
    pass

def verificar(mensagem):
    return True

@bot.message_handler(func=verificar)
def responder(mensagem):
    txt = "texto de teste"

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)
    dthr = mensagem.date
    print(dthr)

    bot.reply_to(mensagem, txt)

bot.polling()