
# # Funções

# Definindo uma função
def primeiraFunc():
    print('Hello World')

primeiraFunc()

# Definindo uma função com parâmetro
def primeiraFunc(nome):
    print('Hello %s' %(nome))


primeiraFunc('Aluno')


def funcLeitura():
    for i in range(0, 5):
        print("Número " + str(i))

funcLeitura()


# Função para somar números
def addNum(firstnum, secondnum):
    print("Primeiro número: " + str(firstnum))
    print("Segundo número: " + str(secondnum))
    print("Soma: ", firstnum + secondnum)


# Chamando a função e passando parâmetros
addNum(45, 3)

# ### Variáveis locais e globais
# Variável Global
var_global = 10  # Esta é uma variável global

def multiply(num1, num2):
    var_global = num1 * num2  # Esta é uma variável local
    print(var_global)

multiply(5, 25)

print(var_global)

# Variável Local
var_global = 10  # Esta é uma variável global
def multiply(num1, num2):
    var_local = num1 * num2   # Esta é uma variável local
    print(var_local)


multiply(5, 25)

print(var_local)

# ### Funções Built-in
abs(-56)
abs(23)
bool(0)
bool(1)

# ### Funções str, int, float

# Erro ao executar por causa da conversão
idade = input("Digite sua idade: ")
if idade > 13:
  print("Você pode acessar o Facebook")  

# Usando a função int para converter o valor digitado
idade = int(input("Digite sua idade: "))
if idade > 13:
  print("Você pode acessar o Facebook")  

int("26")
float("123.345")
str(14)
len([23,34,45,46])

array = ['a', 'b', 'c']
max(array)
min(array)

array = ['a', 'b', 'c', 'd', 'A', 'B', 'C', 'D']
array
max(array)
min(array)


list1 = [23, 23, 34, 45]
sum(list1)


# ### Criando funções usando outras funções

import math

def numPrimo(num):
    '''
    Verificando se um número 
    é primo. 
    '''
    if (num % 2) == 0 and num > 2: 
        return "Este número não é primo"
    for i in range(3, int(math.sqrt(num)) + 1, 2):
        if (num % i) == 0:
            return "Este número não é primo"
    return "Este número é primo"


numPrimo(541)


# ### Fazendo split dos dados


# Fazendo split dos dados
def split_string(text):
    return text.split(" ")

texto = "Esta função será bastante útil para separar grandes volumes de dados."


# Isso divide a string em uma lista.
print(split_string(texto))


# Podemos atribuir o output de uma função, para uma variável
token = split_string(texto)
token

caixa_baixa = "Este Texto Deveria Estar Todo Em LowerCase"

def lowercase(text):
    return text.lower()

lowercased_string = lowercase(caixa_baixa)
lowercased_string


# Funções com número variável de argumentos
def printVarInfo( arg1, *vartuple ):
   # Imprimindo o valor do primeiro argumento
    print ("O parâmetro passado foi: ", arg1)
   
   # Imprimindo o valor do segundo argumento 
    for item in vartuple:
        print ("O parâmetro passado foi: ", item)
    return;


# Fazendo chamada à função usando apenas 1 argumento
printVarInfo(10)

printVarInfo('Chocolate', 'Morango', 'Banana')