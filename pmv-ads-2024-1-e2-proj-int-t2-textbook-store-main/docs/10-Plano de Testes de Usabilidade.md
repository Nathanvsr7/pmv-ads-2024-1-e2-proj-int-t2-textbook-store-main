# Plano de Testes de Usabilidade

Para realização dos testes de usabilidade do projeto Educa Livros,contaremos com a execução de testes remotos via video chamada com compartilhamento de tela.
Os participantes serão selecionados de acordo com o perfil aderente a cada uma de nossas personas e respectivas [histórias de usuários](./02-Especificação%20do%20Projeto.md).

Os testes terão o formato de tarefas específicas visando a utilização do sistema para o cumprimento de cada um de seus requisitos funcionais.

Cada tarefa será avaliada de acordo com os seguintes critérios:

- Tempo total demandado do usuário para realizaçãoda tarefa;
- Quantidade de cliques utilizados para a realização da tarefa;
- Quantidade de desvios considerando-se o "caminho feliz" da tarefa;
- Autorelato do usuário referente a facilidade para conclusão da tarefa(escada de 1 a 5, sendo 5 muito fácil e 1 muito difícil);
- Feedbacks qualitativos do usuário sobre a execução da tarefa;

Abaixo, o registro das tarefas a serem executadas:

| Tarefa  | Descrição                          | Requisito Funcional associado|
|---------|------------------------------------|------------------------------|
| T-01    | Cadastrar na plataforma            | RF-001                       |
| T-02    | Efetuar login na plataforma        | RF-002                       |
| T-03    | Cadastrar um anúncio na plataforma | RF-003                       |
| T-04    | Editar um anuncio na plataforma    | RF-003                       |
| T-05    | Excluir um anuncio na plataforma   | RF-003                       |
| T-06    | Fazer uma pesquisa na plataforam   | RF-004                       |
| T-07    | Iniciar uma conversa               | RF-005                       |
| T-08    | Responder a uma conversa           | RF-005                       |
| T-09    | Localizar uma conversa já iniciada | RF-005                       |
| T-10    | Avaliar outro usuário              | RF-007                       |
| T-11    | Recuperar a senha                  | RF-008                       |

Para cada voluntário, o registro será feito no seguinte formato:

| Tarefa | Tempo | Cliques | Desvios | Avaliação quantitativa | Feedbacks Qualitativos|
|--------|-------|---------|---------|------------------------|-----------------------|
| T-XX   | 00:00 |   X     |   X     |     1 a 5              |  feedback-transcrição |


Além dos critérios de avaliação acima, apresentaremos ao final um questionário a fim de mapear elementos gerais de usabilidade do sistema não atrelados a uma funcionalidade específica. Esse questionário consiste em avaliar, em uma escala de 1 a 10, o quanto o usuário concorda com algumas afirmativas que se mapeiam para elementos das heuristicas de Nielsen:

| Afirmação avaliada                                                                | heuristica correspondente                      |
| ----------------------------------------------------------------------------------| ---------------------------------------------- |
| As ações foram simples de se executar                                             | Visibilidade do Status do Sistema              |
| Encontrei com facilidade os elementos na tela para fazer o que eu gostaria        | Visibilidade do Status do Sistema              |
| Ao ver um ícone no sistema, seu sentifdo era nítido para mim                      | Compatibilidade entre o sistema e o mundo real |
| Ao realizar uma açõa indesejada, foi fácil retornar para o que queria             | Controle e liberdade para o usuário            | 
| Ao navegar entre várias páginas, o estilo se mantinha                             | Consistência e Padronização                    |
| O sistema apresentou mensagens amigáveis de confirmação ao executar alguma ação   | Prevenção de erros                             |
| O sentido de elementos como botões e ícones me era familiar                       | Reconhecimento em vez de memorização           |
| Mesmo sem ter utilizado o sistema antes, foi intuitivo fazer o que eu queria      | Eficiência e flexibilidade de uso              |
| A quantidade de informações e elementos em cada tela estava adequada, sem exageros| Estética e design minimalista                  |
| Ao preencher alguma informação incorreta, foi fácil exergar o erro                | Diagnostico e recuperação de erros             |
| Instruções de uso eram facilmente localizadas                                     | Ajuda e documentação                           |

Os registros podem ser consultados no [Registro de Testes de Usabilidade](./11-Registro%20de%20Testes%20de%20Usabilidade.md)