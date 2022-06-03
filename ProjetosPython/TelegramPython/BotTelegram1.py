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
   
@bot.message_handler(commands=["wordle"])
def word(mensagem):
    
    lista = ["cigar", "rebut", "sissy", "humph", "awake", "blush", "focal", "evade", "naval", "serve", "heath", "dwarf", "model", "karma", "stink", "grade", "quiet", "bench", "abate", "feign", "major", "death", "fresh", "crust", "stool", "colon", "abase", "marry", "react", "batty", "pride", "floss", "helix", "croak", "staff", "paper", "unfed", "whelp", "trawl", "outdo", "adobe", "crazy", "sower", "repay", "digit", "crate", "cluck", "spike", "mimic", "pound", "maxim", "linen", "unmet", "flesh", "booby", "forth", "first", "stand", "belly", "ivory", "seedy", "print", "yearn", "drain", "bribe", "stout", "panel", "crass", "flume", "offal", "agree", "error", "swirl", "argue", "bleed", "delta", "flick", "totem", "wooer", "front", "shrub", "parry", "biome", "lapel", "start", "greet", "goner", "golem", "lusty", "loopy", "round", "audit", "lying", "gamma", "labor", "islet", "civic", "forge", "corny", "moult", "basic", "salad", "agate", "spicy", "spray", "essay", "fjord", "spend", "kebab", "guild", "aback", "motor", "alone", "hatch", "hyper", "thumb", "dowry", "ought", "belch", "dutch", "pilot", "tweed", "comet", "jaunt", "enema", "steed", "abyss", "growl", "fling", "dozen", "boozy", "erode", "world", "gouge", "click", "briar", "great", "altar", "pulpy", "blurt", "coast", "duchy", "groin", "fixer", "group", "rogue", "badly", "smart", "pithy", "gaudy", "chill", "heron", "vodka", "finer", "surer", "radio", "rouge", "perch", "retch", "wrote", "clock", "tilde", "store", "prove", "bring", "solve", "cheat", "grime", "exult", "usher", "epoch", "triad", "break", "rhino", "viral", "conic", "masse", "sonic", "vital", "trace", "using", "peach", "champ", "baton", "brake", "pluck", "craze", "gripe", "weary", "picky", "acute", "ferry", "aside", "tapir", "troll", "unify", "rebus", "boost", "truss", "siege", "tiger", "banal", "slump", "crank", "gorge", "query", "drink", "favor", "abbey", "tangy", "panic", "solar", "shire", "proxy", "point", "robot", "prick", "wince", "crimp", "knoll", "sugar", "whack", "mount", "perky", "could", "wrung", "light", "those", "moist", "shard", "pleat", "aloft", "skill", "elder", "frame", "humor", "pause", "ulcer", "ultra", "robin", "cynic", "aroma", "caulk", "shake", "dodge", "swill", "tacit", "other", "thorn", "trove", "bloke", "vivid", "spill", "chant", "choke", "rupee", "nasty", "mourn", "ahead", "brine", "cloth", "hoard", "sweet", "month", "lapse", "watch", "today", "focus", "smelt", "tease", "cater", "movie", "saute", "allow", "renew", "their", "slosh", "purge", "chest", "depot", "epoxy", "nymph", "found", "shall", "harry", "stove", "lowly", "snout", "trope", "fewer", "shawl", "natal", "comma", "foray", "scare", "stair", "black", "squad", "royal", "chunk", "mince", "shame", "cheek", "ample", "flair", "foyer", "cargo", "oxide", "plant", "olive", "inert", "askew", "heist", "shown", "zesty", "hasty", "trash", "fella", "larva", "forgo", "story", "hairy", "train", "homer", "badge", "midst", "canny", "fetus", "butch", "farce", "slung", "tipsy", "metal", "yield", "delve", "being", "scour", "glass", "gamer", "scrap", "money", "hinge", "album", "vouch", "asset", "tiara", "crept", "bayou", "atoll", "manor", "creak", "showy", "phase", "froth", "depth", "gloom", "flood", "trait", "girth", "piety", "payer", "goose", "float", "donor", "atone", "primo", "apron", "blown", "cacao", "loser", "input", "gloat", "awful", "brink", "smite", "beady", "rusty", "retro", "droll", "gawky", "hutch", "pinto", "gaily", "egret", "lilac", "sever", "field", "fluff", "hydro", "flack", "agape", "voice", "stead", "stalk", "berth", "madam", "night", "bland", "liver", "wedge", "augur", "roomy", "wacky", "flock", "angry", "bobby", "trite", "aphid", "tryst", "midge", "power", "elope", "cinch", "motto", "stomp", "upset", "bluff", "cramp", "quart", "coyly", "youth", "rhyme", "buggy", "alien", "smear", "unfit", "patty", "cling", "glean", "label", "hunky", "khaki", "poker", "gruel", "twice", "twang", "shrug", "treat", "unlit", "waste", "merit", "woven", "octal", "needy", "clown", "widow", "irony", "ruder", "gauze", "chief", "onset", "prize", "fungi", "charm", "gully", "inter", "whoop", "taunt", "leery", "class", "theme", "lofty", "tibia", "booze", "alpha", "thyme", "eclat", "doubt", "parer", "chute", "stick", "trice", "alike", "sooth", "recap", "saint", "liege", "glory", "grate", "admit", "brisk", "soggy", "usurp", "scald", "scorn", "leave", "twine", "sting", "bough", "marsh", "sloth", "dandy", "vigor", "howdy", "enjoy", "valid", "ionic", "equal", "unset", "floor", "catch", "spade", "stein", "exist", "quirk", "denim", "grove", "spiel", "mummy", "fault", "foggy", "flout", "carry", "sneak", "libel", "waltz", "aptly", "piney", "inept", "aloud", "photo", "dream", "stale", "vomit", "ombre", "fanny", "unite", "snarl", "baker", "there", "glyph", "pooch", "hippy", "spell", "folly", "louse", "gulch", "vault", "godly", "threw", "fleet", "grave", "inane", "shock", "crave", "spite", "valve", "skimp", "claim", "rainy", "musty", "pique", "daddy", "quasi", "arise", "aging", "valet", "opium", "avert", "stuck", "recut", "mulch", "genre", "plume", "rifle", "count", "incur", "total", "wrest", "mocha", "deter", "study", "lover", "safer", "rivet", "funny", "smoke", "mound", "undue", "sedan", "pagan", "swine", "guile", "gusty", "equip", "tough", "canoe", "chaos", "covet", "human", "udder", "lunch", "blast", "stray", "manga", "melee", "lefty", "quick", "paste", "given", "octet", "risen", "groan", "leaky", "grind", "carve", "loose", "sadly", "spilt", "apple", "slack", "honey", "final", "sheen", "eerie", "minty", "slick", "derby", "wharf", "spelt", "coach", "erupt", "singe", "price", "spawn", "fairy", "jiffy", "filmy", "stack", "chose", "sleep", "ardor", "nanny", "niece", "woozy", "handy", "grace", "ditto", "stank", "cream", "usual", "diode", "valor", "angle", "ninja", "muddy", "chase", "reply", "prone", "spoil", "heart", "shade", "diner", "arson", "onion", "sleet", "dowel", "couch", "palsy", "bowel", "smile", "evoke", "creek", "lance", "eagle", "idiot", "siren", "built", "embed", "award", "dross", "annul", "goody", "frown", "patio", "laden", "humid", "elite", "lymph", "edify", "might", "reset", "visit", "gusto", "purse", "vapor", "crock", "write", "sunny", "loath", "chaff", "slide", "queer", "venom", "stamp", "sorry", "still", "acorn", "aping", "pushy", "tamer", "hater", "mania", "awoke", "brawn", "swift", "exile", "birch", "lucky", "freer", "risky", "ghost", "plier", "lunar", "winch", "snare", "nurse", "house", "borax", "nicer", "lurch", "exalt", "about", "savvy", "toxin", "tunic", "pried", "inlay", "chump", "lanky", "cress", "eater", "elude", "cycle", "kitty", "boule", "moron", "tenet", "place", "lobby", "plush", "vigil", "index", "blink", "clung", "qualm", "croup", "clink", "juicy", "stage", "decay", "nerve", "flier", "shaft", "crook", "clean", "china", "ridge", "vowel", "gnome", "snuck", "icing", "spiny", "rigor", "snail", "flown", "rabid", "prose", "thank", "poppy", "budge", "fiber", "moldy", "dowdy", "kneel", "track", "caddy", "quell", "dumpy", "paler", "swore", "rebar", "scuba", "splat", "flyer", "horny", "mason", "doing", "ozone", "amply", "molar", "ovary", "beset", "queue", "cliff", "magic", "truce", "sport", "fritz", "edict", "twirl", "verse", "llama", "eaten", "range", "whisk", "hovel", "rehab", "macaw", "sigma", "spout", "verve", "sushi", "dying", "fetid", "brain", "buddy", "thump", "scion", "candy", "chord", "basin", "march", "crowd", "arbor", "gayly", "musky", "stain", "dally", "bless", "bravo", "stung", "title", "ruler", "kiosk", "blond", "ennui", "layer", "fluid", "tatty", "score", "cutie", "zebra", "barge", "matey", "bluer", "aider", "shook", "river", "privy", "betel", "frisk", "bongo", "begun", "azure", "weave", "genie", "sound", "glove", "braid", "scope", "wryly", "rover", "assay", "ocean", "bloom", "irate", "later", "woken", "silky", "wreck", "dwelt", "slate", "smack", "solid", "amaze", "hazel", "wrist", "jolly", "globe", "flint", "rouse", "civil", "vista", "relax", "cover", "alive", "beech", "jetty", "bliss", "vocal", "often", "dolly", "eight", "joker", "since", "event", "ensue", "shunt", "diver", "poser", "worst", "sweep", "alley", "creed", "anime", "leafy", "bosom", "dunce", "stare", "pudgy", "waive", "choir", "stood", "spoke", "outgo", "delay", "bilge", "ideal", "clasp", "seize", "hotly", "laugh", "sieve", "block", "meant", "grape", "noose", "hardy", "shied", "drawl", "daisy", "putty", "strut", "burnt", "tulip", "crick", "idyll", "vixen", "furor", "geeky", "cough", "naive", "shoal", "stork", "bathe", "aunty", "check", "prime", "brass", "outer", "furry", "razor", "elect", "evict", "imply", "demur", "quota", "haven", "cavil", "swear", "crump", "dough", "gavel", "wagon", "salon", "nudge", "harem", "pitch", "sworn", "pupil", "excel", "stony", "cabin", "unzip", "queen", "trout", "polyp", "earth", "storm", "until", "taper", "enter", "child", "adopt", "minor", "fatty", "husky", "brave", "filet", "slime", "glint", "tread", "steal", "regal", "guest", "every", "murky", "share", "spore", "hoist", "buxom", "inner", "otter", "dimly", "level", "sumac", "donut", "stilt", "arena", "sheet", "scrub", "fancy", "slimy", "pearl", "silly", "porch", "dingo", "sepia", "amble", "shady", "bread", "friar", "reign", "dairy", "quill", "cross", "brood", "tuber", "shear", "posit", "blank", "villa", "shank", "piggy", "freak", "which", "among", "fecal", "shell", "would", "algae", "large", "rabbi", "agony", "amuse", "bushy", "copse", "swoon", "knife", "pouch", "ascot", "plane", "crown", "urban", "snide", "relay", "abide", "viola", "rajah", "straw", "dilly", "crash", "amass", "third", "trick", "tutor", "woody", "blurb", "grief", "disco", "where", "sassy", "beach", "sauna", "comic", "clued", "creep", "caste", "graze", "snuff", "frock", "gonad", "drunk", "prong", "lurid", "steel", "halve", "buyer", "vinyl", "utile", "smell", "adage", "worry", "tasty", "local", "trade", "finch", "ashen", "modal", "gaunt", "clove", "enact", "adorn", "roast", "speck", "sheik", "missy", "grunt", "snoop", "party", "touch", "mafia", "emcee", "array", "south", "vapid", "jelly", "skulk", "angst", "tubal", "lower", "crest", "sweat", "cyber", "adore", "tardy", "swami", "notch", "groom", "roach", "hitch", "young", "align", "ready", "frond", "strap", "puree", "realm", "venue", "swarm", "offer", "seven", "dryer", "diary", "dryly", "drank", "acrid", "heady", "theta", "junto", "pixie", "quoth", "bonus",
             "shalt", "penne", "amend", "datum", "build", "piano", "shelf", "lodge", "suing", "rearm", "coral", "ramen", "worth", "psalm", "infer", "overt", "mayor", "ovoid", "glide", "usage", "poise", "randy", "chuck", "prank", "fishy", "tooth", "ether", "drove", "idler", "swath", "stint", "while", "begat", "apply", "slang", "tarot", "radar", "credo", "aware", "canon", "shift", "timer", "bylaw", "serum", "three", "steak", "iliac", "shirk", "blunt", "puppy", "penal", "joist", "bunny", "shape", "beget", "wheel", "adept", "stunt", "stole", "topaz", "chore", "fluke", "afoot", "bloat", "bully", "dense", "caper", "sneer", "boxer", "jumbo", "lunge", "space", "avail", "short", "slurp", "loyal", "flirt", "pizza", "conch", "tempo", "droop", "plate", "bible", "plunk", "afoul", "savoy", "steep", "agile", "stake", "dwell", "knave", "beard", "arose", "motif", "smash", "broil", "glare", "shove", "baggy", "mammy", "swamp", "along", "rugby", "wager", "quack", "squat", "snaky", "debit", "mange", "skate", "ninth", "joust", "tramp", "spurn", "medal", "micro", "rebel", "flank", "learn", "nadir", "maple", "comfy", "remit", "gruff", "ester", "least", "mogul", "fetch", "cause", "oaken", "aglow", "meaty", "gaffe", "shyly", "racer", "prowl", "thief", "stern", "poesy", "rocky", "tweet", "waist", "spire", "grope", "havoc", "patsy", "truly", "forty", "deity", "uncle", "swish", "giver", "preen", "bevel", "lemur", "draft", "slope", "annoy", "lingo", "bleak", "ditty", "curly", "cedar", "dirge", "grown", "horde", "drool", "shuck", "crypt", "cumin", "stock", "gravy", "locus", "wider", "breed", "quite", "chafe", "cache", "blimp", "deign", "fiend", "logic", "cheap", "elide", "rigid", "false", "renal", "pence", "rowdy", "shoot", "blaze", "envoy", "posse", "brief", "never", "abort", "mouse", "mucky", "sulky", "fiery", "media", "trunk", "yeast", "clear", "skunk", "scalp", "bitty", "cider", "koala", "duvet", "segue", "creme", "super", "grill", "after", "owner", "ember", "reach", "nobly", "empty", "speed", "gipsy", "recur", "smock", "dread", "merge", "burst", "kappa", "amity", "shaky", "hover", "carol", "snort", "synod", "faint", "haunt", "flour", "chair", "detox", "shrew", "tense", "plied", "quark", "burly", "novel", "waxen", "stoic", "jerky", "blitz", "beefy", "lyric", "hussy", "towel", "quilt", "below", "bingo", "wispy", "brash", "scone", "toast", "easel", "saucy", "value", "spice", "honor", "route", "sharp", "bawdy", "radii", "skull", "phony", "issue", "lager", "swell", "urine", "gassy", "trial", "flora", "upper", "latch", "wight", "brick", "retry", "holly", "decal", "grass", "shack", "dogma", "mover", "defer", "sober", "optic", "crier", "vying", "nomad", "flute", "hippo", "shark", "drier", "obese", "bugle", "tawny", "chalk", "feast", "ruddy", "pedal", "scarf", "cruel", "bleat", "tidal", "slush", "semen", "windy", "dusty", "sally", "igloo", "nerdy", "jewel", "shone", "whale", "hymen", "abuse", "fugue", "elbow", "crumb", "pansy", "welsh", "syrup", "terse", "suave", "gamut", "swung", "drake", "freed", "afire", "shirt", "grout", "oddly", "tithe", "plaid", "dummy", "broom", "blind", "torch", "enemy", "again", "tying", "pesky", "alter", "gazer", "noble", "ethos", "bride", "extol", "decor", "hobby", "beast", "idiom", "utter", "these", "sixth", "alarm", "erase", "elegy", "spunk", "piper", "scaly", "scold", "hefty", "chick", "sooty", "canal", "whiny", "slash", "quake", "joint", "swept", "prude", "heavy", "wield", "femme", "lasso", "maize", "shale", "screw", "spree", "smoky", "whiff", "scent", "glade", "spent", "prism", "stoke", "riper", "orbit", "cocoa", "guilt", "humus", "shush", "table", "smirk", "wrong", "noisy", "alert", "shiny", "elate", "resin", "whole", "hunch", "pixel", "polar", "hotel", "sword", "cleat", "mango", "rumba", "puffy", "filly", "billy", "leash", "clout", "dance", "ovate", "facet", "chili", "paint", "liner", "curio", "salty", "audio", "snake", "fable", "cloak", "navel", "spurt", "pesto", "balmy", "flash", "unwed", "early", "churn", "weedy", "stump", "lease", "witty", "wimpy", "spoof", "saner", "blend", "salsa", "thick", "warty", "manic", "blare", "squib", "spoon", "probe", "crepe", "knack", "force", "debut", "order", "haste", "teeth", "agent", "widen", "icily", "slice", "ingot", "clash", "juror", "blood", "abode", "throw", "unity", "pivot", "slept", "troop", "spare", "sewer", "parse", "morph", "cacti", "tacky", "spool", "demon", "moody", "annex", "begin", "fuzzy", "patch", "water", "lumpy", "admin", "omega", "limit", "tabby", "macho", "aisle", "skiff", "basis", "plank", "verge", "botch", "crawl", "lousy", "slain", "cubic", "raise", "wrack", "guide", "foist", "cameo", "under", "actor", "revue", "fraud", "harpy", "scoop", "climb", "refer", "olden", "clerk", "debar", "tally", "ethic", "cairn", "tulle", "ghoul", "hilly", "crude", "apart", "scale", "older", "plain", "sperm", "briny", "abbot", "rerun", "quest", "crisp", "bound", "befit", "drawn", "suite", "itchy", "cheer", "bagel", "guess", "broad", "axiom", "chard", "caput", "leant", "harsh", "curse", "proud", "swing", "opine", "taste", "lupus", "gumbo", "miner", "green", "chasm", "lipid", "topic", "armor", "brush", "crane", "mural", "abled", "habit", "bossy", "maker", "dusky", "dizzy", "lithe", "brook", "jazzy", "fifty", "sense", "giant", "surly", "legal", "fatal", "flunk", "began", "prune", "small", "slant", "scoff", "torus", "ninny", "covey", "viper", "taken", "moral", "vogue", "owing", "token", "entry", "booth", "voter", "chide", "elfin", "ebony", "neigh", "minim", "melon", "kneed", "decoy", "voila", "ankle", "arrow", "mushy", "tribe", "cease", "eager", "birth", "graph", "odder", "terra", "weird", "tried", "clack", "color", "rough", "weigh", "uncut", "ladle", "strip", "craft", "minus", "dicey", "titan", "lucid", "vicar", "dress", "ditch", "gypsy", "pasta", "taffy", "flame", "swoop", "aloof", "sight", "broke", "teary", "chart", "sixty", "wordy", "sheer", "leper", "nosey", "bulge", "savor", "clamp", "funky", "foamy", "toxic", "brand", "plumb", "dingy", "butte", "drill", "tripe", "bicep", "tenor", "krill", "worse", "drama", "hyena", "think", "ratio", "cobra", "basil", "scrum", "bused", "phone", "court", "camel", "proof", "heard", "angel", "petal", "pouty", "throb", "maybe", "fetal", "sprig", "spine", "shout", "cadet", "macro", "dodgy", "satyr", "rarer", "binge", "trend", "nutty", "leapt", "amiss", "split", "myrrh", "width", "sonar", "tower", "baron", "fever", "waver", "spark", "belie", "sloop", "expel", "smote", "baler", "above", "north", "wafer", "scant", "frill", "awash", "snack", "scowl", "frail", "drift", "limbo", "fence", "motel", "ounce", "wreak", "revel", "talon", "prior", "knelt", "cello", "flake", "debug", "anode", "crime", "salve", "scout", "imbue", "pinky", "stave", "vague", "chock", "fight", "video", "stone", "teach", "cleft", "frost", "prawn", "booty", "twist", "apnea", "stiff", "plaza", "ledge", "tweak", "board", "grant", "medic", "bacon", "cable", "brawl", "slunk", "raspy", "forum", "drone", "women", "mucus", "boast", "toddy", "coven", "tumor", "truer", "wrath", "stall", "steam", "axial", "purer", "daily", "trail", "niche", "mealy", "juice", "nylon", "plump", "merry", "flail", "papal", "wheat", "berry", "cower", "erect", "brute", "leggy", "snipe", "sinew", "skier", "penny", "jumpy", "rally", "umbra", "scary", "modem", "gross", "avian", "greed", "satin", "tonic", "parka", "sniff", "livid", "stark", "trump", "giddy", "reuse", "taboo", "avoid", "quote", "devil", "liken", "gloss", "gayer", "beret", "noise", "gland", "dealt", "sling", "rumor", "opera", "thigh", "tonga", "flare", "wound", "white", "bulky", "etude", "horse", "circa", "paddy", "inbox", "fizzy", "grain", "exert", "surge", "gleam", "belle", "salvo", "crush", "fruit", "sappy", "taker", "tract", "ovine", "spiky", "frank", "reedy", "filth", "spasm", "heave", "mambo", "right", "clank", "trust", "lumen", "borne", "spook", "sauce", "amber", "lathe", "carat", "corer", "dirty", "slyly", "affix", "alloy", "taint", "sheep", "kinky", "wooly", "mauve", "flung", "yacht", "fried", "quail", "brunt", "grimy", "curvy", "cagey", "rinse", "deuce", "state", "grasp", "milky", "bison", "graft", "sandy", "baste", "flask", "hedge", "girly", "swash", "boney", "coupe", "endow", "abhor", "welch", "blade", "tight", "geese", "miser", "mirth", "cloud", "cabal", "leech", "close", "tenth", "pecan", "droit", "grail", "clone", "guise", "ralph", "tango", "biddy", "smith", "mower", "payee", "serif", "drape", "fifth", "spank", "glaze", "allot", "truck", "kayak", "virus", "testy", "tepee", "fully", "zonal", "metro", "curry", "grand", "banjo", "axion", "bezel", "occur", "chain", "nasal", "gooey", "filer", "brace", "allay", "pubic", "raven", "plead", "gnash", "flaky", "munch", "dully", "eking", "thing", "slink", "hurry", "theft", "shorn", "pygmy", "ranch", "wring", "lemon", "shore", "mamma", "froze", "newer", "style", "moose", "antic", "drown", "vegan", "chess", "guppy", "union", "lever", "lorry", "image", "cabby", "druid", "exact", "truth", "dopey", "spear", "cried", "chime", "crony", "stunk", "timid", "batch", "gauge", "rotor", "crack", "curve", "latte", "witch", "bunch", "repel", "anvil", "soapy", "meter", "broth", "madly", "dried", "scene", "known", "magma", "roost", "woman", "thong", "punch", "pasty", "downy", "knead", "whirl", "rapid", "clang", "anger", "drive", "goofy", "email", "music", "stuff", "bleep", "rider", "mecca", "folio", "setup", "verso", "quash", "fauna", "gummy", "happy", "newly", "fussy", "relic", "guava", "ratty", "fudge", "femur", "chirp", "forte", "alibi", "whine", "petty", "golly", "plait", "fleck", "felon", "gourd", "brown", "thrum", "ficus", "stash", "decry", "wiser", "junta", "visor", "daunt", "scree", "impel", "await", "press", "whose", "turbo", "stoop", "speak", "mangy", "eying", "inlet", "crone", "pulse", "mossy", "staid", "hence", "pinch", "teddy", "sully", "snore", "ripen", "snowy", "attic", "going", "leach", "mouth", "hound", "clump", "tonal", "bigot", "peril", "piece", "blame", "haute", "spied", "undid", "intro", "basal", "shine", "gecko", "rodeo", "guard", "steer", "loamy", "scamp", "scram", "manly", "hello", "vaunt", "organ", "feral", "knock", "extra", "condo", "adapt", "willy", "polka", "rayon", "skirt", "faith", "torso", "match", "mercy", "tepid", "sleek", "riser", "twixt", "peace", "flush", "catty", "login", "eject", "roger", "rival", "untie", "refit", "aorta", "adult", "judge", "rower", "artsy", "rural", "shave"]

    print(len.list)
    print(list[40])
    #print(list["ulcer"])


    d1 = datetime.strptime('2022-01-01', '%Y-%m-%d')
    hoje = date.today().strftime('%Y-%m-%d')
    d2 = datetime.strptime(hoje, '%Y-%m-%d')
    index = abs((d2 - d1).days)

    wrd = lista[index-1].upper()

    msg = "The word today is: "

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