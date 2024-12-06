# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT- 01 – Login com Credenciais Válidas** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002: O sistema deve possuir opção de fazer login, sendo o login endereço de e-mail.  |
| Objetivo do Teste 	| Verificar se os usuários podem fazer login com credenciais válidas. |
| Passos 	| Passo 01 - Acessar a página de login <br>Passo 02 - Preencher o campo de e-mail e senha com credenciais válidas.<br>Passo 03- Clicar no botão de login. |
|Critério de Êxito | O usuário deve ser redirecionado para sua página inicial após o login bem-sucedido. |
|  	|  	|
| **Caso de Teste**	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001: O sistema deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| VVerificar se os novos usuários podem se cadastrar com sucesso no sistema. |
| Passos 	| Passo 01 - Acessar a página de cadastro. <br>Passo 02 - Preencher todos os campos obrigatórios do formulário de cadastro. <br>Passo 03 Clicar no botão de Cadastrar.|
|Critério de Êxito | O usuário deve ser redirecionado para a página inicial após o registro bem-sucedido e receber uma confirmação por e-mail. |
|  	|  	|
| **Caso de Teste**	| **CT- 03 – Solicitação de Recuperação de Senha**	|
|Requisito Associado | RF-008: O sistema deve permitir que o usuário recupere sua senha. |
| Objetivo do Teste 	| Verificar se os usuários podem solicitar a recuperação de senha com sucesso. |
| Passos 	| Passo 01- Acessar a página de recuperação de senha. <br>Passo 02 -Preencher o campo de e-mail cadastrado. <br>Passo 03 - Clicar no botão Enviar link para recuperar senha.<br>Passo 04 - Verificar se o usuário recebe um e-mail com instruções para recuperar a senha |
|Critério de Êxito |O usuário deve receber um e-mail com instruções claras sobre como recuperar a senha após solicitar a recuperação. | 
|  	|  	|
| **Caso de Teste**	| **CT- 04 – Exibição dos Recursos na Página Inicial Após o Login**	|
|Requisito Associado | RF-001: O sistema deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. <br> RF-003: O sistema deve permitir que o usuário cadastre e gerencie livros para venda.<br>RF-004: O sistema deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros por critérios diversos.<br>RF-005: O sistema deve ter um chat para conversação em cada anúncio para os usuários interagirem entre si.|
| Objetivo do Teste 	| Verificar se os usuários podem solicitar a recuperação de senha com sucesso. |
| Passos 	| Passo 01- Efetuar o login com um usuário válido.<br>Passo 02 - Verificar se a página inicial é carregada corretamente após o login.<br> Passo 03 -   Verificar se há uma seção "Meus Anúncios" visível. <br>Passo 04 - Verificar se há uma seção "Conversas" visível.<br>Passo 05 - Verificar se há uma seção "Meu Perfil" visível.<br>Passo 06 -  Verificar se há uma opção "Logout" visível para que o usuário possa sair da sessão.|
|Critério de Êxito |Todos os recursos mencionados nos passos devem estar presentes e funcionando corretamente na página inicial após o login do usuário. | 
|  	|  	|
| **Caso de Teste**	| **CT- 05 – Exibição dos Dados do Usuário e Listas de Anúncios e Favoritos**	|
|Requisito Associado | RF-001: O sistema deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil.<br>RF-003: O sistema deve permitir que o usuário cadastre e gerencie livros para venda. |
| Objetivo do Teste 	| Verificar se os dados do usuário, bem como as listas de seus anúncios e favoritos, são exibidos corretamente na página de perfil. |
| Passos 	| Passo 01 - Efetuar o login com um usuário válido.<br>Passo 02 - Navegar até a página de perfil do usuário.<br>Passo 03 - Verificar se os dados do usuário (como nome, e-mail, etc.) estão sendo exibidos corretamente <br>Passo 04 - Verificar se há uma seção "Meus Anúncios" que lista os anúncios do usuário.<br>Passo 05 - Verificar se há uma seção "Meus Favoritos" que lista os anúncios favoritos do usuário. |
|Critério de Êxito |Todos os dados do usuário devem ser exibidos corretamente, e as listas de anúncios e favoritos devem estar atualizadas e funcionando conforme esperado.| 
|  	|  	|
**Caso de Teste**	| **CT- 06 - Edição dos Dados do Perfil do Usuário**	|
|Requisito Associado | F-001: O sistema deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil.|
| Objetivo do Teste 	| Verificar se os usuários podem editar com sucesso os dados de seu perfil. |
| Passos 	| Passo 01- Efetuar o login com um usuário válido. <br>Passo 02 - Navegar até a página de edição de perfil do usuário. <br>Passo 03- Localizar os campos de edição de dados do perfil, como nome, e-mail, senha, etc. <br> Passo 04 - Alterar os dados desejados do perfil. <br>Passo 05 - Salvar as alterações. <br> Passo 06 - Verificar se as alterações foram salvas corretamente no perfil do usuário.|
|Critério de Êxito |As alterações feitas nos dados do perfil do usuário devem ser salvas com sucesso e refletidas corretamente na página de perfil.|
|  	|  	|
**Caso de Teste**	| **CT- 07 Cadastro de Novo Anúncio**	|
|Requisito Associado |RF-003: O sistema deve permitir que o usuário cadastre e gerencie livros para venda.|
| Objetivo do Teste 	| Verificar se os usuários conseguem cadastrar novos anúncios de livros para venda. |
| Passos 	| Passo 01- Efetuar o login com um usuário válido. <br>Passo 02 - Navegar até a página de cadastro de anúncio. <br> Passo 03 - Preencher os campos obrigatórios do formulário de cadastro, como título, descrição, Autor, editora, ISBN. <br> Passo 04 - Anexar imagens do livro, se aplicável.<br> Passo 05 – Publicar o anúncio. <br>Passo 06 - Verificar se o anúncio foi cadastrado com sucesso e está sendo exibido corretamente na lista de anúncios do usuário. <br>Passo 07 - Verificar se o anúncio foi publicado com sucesso e está sendo exibido corretamente na lista de anúncios da home pagina. |
|Critério de Êxito |O anúncio deve ser cadastrado com sucesso e estar disponível na lista de anúncios do usuário e na página inicial. |
|  	|  	|
**Caso de Teste**	| **CT- 08  Edição de Anúncio Existente**	|
|Requisito Associado |RF-003: O sistema deve permitir que o usuário cadastre e gerencie livros para venda.|
| Objetivo do Teste 	|Verificar se os usuários conseguem editar um anúncio existente de livro para venda.|
| Passos 	| Passo 01- Efetuar o login com um usuário válido. <br>Passo 02 - Navegar até a página de edição de anúncio.<br>Passo 02 - Selecionar o anúncio que deseja editar.<br>Passo 04 - Realizar as alterações desejadas nos campos do formulário de edição.<br>Passo 05 – Atualizar o anuncio <br>Passo 06 - Verificar se as alterações foram salvas com sucesso e refletidas no anúncio. |
|Critério de Êxito |As alterações feitas no anúncio devem ser salvas corretamente e refletidas na visualização do anúncio editado. |
|  	|  	|
**Caso de Teste**	| **CT- 09  Exclusão de Anúncio Existente**	|
|Requisito Associado |RF-003: O sistema deve permitir que o usuário cadastre e gerencie livros para venda.|
| Objetivo do Teste 	|Verificar se os usuários conseguem excluir um anúncio existente de livro para venda.|
| Passos 	| Passo 01- Efetuar o login com um usuário válido. <br>Passo 02 - Navegar até a página de edição de anúncio. <br>Passo 02 - Selecionar o anúncio que deseja excluir. <br>Passo 04 - Localizar a opção de exclusão do anúncio. <br>Passo 05 – Confirmar a exclusão do anúncio.<br>Passo 06 - Verificar se o anúncio foi removido com sucesso da lista de anúncios do usuário.|
|Critério de Êxito |O anúncio selecionado deve ser removido com sucesso da lista de anúncios do usuário. |
|  	|  	|
**Caso de Teste**	| **CT- 10  Visualização dos Detalhes de um Anúncio**	|
|Requisito Associado |RF-004: O sistema deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros por critérios diversos.|
| Objetivo do Teste 	|Verificar se os usuários conseguem visualizar os detalhes de um anúncio de livro.|
| Passos 	| Passo 01 – Acessar a página inicial do site. <br>Passo 02 - Selecionar o anúncio que deseja visualizar.<br>Passo 03 - Verificar se todas as informações relevantes do anúncio estão visíveis, título, descrição, Autor, editora, ISBN |
|Critério de Êxito |Todos os detalhes do anúncio selecionado devem estar visíveis e apresentados corretamente na página de detalhes. |
|  	|  	|
**Caso de Teste**	| **CT- 11  Funcionalidade de Chat entre Usuários**	|
|Requisito Associado |RF-005: O sistema deve ter um chat para conversação em cada anúncio para os usuários interagirem entre si.|
| Objetivo do Teste 	|Verificar se os usuários conseguem utilizar o chat para se comunicarem entre através do anuncio do livro.|
| Passos 	| Passo 01 - Efetuar o login com um usuário válido.<br>Passo 02 – Abrir um anuncio de livro. <br>Passo 03 - Selecionar o a opção mandar mensagem para anunciante. <br>Passo 04 - Enviar uma mensagem para o usuário selecionado.<br>Passo 05 - Verificar se a mensagem foi enviada com sucesso e se é exibida corretamente na conversa.<br>Passo 06 - Verificar se o anunciante recebeu a mensagem corretamente |
|Critério de Êxito |O usuário deve ser capaz de enviar e receber mensagens corretamente, e as mensagens devem ser exibidas na conversa de forma clara e organizada.|
>