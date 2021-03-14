
# Atribuindo o valor 1 à variável var_teste
var_teste = 1

# Imprimindo o valor da variável
var_teste

# Imprimindo o valor da variável
print(var_teste)

# Não podemos utilizar uma variável que não foi definida. Veja a mensagem de erro.
my_var

var_teste = 2
var_teste

type(var_teste)

var_teste = 9.5
type(var_teste)

x = 1
x

# ## Declaração Múltipla
pessoa1, pessoa2, pessoa3 = "Maria", "José", "Tobias"
pessoa1
pessoa2
pessoa3

fruta1 = fruta2 = fruta3 = "Laranja"
fruta1
fruta2

# Fique atento!!! Python é case-sensitive. Criamos a variável fruta2, mas não a variável Fruta2.
# Letras maiúsculas e minúsculas tem diferença no nome da variável.
Fruta2


# ## Pode-se usar letras, números e underline (mas não se pode começar com números)
x1 = 50
x1

# Mensagem de erro, pois o Python não permite nomes de variáveis que iniciem com números
1
x = 50


# ## Não se pode usar palavras reservadas como nome de variável
# 
# ## False      
# ## class      
# ## finally    
# ## is         
# ## return
# ## None       
# ## continue   
# ## for        
# ## lambda     
# ## try
# ## True       
# ## def        
# ## from       
# ## nonlocal   
# ## while
# ## and        
# ## del        
# ## global     
# ## not        
# ## with
# ## as         
# ## elif       
# ## if         
# ## or         
# ## yield
# ## assert     
# ## else       
# ## import     
# ## pass
# ## break      
# ## except     
# ## in         
# ## raise

# Não podemos usar palavras reservadas como nome de variável
break = 1


# ## Variáveis atribuídas a outras variáveis e ordem dos operadores
largura = 2
altura = 4
area = largura * altura
area
perimetro = 2 * largura + 2 * altura
perimetro

# A ordem dos operadores é a mesma seguida na Matemática
perimetro = 2 * (largura + 2)  * altura
perimetro


# ## Operações com variáveis
idade1 = 25
idade2 = 35
idade1 + idade2
idade2 - idade1
idade2 * idade1
idade2 / idade1
idade2 % idade1


# ## Concatenação de Variáveis
nome = "Steve"
sobrenome = "Jobs"
fullName = nome + " " + sobrenome
fullName