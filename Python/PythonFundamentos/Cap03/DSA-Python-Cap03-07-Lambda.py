
# # Expressões Lambda

# Definindo uma função - 3 linhas de código
def potencia(num):
    result = num**2
    return result

potencia(5)

# Definindo uma função - 2 linhas de código
def potencia(num):
    return num**2

potencia(5)


# Definindo uma função - 1 linha de código
def potencia(num): return num**2

potencia(5)

# Definindo uma expressão lambda
potencia = lambda num: num**2

potencia(5)


# Lembre: operadores de comparação retornam boolean, true or false
Par = lambda x: x%2==0
Par(3)
Par(4)

first = lambda s: s[0]
first('Python')

reverso = lambda s: s[::-1]
reverso('Python')

addNum = lambda x,y : x+y
addNum(2,3)