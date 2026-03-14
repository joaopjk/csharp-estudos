# Codificador Limpo
---
## 1) Nomes Significativos
- Nomes devem **revelar intenção**: deixar claro *o que é*, *porque existe* e *como é usado*.
- Evite **ambiguidade** e “sinônimos aleatórios” para o mesmo conceito; padronize vocabulário.
- Evite **distinções sem sentido** (ex.: `data`, `data2`, `info`, `obj`, `temp`).
- Prefira nomes **pronunciáveis** e **buscáveis** (facilita discussão e busca no código).
- **Classes** normalmente como substantivos; **métodos** normalmente como verbos.
- Quanto maior o escopo/impacto, mais **cuidado** com o nome.
---
## 2) Funções
- Funções devem ser **pequenas** e fazer **uma coisa só** (responsabilidade única).
- Evite muitos parâmetros; prefira **objetos de parâmetro** quando fizer sentido.
- Use nomes que descrevam claramente o **comportamento**.
- Reduza **efeitos colaterais** e dependências ocultas.
- Evite repetição (DRY) e mantenha o fluxo simples (pouca profundidade de `if/for/while`).
---
## 3) Comentários
- Comentário não deve ser “muleta” para código confuso: **código claro > comentário**.
- Bons comentários: explicam **intenção**, **decisões** e **trade-offs** que o código não revela.
- Comentários ruins: redundantes (“o que o código já diz”), desatualizados, longos demais, ou que “justificam bagunça”.
- Prefira refatorar para que o código **se explique** (nomes, funções pequenas, extrações).
---
## 4) Formatação
- Formatação é parte da **comunicação**: consistência aumenta legibilidade.
- Organize o arquivo para leitura: **conceitos relacionados ficam juntos**.
- Use espaçamento e quebras de linha para separar “blocos de ideia”.
- Convenções do time/projeto devem ser seguidas sempre (consistência > preferência pessoal).
---
## 5) Objetos e Estrutura de Dados
- **Objetos** expõem comportamento e escondem dados (encapsulamento).
- **Estruturas de dados** expõem dados e têm pouco comportamento.
- Escolha a abordagem conforme o tipo de mudança esperada:
    - Se muda mais o **comportamento**, objetos tendem a ajudar.
    - Se muda mais a **forma dos dados**, estruturas podem ser mais diretas.
- Evite “híbridos confusos” (meio objeto, meio estrutura) que não protegem nem simplificam.
---
## 6) Tratamento de Erros
- Trate erros de forma **explícita e consistente**.
- Prefira exceções (onde apropriado) em vez de códigos de erro espalhados.
- Separe o “caminho feliz” do “caminho do erro” para manter o fluxo legível.
- Mensagens de erro devem ajudar diagnóstico; não “engula” exceções sem contexto.
- Garanta limpeza/rollback quando necessário (recursos, estado, transações).
---
## 7) Limites (Boundaries)
- Ao usar bibliotecas/APIs externas, crie uma **camada de isolamento** (wrappers/adapters) para:
    - reduzir acoplamento,
    - centralizar mudanças,
    - facilitar testes.
- Não espalhe detalhes de frameworks por todo o código: mantenha dependências na “borda”.
- Escreva código para o *seu domínio* e adapte o resto.
---
## 8) Teste de Unidade
- Testes devem ser **rápidos, confiáveis e fáceis de ler**.
- Um bom teste é claro sobre: **arranjo**, **ação** e **verificação** (AAA).
- Teste deve ser **independente** (não depender da ordem, nem de estado global).
- Um teste que falha deve indicar o problema com precisão (boa nomenclatura e asserções).
- Código testável costuma ser melhor design: baixo acoplamento, alta coesão, dependências injetáveis.
---
## 9) Classes
- Classes devem ser **pequenas** em responsabilidade (SRP): um motivo principal para mudar.
- Mantenha **alta coesão**: métodos e campos da classe devem “pertencer” ao mesmo conceito.
- Reduza acoplamento entre classes; dependa de **abstrações** quando útil (DIP).
- Prefira composição e interfaces claras; evite classes “Deus” (muito grande, faz tudo).
- Organização interna ajuda leitura (campos, construtores, métodos públicos, privados, etc.).

___

# Solid

SOLID é um conjunto de 5 princípios de design orientado a objetos que ajudam a criar código mais **manutenível**, **flexível** e **testável**.
---
## S — Single Responsibility Principle (SRP)
**Uma classe/módulo deve ter um único motivo para mudar.**
- Cada componente deve ter **uma responsabilidade bem definida**.
- Evita “classes Deus” (fazem de tudo) e facilita manutenção.
- Ajuda a manter **alta coesão** e a reduzir efeitos colaterais.
---
## O — Open/Closed Principle (OCP)
**Entidades de software devem ser abertas para extensão e fechadas para modificação.**
- Você deve conseguir **adicionar comportamento** sem precisar alterar código já estável.
- Normalmente é alcançado com **polimorfismo**, **interfaces** e **composição**.
- Reduz risco de regressões ao evoluir o sistema.
---
## L — Liskov Substitution Principle (LSP)
**Subtipos devem poder substituir seus tipos-base sem quebrar o comportamento esperado.**
- Se `B` herda de `A`, você deve poder usar `B` onde `A` é esperado sem “surpresas”.
- Violações comuns:
    - sobrescrever método mudando regras essenciais do contrato,
    - lançar exceções inesperadas,
    - exigir pré-condições mais fortes ou entregar pós-condições mais fracas.
- Em geral: herança deve preservar o **contrato**.
---
## I — Interface Segregation Principle (ISP)
**Clientes não devem ser forçados a depender de interfaces que não usam.**
- Prefira **interfaces pequenas e específicas** (papéis/roles) em vez de uma interface “gorda”.
- Evita implementações com métodos “não usados”/“não suportados”.
- Ajuda a reduzir acoplamento e aumenta reutilização.
---
## D — Dependency Inversion Principle (DIP)
**Módulos de alto nível não devem depender de módulos de baixo nível; ambos devem depender de abstrações.  
Abstrações não devem depender de detalhes; detalhes devem depender de abstrações.**
- Direciona dependências para **interfaces/abstrações**.
- Facilita testes (mocks/fakes) e troca de implementações (ex.: trocar um repositório em memória por um banco).
- Geralmente aplicado via **injeção de dependência** (DI).
---

# DRY — *Don’t Repeat Yourself* (Não se repita)
**Ideia central:** evite duplicação de conhecimento e de lógica.
- Duplicação aumenta custo de manutenção: ao mudar uma regra, você precisa lembrar de alterar “todas as cópias”.
- Prefira **uma única fonte de verdade** para regras de negócio, validações e transformações.
- Como aplicar:
    - extrair funções/métodos reutilizáveis,
    - criar componentes/serviços compartilhados,
    - centralizar regras (em vez de repetir em vários lugares).
- Atenção: DRY não significa “juntar tudo”. Reutilização forçada pode criar acoplamento e piorar clareza.
---
# KISS — *Keep It Simple, Stupid* (Mantenha simples)
**Ideia central:** escolha a solução mais simples que resolva o problema de forma clara.
- Simples aqui significa **fácil de entender**, testar e manter (não necessariamente “menos linhas”).
- Evite complexidade desnecessária: abstrações profundas, padrões sem necessidade, generalizações prematuras.
- Como aplicar:
    - preferir código direto e legível,
    - reduzir ramificações e aninhamentos,
    - usar nomes claros e fluxo previsível.
---
# YAGNI — *You Aren’t Gonna Need It* (Você não vai precisar disso)
**Ideia central:** não implemente funcionalidades “para o futuro” sem uma necessidade real agora.
- Evita “overengineering” e código morto (features especulativas).
- Ajuda a manter foco no valor entregue e reduz custo de manutenção.
- Como aplicar:
    - implemente o que é necessário **para o requisito atual**,
    - quando surgir nova necessidade, evolua com base em fatos (não suposições),
    - refatore para extender quando houver demanda real.
___

# Principais conceitos de POO (Programação Orientada a Objetos)
POO é um paradigma que organiza o software em **objetos** que combinam **estado (dados)** e **comportamento (métodos)**, visando modelar o domínio e facilitar manutenção/evolução.
---
## 1) Classe e Objeto
- **Classe**: “molde”/tipo que define atributos e métodos (estrutura e comportamento).
- **Objeto**: instância concreta de uma classe em tempo de execução.
- Ideia prática: classes definem *o que algo é e faz*; objetos são *exemplares reais* disso.
---
## 2) Abstração
- Focar no que é essencial para o problema e **ocultar detalhes desnecessários**.
- Ajuda a criar modelos mais simples do mundo real e reduzir complexidade.
- Normalmente envolve definir **interfaces** claras e responsabilidades bem delimitadas.
---
## 3) Encapsulamento
- Protege o estado interno do objeto, controlando como ele é acessado/modificado.
- Exposição deve ser feita por uma API (métodos/propriedades) que mantenha o objeto em um **estado válido**.
- Benefícios: menos acoplamento, menos “efeitos colaterais” e maior previsibilidade.
---
## 4) Herança
- Permite criar uma classe baseada em outra, reaproveitando e especializando comportamento/estrutura.
- Modela relações do tipo **“é um”** (*is-a*).
- Use com cautela: herança forte pode aumentar acoplamento; muitas vezes **composição** é mais flexível.
---
## 5) Polimorfismo
- Permite tratar objetos de tipos diferentes de forma uniforme por uma **abstração comum** (ex.: interface/classe base).
- Comportamentos diferentes podem ser acionados pelo mesmo “contrato” (mesma chamada, implementações distintas).
- Ajuda a reduzir `if/else` por tipo e facilita extensão do sistema.
---
## 6) Composição (e Agregação)
- **Composição**: um objeto é formado por outros objetos (relação **“tem um”** / *has-a*) com dependência forte de ciclo de vida.
- **Agregação**: “tem um”, mas com dependência mais fraca (os componentes podem existir independentemente).
- Em design moderno, composição costuma ser preferida a herança para ganhar flexibilidade.
---
## 7) Interfaces e Contratos
- Uma **interface** define um conjunto de operações esperadas (um **contrato**), sem ditar a implementação.
- Facilita desacoplamento, testes (mocks/fakes) e substituição de implementações.
---
## 8) Coesão e Acoplamento (qualidade do design)
- **Alta coesão**: uma classe tem foco e responsabilidades relacionadas.
- **Baixo acoplamento**: classes dependem pouco de detalhes umas das outras.
- Geralmente, bom design em POO busca **alta coesão + baixo acoplamento**.
---
## 9) Mensagens / Colaboração entre objetos
- Sistemas POO são compostos por objetos **colaborando** entre si.
- A lógica emerge de “quem sabe o quê” e “quem faz o quê” (responsabilidades distribuídas).
---

# Principais conceitos de *Clean Code* (Código Limpo)
*Clean Code* é um conjunto de práticas para escrever código que seja **legível**, **fácil de manter**, **fácil de evoluir** e **difícil de usar errado**.
---
## 1) Legibilidade e intenção
- Código é uma forma de comunicação: deve ser escrito para **pessoas**, não só para o compilador.
- O leitor deve entender **o que está acontecendo** e **por que** com o mínimo de esforço.
- Prefira clareza a “truques” e espertezas.
---
## 2) Nomes significativos
- Nomes devem **revelar intenção** (o que é, porque existe, como é usado).
- Evite abreviações obscuras, termos genéricos e nomes muito parecidos.
- Padronize vocabulário (um termo por conceito).
- Classes tendem a ser substantivos; métodos, verbos.
---
## 3) Funções pequenas e focadas
- Funções devem ser **curtas** e fazer **uma coisa**.
- Reduza aninhamento (`if/for/while`) e complexidade ciclomática.
- Evite muitos parâmetros; quando necessário, agrupe com objetos apropriados.
- Minimize efeitos colaterais e dependências implícitas.
---
## 4) Comentários (com parcimônia)
- Comentários não devem compensar código ruim: **refatore** para o código se explicar.
- Bons comentários registram **intenção**, **decisões** e **trade-offs**.
- Comentários redundantes ou desatualizados pioram o código.
---
## 5) Formatação e organização
- Consistência de estilo melhora leitura e reduz carga cognitiva.
- Agrupe código relacionado; mantenha estrutura previsível.
- Use espaços e quebras de linha para separar “blocos de ideia”.
---
## 6) Objetos, dados e encapsulamento
- Proteja invariantes do domínio com encapsulamento.
- Prefira objetos com comportamento claro; evite “híbridos” confusos (meio objeto, meio estrutura de dados).
- Mantenha responsabilidade bem distribuída e coesa.
---
## 7) Tratamento de erros
- Erros devem ser tratados de forma **clara e consistente**.
- Preserve o “caminho feliz” legível e separe a lógica de erro.
- Não ignore exceções; adicione contexto quando necessário.
---
## 8) Testes (código limpo é testável)
- Testes devem ser legíveis, confiáveis e rápidos.
- Bons testes documentam comportamento e ajudam refatoração segura.
- Design orientado a testes incentiva baixo acoplamento e alta coesão.
---
## 9) Baixo acoplamento e alta coesão
- Evite dependências desnecessárias entre módulos/classes.
- Cada unidade deve ter foco (coesão) e interagir por interfaces/contratos claros.
- Facilita evolução, reutilização e manutenção.
---
## 10) Refatoração contínua
- Código limpo é um processo: melhorar continuamente sem mudar o comportamento.
- Elimine duplicação, simplifique, renomeie, extraia funções/classes.
- Pequenas melhorias frequentes evitam “dívida técnica” acumulada.
---

# Tipo Valor vs Tipo Referência (C#) — principais conceitos
Em C#, os tipos se dividem em **Tipos Valor** (*value types*) e **Tipos Referência** (*reference types*). A diferença central é **como eles são armazenados e como atribuições/passagens de parâmetro se comportam**.
---
## 1) O que é **Tipo Valor** (Value Type)
- A variável **contém o valor diretamente**.
- Ao atribuir para outra variável, ocorre **cópia do valor**.
- Exemplos comuns:
    - `int`, `double`, `decimal`, `bool`, `char`
    - `struct`
    - `enum`
    - `DateTime` (é `struct`)
**Consequência prática:** se você altera uma cópia, a original não muda.
---
## 2) O que é **Tipo Referência** (Reference Type)
- A variável **contém uma referência (um “ponteiro gerenciado”)** para um objeto no heap.
- Ao atribuir para outra variável, ocorre **cópia da referência**, e ambas passam a apontar para o **mesmo objeto**.
- Exemplos comuns:
    - `class`
    - `string` (é referência, embora seja imutável)
    - `object`
    - `array`
    - `delegate`
**Consequência prática:** se você modifica o objeto, todas as referências que apontam para ele “enxergam” a mudança.
---
## 3) Memória (visão geral)
- **Tipos Valor**:
    - podem ficar na *stack* (quando são variáveis locais) **ou**
    - podem ficar “dentro” de outro objeto no *heap* (ex.: campo de uma classe).
- **Tipos Referência**:
    - o objeto vive no *heap*;
    - a variável guarda apenas a **referência** (que pode estar na stack, em campo, etc.).
---
## 4) Atribuição e igualdade (diferenças comuns)
- **Atribuição**
    - Value type: copia o conteúdo.
    - Reference type: copia o endereço/referência.
- **Igualdade**
    - Value type: em geral, `Equals` compara por valor (conteúdo).
    - Reference type: por padrão, pode comparar referência (mesma instância), a menos que o tipo sobrescreva `Equals`/operadores.
    - `string` é um caso especial: é referência, mas comparação é normalmente por **conteúdo** (e é imutável).
---
## 5) Nullability (nulo)
- **Tipos Referência** podem ser `null` (não apontam para nenhum objeto).
- **Tipos Valor** não podem ser `null` por padrão, exceto `Nullable<T>` (ex.: `int?`, `DateTime?`).
---
## 6) Passagem de parâmetros (por valor vs referência)
Por padrão, parâmetros em C# são passados **por valor**:
- Se o parâmetro é **value type**, passar “por valor” copia o valor.
- Se o parâmetro é **reference type**, passar “por valor” copia a referência (ainda assim, aponta para o mesmo objeto).
Com `ref`, `out` e `in` você altera a forma de passagem:
- `ref` / `out`: permitem reatribuir a variável do chamador.
- `in`: passa por referência somente-leitura (útil para structs maiores).
---
## 7) Quando preferir cada um (regra prática)
- **Value type (struct)** costuma ser melhor para:
    - valores pequenos, imutáveis, com semântica de “número/medida” (ex.: coordenada, moeda, data),
    - quando faz sentido copiar e comparar por valor.
- **Reference type (class)** costuma ser melhor para:
    - entidades com identidade e ciclo de vida (ex.: `Customer`, `Order`),
    - objetos mutáveis e compartilhados.
---

# Principais conceitos de **BDD** (Behavior-Driven Development)
Behavior-Driven Development (BDD), ou Desenvolvimento Guiado por Comportamento, é uma abordagem de desenvolvimento de software focada em **comportamentos esperados do sistema**, descritos em uma linguagem que seja compreensível tanto para equipes técnicas quanto para não técnicas (como analistas de negócio ou stakeholders).
---
## 1) O que é BDD?
- É a evolução do TDD (Test-Driven Development), mas com foco na **especificação funcional comportamental**.
- Usa cases/cenários escritos em formato de **linguagem natural** para descrever como o sistema deve se comportar.
- Essas descrições são usadas para criar testes automatizados.
---
## 2) Objetivo do BDD
- Facilitar a **comunicação** entre equipes técnicas e não-técnicas.
- Focar nos comportamentos que trazem **valor ao negócio**, evitando discussões puramente técnicas.
- Garantir que a implementação esteja alinhada com os requisitos de negócio.
---
## 3) Elementos principais do BDD
### **1. Linguagem Ubíqua**
- O BDD promove a criação de **uma linguagem compartilhada** (comum entre devs, QA, analistas e stakeholders).
- Permite que todos compreendam os casos de uso e comportamentos esperados do sistema.
### **2. User Stories**
- Cenários de comportamento são geralmente derivados de **user stories** (histórias de usuário).
- Formato comum:
  ```
  Como [tipo de usuário]  
  Eu quero [função/desejo]  
  Para que [benefício/necessidade atendida]
  ```
### **3. Given-When-Then (GWT): Estrutura dos Cenários**
- O comportamento esperado é descrito em **cenários** no formato:
  ```
  Dado [um contexto inicial]  
  Quando [uma ação ocorre]  
  Então [um resultado esperado é observado]
  ```
- Exemplo:
  ```
  Cenário: Compra de um produto com sucesso  
  Dado que um cliente seleciona um produto disponível  
  Quando ele confirma o pedido e realiza o pagamento  
  Então o sistema deve registrar a compra e exibir uma mensagem de sucesso
  ```
### **4. Ferramentas de Automação**
- Ferramentas como Cucumber, SpecFlow ou Behave permitem vincular os cenários escritos em linguagem natural (ex.: Gherkin) a testes automatizados.
- Exemplo de vinculação:
    - O texto `Dado que um cliente seleciona um produto disponível` é associado a um código que simula tal ação.
---
## 4) Práticas do BDD
### **1. Colaboração**
- Envolver todas as partes interessadas (negócio, desenvolvedores, QA) em uma discussão inicial sobre comportamentos e critérios.
### **2. Descrição orientada a comportamento**
- Priorize descrever **o que o software deve fazer**, não **como** isso será implementado.
### **3. Critérios de Aceitação**
- Cada cenário é, na prática, um **critério de aceitação automatizado**.
- Se o teste baseado no cenário falha, significa que o comportamento esperado não foi implementado corretamente.
---
## 5) Benefícios do BDD
- **Alinhamento entre times**: promove um entendimento compartilhado dos requisitos.
- **Foco no negócio**: minimiza desperdício ao implementar o que realmente gera valor.
- **Documentação viva**: os cenários funcionam como especificação funcional, alinhada com os testes.
- **Redução de ambiguidades**: cenários bem definidos esclarecem dúvidas antes de iniciar a implementação.
---
## 6) Desafios do BDD
- **Criação de cenários ambíguos**:
    - Cenários mal escritos ou genéricos podem confundir em vez de ajudar.
- **Sobrecarga inicial**:
    - Envolver múltiplas partes interessadas em cada funcionalidade pode parecer custoso, mas geralmente compensa a longo prazo.
- **Foco excessivo em ferramentas**:
    - Ferramentas são úteis, mas o maior valor do BDD vem das discussões e da colaboração.
---
## 7) Ferramentas populares para BDD
- **Cucumber** (Java, Ruby, etc.)
- **SpecFlow** (.NET)
- **Behave** (Python)
- **JBehave** (Java)
- **Lettuce** (Python)
---
## 8) Quando usar BDD?
- Projetos com múltiplas equipes, onde comunicação e alinhamento são cruciais.
- Quando há dependência clara entre regras de negócio e comportamento esperado.
- Para criar uma documentação funcional automatizada que acompanhe a evolução do sistema.
---

# Principais conceitos de **TDD** (Test-Driven Development)
TDD (Test-Driven Development), ou Desenvolvimento Guiado por Testes, é uma técnica de desenvolvimento de software onde testes são escritos **antes do código funcional**. O processo foca em ciclos curtos de iteração, garantindo que cada parte do sistema seja funcional e testável, promovendo alta qualidade e facilidade de manutenção.
---
## 1) O que é TDD?
- É um processo iterativo onde **testes automatizados orientam o desenvolvimento**.
- Baseia-se na ideia de que todo código novo deve ser acompanhado por um **teste que valide seu comportamento**.
- Ajuda a criar software de forma incremental e com menor risco de bugs.
---
## 2) O ciclo do TDD (Red-Green-Refactor)
### **1. Red (Escreva um teste que falhe):**
- Escreva um teste para o comportamento desejado.
- Inicialmente, o teste não vai passar porque a funcionalidade ainda não existe.
### **2. Green (Implemente o mínimo para passar o teste):**
- Implemente a funcionalidade de forma suficiente para que o teste passe.
- A ideia é focar **no comportamento esperado**, não na perfeição do código.
### **3. Refactor (Refatore o código):**
- Melhore o código existente, priorizando simplicidade, clareza e qualidade.
- Certifique-se de que todos os testes continuam passando após a refatoração.
Esses passos são repetidos continuamente em ciclos curtos.
---
## 3) Princípios do TDD
### **1. Teste primeiro**
- Antes de adicionar qualquer funcionalidade, escreva um teste que descreva o comportamento esperado.
### **2. Ciclos pequenos**
- Faça pequenas alterações no código e nos testes para manter o processo rápido e eficiente.
### **3. Um teste por vez**
- Escreva um único teste, implemente a funcionalidade necessária para passá-lo e só depois escreva o próximo teste.
### **4. Sem deadline artificial**
- Não avance para outros testes ou funcionalidades enquanto não concluir o ciclo atual.
---
## 4) Benefícios do TDD
### **1. Código de alta qualidade**
- O código é testável e geralmente possui **baixo acoplamento e alta coesão**, facilitando manutenções futuras.
### **2. Redução de bugs**
- Como todo comportamento é coberto por testes, erros são detectados mais cedo.
### **3. Confiança ao refatorar**
- Mudanças podem ser feitas no código com segurança, pois você sabe que os testes protegem os comportamentos esperados.
### **4. Documentação viva**
- Os testes servem como uma documentação executável do sistema.
### **5. Evita overengineering**
- Você escreve apenas o código necessário para atender aos testes, reduzindo complexidade desnecessária.
---
## 5) Desafios do TDD
### **1. Curva de aprendizado**
- Pode ser desafiador para equipes acostumadas a começar pelo código funcional em vez de pelos testes.
### **2. Sobrecarga inicial**
- Em sistemas ou funcionalidades simples, criar testes primeiro pode parecer mais demorado (mas compensa a longo prazo).
### **3. Qualidade dos testes**
- Testes mal escritos ou genéricos podem gerar um falso senso de confiança. É importante escrever **testes claros e específicos**.
---
## 6) Testes no TDD
### **1. Testes de unidade**
- O foco principal do TDD.
- Validam funcionalidades específicas de forma isolada.
### **2. Testes bem escritos**
- Devem ser **rápidos**, **reprodutíveis** e **independentes** uns dos outros.
- Seguem o padrão **AAA (Arrange, Act, Assert)**:
    - **Arrange**: configurar o cenário/teste.
    - **Act**: executar a ação a ser testada.
    - **Assert**: verificar se o resultado esperado foi atingido.
---
## 7) TDD x Testes Tradicionais

| **Testes Tradicionais**                          | **TDD**                                     |
|--------------------------------------------------|---------------------------------------------|
| Testes são feitos **após** o código.             | Testes são escritos **antes** do código.    |
| Código não é necessariamente orientado a testes. | Produz código altamente testável e modular. |
| Pode ser difícil cobrir cenários complexos.      | Foca em pequenos ciclos incrementais.       |
---
## 8) Ferramentas comuns para TDD
- **Java**: JUnit, TestNG
- **.Net (C#)**: NUnit, xUnit, MSTest
- **JavaScript**: Jest, Mocha
- **Python**: Unittest, PyTest
- **Ruby**: RSpec
---

# Principais conceitos de **EDD** (Event-Driven Design / Arquitetura Orientada a Eventos)
O **Event-Driven Design (EDD)** é um paradigma arquitetural baseado na ideia de que **eventos** dirigem o comportamento e a comunicação num sistema. Ele foca em sistemas assíncronos aonde partes independentes reagem a acontecimentos, promovendo **desacoplamento**, **escalabilidade** e **flexibilidade**.
---
## 1) O que é um Evento?
- Um **evento** é uma **notificação de que algo aconteceu** no sistema.
- Exemplos:
    - *PedidoCriado*
    - *PagamentoAprovado*
    - *ClienteRegistrado*
- Eventos são declarações de fato (algo que já ocorreu, sempre no passado).
---
## 2) Componentes principais
### **Produtores (Emitters)**
- Gatilhos que criam eventos quando algo acontece no sistema.
- Exemplo: um serviço de pedidos emite um evento `PedidoCriado` após salvar o pedido.
### **Consumidores (Listeners)**
- Partes do sistema que **reagem** aos eventos emitidos.
- Exemplo: um serviço de faturamento consome o evento `PedidoCriado` para gerar uma nota fiscal.
### **Mensageria/Event Broker**
- Infraestrutura responsável por entregar os eventos dos produtores para os consumidores.
- Exemplos: RabbitMQ, Apache Kafka, AWS SNS/SQS.
### **Eventos**
- Representam os dados necessários para descrever algo que aconteceu.
- Geralmente possuem:
    - **Tipo**: qual o nome do evento (ex.: `PedidoCriado`).
    - **Dados**: informações adicionais sobre o evento (ex.: ID do pedido, valor total).
---
## 3) Características do EDD
### **1. Comunicação Assíncrona**
- Produtores não precisam esperar uma resposta dos consumidores.
- As mensagens são colocadas em filas ou topics e processadas de forma independente.
### **2. Desacoplamento**
- Produtores e consumidores são independentes:
    - O produtor não sabe quem está consumindo o evento.
    - O consumidor não depende diretamente do produtor.
- Isso permite adicionar novos consumidores sem afetar os sistemas existentes.
### **3. Escalabilidade**
- Por ser assíncrono e desacoplado, sistemas orientados a eventos lidam melhor com altas cargas.
- Permite processar eventos em paralelo e em diferentes serviços.
### **4. Eventual Consistency**
- Como os eventos fluem entre sistemas diferentes, pode haver um delay até que todas as partes estejam atualizadas.
- O sistema precisa estar preparado para consistência eventual.
---
## 4) Padrões comuns em EDD
### **1. Evento de Domínio (Domain Event)**
- Representa algo importante no domínio do negócio.
- Exemplo: `PedidoCriado`, `PagamentoRejeitado`.
### **2. Evento de Integração**
- Usado para comunicação entre sistemas diferentes.
- Geralmente publicado para um barramento de eventos (*event bus*).
### **3. Event Sourcing**
- Armazena o estado de uma entidade como uma sequência de eventos.
- O estado atual é reconstruído a partir dessa sequência.
### **4. CQRS (Command Query Responsibility Segregation)**
- Muitas vezes é usado com EDD para processar eventos no lado da escrita e criar projeções otimizadas no lado da leitura.
---
## 5) Benefícios do EDD
1. **Desacoplamento**: permite mudanças em um serviço sem impactar diretamente outros.
2. **Escalabilidade**: suporta grandes volumes de dados e usuários com facilidade.
3. **Extensibilidade**: consumidores podem ser adicionados ou modificados sem alterar os produtores.
4. **Resiliência**: sistemas podem continuar funcionando mesmo que partes estejam temporariamente indisponíveis.
---
