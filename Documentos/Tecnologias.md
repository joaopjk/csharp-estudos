# Principais conceitos de GraphQL
GraphQL é uma linguagem de consulta (query language) e uma especificação para APIs onde o cliente consegue pedir **exatamente os dados que precisa**. Em vez de múltiplos endpoints com respostas fixas, normalmente você expõe **um único endpoint** que executa queries conforme um **schema**.
---
## 1) Schema (Esquema) e Tipos
- O **schema** é o “contrato” da API.
- Define os **tipos** disponíveis e como eles se relacionam.
- Tipos comuns:
    - **Scalar**: `Int`, `Float`, `String`, `Boolean`, `ID`
    - **Object types**: tipos com campos (ex.: `User { id, name }`)
    - **Enum**, **Interface**, **Union**, **Input**
---
## 2) Operações: Query, Mutation e Subscription
- **Query**: leitura de dados (equivalente a um “GET” conceitual).
- **Mutation**: alteração de dados (criar/editar/remover).
- **Subscription**: fluxo em tempo real (push de eventos/atualizações), geralmente via WebSocket.
---
## 3) Seleção de campos (Field Selection)
- O cliente escolhe quais campos quer receber.
- Benefícios:
    - evita **overfetching** (receber dados demais),
    - evita **underfetching** (precisar de várias requisições para compor uma tela).
---
## 4) Resolvers
- **Resolvers** são funções que “buscam/montam” o valor de um campo.
- Em geral, cada campo relevante pode ter um resolver (ou usar um padrão default).
- O GraphQL executa resolvers conforme a árvore da query.
---
## 5) Tipos de entrada (Input Types) e Argumentos
- Campos podem receber **argumentos** (ex.: `user(id: "123")`).
- Para entradas mais complexas (principalmente em mutations), usa-se **input types** (ex.: `CreateUserInput`).
- Ajuda a manter o contrato tipado e claro.
---
## 6) Variáveis (Variables)
- Permitem parametrizar queries/mutations sem “montar string”.
- Melhoram reuso, legibilidade e facilitam cache no cliente.
---
## 7) Fragments
- Permitem reutilizar conjuntos de campos.
- Evitam duplicação em queries grandes (princípio DRY na camada de consulta).
---
## 8) Introspection e Ferramentas
- GraphQL suporta **introspection**: o cliente pode descobrir o schema.
- Isso habilita:
    - documentação automática,
    - autocompletar em IDEs,
    - ferramentas como GraphiQL/GraphQL Playground (dependendo do stack).
---
## 9) Validação e Tipagem
- Antes de executar, a query é validada contra o schema:
    - campos inexistentes são rejeitados,
    - tipos/argumentos são checos.
- Erros tendem a ser mais previsíveis devido ao contrato tipado.
---
## 10) Paginação (conceitos comuns)
GraphQL não define uma forma única, mas padrões comuns incluem:
- **Cursor-based pagination** (ex.: `edges`, `node`, `cursor`, `pageInfo`) — muito usado no estilo Relay.
- **Offset pagination** — mais simples, mas pode ter problemas com consistência em listas mutáveis.
---
## 11) Performance e o problema do N+1
- Uma query pode disparar muitos resolvers e gerar **N+1 queries** no banco.
- Soluções comuns:
    - **batching/caching por request** (ex.: DataLoader),
    - loaders por entidade,
    - otimização de resolvers e consultas.
---
## 12) Autorização e Segurança
- Pode ser feita:
    - no nível do resolver (por campo),
    - por middleware/pipeline,
    - por diretivas (dependendo da implementação).
- Importante também limitar complexidade:
    - depth limit (profundidade),
    - query cost/complexity,
    - rate limiting.
---

# Kafka — principais conceitos
## 1) Tópicos e Partições
- Mensagens são publicadas em **topics**.
- Cada topic é dividido em **partitions**:
    - dá **paralelismo** (vários consumidores em paralelo),
    - garante **ordem apenas dentro da partição**.
## 2) Offset e Retenção
- Consumidores leem sequencialmente e controlam um **offset** (posição de leitura).
- Mensagens ficam armazenadas por política de **retenção** (tempo/tamanho), mesmo após serem consumidas.
- Isso permite:
    - **reprocessamento**,
    - múltiplos consumidores independentes lendo o mesmo histórico.
## 3) Consumer Groups
- Consumidores podem se agrupar em **consumer groups**:
    - cada partição é atribuída a no máximo um consumidor dentro do mesmo grupo (paralelismo + escala),
    - grupos diferentes podem consumir o mesmo topic de forma independente.
## 4) Producers, Acks e Entrega
- Producer publica em tópico/partição.
- `acks` controla o nível de confirmação (trade-off entre latência e durabilidade).
- Suporte forte a throughput alto; “exatamente uma vez” depende de configuração e do fluxo (transações/idempotência).
## 5) Replicação e Brokers
- Cluster com vários **brokers**.
- Partições podem ser **replicadas** para tolerância a falhas.
## 6) Ecossistema (streams/connect)
- Kafka costuma ser usado com:
    - **Kafka Connect** (integrações com bancos, filas, storage),
    - **Kafka Streams** / stream processing (transformações, joins, agregações em fluxo).
---

# RabbitMQ — principais conceitos

## 1) Exchanges, Queues e Bindings
- Mensagens entram por **exchanges** e são roteadas para **queues**.
- A ligação exchange → queue é definida por **bindings**.
- Tipos de exchange comuns:
    - **direct** (roteamento por chave exata),
    - **topic** (padrões com `*` e `#`),
    - **fanout** (broadcast),
    - **headers** (por cabeçalhos).
## 2) Consumidores, Ack e Prefetch
- Consumidores leem de filas.
- `ack` confirma processamento; sem `ack`, a mensagem pode ser reenviada (redelivery).
- **prefetch** controla quantas mensagens o consumidor recebe antes de confirmar, ajudando a balancear carga.
## 3) Durabilidade e Persistência
- Filas e mensagens podem ser **duráveis/persistentes** (com custo de desempenho).
- RabbitMQ é frequentemente usado para **tarefas** e **comandos** com entrega confiável.
## 4) Dead Letter Queue (DLQ) e TTL
- Suporte robusto a:
    - **DLQ** (mensagens que falham vão para outra fila),
    - **TTL** (expiração de mensagens/filas),
    - retries com políticas de reencaminhamento.
## 5) Padrões de mensageria
- Muito forte para:
    - **work queues** (distribuição de tarefas),
    - **request/reply**,
    - roteamento sofisticado entre múltiplos serviços.
---
## Comparativo Kafka vs RabbitMQ (quando usar cada um)
### Modelo mental
- **Kafka**: log distribuído + streaming de eventos (histórico + replay).
- **RabbitMQ**: broker de filas com roteamento e entrega orientada a mensagem/tarefa.
### Retenção e replay
- **Kafka**: mensagens ficam por retenção; replay é natural (offset).
- **RabbitMQ**: normalmente mensagem é removida após consumo/ack; replay exige re-publicar ou estratégias específicas.
### Throughput e escalabilidade
- **Kafka**: muito forte em **alto throughput** e escala horizontal por partições.
- **RabbitMQ**: excelente para muitos casos, mas o modelo e roteamento podem limitar throughput em cenários extremos; escala costuma ser mais “fila/consumidor” e desenho cuidadoso.
### Ordenação
- **Kafka**: ordem garantida **por partição**.
- **RabbitMQ**: ordem por fila pode existir, mas reentregas, múltiplos consumidores e prioridades podem afetar o comportamento percebido.
### Roteamento
- **Kafka**: roteamento é mais simples (topic/partition key). Transformações/roteamentos complexos são geralmente feitos por aplicações/stream processing.
- **RabbitMQ**: roteamento é um ponto forte (exchanges e bindings).
### Semântica de consumo
- **Kafka**: consumidores gerenciam offset; múltiplos grupos podem ler o mesmo topic independentemente.
- **RabbitMQ**: filas entregam para consumidores; padrão mais “trabalho a ser feito” (competing consumers).
### Casos de uso típicos
- **Kafka**:
    - event sourcing / event log,
    - integração entre sistemas via eventos,
    - pipelines de dados e streaming,
    - analytics near-real-time,
    - necessidade de reprocessamento/histórico.
- **RabbitMQ**:
    - filas de tarefas (background jobs),
    - comandos e integrações com roteamento rico,
    - workloads que precisam de DLQ/TTL/retry bem diretos,
    - request/reply assíncrono.
### Operação e complexidade
- **Kafka**: costuma exigir mais atenção a operações (cluster, partições, retenção, tuning).
- **RabbitMQ**: normalmente é mais simples para cenários clássicos de fila; ainda assim requer cuidado com durabilidade, prefetch e padrões de retry.
---
