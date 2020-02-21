# Weather Forecast

Exemplo de Aplicação Web que retorna a previsão do tempo para 7 dias, baseado na cidade informada, consumindo Web Services do CPTEC/INPE (http://servicos.cptec.inpe.br/XML/) para a busca das informações

![](/misc/ModelClass.png)

![](/misc/ComponentDiagram.png)

## Tecnologias Utilizadas

### Back-End (C# - .NET Core)

* src/WFDomain - Biblioteca do Domínio, Lógica do Negócio e Modelo de Dados do Projeto (baseado nos XMLs retornados)

### Front-End (C# - .NET Core; TypeScript/JavaScript/HTML/CSS - Angular com Angular Material-https://material.angular.io/)

* src/WFWeb - Api Web MVC e Single Page Application (Microsoft.AspNetCore.SpaServices.Extensions), utilizando os padrões "MVC" e "Dependency Injection" para Inversão de Controle

## Screenshots da Aplicação

![](/misc/screenshots/01.png)
![](/misc/screenshots/02.png)
![](/misc/screenshots/03.png)
![](/misc/screenshots/04.png)
