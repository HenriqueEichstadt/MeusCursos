# ## Dicionários

# Isso é uma lista
estudantes_lst = ["Mateus", 24, "Fernanda", 22, "Tamires", 26, "Cristiano", 25]   
estudantes_lst

# Isso é um dicionário
estudantes_dict = {"Mateus":24, "Fernanda":22, "Tamires":26, "Cristiano":25}
estudantes_dict
estudantes_dict["Mateus"]
estudantes_dict["Pedro"] = 23
estudantes_dict["Pedro"]
estudantes_dict["Tamires"]
estudantes_dict.clear()
estudantes_dict
del estudantes_dict
estudantes_dict

estudantes = {"Mateus":24, "Fernanda":22, "Tamires":26, "Cristiano":25}
estudantes
len(estudantes)
estudantes.keys()
estudantes.values()
estudantes.items()

estudantes2 = {"Maria":27, "Erika":28, "Milton":26}
estudantes2
estudantes.update(estudantes2)
estudantes

dic1 = {}
dic1
dic1["key_one"] = 2
print(dic1)
dic1[10] = 5
dic1
dic1[8.2] = "Python"
dic1
dic1["teste"] = 5
dic1
dict1 = {}
dict1
dict1["teste"] = 10
dict1["key"] = "teste"

# Atenção, pois chave e valor podem ser iguais, mas representam coisas diferentes.
dict1
dict2 = {}
dict2["key1"] = "Big Data"
dict2["key2"] = 10
dict2["key3"] = 5.6
dict2
a = dict2["key1"]
b = dict2["key2"]
c = dict2["key3"]
a, b, c

# Dicionário de listas
dict3 = {'key1':1230,'key2':[22,453,73.4],'key3':['leite','maça','batata']}
dict3
dict3['key2']


# Acessando um item da lista, dentro do dicionário
dict3['key3'][0].upper()

# Operações com itens da lista, dentro do dicionário
var1 = dict3['key2'][0] - 2
var1


# Duas operações no mesmo comando, para atualizar um item dentro da lista
dict3['key2'][0] -= 2
dict3


# ### Criando dicionários aninhados

# Criando dicionários aninhados
dict_aninhado = {'key1':{'key2_aninhada':{'key3_aninhada':'Dict aninhado em Python'}}}
dict_aninhado

dict_aninhado['key1']['key2_aninhada']['key3_aninhada']