# Jogo de Adivinha��o
 
Um jogo de adivinha��o onde o computador pensar� em um n�mero, e voc�, jogador, precisar� adivinh�-lo. 
A cada erro, a m�quina lhe dir� se o n�mero chutado foi maior ou menor do que o pensado. 
Voc� tamb�m poder� escolher o n�vel de dificuldade do jogo, e isso lhe dar� mais ou menos oportunidades de chutar um n�mero. 
Ao final, se voc� ganhar, o computador lhe dir� quantos pontos voc� fez, baseando-se em qu�o bons eram seus chutes.

---

## Funcionalidades

   - Recebe como entrada o nivel de dificuldade.
   - Solicita o palpites dos chutes.
   - Atualiza a pontua��o em cada erro.
   - Imprime a quantidade de tentativas,o qu�o perto foi seu chute, e sua pontua��o total.
---
## Requisitos

    .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

---

## Como Usar

    Clone o reposit�rio ou baixe o c�digo fonte do projeto.
    Abra ou terminal ou o prompt de comando e navegue at� a pasta raiz da solu��o.
    Utilize o comando abaixo para restaurar as depend�ncias do projeto.

dotnet restore

    Em seguida, compile a solu��o utilizando o comando:

dotnet build --configuration Release

    Para executar o projeto compilando em tempo real

dotnet run --project RoboTupiniquim.ConsoleApp

    Para executar o arquivo compilado, navegue at� a pasta ./RoboTupiniquim.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:

RoboTupiniquim.ConsoleApp.exe



