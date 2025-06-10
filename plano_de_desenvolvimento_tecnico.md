# Plano de Desenvolvimento Técnico — PSE

- Este documento **considera dias de 6 horas** de trabalho.
- Este documento considera **apenas dias úteis.**
- Este documento é **melhor visualizado como em um visualizador de arquivos .md(Markdown).**
- Para um **melhor fluxo de compreensão das funcionalidades**, comece pelos componentes e funcionalidades nas aplicações de front-end, através de seus **campos de dependência** é possível conferir o fluxo **de cada funcionalidade.**

1. Autenticação/login

---

# Web-API

### API de SMTP.

#### Descrição:

- Essa API deve ter algumas funções que serão usadas por outras funcionalidades, como: ADF para açõa de impactoAPI de autenticação, envio de certificado e envio automático de certificado.

#### Dependências:

-

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

- Haver alguma limitação na API do provedor de SMPT, impossibilitando a realização de alguma funcionalidade.

### Envio automático de certificado.

#### Descrição:

- No momento em que o profissional cumpre a carga horária do respectivo evento ele deve receber em seu e-mail o certificado em PDF.
- Essa funcionalidade deve ser incorporada no sistema de contabilidade de horas para fazer uma chamada para a funcionalidade de envio de certificado dentro da API de SMTP para que ela realize o envio para o e-mail do respectivo usuário.

#### Dependências:

- E

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

-

### Montagem de certificado.

#### Descrição:

- Essa funcionalidade deve receber o o idetificador de profissional e curso para que use o layout apropriado para realizar a montágem de certificado, retornando um arquivo PDF como resultado.

#### Dependências:

- API de SMTP

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

- A complexidade da biblioteca usada para interagir com o PDF ser muito complexa, extrapolando prasos.

### Sistema de contabilidade de horas

#### Descrição:

- Este sistema deve receber os eventos profissionais inscritos e as carga horárias necessárias para a aprovação no evento. Recebendo requisições para atualizar quantidades de horas cumpridas e fazer chamadas para a funcionalidade de envio de certificado quando algum profissional cumprir as horas necessárias para a aprovação em algum evento, solicitando que o respectivo certifiado seja montado e enviado ao usuário.

#### Dependências:

-

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

-

### Sistema de booking

#### Descrição:

- No momento em que um administrador cria um evento, ele configura a quantidade de vagas disponíveis
- A medida que os usuários vão se inscrevendo ocupando prioridade 1, as vagas vão sendo preenchidas
- A medida que os usuários confirmam presença, ocupando prioridade 2, _que é priorizada em detrimento da prioridade 1_, as vagas vão sendo reservadas(trancadas) para o respectivo usuário.
- Ao confirmar sua presença, o usuário pode então gerar o QR code para sua contabilização de horas.

#### Dependências:

-

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

-

### ADF para ação de alto impacto.

#### Descrição:

- Essa funcionalidade consiste em um fluxo simples de ADF através do serviço de e-mail para realizar ações de alto impacto, como criar eventos, confirmar presença ou restringir um profissional de realizar inscrições.

#### Dependências:

- API de Autenticação.

#### Estimativa Total:

- 2 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                                  | Descrição                                                                                               | O     | M      | P     | Est.Final |
| ----------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ----- | ------ | ----- | --------- |
| Conferir documentação do provedor de SMTP.                              |                                                                                                         | 30min | 1h     | 90min | 0,17d     |
| Implementar lógica para gerar tokens.                                   | que serão enviados por e-mail para que o usuário confirme sua identidade Ao reinseri-lo pela aplicação. | 1h    | 2h     | 3h    | 0,3d      |
| Idealizar como sistematizar o envio de e-mails para determinadas ações. | Usar copo de e-mail genérico que é alterado apenas por função chamadora.                                | 30min | 1h     | 90min | 0,17d     |
| Implementar lógica na webAPI.                                           |                                                                                                         | 1h    | 2h     | 3h    | 0,3d      |
| Realizar testes.                                                        | Uma bateria bem confiável,variáda.                                                                      | 1h    | 2h     | 2:30h | 0,3d      |
| realizar a justes.                                                      | intervalo que considera complicações.                                                                   | 1:30h | 2:30h  | 3:30h | 0,42d     |
| Documentar como foi feita a implementação.                              | De maneira extensa, (funcionabilidade crítica)                                                          | 15min | 20 min | 30min | IRL       |

#### Riscos:

- A complexidade ou complicação com a API do provedor de SMPT ocasionar expansão de prazo. (médio)

### Fluxo de inscrição. Back-end

#### Descrição:

- Essa parte é apenas a contraparte do botão de de inscrição. Responsavel por dar continuidade do fluxo no back-end.

#### Dependências:

- API de Autenticação.
- Fluxo de inscrição. Front-end.
- Botão de de inscrição.

#### Estimativa Total:

- 1 dia útil.

#### Sub -Tarefas:

| Tarefa                                                                                            | Descrição                             | O     | M        | P        | Est.Final |
| ------------------------------------------------------------------------------------------------- | ------------------------------------- | ----- | -------- | -------- | --------- |
| Idealizar lógica para recebimento de requisições do front.                                        | garantir que todo o fluxo está claro. | 30min | 1h       | 1h:30min | 0,2d      |
| Implementar lógica para CRUD realizar alteração no evento, confirmando inscrição de profissional. |                                       | 30min | 1h:30min | 2h       | 0,24d     |
| Realizar testes.                                                                                  | De todo o fluxo.                      | 30min | 1h       | 2h       | 0,18d     |
| Realizar alterações                                                                               |                                       | 1h    | 1h:30min | 2h:30min | 0,26d     |
| Checar tudo e fazer deploy para homolog.                                                          |                                       | 10min | 30min    | 1h       | 0,1d      |

#### Riscos:

-

### Fluxo de confirmação de inscrição. Back-end

#### Descrição:

- Essa parte é apenas a contraparte do botão de confirmação de inscrição. Responsável por dar continuidade do fluxo no back-end.

#### Dependências:

- API de Autenticação.
- Fluxo de confirmação de inscrição. Front-end.
- Botão de confirmação de inscrição.
- ADF para ações de alto impacto.

#### Estimativa Total:

- 1,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                                                           | Descrição                                   | O     | M        | P        | Est.Final |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------- | ----- | -------- | -------- | --------- |
| Confirmar o funcionamento do fluxo de ADF.                                                       | Para deixar mais claro como fazer a lógica. | 10min | 15min    | 20min    | 0,04d     |
| Realizar integração com funcionalidade de ADF para ações de alto impacto                         |                                             | 30min | 1h       | 2h       | 0,18d     |
| Implementar lógica para CRUD realizar alteração no evento, confirmando presença de profissional. |                                             | 30min | 1h       | 2h       | 0,18d     |
| Realizar testes.                                                                                 | De todo o fluxo.                            | 30min | 1h       | 2h       | 0,18d     |
| Realizar alterações                                                                              |                                             | 1h    | 1h:30min | 2h:30min | 0,26d     |
| Chegar tudo e fazer deploy para homolog.                                                         |                                             | 10min | 30min    | 1h       | 0,1d      |

#### Riscos:

-

### API de autenticação.

#### Descrição:

- API para realização de login, registro e ADF(Autenticação de dois fatores).

#### Tecnologias específicas usadas.

- ASP.NET Identity CORE.

#### Dependências:

- [x] Configuração adequada de firewall.
- [ ] Configuração adequada do balanceador de carga.

#### Estimativa Total:

- 9 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                    | Descrição                                                                                  | O     | M     | P   | Est.Final |
| --------------------------------------------------------- | ------------------------------------------------------------------------------------------ | ----- | ----- | --- | --------- |
| Estudar o ASP.NET Core Identity                           | Compreender a sintaxe e funções usadas.                                                    | 0,5d  | 1d    | 2d  | 1,6d      |
| Realizar testes para consolidar                           | Ambiente simples como localhost                                                            | 2h    | 3h    | 4h  | 0,5d      |
| mplementar ASP.NET Core identity no registro de usuários. | implementar no ambiente de homologação, deixar pronto para deploy em Homolog.              | 1d    | 2d    | 3d  | 2d        |
| Implementar ASP.NET Core identity no login de usuários.   | implementar no ambiente de homologação, deixar pronto para deploy em Hmolog.               | 1d    | 2d    | 3d  | 2d        |
| <br>Implementar ASP.NET Core identity no ADF.             | implementar no ambiente de homologação, deixar pronto para deploy em Homolog.              | 1d    | 2d    | 4d  | 2,5d      |
| <br>Documentar a implementação.                           | Registrar detalhes importantes e pontos chaves para depois passar para documentação final. | 30min | 40min | 1h  | 0,1d      |

#### Riscos:

- A complexidade do ASP.NET Core identity ser muito maior que o esperado.(Baixo)

### Login.

#### Descrição:

- Processo padrão de login para usuários.

#### Dependências:

- API de autenticação.

#### Estimativa Total:

1,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                   | Descrição                                                                           | O   | M   | P   | Est.Final |
| ---------------------------------------- | ----------------------------------------------------------------------------------- | --- | --- | --- | --------- |
| Importar tela de login feita por design. | Acessar figma e copiar parâmetros e elementos importando-os para o projeto.         | 0,5 | 1   | 1,5 | 1,3       |
| Testar fluxo de UI com Backend.          | Garantir que as botões estão realizando as funções orquestradas pelo Identity CORE. | 0,1 | 0,2 | 0,5 | 0,3       |

- Riscos
- ### CRUD Evento

#### Descrição:

- Crud para os eventos do sistema.

#### Dependências:

-

#### Estimativa Total:

- 1 dia útil.

#### Sub -Tarefas:

| Tarefa                    | Descrição                      | O       | M     | P   | Est.Final |
| ------------------------- | ------------------------------ | ------- | ----- | --- | --------- |
| idealizar classe.         | Definir todas as propriedades. | 15min   | 30min | 1h  | 0,1d      |
| Faze função de criação.   | No Backend.                    | 30min   | 1h    | 2h  | 0,2d      |
| Fazer função de edição.   | No Backend                     | 30m min | 1h    | 2h  | 0,2d      |
| Fazer função para apagar. | No Backend                     | 30min   | 1h    | 2h  | 0,2d      |

#### Riscos:

- Não poder ser realizado o reaproveitamento da tela de login feita pelo design.(Baixo)

### Registro de usuário.

#### Dependências

- API de autenticação.

#### Descrição:

- Processo padrão de registro para usuários.

#### Estimativa Total:

- 0,5 dia útil.

#### Sub -Tarefas:

| Tarefa                                   | Descrição                                                                           | O     | M     | P     | Est.Final |
| ---------------------------------------- | ----------------------------------------------------------------------------------- | ----- | ----- | ----- | --------- |
| Importar tela de login feita por design. | Acessar figma e copiar parâmetros e elementos importando-os para o projeto.         | 1h    | 2h    | 3h    | 0,4d      |
| Testar fluxo de UI com Backend.          | Garantir que as botões estão realizando as funções orquestradas pelo Identity CORE. | 15min | 20min | 50min | 0,1d      |

### CRUD Usuário.

#### Descrição:

- CRUD para os usuários do sistema.

#### Estimativa Total:

- 0,5 dia útil.

#### Sub -Tarefas:

| Tarefa                    | Descrição                      | O     | M     | P   | Est.Final |
| ------------------------- | ------------------------------ | ----- | ----- | --- | --------- |
| idealizar classe.         | Definir todas as propriedades. | 30min | 1h    | 2h  | 0,2d      |
| Fazer função de criação.  | No Backend.                    | 15min | 20min | 1h  | 0,1d      |
| Fazer função de edição.   | No Backend                     | 15min | 20min | 1h  | 0,1d      |
| Fazer função para apagar. | No Backend                     | 15min | 20min | 1h  | 0,1d      |

### CRUD Eventos.

#### Descrição:

- CRUD para o a estrutura básica de eventos.

#### Estimativa Total:

- 0,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                    | Descrição                      | O     | M     | P   | Est.Final |
| ------------------------- | ------------------------------ | ----- | ----- | --- | --------- |
| idealizar classe.         | Definir todas as propriedades. | 30min | 1h    | 2h  | 0,2d      |
| Fazer função de criação.  | No Backend.                    | 15min | 20min | 1h  | 0,1d      |
| Fazer função de edição.   | No Backend                     | 15min | 20min | 1h  | 0,1d      |
| Fazer função para apagar. | No Backend                     | 15min | 20min | 1h  | 0,1d      |

# Design-System/Componentes.

- _A interface deve contemplar todos os artifícios visuais para a interação com todas as funcionalidades presentes nos documentos: Histórias de usuário e requisitos funcionais especificados._
- Para não aumentar a complexidade do projeto de forma indesejada, foi decidido que a biblioteca _Mudblazor_ será utilizada para o projeto. Retirando qualquer necessidade de criar componentes do zero.
- Ela ja tem integração no figma, tornando totalmente possível fazer os protótipos para homologação e testes(opcional).
- A paleta de cores e tipografia da biblioteca deve ser alterada para respeitar as selecionadas pelo Design system já feito.

# PSE-Client/Profissional

## Funcionalidades.

### Fluxo de inscrição. Front-end.

#### Descrição:

- Essa parte da funcionalidade deve fazer uma chamada para o backend com o evento e respectivo usuário para que o o fluxo da funcionalidade siga e seja possível que o usuário confirme sua inscrição no respectivo evento.

#### Dependências:

- API de autenticação.
- Fluxo de inscrição. B.E.
- Botão de inscrição.

#### Estimativa Total:

- 30 min (IRL).

#### Sub -Tarefas:

| Tarefa                                                                      | Descrição                                | O      | M     | P     | Est.Final |
| --------------------------------------------------------------------------- | ---------------------------------------- | ------ | ----- | ----- | --------- |
| Conferir os dados que precisam ser mandados para o back-end.                | Como o usuário é passado, evento... ETC. | 5min   | 10min | 20min | IRL       |
| Fazer integração entre botão e lógica para fazer requisição para a Web API. |                                          | 20 min | 30min | 1h    | IRL       |

#### Riscos:

-

### Fluxo de Confirmação de inscrição. Front-end.

#### Descrição:

- Essa parte da funcionalidade deve fazer uma chamada para o backend com o evento e respectivo usuário para que o o fluxo da funcionalidade siga e seja possível que o usuário confirme sua presença no respectivo evento.

#### Dependências:

- API de autenticação.
- Fluxo de inscrição. B.E.
- Botão para confirmação de inscrição.

#### Estimativa Total:

- 30 min (IRL).

#### Sub -Tarefas:

| Tarefa                                                                      | Descrição | O      | M     | P   | Est.Final |
| --------------------------------------------------------------------------- | --------- | ------ | ----- | --- | --------- |
| Fazer integração entre botão e lógica para fazer requisição para a Web API. |           | 20 min | 30min | 1h  | IRL       |

### Filtro para eventos relacionados.

#### Descrição:

- No momento em que o feed for carregado com os eventos, será preciso separar os eventos entre os que o usuário está inscrito, que ele ja concluiu, todos os eventos, os que são cursos... Para que o Menu Dropdown para filtro de eventos possa ser usado pelo profissional, selecionando quais tipos de eventos ele deseja visualizar.

#### Dependências:

- CRUD Eventos.

#### Estimativa Total:

- 1,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                                             | Descrição                                                                                              | O      | M     | P     | Est.Final |
| ---------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------ | ------ | ----- | ----- | --------- |
| idealizar lógica para separar eventos de acordo com a relação deles com o usuário. | cada evento vai aparecer em um filtro diferente de acordo com seu tipo e relação direta com o usuário. | 30min  | 1h    | 2h    | 0,23d     |
| Implementar lógica de separação.                                                   | Apenas lógica.                                                                                         | 1h     | 2h    | 3h    | 0,5d      |
| Testar lógica                                                                      | apenas lógica.                                                                                         | 30 min | 1h    | 1h    | 0,20d     |
| Aplicar correções.                                                                 |                                                                                                        | 15min  | 30min | 1h    | 0,11d     |
| Implementar com componentes.                                                       | Da mudblazor.                                                                                          | 15min  | 30min | 1h    | 0,11d     |
| Testar com lógica e componentes                                                    | Agora sim todo o fluxo                                                                                 | 15min  | 30min | 1h    | 0,11d     |
| Aplicar correções                                                                  | No fluxo inteiro.                                                                                      | 15min  | 30min | 1h    | 0,11d     |
| Fazer documentação rápida de implementação.                                        | Para ajudar na mantenabilidade em atualizações futuras.                                                | 2min   | 5min  | 10min | 0,01d     |

### Pop-ups de ação de impacto.

#### Descrição:

- Popups informativos que chamam a atenção do usuário para uma ação específica em momentos de configuração e edição, visando dar uma noção de como aquela opção pode impactar quando alterada.

#### Dependências:

- Componentes de pop-ups criados.

#### Estimativa Total:

- 0,19 dias úteis.

#### Sub -Tarefas:

| Tarefa                                 | Descrição                                                         | O     | M     | P     | Est.Final |
| -------------------------------------- | ----------------------------------------------------------------- | ----- | ----- | ----- | --------- |
| Pesquisar componentes de pop-ups(css). | Caso disponíveis, incorporar no DS.                               | 10min | 20min | 30min | 0,07      |
| Incorporar componente no DS.           | Copiar css e fazer um componente razor simples, vercionar.        | 15min | 30min | 1h    | 0,11      |
| Fazer documentação mínima.             | Para o componente em específico, no proprio repo do design system | 2min  | 5min  | 8min  | 0,01      |

#### Riscos:

-

## Interfaces/componentes.

### Barra de busca.

#### Descrição:

- Quando o feed carregar, o usuário terá a opção de usar uma barra de busca para pesquisar por nomes de eventos, filtrando os que são mostrados.

#### Dependências:

- CRUD Eventos.

#### Estimativa Total:

- 0,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                   | Descrição                | O     | M      | P     | Est.Final |
| -------------------------------------------------------- | ------------------------ | ----- | ------ | ----- | --------- |
| Idealizar lógica para funcionamento da barra de busca.   |                          | 15min | 30min  | 45min | 0,11d     |
| Implementar lógica para funcionamento da barra de busca. |                          | 15min | 30min  | 1h    | 0,11d     |
| Realizar testes de implementação                         | Apenas regras de negócio | 15min | 30min  | 40min | 0,11d     |
| Realizar ajustes.                                        |                          | 10min | 30 min | 40min | 0,11d     |
| Implementar com componentes.                             | Todo o fluxo             | 10min | 30min  | 40min | 0,11d     |

#### Riscos:

-

### Menu Dropdown para filtro de eventos.

#### Descrição:

- Um botão simples, para que o usuário possa escolher entre os eventos mostrados no feed.

#### Dependências:

- Filtro para eventos relacionados

#### Estimativa Total:

- Considerar tempo da funcionalidade Filtro para eventos relacionados

### Botão confirmação de presença.

#### Descrição:

- Este botão, _disponível apenas depois de confirmada a inscrição do profissional_, deve usar um processo de ADF por e-mail para confirmar a inscrição do profissional no evento em específico.

#### Dependências:

- Fluxo de confirmação de presença.

#### Estimativa Total:

- Considerar Estimativa de Fluxo de confirmação de presença.

### Botão inscrever-se em evento.

#### Descrição:

- Botão que deve aparecer no modal do evento que possibilita que o profissional realize sua inscrição no respectivo evento.

#### Dependências:

- Modal de evento.
- Fluxo de inscrição.
- Fluxo de verificação de anuidade. B.E

#### Estimativa Total:

- 0,22 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                                    | Descrição                                                      | O     | M     | P     | Est.Final |
| ------------------------------------------------------------------------- | -------------------------------------------------------------- | ----- | ----- | ----- | --------- |
| Conferir fluxo de Inscrição no backend.                                   | garantir que está funcionando tudo como deveria.               | 10min | 15min | 20min | 0,04      |
| Implementar lógica que realiza link entre botão e chamada para o backend. |                                                                | 15min | 30min | 1h    | 0,09      |
| Realizar testes.                                                          |                                                                | 15min | 30min | 1h    | 0,09      |
| Realizar deploy em homolog                                                | documentar se houver qualquer nível relevante de complexidade. | IRL   | IRL   | IRL   | IRL       |

### ()Botão reenvio de certificados.

#### Descrição:

- Este botão tem o objetivo de permitir o reenvio de certificados quando o profissional ja houver cumprido a carga horária e desejar que o certificado seja enviado novamente.

#### Dependências:

- API de SMTP. B.E
- montagem de certificados. B.E
- Envio de certificados. B.E

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

### Modal de Evento

#### Descrição:

- Um modal que mostra mais opções e informações sobre um determinado evento do feed.

#### Dependências:

- CRUD Eventos.
- Botão confirmação de presença.
- Botão inscrever-se em evento.
- Botão reenvio de certificados.

#### Estimativa Total:

- 0,5 dias úteis

#### Sub -Tarefas:

| Tarefa                       | Descrição                                                                                                                               | O     | M     | P     | Est.Final |
| ---------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- | ----- | ----- | ----- | --------- |
| Idealização do modal         | Escolha de componentes da Mud blazor (Completar modelo de dados de Evento antes)(Confirmar todas as funcionalidades antes)              | 30min | 1h    | 2h    | 0,23d     |
| Conferir lógica de negócio.  | Funcionamento do CRUD de evento, pode estar faltando algum detalhe ou pode haver necessidade de função específica para gerar metadados. | 15min | 20min | 30min | 0,1d      |
| Implementar com componentes. | Da Mudblazor(Com certeza há um modal lá.) Usar outros componentes como subpartes.                                                       | 20min | 30min | 1h    | 0,1d      |
| Realizar testes.             | Apenas front-end                                                                                                                        | 5min  | 10min | 15min | IRL       |

#### Riscos:

-

### Bloco de evento.

#### Descrição:

- Bloco visual que representa um evento no feed, contendo informações e mostrando modais para mais opções de interações.

#### Dependências:

- Modal de evento.
- CRUD Evento.

#### Estimativa Total:

- 0,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                                        | Descrição                                      | O     | M     | P     | Est.Final |
| ------------------------------------------------------------- | ---------------------------------------------- | ----- | ----- | ----- | --------- |
| Idealizar componente.                                         | Completar modelo de dados de evento antes.     | 15min | 20min | 40min | 0,1d      |
| Fazer protótipo no figma.                                     | Existe uma biblioteca de mudblazor para figma. | 20min | 40min | 1h    | 0,14d     |
| Checar lógica de négócio com CRUD                             |                                                | 10min | 20min | 30min | 0,1d      |
| Assimilar componente com componentes da biblioteca mudblazor. | Provavelmente mais de um será utilizado.       | 10min | 20min | 30min | 0,1d      |
| Implementar componente.                                       | Com regras de negócio                          | 10min | 20min | 30min | 0,1d      |
| Realizar testes                                               | com todo o fluxo                               | 10min | 15min | 20min | 0,05d     |
| Caso tenha ficado complexo, documentar                        | No próprio código ou design system.            | 2min  | 5min  | 10min | IRL       |

### Feed

#### Descrição:

- Mostra todos os cursos disponíveis.

#### Dependências:

- Barra de busca.
- Botão de troca(interruptor)(Toggle).
- Filtro para eventos relacionados.
- Bloco de evento.

#### Estimativa Total:

- 0,5 dias úteis.

#### Sub -Tarefas:

| Tarefa                                              | Descrição                                                    | O     | M     | P     | Est.Final |
| --------------------------------------------------- | ------------------------------------------------------------ | ----- | ----- | ----- | --------- |
| Fazer esboço simples do componente.                 | Se possível no figma.                                        | 15min | 30min | 1h    | 0,11d     |
| Selecionar componente correspondente na biblioteca. | Mudblazor.                                                   | 5min  | 10min | 15min | 0,03d     |
| Fazer lógica de negócio.                            | chamada ao banco para recolher cursos e relações de usuário. | 20min | 40min | 50min | 0,14d     |
| Integrar lógica de negócio no Com o componente.     | Usar blocos de evento para mostrar as informações.           | 20min | 40min | 50min | 0,14d     |

#### Riscos:

-

# PSE-Admin:

## Funcionalidades

### Cadastro de eventos

#### Descrição:

- Função administrativa para cadastrar novos eventos.
- No modelo de dados é

#### Dependências:

- API de Autenticação.
- CRUD eventos.

#### Estimativa Total:

- 1 dia útil.

#### Sub -Tarefas:

| Tarefa                                         | Descrição                                    | O      | M     | P     | Est.Final |
| ---------------------------------------------- | -------------------------------------------- | ------ | ----- | ----- | --------- |
| Revisitar documentação.                        | Conferir detalhes importantes presentes.     | 10min  | 15min | 30min | 0,05d     |
| Idealizar regras de negócio.                   | Detalhes e fluxo e implementação.            | 10min  | 15min | 30min | 0,05d     |
| Idealizar UI                                   | Campos de preenchimento e seleção de opções. | 10min  | 15min | 30min | 0,05d     |
| Implementar regras de negócio.                 | Considerando requisitos e CRUD.              | 30min  | 50min | 1h    | 0,2d      |
| Testar regras de negócio.                      | Com BD.                                      | 15min  | 30min | 1h    | 0,1d      |
| Fazer componentes restantes no figma.          | Campos de preenchimento e seleção de opções. | 10 min | 15min | 30min | 0,05d     |
| Integrar componentes no repo do design system. | Dar push com os novos componentes            | 5 min  | 10min | 15min | 0,03d     |
| Incorporar componentes nas regras de negócios. | Deixar tudo pronto para deploy em homolog.   | 5min   | 10min | 15min | 0,03d     |
| Documentar implementação.                      | Detalhes importantes para manutenção.        | 5min   | 10min | 15min | 0,03d     |

### Editar Eventos.

#### Descrição:

- Uso básico de parte doo CRUD para eventos.
- Envio de post com autenticação por ADF.

#### Dependências:

- CRUD Eventos.
- API de autenticação.
- Pop-Ups de Ações de impacto.

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
|        |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

-

### Fluxo de liberar evento para inscrição. Front-end.

#### Descrição:

- Essa parte da funcionalidade deve fazer uma chamada para o backend com o evento e respectivo usuário para que o o fluxo da funcionalidade siga e seja possível que o evento esteja disponível para inscrição pelo profissionais.

#### Dependências:

- API de autenticação.
- Fluxo de inscrição. B.E.
- Botão de inscrição.

#### Estimativa Total:

- 30 min (IRL).

#### Sub -Tarefas:

| Tarefa                                                                      | Descrição                                | O      | M     | P     | Est.Final |
| --------------------------------------------------------------------------- | ---------------------------------------- | ------ | ----- | ----- | --------- |
| Conferir os dados que precisam ser mandados para o back-end.                | Como o usuário é passado, evento... ETC. | 5min   | 10min | 20min | IRL       |
| Fazer integração entre botão e lógica para fazer requisição para a Web API. |                                          | 20 min | 30min | 1h    | IRL       |

## Interface/componentes

### Botão Liberar evento para inscrição

#### Descrição:

- Este botão deve ser utilizado após a configuração do evento, permitindo que ele fique disponível para que os profissionais realizem suas inscrições.

#### Dependências:

- API de autenticação.
- Modal de configuração evento.
- Fluxo liberar evento para inscrição.
- Autenticação de dois fatores para a ação de alto impacto.

#### Estimativa Total:

- IRL.

#### Sub -Tarefas:

| Tarefa                                                          | Descrição                                         | O     | M     | P     | Est.Final |
| --------------------------------------------------------------- | ------------------------------------------------- | ----- | ----- | ----- | --------- |
| Realizar implementação de botão com lógica do front.            | Todo o fluxo de back e front devem estar prontos. | 5min  | 10min | 20min |           |
| Realizar testes e validar todo o fluxo.                         |                                                   | 10min | 20min | 30min |           |
| Realizer deploy para homolog                                    |                                                   | IRl   | IRl   | IRl   | IRl       |
| Caso haja alguma complexidade relacionada ao botão, documentar. |                                                   | IRl   | IRl   | IRl   | IRl       |

#### Riscos:

-

### Botão criar mensagem.

#### Descrição:

- Este botão criará a a mesma estrutura de bloco de um evento, mas ao invés disso, ele deve apenas conter textos e links. Podendo levar para forms aonde os usuários podem sugerir novos cursos e ou sinalizar interesse em cursos ja sugeridos pela administração do sistema. Posteriormente isso pode ser mais integrado no projeto, para fazer testes AB de eventos.

#### Dependências:

- Modal de evento.
- Feed.
- Bloco de evento.

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

- O processo de reaproveitamento de componentes e fluxo da aplicação de profissional para a aplicação Admin requerer tempo extra. (Aalto).

# Considerações

- Haverão funcionalidades que pertencem a apenas a aplicação destinada aos profissionais e vice versa, mas todas as funcionalidades que puderem devem ser reaproveitadas visando um melhor uso de tempo.

# fim ---

### Nome

#### Descrição:

-

#### Dependências:

-

#### Estimativa Total:

-

#### Sub -Tarefas:

| Tarefa | Descrição | O   | M   | P   | Est.Final |
| ------ | --------- | --- | --- | --- | --------- |
| l      |           |     |     |     |           |
|        |           |     |     |     |           |

#### Riscos:

-
