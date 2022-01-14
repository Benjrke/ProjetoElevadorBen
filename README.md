# Projeto Final do Curso da Jornada Microsoft Dev na Ocean

-Projetar Um Elevador de acordo com as seguintes Especificações:

-**INSTRUÇÕES**

Utilize o Visual Studio Community, crie um projeto **Aplicativo de Console** (**console app) como nome ProjetoElevador, utilize a estrutura .NET 5 ou inferior.**

Todas as classes deverão ficar em uma pasta chamada Model, a estrutura com as pastas de Controller e View são opcionais.

Crie uma classe denominada Elevador para armazenar as informações de um elevador
dentro de um prédio, a classe deve armazenar o andar atual (térreo = 0), total de andares
no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
presentes nele. A classe deve também disponibilizar os seguintes métodos:

**Métodos:**

***Inicializar*** : deve receber como parâmetros a capacidade do elevador e o total de
andares no prédio (os elevadores sempre começam no térreo e vazio);

***Entrar*** : deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
espaço);

***Sair*** : deve remover uma pessoa do elevador (só deve remover se houver alguém
dentro dele);

***Subir*** : deve subir um andar (não deve subir se já estiver no último andar);

***Descer*** : deve descer um andar (não deve descer se já estiver no térreo);

> Dica: O usuário vai informar quantos andares o elevador possui e a capacidade de pessoas.
> 

Utilize o Visual Studio Community, crie um projeto  Aplicativo Web do [ASP.NET](http://ASP.NET) CORE (Model-View-Controller) **como nome ProjetoElevador_Documentacao, utilize a estrutura .NET 5 ou inferior.**

Na página inicial descreva um passo a passo de como funciona o seu projeto Elevador.

**Opcional:**

 - Publique o seu projeto WEB MVC em sua conta Azure utilizando o serviço WebApp.

 - Crie um aplicativo do tipo página (Canvas App) pelo Power Apps que represente um Login, apenas o front-end deve ser realizado, sem conexão com tabela.
