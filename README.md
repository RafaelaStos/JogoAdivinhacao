# Jogo de Adivinhação
 
Um jogo de adivinhação onde o computador pensará em um número, e você, jogador, precisará adivinhá-lo. 
A cada erro, a máquina lhe dirá se o número chutado foi maior ou menor do que o pensado. 
Você também poderá escolher o nível de dificuldade do jogo, e isso lhe dará mais ou menos oportunidades de chutar um número. 
Ao final, se você ganhar, o computador lhe dirá quantos pontos você fez, baseando-se em quão bons eram seus chutes.

---

## Funcionalidades

   - Recebe como entrada o nivel de dificuldade.
   - Solicita o palpites dos chutes.
   - Atualiza a pontuação em cada erro.
   - Imprime a quantidade de tentativas,o quão perto foi seu chute, e sua pontuação total.
---
## Requisitos

    .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

---

## Como Usar

    Clone o repositório ou baixe o código fonte do projeto.
    Abra ou terminal ou o prompt de comando e navegue até a pasta raiz da solução.
    Utilize o comando abaixo para restaurar as dependências do projeto.

dotnet restore

    Em seguida, compile a solução utilizando o comando:

dotnet build --configuration Release

    Para executar o projeto compilando em tempo real

dotnet run --project RoboTupiniquim.ConsoleApp

    Para executar o arquivo compilado, navegue até a pasta ./RoboTupiniquim.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:

RoboTupiniquim.ConsoleApp.exe



