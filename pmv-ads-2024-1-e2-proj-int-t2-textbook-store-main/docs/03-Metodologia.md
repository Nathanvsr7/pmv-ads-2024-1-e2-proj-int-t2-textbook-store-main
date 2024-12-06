
# Metodologia

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto se utiliza da branch `main` como branch principal para abrigar a versão mais recente do software. Para alterações referentes a documentação, funcionalidades, testes e outros, os seguintes prefixos são utilizados para se criar novas branches:

- `doc`: prefixo utilizado para branches relacionadas a tarefas de documentação, ex: `doc-metodologia`
- `test`: prefixo utilizado para branches relacionadas a tarefas de testes de software.
- `feat`: prefixo utilizado para branches relacionadas ao desenvolvimento de alguma funcionalidade da aplicação.
- `style`: prefixo utilizado para branches relacionadas ao design e elementos estilisticos da aplicação.

Quanto à gerência de issues, o projeto adota o seguinte padrão de `tags`(etiquetas):

- `design`: Issues ou Pull Requests(PRs) relacionadas a atividades de design como wireframes, figma, modelo de banco de dados, MER etc
- `documentação`: Issues ou PRs relacionados a melhorias ou adições na documentação.
- `duplicado`: indica que a issue ou o Pulll Request já existem.
- `feature`: Issues ou PRs relacionados ao desenvolvimento de novcas funcionalidades.
- `pedido de ajuda`: Solicitação de ajuda de outra pessoa em uma tarefa.
- `testes`: Indica issues ou PRs relacionados ao planejamento e/ou execução de testes.
- `Sprint XX`, onde XX é o número da Sprint. Associa a issue ou o PR a uma determinada Sprint do projeto.

## Gerenciamento de Projeto

### Divisão de Papéis

Para as atividades do projeto, a seguinte divisão de papéis foi adotada:
- `Product Owner`: Ana Paula
- `Scrum Master`: Rafael Maltez
- `Equipe de Design`: Nathan Vitorino e Rafael Maltez
- `Equipe de Dssenvolvimento`: Elismar Ramos, Pablo Rangel, Ana Paula, Nathan Vitorino e Rafael Maltez

### Processo

O processo de realização do projeto se dá através da metodologia Scrum. Em conjunto ao Scrum, utilizamos um quadro Kanban adaptado para gereciamento das atividades. O quadro é composto pelas seguintes colunas:

- `Backlog`: lista todas as atividades previstas para a realização do projeto.
- `Ready`: lista tarefas que foram triadas pelo Scrum Master para uma determinada spint e podem ser realizadas pela equipe.
- `In progress`: lista atividades que estão sendo executadas por alguém da equipe.
- `In review`: lista as atividades finalizadas na etapa anterior e que estão prontas para serem revisadas por outros membros da equipe.
- `Done`: lista as tarefas finalizadas 

### Ferramentas

As ferramentas empregadas no projeto são:

- `Sistemas Operacionais`: Windows, Ubuntu, MacOS
- `Editores de código`:  Visual Studio e Visual Studio Code 
- `Ferramentas de comunicação`: Whatsapp (comunicação assíncrona), Microsoft Teams (comunicação sincrona)
- `Ferramenta de Design de Tela`: Figma
- `Ferramenta de Gestão de Projeto`: Github Projects
- `Ferramenta de containerização`: Docker

Pelo fato de cada membro do grupo utilizar um detrerminado sistema operacional, utilizamos dois editores de código diferentes: Visual Studio, para Windows e Visual Studio Code para MacOS e Ubuntu. Ambos possuem integração com o Sistema de Gerenciamento de Versões utilizado, no caso, git. Para comunicação assíncrona utilizamos a ferramenta de grupos do Whatsapp, por ser uma ferramente de uso comum entre todos os integrantes do grupo. Na comunicação síncrona, adotamos o Microsoft Teams como plataforma,pela simplicidade e integração com demais atividades da universidade nessa mesma plataforma. A ferramenta escolhida para a gestão do projeto foi o Github projects, pela simplicidade e integração nativa com a plataforma de repositórios adotada no projeto.
