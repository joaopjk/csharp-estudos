# Principais conceitos de Clean Architecture (Clean Arch)
Clean Architecture é um estilo arquitetural que organiza o sistema para manter o **domínio e as regras de negócio no centro**, protegidos de detalhes externos (frameworks, UI, banco, mensageria). O objetivo é ter um software **testável**, **flexível** e **fácil de evoluir**.
---
## 1) As camadas (visão geral)
A arquitetura é normalmente representada em “anéis” (camadas concêntricas), onde o centro é o mais importante:
1. **Entities (Domínio/Empresa)**
    - Regras de negócio mais centrais e estáveis.
    - Modelos e comportamentos que mudam pouco.
2. **Use Cases (Application / Interactors)**
    - Regras de negócio específicas da aplicação (casos de uso).
    - Orquestra o fluxo: validações, chamadas ao domínio, decisões de negócio do caso.
3. **Interface Adapters**
    - Converte dados entre o mundo externo e os use cases.
    - Exemplos: controllers, presenters, view models, mapeadores/DTOs, gateways.
4. **Frameworks & Drivers**
    - Detalhes: Web framework (ASP.NET), banco/ORM, mensageria, UI, arquivos, integrações externas.
---
## 2) Dependency Rule (Regra de Dependência)
**Dependências só podem apontar para dentro** (em direção ao domínio/use cases).
- Camadas internas **não conhecem** frameworks, banco, HTTP, UI.
- “Detalhes” dependem do “núcleo”, e não o contrário.
- Benefícios:
    - troca de DB/ORM/framework com menor impacto,
    - regras de negócio ficam testáveis sem infraestrutura.
---
## 3) Abstrações: Ports & Adapters (Interfaces e Implementações)
- As camadas internas definem **interfaces (ports)** para o que precisam (ex.: persistência, mensageria, relógio, serviços externos).
- As camadas externas fornecem **implementações (adapters)** dessas interfaces.
- Isso reduz acoplamento e permite mocks/fakes em testes.
---
## 4) Casos de Uso (Use Cases) como unidade central
- O sistema é organizado ao redor de **ações do usuário/negócio** (ex.: “CriarPedido”, “AprovarPagamento”).
- Cada caso de uso:
    - recebe uma entrada (request),
    - aplica regras,
    - produz uma saída (response),
    - sem depender de transporte (HTTP) ou persistência real.
---
## 5) Separação de responsabilidades (SRP na arquitetura)
- **Controller**: traduz HTTP/UI → entrada do caso de uso.
- **Use case**: coordena regra e fluxo.
- **Presenter/ViewModel** (quando aplicável): prepara saída para UI/API.
- **Repository/Gateway**: abstrai acesso a dados/integrações.
- **Infra**: implementa detalhes técnicos.
---
## 6) Independência de frameworks e infraestrutura
- Frameworks são tratados como **detalhe substituível**.
- Você evita espalhar atributos, classes-base e APIs de framework no domínio/use cases.
- Isso reduz “lock-in” e facilita upgrades/migrações.
---
## 7) Testabilidade como consequência
- Como o núcleo não depende de IO, é fácil escrever:
    - testes de unidade para entidades,
    - testes de caso de uso com dependências fakes/mock.
- Testes ficam mais rápidos e confiáveis.
---
## 8) DTOs e mapeamento (isolando transporte)
- Dados que entram/saem por HTTP/filas/GUI são frequentemente DTOs.
- O mapeamento para modelos internos evita “vazar” detalhes do transporte para o domínio.
---
## 9) Trade-offs e cuidados
- Pode aumentar número de arquivos e “cerimônia” em projetos pequenos.
- É importante equilibrar:
    - clareza e separação,
    - com pragmatismo (não criar camadas sem necessidade real).
- O benefício maior aparece em sistemas com:
    - regras de negócio relevantes,
    - integrações,
    - necessidade de evolução e testes.
---

# Principais conceitos de DDD (Domain-Driven Design)
DDD (Domain-Driven Design) é uma abordagem para construir software com foco no **domínio do negócio**, usando um modelo rico e uma linguagem compartilhada entre pessoas técnicas e de negócio. O objetivo é reduzir mal-entendidos, lidar melhor com complexidade e criar sistemas mais fáceis de evoluir.
---
## 1) Domínio, Subdomínios e Complexidade
- **Domínio**: o “assunto” do sistema (ex.: e-commerce, logística, pagamentos).
- **Subdomínios**: partes do domínio, geralmente classificados como:
    - **Core Domain**: onde está o diferencial do negócio (maior investimento e atenção).
    - **Supporting**: importante, mas não é o “diferencial”.
    - **Generic**: comum (pode usar soluções prontas).
- Ajuda a decidir **onde colocar esforço** (arquitetura, testes, especialistas, refino do modelo).
---
## 2) Ubiquitous Language (Linguagem Ubíqua)
- Um vocabulário **único e consistente** usado por todo o time (devs e negócio).
- Termos do domínio viram nomes no código, documentos e conversas.
- Reduz traduções ambíguas (“tecnês vs negocês”) e erros de entendimento.
---
## 3) Bounded Context (Contexto Delimitado)
- Limite onde um modelo e linguagem têm **significado consistente**.
- O mesmo termo pode ter significados diferentes em contextos diferentes (ex.: “Pedido” em Vendas vs “Pedido” em Logística).
- Bounded Context ajuda a evitar um “modelo único gigante” e reduz acoplamento.
---
## 4) Context Map (Mapa de Contextos)
- Mostra como Bounded Contexts se relacionam e se integram.
- Padrões de relacionamento (exemplos comuns):
    - **Customer/Supplier** (um contexto influencia o outro),
    - **Conformist** (um se adapta ao outro),
    - **Anti-Corruption Layer (ACL)** (camada para traduzir e proteger o modelo),
    - **Shared Kernel** (parte compartilhada com governança forte).
---
## 5) Domain Model (Modelo de Domínio)
- Representa regras e conceitos do negócio no código.
- Em DDD, busca-se um modelo que expresse **invariantes** e **regras** no lugar certo, não só “dados + CRUD”.
---
## 6) Building Blocks (Blocos Táticos do DDD)
### Entidade (Entity)
- Possui **identidade** e ciclo de vida (ex.: `Cliente`, `Pedido`).
- Pode mudar atributos, mas continua “sendo a mesma” devido ao ID.
### Objeto de Valor (Value Object)
- Não tem identidade; é definido pelos **valores** (ex.: `Dinheiro`, `Endereço`, `Período`).
- Geralmente é **imutável** e comparado por valor.
### Agregado (Aggregate) e Raiz do Agregado (Aggregate Root)
- Conjunto de entidades e value objects tratados como **unidade de consistência**.
- A **Aggregate Root** é a “porta de entrada” para alterações; garante invariantes.
- Regra prática: só referencie diretamente a **raiz**, não objetos internos do agregado.
### Repositório (Repository)
- Abstrai persistência (buscar/salvar agregados) como se fosse uma “coleção”.
- Ajuda a manter o domínio livre de detalhes de banco/ORM.
### Serviço de Domínio (Domain Service)
- Regra de negócio que não “encaixa” naturalmente em uma entidade/value object.
- Deve representar um conceito do domínio, não um “helper genérico”.
### Fábrica (Factory)
- Cria objetos/agregados complexos garantindo estado válido desde o início.
### Evento de Domínio (Domain Event)
- Representa algo que **aconteceu no domínio** (passado), relevante para outras partes.
- Ex.: “PedidoConfirmado”, “PagamentoAprovado”.
- Útil para integração entre bounded contexts e para desacoplar reações a acontecimentos.
---
## 7) Invariantes e Consistência
- DDD enfatiza colocar regras que “não podem ser quebradas” (invariantes) dentro do modelo.
- Agregados ajudam a definir limites de **consistência transacional**.
- Para consistência entre agregados/contextos, costuma-se usar **eventos** e consistência eventual.
---
## 8) DDD Estratégico vs Tático
- **Estratégico**: entender o domínio, subdomínios, bounded contexts e integrações (visão macro).
- **Tático**: como modelar no código com entidades, VOs, agregados, eventos, repositórios, etc. (visão micro).
---
## 9) Application Layer vs Domain Layer (separação comum)
- **Application Layer**: orquestra casos de uso (fluxo), chama domínio, controla transações.
- **Domain Layer**: regras e modelo do negócio (o “coração”).
- **Infrastructure Layer**: detalhes técnicos (DB, filas, APIs, IO).
---

# Principais conceitos de **CQRS** (Command Query Responsibility Segregation)
CQRS é um padrão arquitetural que separa as operações de **escrita** (*Commands*) das operações de **leitura** (*Queries*). Essa separação permite tratar leitura e escrita como processos independentes, otimizando cada um de forma distinta, o que deixa o sistema mais eficiente e escalável.
---
## 1) Separação entre Command e Query
### **Command (Escrita)**
- Representa a intenção de **alterar o estado** do sistema.
- Características principais:
    - Validações e regras de negócio concretas.
    - Não retorna dados de negócio (geralmente retorna apenas sucesso/falha, ID ou mensagens de erro).
- Exemplos: `CriarPedido`, `AtualizarPerfil`, `AprovarCompra`.
### **Query (Leitura)**
- Representa a intenção de **consultar dados** sem alterar estado.
- Características principais:
    - Focado na obtenção de informações.
    - Não possui efeitos colaterais no sistema (somente leitura).
- Exemplos: `ObterPedidosPorCliente`, `BuscarDetalhesDoProduto`.
---
## 2) Dois modelos distintos: Write Model e Read Model
- **Write Model**:
    - Projetado para **manter consistência** e **aplicar regras de negócio**.
    - Geralmente estruturado de forma relacional e normalizada.
- **Read Model**:
    - Otimizado para **desempenho** e para fornecer os dados no formato ideal para consumo (telas, relatórios, etc.).
    - Pode ser **desnormalizado** (ex.: tabelas ou documentos especializados por caso de uso).
---
## 3) Persistência e sincronização
- CQRS pode ser aplicado:
    - **No mesmo banco de dados**: separação no código, mas leitura/escrita ainda compartilham o banco.
    - **Em bancos distintos**: leitura e escrita têm bases separadas.
- Quando bancos distintos são usados:
    - **Consistência eventual** pode ocorrer (dados atualizados na escrita podem demorar a aparecer na leitura).
    - Um mecanismo de sincronização é usado, frequentemente baseado em eventos.
---
## 4) Handlers
### **Command Handler**
- Responsável por:
    - Receber o comando.
    - Validar e executar as regras de negócio.
    - Persiste mudanças usando o Write Model.
    - Pode publicar eventos de domínio.
### **Query Handler**
- Responsável por:
    - Realizar a consulta no Read Model.
    - Retornar os dados no formato esperado pelo cliente.
---
## 5) Eventos e projeções (opcionais)
- CQRS **não exige** o uso de eventos, mas é frequentemente combinado com:
    - **Eventos de domínio**: propagam mudanças do Write Model.
    - **Projeções**: atualizam o Read Model com base nos eventos.
- As projeções permitem construir bancos desnormalizados otimizados para leitura.
### Event Sourcing (opcional, avançado)
- Em vez de armazenar o estado atual diretamente, as mudanças no estado são registradas como uma sequência de **eventos** (ex.: `PedidoCriado`, `ItemAdicionadoNoCarrinho`).
- A partir desses eventos, o estado pode ser reconstruído (ou Read Models atualizados).
---
## 6) Benefícios do CQRS
- **Escalabilidade**: leitura e escrita podem escalar separadamente conforme suas demandas.
- **Performance**: o Read Model pode ser projetado para consultas rápidas e específicas.
- **Separação de responsabilidades**: mantém a lógica de leitura e escrita isoladas.
- **Flexibilidade**: diferentes visões de leitura podem ser construídas sem impactar o Write Model.
---
## 7) Desafios e trade-offs
- **Aumento da complexidade**:
    - Modelos separados exigem mais cuidado na sincronização e manutenção do Read Model.
    - Projeções e eventos podem aumentar as partes móveis do sistema.
- **Consistência eventual**:
    - Em sistemas com bases
---

# Principais conceitos de **Arquitetura Hexagonal** (Ports and Adapters)
A **Arquitetura Hexagonal**, também conhecida como **Ports and Adapters**, é um estilo arquitetural que visa criar sistemas **desacoplados e flexíveis**, permitindo que a lógica central (o domínio) seja independente de tecnologias externas (frameworks, bancos de dados, APIs, etc.). Essa independência facilita a testabilidade, a troca de implementações e a evolução dos sistemas.
---
## 1) Objetivo da Arquitetura Hexagonal
- Centralizar a lógica de negócio do sistema no **domínio**.
- Permitir que as interações externas (UI, banco de dados, APIs, filas, etc.) sejam tratadas como **detalhes** que podem ser facilmente substituídos.
- Facilitar a **testabilidade** ao isolar as dependências externas.
---
## 2) Elementos principais
### **1. Core (Domínio)**
- O núcleo do sistema, onde ficam as **regras de negócio**.
- Totalmente independente de frameworks, bancos de dados, UI ou qualquer tecnologia externa.
- É testado isoladamente, sem precisar de infraestrutura real.
### **2. Ports (Portas)**
- **Interfaces** através das quais o Core interage com o mundo externo.
- Responsabilidades:
    - Descrever o que o domínio precisa para funcionar (ex.: salvar um pedido, enviar um e-mail, buscar dados).
    - Garantir que o domínio não dependa diretamente de implementações concretas.
Tipos de ports:
- **Inbound Ports (entradas)**:
    - Usados por **adaptadores do lado de fora** para invocar lógicas do Core.
    - Representam os casos de uso (ex.: `CriarPedido`, `AtualizarCliente`).
- **Outbound Ports (saídas)**:
    - Usados pelo **domínio** para delegar tarefas a recursos externos (ex.: persistir dados, enviar mensagens).
    - Exemplo: `PedidoRepository`, `EmailService`.
### **3. Adapters (Adaptadores)**
- Implementações práticas das **Ports**.
- Ligam o Core a recursos ou serviços específicos, como:
    - APIs REST/GraphQL,
    - bancos de dados,
    - sistemas de mensageria (RabbitMQ, Kafka),
    - interfaces de usuário (UI).
- Exemplo:
    - `MySQLPedidoRepository` implementa o Port `PedidoRepository`.
    - `SendGridEmailService` implementa o Port `EmailService`.
---
## 3) Estrutura da Arquitetura Hexagonal
A arquitetura é frequentemente representada como um **hexágono** dividido em camadas:

1. **Core do domínio** (camada mais interna): contém as entidades e a lógica de negócios.
2. **Ports** (interfaces): ligam o Core ao mundo externo.
3. **Adapters** (implementações externas): conectam tecnologias e recursos externos às portas do Core.
---
## 4) Características principais
### **Desacoplamento**
- Isola o domínio de detalhes externos como frameworks e bancos.
- Para substituir tecnologia, basta trocar os adaptadores.
### **Testabilidade**
- O Core pode ser testado sem dependências externas (ex.: sem precisar de banco de dados real).
- Tests de unidade e mocks substituem facilmente as implementações reais das portas.
### **Flexibilidade**
- Novos adaptadores podem ser adicionados sem modificar o domínio.
- Exemplo: expor uma nova API GraphQL sem alterar a lógica central.
---
## 5) Benefícios
1. **Manutenção e Evolutividade**:
    - Regras de negócios são preservadas e protegidas de mudanças tecnológicas.
2. **Facilidade de teste**:
    - Teste o Core sem necessidade de infraestrutura.
3. **Independência de tecnologias específicas**:
    - Troque bancos de dados, frameworks ou ferramentas externas sem impactar o núcleo.
4. **Reusabilidade**:
    - O mesmo domínio pode ser utilizado em contextos diferentes.
---
## 6) Desafios
1. **Sobre complexidade inicial**:
    - Nem todo sistema precisa de um nível tão alto de abstração; pode aumentar a complexidade desnecessariamente em projetos pequenos.
2. **Design orientado a interfaces**:
    - Exige disciplina para projetar boas abstrações e evitar vazamentos do domínio para os adaptadores.
---
## 7) Comparação com outras arquiteturas
| **Ponto**             | **Arquitetura Hexagonal**          | **Clean Architecture**      |
|-----------------------|------------------------------------|-----------------------------|
| Foco principal        | Desacoplar domínio das tecnologias | Regras de negócio no centro |
| Comunicação           | Via Ports e Adapters               | Via camadas (use cases)     |
| Testabilidade interna | Muito alta                         | Muito alta                  |
---
## 8) Exemplos de uso prático
- Uma aplicação de e-commerce em que:
    - O domínio implementa a lógica de preços e descontos.
    - Uma porta de saída (`PedidoRepository`) pode ter diferentes adaptadores (MySQL, MongoDB).
    - Uma porta de entrada (`CriarPedido`) pode ser acionada via API REST ou uma interface CLI.
---

# Principais conceitos de **Microserviços**
Microserviços são um estilo arquitetural onde o sistema é dividido em **partes menores e independentes**, cada uma centrada em uma funcionalidade de negócio específica. Esses serviços comunicam-se entre si de forma leve, normalmente via APIs, e podem ser desenvolvidos, implementados e escalados de forma autônoma.
---
## 1) Características dos Microserviços
### **1.1. Independência**
- Cada microserviço pode ser desenvolvido, implementado e escalado de forma **independente**.
- Serviços não compartilham código ou banco de dados diretamente; interagem por meio de **APIs**.
### **1.2. Foco no domínio de negócio**
- Cada microserviço é responsável por uma **funcionalidade específica do negócio**.
- O sistema é modelado em torno de **subdomínios** (conforme conceitos de DDD).
### **1.3. Comunicação entre serviços**
- Geralmente ocorre via HTTP/REST, gRPC ou mensagens (RabbitMQ, Kafka).
- Comunicação pode ser síncrona ou assíncrona.
### **1.4. Descentralização**
- Cada microserviço pode ter suas **próprias decisões tecnológicas**: linguagem, banco de dados, frameworks, etc.
---
## 2) Arquitetura de Microserviços
### **2.1. API Gateway**
- Funciona como um ponto de entrada único para clientes, roteando as chamadas para os microserviços apropriados.
- Pode lidar com:
    - Autenticação/autorização.
    - Agregação de respostas de múltiplos serviços.
    - Monitoramento e logs.
### **2.2. Comunicação**
- **Síncrona**: solicitações diretas via REST/gRPC.
- **Assíncrona**: mensagens usando filas ou brokers como Kafka e RabbitMQ.
**2.3. Bancos de dados descentralizados**
- Cada microserviço gerencia seu próprio banco de dados (independência de dados).
- Evita um modelo monolítico de banco, promovendo **autonomia**.
## 3) Benefícios dos Microserviços
### **3.1. Escalabilidade**
- Serviços podem ser escalados individualmente conforme a demanda.
- Exemplo: escalar apenas o serviço de busca, sem afetar o restante do sistema.
### **3.2. Velocidade de Desenvolvimento**
- Times podem trabalhar em serviços diferentes de forma independente, reduzindo gargalos.
### **3.3. Resiliência**
- Falhas em um serviço específico não derrubam todo o sistema (se projetado corretamente).
### **3.4. Múltiplas tecnologias**
- Microserviços podem ser escritos em linguagens diferentes, dependendo das necessidades.
### **3.5. Manutenção**
- Atualizações e deploys podem ser feitos em um único serviço, sem necessidade de interromper todo o sistema.
---
## 4) Desafios dos Microserviços
### **4.1. Complexidade**
- Dividir um sistema em microserviços adiciona complexidade ao lidar com:
    - Comunicação entre serviços.
    - Monitoramento.
    - Gerenciamento de dependências.
### **4.2. Consistência de dados**
- Garantir a consistência e sincronização entre serviços pode ser difícil em sistemas distribuídos.
- Muitas vezes, exige o uso de **consistência eventual** e **eventos**.
### **4.3. Deploy**
- Orquestrar o deploy de múltiplos serviços pode ser desafiador, especialmente quando há dependências.
### **4.4. Monitoramento e rastreamento**
- Troubleshooting em sistemas distribuídos requer ferramentas para **observabilidade**:
    - Logs centralizados.
    - Rastreamento de transações distribuídas (Tracing).
    - Métricas de performance.
---
## 5) Ferramentas e tecnologias comuns
### **5.1. Comunicação**
- HTTP/REST
- gRPC
- Mensagerias: RabbitMQ, Kafka, AWS SQS, ZeroMQ
### **5.2. Orquestração e Deploy**
- Kubernetes
- Docker
- Service Mesh (ex.: Istio)
### **5.3. Gerenciamento**
- API Gateway: NGINX, Kong, Zuul
- Monitoramento: Prometheus, Grafana, ELK Stack, OpenTelemetry
---
## 6) Casos de Uso
### **6.1. E-commerce**
- Serviços separados para carrinho, catálogo, pagamentos e envio.
### **6.2. Streaming**
- Serviços como autenticação, recomendação e entrega de vídeo.
### **6.3. Setor financeiro**
- Serviços para processamento de transações, gestão de contas, relatórios, etc.
---
## 7) Monolito vs Microserviços: Comparação
| **Aspecto**              | **Monolito**                       | **Microserviços**                         |
|--------------------------|------------------------------------|-------------------------------------------|
| **Escalabilidade**       | Escalado como um todo              | Escalável por serviço                     |
| **Manutenção**           | Alterações impactam todo o sistema | Alterações isoladas                       |
| **Linguagem/Tecnologia** | Única tecnologia                   | Múltiplas tecnologias por serviço         |
| **Banco de dados**       | Centralizado                       | Distribuído (cada serviço gerencia o seu) |
| **Complexidade**         | Simples de construir inicialmente  | Maior complexidade de operação e deploy   |
---
## 8) Quando (não) usar Microserviços?
### **Use Microserviços quando:**
- O sistema for grande ou crescerá no futuro.
- Diferentes áreas podem ou precisam de desenvolvimento independente.
- A escalabilidade separada é necessária para demandas específicas.
### **Evite Microserviços quando:**
- O sistema for pequeno ou com baixa complexidade.
- Recursos para lidar com a orquestração e gerenciamento de serviços forem escassos.
---

# Principais conceitos de **Minimal API** no ASP.NET Core
**Minimal API** é um modelo de desenvolvimento leve no **ASP.NET Core** que simplifica a criação de APIs. Com menos configurações e códigos boilerplate, ela permite desenvolver aplicações rápidas e diretas, sendo ideal para microserviços, APIs simples ou protótipos.
---
## 1) O que é Minimal API?

- **Minimal API** é uma abordagem de desenvolvimento que reduz o uso de controladores e organização tradicional de APIs.
- Introduzida no **ASP.NET Core 6.0**, com foco em:
    - **Simplicidade**;
    - **Performance**;
    - **Menos código** sem sacrificar funcionalidades essenciais.
---
## 2) Características principais
### **2.1. Sem Controladores**
- Diferente da abordagem tradicional, a Minimal API não utiliza controladores separados.
- Rotas, endpoints e lógica estão concentrados no programa principal (ex.: `Program.cs`).
### **2.2. Configuração Simplificada**
- Não exige muitos arquivos ou configurações iniciais.
- Trabalha diretamente com middlewares e ferramentas-base do ASP.NET Core.
### **2.3. Alto desempenho**
- Desempenho otimizada graças ao código mais enxuto e sem sobrecarga de abstrações adicionais.
### **2.4. Delegates para endpoints**
- Endpoints podem ser declarados diretamente no código via expressões lambda.
- Exemplo:
  ```csharp
  var app = WebApplication.CreateBuilder(args).Build();
  app.MapGet("/hello", () => "Hello, World!");
  app.Run();
  ```
---
## 3) Benefícios da Minimal API
### **3.1. Simplicidade**
- Menos código e mais direto ao ponto, ideal para pequenas APIs ou protótipos.
### **3.2. Testabilidade**
- APIs pequenas são facéis de desacoplar e testar individualmente.
### **3.3. Performance**
- A ausência de sobrecarga estrutural melhora o desempenho em comparação com projetos mais robustos.
### **3.4. Produtividade**
- Desenvolvimento ágil, reduzindo tempo para realizar protótipos ou criar APIs simples.
---
## 4) Estrutura básica de uma Minimal API
### **4.1. Criando e configurando o aplicativo**
- O ponto de partida é o método `WebApplication.CreateBuilder`.
- Exemplo básico:
  ```csharp
  var builder = WebApplication.CreateBuilder(args);
  var app = builder.Build();
  app.MapGet("/", () => "Bem-vindo à Minimal API!");
  app.Run();
  ```
### **4.2. Mapear rotas com `Map`**
- Os métodos `MapGet`, `MapPost`, `MapPut` e `MapDelete` são usados para definir endpoints HTTP.
- Exemplo com diferentes métodos HTTP:
  ```csharp
  app.MapGet("/produtos", () => "Listagem de produtos");
  app.MapPost("/produtos", (Produto produto) => $"Produto {produto.Name} criado!");
  ```
### **4.3. Suporte à injeção de dependência (DI)**
- Minimal API suporta **injeção de dependência** diretamente nos handlers/rotas.
- Exemplo:
  ```csharp
  app.MapGet("/time", (DateTimeProvider dateTimeProvider) => {
      return $"Hora atual: {dateTimeProvider.Now()}";
  });
  ```
---
## 5) Validações e Binding
### **5.1. Bind automáticos**
- Parâmetros podem ser vinculados diretamente de:
    - Query Strings;
    - JSON no corpo da requisição;
    - Headers.
### **5.2. Validação de modelos**
- Usa anotações do C# como `[Required]`, `[MaxLength]`, etc.
- Exemplo:
  ```csharp
  app.MapPost("/usuarios", (Usuario usuario) => {
      if (!MiniValidator.TryValidate(usuario, out var errors))
          return Results.BadRequest(errors);

      return Results.Ok($"Usuário {usuario.Nome} criado!");
  });
  ```
---
## 6) Ferramentas de resposta (`Results`)
Minimal API oferece o objeto `Results` para facilitar a geração de respostas personalizadas:
- **Resultados comuns**:
    - `Results.Ok()`
    - `Results.BadRequest()`
    - `Results.NotFound()`
    - `Results.Unauthorized()`
- Exemplo:
  ```csharp
  app.MapGet("/cliente/{id}", (int id) =>
      id > 0 ? Results.Ok($"Cliente {id}") : Results.NotFound("Cliente não encontrado.")
  );
  ```
---
## 7) Quando usar Minimal API?
### **7.1. Casos Ideais**
- APIs pequenas ou simples;
- Protótipos e projetos MVP (Minimum Viable Product);
- Microserviços;
- Endpoints de funções simples.
### **7.2. Casos de Limitação**
- Aplicações grandes e complexas