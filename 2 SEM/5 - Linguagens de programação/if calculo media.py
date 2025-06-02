classificacao = ''
nome = input('Nome do aluno: ')
media = input('Nota do aluno: ')
presenca = input('Presença do aluno: ')
if(int(media)>=50 and int(presenca)>=75):
    classificacao = ('está aprovado')
if(int(media)>=50 and int(presenca)<=75):
    classificacao = ('deverá repor aulas')
if(int(media)<=50 and int(presenca)>=75):
    classificacao = ('deverá realizar trabalhos de recuperação')
if(int(media)<=50 and int(presenca)<=75):
    classificacao = ('deverá realizar trabalhos de recuperação e repor aulas')
print(f"O aluno {nome} com média {media} e {presenca}% de presença {classificacao}")
