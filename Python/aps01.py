#Aluno: Jonathan Guimarães Ferreira Fernandes
#Matrícula: **********
#Professor, comentei bastante para explicar o que eu estava fazendo em cada trecho de código. 
#Perdoe-me, caso tenham ficado muito comentado.

print('Digite uma palavra com 6 caracteres: ')
#Lendo uma string, substituindo o espaço por '*' e colocando a String em maíusculo.
palavra = input().replace(' ', '*').upper() 

if (len(palavra) < 6):
  palavra = palavra.ljust(6).replace(' ', '*') #Verifica se a palavra é menor, caso seja verdade é adicionado o caractere '*' a palavra. 

if (len(palavra) >6 ):
  palavra = palavra[0:6] #Pega apenas a palavra até 6 caracteres, caso seja maior que 6.

print('Sua palavra é: ' + palavra)
#Criando um dicionário com as letras tendo como refêrencia os números. 
tabela_numerica = {'A': 1, 'B': 2, 'C': 3,
                   'D': 4, 'E': 5, 'F': 6,
                   'G': 7, 'H': 8, 'I': 9,
                   'J':10, 'K': 11, 'L': 12,
                   'M':13, 'N': 14, 'O': 15,
                   'P': 16, 'Q': 17, 'R': 18,
                   'S': 19, 'T':20, 'U': 21,
                   'V': 22, 'W': 23, 'X':24,
                   'Y': 25, 'Z': 26, '*': 0 }

#Foreach dentro de cada letra da String e caso a letra seja igual ao da tabela_numerica, é adicionado o valor do dicionário dentro do Array.
#(Acreditei que daria uma boa perfomarce e ficaria bem escrito, por isso fiz dessa forma.)
matriz_m = []
lista_auxiliar = []
for letra in palavra:
  lista_auxiliar.append(tabela_numerica[letra])
# 0 e 2, 1 e 3, 2 e 4 (i + 2). Adicionando lista para uma lista de lista de números.
print('\n' + 'Matriz númerica referente a palavra ' + palavra)
for x in range(3):
  matriz_m.append([lista_auxiliar[x], lista_auxiliar[3 + x]])
  print([lista_auxiliar[x], lista_auxiliar[3 + x]])

matriz_de_criptografia = [[1, 0, 1], 
                          [1, 1, 1],
                          [0, 2, -1]]

#Calculando o produto das matrizes

num_linhas_A = len(matriz_de_criptografia)
num_colunas_A = len(matriz_de_criptografia[0])
num_linhas_B = len(matriz_m)
num_colunas_B = len(matriz_m[0])

C = []

for linha in range(num_linhas_A):
  C.append([])
  for coluna in range(num_colunas_B):
    C[linha].append(0)
    for k in range(num_colunas_A):
      C[linha][coluna] += matriz_de_criptografia[linha][k] * matriz_m[k][coluna]

print('===============================================')
print('===================RESULTADO===================')
print('===============================================')
print('\n\nMatriz criptografada: ')
for i in C:
  print(i)
#imprimindo a matrix criptografada.
