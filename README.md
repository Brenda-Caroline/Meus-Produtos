# Meus-Produtos
 API Web com ASP .NET 5 com c# e MySQL
 
 
O projeto foi realizado no Visual Studio e para a conexão com o banco de dados foi utilizado o MySQL Workbench, ambos instalados no notebook.

Para acessar o projeto é necessário possuir o Visual Studio instalado na máquina.

É possível abrir de algumas formas: 

1- Na primeira tela do repositório possui um botão verde escrito código, ao clicar nele é possível ver algumas possibilidades de execução, uma delas é o "Abrir com o Visual Studio". Clicando nessa opção, aparecerá um alert perguntando se deseja abri-lo, logo após o software irá abrir, será preciso clonar o repositório, na pasta em que você selecionar no seu dispositivo, espere o carregamento e clique na solução "Meus Produtos.sln" e por fim você poderá ter acesso aos arquivos. Para executar a aplicação selecione a tecla F5, ou Depurar -> Iniciar depuração ou no botão de play verde escrito IIS Express.

2- Outra forma de acesso, é baixar o arquivo zip. Essa ação pode ser realizada clicando no botão código e logo após download zip da tela inicial (Code -> download ZIP) do repositório no GitHub. Crie uma pasta em local desejado no computador e após o arquivo ser baixado, você deve clicar nele e abrir. Lopo após clique com o botão direito na pasta "Meus-Produtos-main" e clique "extrair para a pasta selecionada", busque pela pasta que foi criada e clique em Ok. Abra o seu Visual Studio e clique "Abrir um projeto ou uma solução", depois que aparecer as opções de pastas e arquivos, busque pela pasta criada, clique nela e logo após clique na pasta "Meus-Produtos-main" e selecione o arquivo "Meus Produtos.sln" e clique em Abrir. 
Agora para executar o projeto basta selecionar a tecla F5, ou Depurar -> Iniciar depuração ou no botão de play verde escrito IIS Express.

Ao ser executado, será aberto uma guia no navegador. Essa página possui três tópicos: Produtos, Usuários e Schemas. 
Nos schemas possuem dados das tabelas de banco de dados, onde mostra os dados, tipos e restrições dos produtos e usuários.

Nos tópicos de produtos e usuários possuem cinco possíveis ações: get, post get por id, put e delete.
Para executar funcionalidades, é necessário selecionar um tipo e clicar em "Try it out (experimente)". 
Se o selecionado for get, basta clicar em "execute" e será mostrado todos os tipos de dados armazenados no banco de dados.
Se o selecionado for post, é preciso digitar o respectivo dado que deseja ser acrescentado e clicando em "execute" será acrescentado ao banco. Caso digite alguma informação incorreta será repassado um erro. Cuidado nos campos que recebem strings, pois caso não seja escrito o que deseja será repassado o próprio nome "string", pois ele identifica que já é a string desejada e caso não tenha nada escrito entre as aspas será retornado um erro.
Se o selecionado for get {id}, será necessário repassar um id, clicando em "execute" será retornado as informações do id selecionado.


No projeto consegui executar as funcionalidades básicas, get, get por id, post, put e delete das tabelas produtos e usuários. Em relação as validações, consegui colocar quase todas, as que faltaram foram as que avaliam se o email é válido e se o email é único no banco e a senha ser criptografada. Também faltou a documentação do projeto , a implementação de rota autenticada, a implementação do retorno de um JWT no login e impedir acesso a uma rota a requisições sem JWT.


O principal desafio que encontrei ao desenvolver a aplicação foi em relação ao tempo, pois foi necessário aprender algo totalmente novo, aprender a usar ferramentas novas e nova linguagem.
Alguns problemas que encontrei foi ao tentar aprender a criação dos tipos de aplicações, onde sempre ocorria erro em relação aos pacotes e acabei ficando um bom tempo presa a essa questão diminuindo assim o tempo para a execução das funcionalidades do projeto. Além disso algo que atrapalhou foi o fato do notebook ficar processando por um bom tempo algumas funções. 


