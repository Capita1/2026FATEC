nome = input('Seu nome:')
altura = input('Sua altura em centimetros:')
peso = input('Seu peso em KG:')
altura /= 100
M = ((peso)/(altura*altura))
classificacao = ''

if(M<16):
    classificacao = ('Baixo peso muito grave')
if(M>16 and 16.99>M):
    classificacao = ('Baixo peso grave')
if(M>17 and 18.49>M):
    classificacao = ('Baixo peso')
if(M>18.50 and 24.99>M):
    classificacao = ('Peso normal')
if(M>25 and 29.99>M):
    classificacao = ('Sobrepeso')
if(M>30 and 34.99>M):
    classificacao = ('Obesidade grau I')
if(M>35 and 39.99>M):
    classificacao = ('Obesidade grau II')
if(M>40):
    classificacao = ('Obesidade grau III')

print(+nome+' possui índice de massa corporal igual a '+((M * 100) / 100)+' sendo classificado como '+classificacao)
