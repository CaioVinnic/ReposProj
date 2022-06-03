#!/usr/local/bin/python
# -*- coding: utf-8 -*-

import telebot
from datetime import datetime, date

token = "5103115915:AAEmO84IXinv18P76wHD6P-zURhvklRV4iA"
bot = telebot.TeleBot(token)

bot.delete_webhook()

@bot.message_handler(commands=["termooo"])
def word(mensagem):
    
    lista = ["termo", "suíte", "ávido", "festa", "bebia", "honra", "ouvir", "pesco", "fungo", "pagam", "ginga", "pinta",
             "poder", "útero", "pilha", "sarar", "fruta", "piano", "notar", "musgo", "tensa", "melão", "feliz", "miojo",
             "pagos", "texto", "mamãe", "ameno", "chuva", "coral", "forte", "tonta", "temor", "ligar", "rolar", "navio",
             "limbo", "calvo", "fedor", "balde", "oxalá", "talco", "lábia", "crime", "grade", "carta", "flora", "comum",
             "fatal", "pecar", "feroz", "vírus", "armar", "couro", "êxito", "ecoar", "balão", "falir", "tecer", "arena",
             "justo", "árido", "ruiva", "múmia", "fogão", "dupla", "touca", "sogro", "ósseo", "treta", "manhã", "cárie",
             "brejo", "acima", "bolso", "sítio", "dólar", "aéreo", "peixe", "golfo", "bunda", "conde", "meses", "perua",
             "suíno", "molas", "corar", "águia", "rumor", "senão", "risos", "milha", "chato", "praga", "cloro", "mexer",
             "beato", "lugar", "nuvem", "plebe", "lindo", "bispo", "idosa", "funil", "artes", "supor", "vital", "então",
             "trigo", "rapaz", "caldo", "bocas", "manto", "males", "renal", "caber", "menor", "seiva", "palco", "palmo",
             "poeta", "mágoa", "ideia", "temer", "bolsa", "ruivo", "forno", "sismo", "exata", "razão", "radar", "pegar",
             "blusa", "hinos", "baita", "tricô", "chata", "vasta", "rugir", "motor", "taças", "orgia", "aspas", "total",
             "ardor", "prole", "tarja", "ninho", "credo", "pente", "falar", "canoa", "prato", "clave", "opaco", "anjos",
             "velho", "grana", "vazia", "rumos", "altos", "mútua", "missa", "pardo", "leões", "muros", "altas", "vigor",
             "tonto", "bruxa", "bacon", "órgão", "bioma", "miúdo", "reter", "agora", "fosco", "áudio", "carpa", "cacho",
             "fardo", "povos", "denso", "perna", "basco", "guria", "pluma", "final", "ditos", "ícone", "jaula", "duros",
             "pônei", "âmago", "barão", "pomba", "ficar", "sério", "moura", "cafés", "nicho", "fraca", "catar", "dicas",
             "morno", "claro", "posar", "acesa", "dublê", "levar", "corda", "trena", "invés", "achar", "barca", "peste",
             "batom", "dever", "crase", "todos", "picos", "cação", "pulga", "bruxo", "exame", "babar", "opção", "tédio",
             "secar", "rival", "aguda", "tiros", "tênis", "curar", "moeda", "bater", "cubos", "verme", "ostra", "mundo",
             "sábio", "nomes", "belos", "parda", "nossa", "tanga", "unida", "caqui", "colar", "devir", "girar", "rimar",
             "panda", "laico", "sueca", "mercê", "laços", "ritos", "verde", "pesar", "nadar", "fuzuê", "obter", "dedão",
             "moída", "disso", "longa", "autos", "surda", "pinos", "poema", "ponte", "galão", "musas", "ânimo", "globo",
             "leito", "caçar", "ileso", "malas", "pagar", "surfe", "polvo", "vasto", "nariz", "daqui", "lombo", "ambos",
             "vinda", "couve", "toada", "árabe", "sabão", "porém", "veloz", "tábua", "seita", "grato", "falsa", "doces",
             "fogos", "lenta", "veias", "arcar", "danos", "arame", "poços", "união", "hiena", "tipos", "sacro", "pátio",
             "tripa", "menos", "tosco", "cargo", "tanto", "igual", "eixos", "sadia", "ápice", "expor", "ponta", "bonés",
             "farol", "rolos", "astro", "tapar", "fisco", "meter", "cesta", "calmo", "áries", "fiada", "feias", "óxido",
             "gesso", "ordem", "birra", "corvo", "dores", "fetal", "cisne", "lapso", "exato", "penal", "pompa", "âmbar",
             "ossos", "prazo", "ambas", "finas", "régua", "parco", "capaz", "pouco", "anais", "lápis", "vosso", "linda",
             "canil", "infra", "ditar", "pudor", "mesmo", "lenço", "enfim", "ânsia", "morar", "axila", "áureo", "greve",
             "seios", "ácido", "rolim", "divas", "sótão", "banda", "fatos", "corno", "áreas", "dente", "poros", "cinto",
             "santa", "visor", "casca", "ferir", "fonte", "mania", "urnas", "cacau", "calva", "cento", "jarra", "sutil",
             "magos", "gênio", "sexta", "páreo", "reais", "mansa", "extra", "virar", "totem", "graxa", "capuz", "morna",
             "pudim", "andar", "genro", "médio", "prosa", "gases", "trono", "medos", "lente", "hotel", "jogos", "gatos",
             "coxas", "óleos", "polos", "massa", "dosar", "macio", "agudo", "focar", "seção", "bloco", "atrás", "turma",
             "ômega", "tropa", "jarro", "motel", "galês", "focos", "penta", "fusão", "vogal", "chefe", "verba", "campo",
             "ainda", "noite", "máfia", "cruel", "úmido", "assar", "quiçá", "pizza", "óvulo", "presa", "placa", "telas",
             "gordo", "aliás", "quina", "estes", "pista", "latão", "gatas", "mares", "nudez", "aliar", "areia", "fugir",
             "surdo", "untar", "bolos", "pólen", "obeso", "cosmo", "preto", "luvas", "sarro", "gripe", "ruína", "geral",
             "tórax", "euros", "banal", "maior", "lomba", "tênue", "pouca", "sogra", "finos", "fluxo", "líder", "latas",
             "bazar", "limão", "duque", "belas", "seara", "secos", "cólon", "monge", "gelar", "ações", "sacos", "caros",
             "média", "lagos", "torto", "suave", "baque", "alçar", "bambu", "ricas", "ótico", "noção", "tutor", "pires",
             "folia", "fumar", "praia", "corja", "anões", "toldo", "dunas", "norte", "bingo", "retro", "naves", "matos",
             "muito", "acaso", "viril", "vagar", "costa", "esqui", "bucho", "dogma", "burra", "optar", "árdua", "rezar",
             "mamar", "fuçar", "aluna", "dados", "saída", "vazar", "cervo", "negar", "picar", "furor", "carma", "ótima",
             "ídolo", "juízo", "filho", "gambá", "perto", "gozar", "feudo", "sueco", "salas", "tíbia", "fútil", "lisos",
             "brasa", "facão", "sumir", "sócio", "bando", "ético", "grego", "pelos", "signo", "votos", "vulto", "lótus",
             "pampa", "lerdo", "louça", "times", "gaita", "gosma", "tarso", "telha", "visão", "moela", "hífen", "murro",
             "sigma", "celta", "goela", "modos", "reger", "longe", "ópera", "bamba", "cesto", "gêmeo", "zonas", "vídeo",
             "carga", "vanda", "julho", "ondas", "anual", "longo", "roupa", "treco", "bucal", "aroma", "citar", "vulgo",
             "revés", "bares", "lidar", "aveia", "novos", "bravo", "mirar", "modas", "nasal", "cedro", "camas", "atlas",
             "anzol", "comer", "calar", "linho", "sadio", "roçar", "major", "tubos", "bolha", "arcos", "selva", "sagaz",
             "puxar", "olhos", "meias", "velha", "angra", "duplo", "fixar", "garra", "ímpio", "algum", "setor", "japão",
             "pisos", "sauna", "salsa", "aonde", "fúria", "densa", "besta", "tribo", "loura", "socar", "índio", "preço",
             "crise", "teses", "sarda", "clara", "legal", "frase", "ceder", "loção", "praça", "turco", "boato", "olhar",
             "valor", "vácuo", "casar", "geada", "sódio", "dotar", "cavar", "quais", "opala", "elite", "banjo", "ultra",
             "vivos", "truco", "terno", "posse", "bonde", "robôs", "cetro", "frios", "pneus", "valer", "zerar", "pedir",
             "matar", "leite", "mista", "porre", "lince", "gesto", "morta", "vazão", "titia", "única", "dueto", "gávea",
             "pomar", "vocal", "época", "busto", "calor", "sutis", "faixa", "prata", "pavor", "prado", "genes", "afins",
             "cacos", "ótica", "culto", "jovem", "ideal", "negro", "lunar", "balsa", "norma", "zelar", "lutar", "ducha",
             "nisso", "ciclo", "rosca", "diodo", "frota", "moral", "fibra", "adeus", "pedra", "culta", "turno", "pobre",
             "poção", "solar", "podar", "peões", "idade", "clipe", "pausa", "avelã", "naipe", "piada", "sucos", "trufa",
             "parar", "cabos", "subir", "bulbo", "pilar", "fauna", "rotas", "adaga", "dorso", "átomo", "repor", "parvo",
             "canja", "urubu", "pedal", "sorte", "tecno", "sinal", "boate", "ursos", "coisa", "botão", "rombo", "moita",
             "fases", "raros", "censo", "polar", "perda", "trens", "tenor", "viral", "cupom", "tosca", "cheia", "terra",
             "menta", "brava", "judeu", "hiato", "raiva", "épica", "casos", "grega", "meiga", "gíria", "rosas", "lares",
             "cinco", "vezes", "desde", "larva", "vetor", "clube", "beata", "minha", "congo", "trair", "laudo", "mapas",
             "fosso", "zebra", "banir", "tátil", "mimar", "ricos", "setas", "cabra", "móvel", "motos", "irmãs", "jurar",
             "lobos", "manga", "nobel", "persa", "pirão", "licor", "gerir", "linha", "algoz", "abade", "pombo", "zinco",
             "faraó", "copos", "cinta", "gorro", "rodar", "tigre", "táxis", "ímpar", "palha", "dócil", "quase", "sushi",
             "mover", "graça", "mogno", "papel", "porca", "ética", "cheio", "féria", "carro", "farsa", "redor", "doido",
             "quota", "rampa", "oeste", "facas", "diabo", "balas", "vozes", "tango", "pesos", "oásis", "rímel", "haras",
             "foice", "lilás", "gente", "junho", "tirar", "puxão", "parir", "circo", "ampla", "lebre", "óscar", "mesma",
             "nisto", "haste", "sopas", "donos", "vilas", "pirar", "rádio", "farra", "senso", "nunca", "certo", "acolá",
             "mirim", "vinil", "senha", "cisto", "farpa", "estar", "haver", "avião", "natal", "rigor", "sonar", "álbum",
             "atriz", "verbo", "homem", "germe", "lábio", "parma", "clima", "misto", "bocal", "bacia", "micro", "vagão",
             "nulos", "topar", "abono", "burro", "braço", "tempo", "gerar", "canal", "ritmo", "ótimo", "lados", "ralar",
             "débil", "atual", "capim", "muita", "votar", "tenso", "fórum", "fator", "galho", "lixar", "ramos", "areal",
             "febre", "loiro", "jejum", "alado", "ousar", "amplo", "impor", "museu", "manso", "delta", "idoso", "juíza",
             "nozes", "fiapo", "cujos", "abrir", "tripé", "sexto", "retas", "civil", "feira", "servo", "névoa", "patas",
             "jogar", "sanha", "doida", "bicos", "rever", "folha", "palma", "sarau", "filha", "vênus", "fugaz", "óbvio",
             "sacra", "focal", "mosca", "touro", "punir", "barba", "rocha", "casco", "panos", "açude", "terço", "gotas",
             "favor", "usual", "óssea", "rubro", "rosto", "nevar", "dardo", "brega", "prece", "regar", "frias", "rolha",
             "trenó", "casta", "garça", "torpe", "fixos", "jegue", "frade", "macro", "hábil", "rouca", "caule", "guiar",
             "horto", "lidos", "somar", "mitos", "cílio", "ninar", "santo", "assim", "netos", "caspa", "ninja", "cegos",
             "fácil", "altar", "algas", "caras", "farda", "sunga", "cupim", "horta", "vespa", "lorde", "deusa", "vacas",
             "relva", "vidas", "abril", "super", "criar", "nível", "grupo", "adega", "voraz", "vasos", "usina", "ratos",
             "terça", "cueca", "brisa", "feita", "vetar", "pódio", "fossa", "coeso", "anéis", "lírio", "tinto", "vôlei",
             "serva", "mútuo", "trapo", "metro", "nobre", "ombro", "úmida", "louco", "gueto", "punho", "amora", "redes",
             "cofre", "síria", "vária", "trama", "ágeis", "ganso", "latim", "obras", "golpe", "rente", "vício", "russo",
             "vazio", "civis", "nação", "bicho", "sabiá", "salmo", "podre", "alvos", "loira", "cetim", "unhas", "fobia",
             "salão", "praxe", "bruta", "lenha", "clero", "jeito", "potes", "tumba", "ninfa", "sarna", "tomar", "macia",
             "sabor", "caída", "leque", "justa", "tocha", "lazer", "feixe", "selos", "etapa", "único", "dúzia", "pavão",
             "sigla", "durar", "fazer", "truta", "tinta", "graus", "pavio", "torta", "deter", "abada", "clone", "tufão",
             "polpa", "trupe", "malta", "irado", "selar", "boina", "atuar", "corpo", "magia", "maçãs", "pinho", "preta",
             "fosca", "gruta", "bossa", "magro", "lento", "lousa", "falso", "tosar", "aluno", "padre", "metal", "meios",
             "lenda", "bônus", "crepe", "antes", "milho", "símio", "drama", "chave", "grama", "raras", "mesas", "harpa",
             "treze", "fraco", "gorda", "magra", "leigo", "hindu", "adiar", "caixa", "vocês", "magna", "fofas", "varal",
             "úteis", "teias", "fêmea", "marte", "errar", "frear", "macho", "série", "viver", "damas", "fêmur", "feios",
             "sutiã", "árduo", "sujar", "golfe", "ração", "cinza", "barco", "rasto", "malte", "almas", "arder", "naval",
             "vinte", "nervo", "reler", "xampu", "lotar", "reles", "erros", "ponto", "frevo", "ervas", "copas", "pisar",
             "fruto", "beber", "trevo", "lesão", "grata", "certa", "botar", "tocar", "sujos", "amada", "cerne", "valsa",
             "herói", "ciúme", "juros", "dedos", "mambo", "bruto", "reúso", "dieta", "telão", "depor", "litro", "domar",
             "míope", "polir", "dizer", "mídia", "autor", "bucha", "remar", "miolo", "letal", "plena", "fluir", "calma",
             "cenas", "medir", "zíper", "selim", "pleno", "outra", "lição", "mural", "feras", "todas", "aérea", "tetra",
             "outro", "irmão", "coçar", "furar", "porco", "advir", "breve", "êxodo", "vilão", "letra", "vapor", "libra",
             "amido", "imune", "pular", "lagoa", "bomba", "horas", "casal", "índia", "sacar", "meros", "túnel", "rural",
             "mudar", "chapa", "usada", "atroz", "etnia", "neném", "órfão", "calda", "chalé", "furos", "ontem", "cópia",
             "raiar", "novas", "cauda", "meigo", "vinho", "joias", "lavar", "bufão", "aulas", "lojas", "safra", "odiar",
             "tchau", "arroz", "carne", "prumo", "fotos", "junco", "épico", "tesão", "refém", "manta", "raios", "humor",
             "sanar", "dique", "berço", "flúor", "sósia", "local", "gemer", "saber", "visar"]

    d1 = datetime.strptime('2022-01-01', '%Y-%m-%d')
    hoje = date.today().strftime('%Y-%m-%d')
    d2 = datetime.strptime(hoje, '%Y-%m-%d')
    index = abs((d2 - d1).days)

    wrd = lista[index-1].upper()

    msg = "A palavra de hoje é: "

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)

    bot.send_message(mensagem.chat.id, msg + wrd)
   
def verificar(mensagem):
    return True

@bot.message_handler(func=verificar)
def responder(mensagem):
    txt = "texto de teste"

    who = mensagem.from_user.first_name+" "+mensagem.from_user.last_name
    conteudo = mensagem.text
    print(who+": "+conteudo)
    
    bot.reply_to(mensagem, txt)

bot.polling()