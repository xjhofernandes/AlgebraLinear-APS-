#Aluno: Jonathan Guimarães Ferreira Fernandes
#Matrícula: 2017201778
#Questão2: Recebendo a matriz criptografada e logo em seguida multiplicando com o inverso da matriz de criptografia. Após a multiplicação, exibindo a mensagem descriptografada.

import numpy as np

mensagem_criptografada = []

#ler matrix 3 x 2
for linha in range (3):
  mensagem_criptografada.append([])
  for coluna in range(2):
    mensagem_criptografada[linha].append(0)
    print('Adicionar valor na posição [' + str(linha) + ', '+ str(coluna) + '] da matriz')
    mensagem_criptografada[linha][coluna] += int(input())

print('============================================')
print('========== Matriz criptografada ============')
print('============================================')
for linha in mensagem_criptografada:
  print(linha)

print()
#invertendo matriz de criptografia
matriz_de_criptografia = [[1, 0, 1], 
                          [1, 1, 1],
                          [0, 2, -1]]
#Utilizando a função inv do numpy para calcular a inversa da Matriz. 
matriz_de_criptografia_inversa = np.linalg.inv(matriz_de_criptografia)

print('\n============================================')
print('=== Matriz de criptografia invertida(MC) ===')
print('============================================')

print(matriz_de_criptografia_inversa)

num_linhas_A = len(matriz_de_criptografia_inversa)
num_colunas_A = len(matriz_de_criptografia_inversa[0])
num_linhas_B = len(mensagem_criptografada)
num_colunas_B = len(mensagem_criptografada[0])

C = []
#Calculando a matrix inversa x matriz criptografada
for linha in range(num_linhas_A):
  C.append([])
  for coluna in range(num_colunas_B):
    C[linha].append(0)
    for k in range(num_colunas_A):
      C[linha][coluna] += int(matriz_de_criptografia_inversa[linha][k] * mensagem_criptografada[k][coluna])


tabela_numerica = {1: 'A', 2: 'B', 3: 'C',
                   4: 'D', 5: 'E', 6: 'F',
                   7: 'G', 8: 'H', 9: 'I',
                   10: 'J', 11: 'K', 12: 'L',
                   13: 'M', 14: 'N', 15: 'O',
                   16: 'P', 17: 'Q', 18: 'R',
                   19: 'S', 20: 'T', 21: 'U',
                   22: 'V', 23: 'W', 24: 'X',
                   25: 'Y', 26: 'Z', 0: '*' }


print('\n============================================')
print('===========Matriz descriptografada==========')
print('============================================')

mensagem_descriptografada = ''
#Acessando linha por linha e utilizando o dicionário para dar valor a string de mensagem descriptografada.
for linha in C:
  print(linha)
  for i in range(3):
    mensagem_descriptografada += tabela_numerica[i] 

print('\n============================================')
print('===========Mensagem descriptografada========')
print('============================================')

print(mensagem_descriptografada)