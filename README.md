# ProjetoEmpresa
Uppertools

# Plataforma integrada

Exercício feito com único propósito de ingresso no processo de seleção para oportunidade de desenvolvimento na Uppertools Tecnologia da Informação


# Justificativas

Utilize esta seção e as seguintes para melhor justificar suas escolhas, quanto a tecnologias, técnicas, padrões de design e principalmente escolhas FUNCIONAIS que foram feitas no decorrer do desenvolvimento.
Aproveite este espaço para deixar claro também as dúvidas ou dificuldades QUE O IMPEDIRAM DE PROSSEGUIR em determinados pontos.
Tudo isto será avaliado!!

Para exemplificar, alguns subtópicos que podem ser abordados, mas que NÃO SÃO OBRIGATÓRIOS, ou seja, sinta-se a vontade para criar seus próprios tópicos:

## Arquitetura

Utilizei a arquitetura em camadas MVC para realizar o projeto, e criei meu banco de dados pelo fluxo Code First utilizando o Entity Framework.

## Tecnologias

O projeto foi desenvolvido na linguagem C# como aplicativo WEB ASP.NET, o banco de dados foi feito em Microsoft SQL Server. 
Gostaria de pedir desculpas se em algum momento não segui padrões ou boas práticas da linguagem, pois foi minha primeira vez programando em C# e ASP.NET.
Também utilizei JQuery para acessar a API da Receita Federal e fazer algumas validações de campos.

## Dificuldades gerais

Na verdade, eu tive dificuldades de encontrar uma API válida que trouxesse os dados da Receita Federal de maneira gratuita.
Eu não sei se existe algum lugar, além do Google, pra encontrar APIs boas, pois foi apenas o segundo projeto que fiz utilizando API e o primeiro me foi fornecido o endereço dela. 
Vi que existem algumas APIs para utilizar nos Pacotes Nugget, mas escolhi não utilizar pois não sei se isso seria "errado" por ser fácil demais. Então acabei utilizando uma que é paga, mas posso realizar 30 pesquisas por dia (um pouco mais se eu utilizar o cachê dos ultimos 90 dias deles, que eu coloquei no código), acho que isso não vai ser um problema (eu não sei qual seria a resposta do get se testar demais, porque tive medo de extrapolar as 30 pesquisas e não liberar mais).
Eu tentei fazer um controller pra API mas tive dificuldades, não tive muita certeza de como utilizar dois controllers na mesma View e como trazer os dados do Controller pra preencher os campos com eles antes de salvar no banco de dados e tal. 
Mas encontrei uma saída alternativa e acabei utilizando o JQuery pra fazer minha requisição GET e popular meus campos do formulário.
Não fiz a tabela do banco de dados muito grande e nem puxei muitos dados do JSON, pois achei que não era essa a intenção. Se era pra colocar todos os campos de um cartão CNPJ no formulário eu peço desculpas se entendi errado.

## Conclusão

Gostei muito de fazer o projeto! Foi muito legal aprender uma nova linguagem, descobrir como conectar cada uma dessas tecnologias!
Eu já tinha programado em arquitetura em camadas antes, mas foi em Java e foi algo bem simples, então foi como aprender de novo. 
Espero que me dêem uma chance de trabalhar com vocês e aprender mais ainda! 
Obrigada!
