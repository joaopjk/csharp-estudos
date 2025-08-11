# Padrões Criacionais

São padrões de design que lidam com mecanismos de criação de objetos
- *Encapsulamento*: Reduz a complexidade e promovem a reutilização de código.
- *Flexibilidade*: Facilitam a adição de novos tipos de objetos
- *Desacoplamento*: Reduzem a dependência entre classes e permitem isolar mudanças
- *Manutenção e testabilidade*: A criação dos objetos está centralizada, facilitando a manutenção e o desenvolvimento de testes
- *Consistência*: Os objetos são criados da mesma forma em todo o sistema, promovendo, por exemplo, standardização entre a equipe de desenvolvimento
- *Eficiência*: Padrões como o Singleton podem ajudar a otimizar recursos e reduzir potenciais bugs

## Factory Method
- Factory é um objeto que é usado para criar outros objetos
- No padrão Factory, criamos um objeto sem expor a lógica de criação ao cliente e referimos ao objeto recém-criado usando uma interface comum
- Tipos de Factory:
  - Simple Factory: mais usado, porém não está no catálogo GoF
  - Factory Method
  - Abstract Factory

## Simple Factory
- Cria objetos sem expor a lógica de criação ao cliente
- Refere-se ao objeto recém-criado usando uma interface comum

## Factory Method
- Define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar
- O Factory Method permite que uma classe adie a instanciação que ela usa para as subclasses
- O padrão usa herença e depdente de uma subclasse para lidar com a instanciação do objeto desejado
- Usado para criar objetos sem expor a lógica de criação ao cliente

## Abstract Factory
- Fornece uma interface para a criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas
- A interface fornecida define os métodos e cada método cria um objeto
- O padrão cria objetos por meio da composição e produz famílias de produtos onde as fábricas concretas implementam os métodos para criar produtos

## Builder
- Permite a separação da construção de um objeto complexo da sua representação, de forma que o mesmo processo de construção possa criar diferentes
representações
- Pode produzir diferentes tipos e representações de um objeto usando o mesmo código de construção
- Constrói um objeto complexo usando muitos objetos simples e uma abordagem passo a passo

## Fluent Builder
- Fluent builder é um estilo de codificação que força o desenvolvedor a criar o objeto em sequência, chamando cada método setter, um após o outro, até
que todos os atributos necessários sejam configurados
- Este padrãp fornece uma interface fluída o que torna o código muito mais fácil de ler
- A Fluent interface é uma API orientada a objetos cujo design se baseia no encadeamento de métodos cujo objetivo é aumentar a legibilidade do código
criando uma linguagem específica do domínio
- LINQ é um tipo de programação fluente

## Prototype
- Especificar os tipos de objetos a serem criados usando uma instância protótipo e criar novos objetos copiando este protótipo
- Permite copiar objetos existentes sem tornar seu código dependente de suas classes
- Delega o processo de clonagem para o próprio objeto que está sendo clonado
- Oferece uma maneira de criar novos objetos a partir da instância existente do objeto
- Evita criar um novo objeto utilizando a palavra-chave new, o que diminui o custo de memória
- Evita que as subclasses que criam objetos funcionem como o padrão abstract factory
- É útil quando a inicialização do objeto é cara e possui parâmetros de inicialização. Nesse contexto, o prototype pode evitar a criação do zedo que é
custosa e suportar clonagem barata de um protótipo pré-criado
- É o único entre os outros padrões de criação, pois não requer uma classe apenas um objeto
- Não requer o uso de subclases mais precisa de uma inicialização
- A clonagem de objetos complexos que contenham referências circulares pode ser problemática

## Singleton
- Garante que uma classe tenha somente uma instância fornecendo um ponto de acesso global a ela
- Thread-safe sem lock: Criar a classe como static e ela só será executada com a propriedade instance apenas quando for chamada pela primeira vez

---

# Padrões Estruturais

Padrões estruturais são padrões de design que tratam da composição de classes e objetos para formar estruturas maiores e mais flexíveis. Eles 
facilitam o design ao identificar maneiras simples de realizar relacionamentos entre entidades, promovendo reutilização, desacoplamento e organização
do código.

## Adapter
- Adapta uma interface em outra de acordo com a expectativa do cliente
- Permite a colaboração de objetos com interfaces incompatíveis
- Conhecido como Invólucro (Wrapper)
- Converte a interface de uma clsse em outra
- Envolver (Wrap) uma classe existente com uma nova interface
- Introduzir um componente legado em um novo sistema
- *Adaptador de Objeto*: Essa implementação usa o princípio de composição de objetos. O adaptador implemente a interface de um objeto e encobre o outro
- *Adaptador de Classe*: Essa implementação usa a herança: o adaptador herda interfaces de ambos os objetos ao mesmo tempo
### Exemplos de uso
- Quando um objeto precisa usar uma classe existente com uma interface incompatível
- Quando você deseja criar uma classe reutilizável que coopere como classes que não possuem interfaces compatíveis
### Vantagens
- Aumenta a reutilização de código
- Você pode usar código entre plataformas diferentes
- Permite a interação de dois ou mais objetos incompatíveis
### Desvantagens
- A complexidade geral do código aumenta porque você precisa introduzir um conjunto de novas interfaces e classes

## Bridge
- Desacopla uma abstração de sua implementação para que as duas possam variar de forma independente
- Divide a lógica de negócio (uma classe maior) em hierarquias de classes separadas que podem ser desenvolvidas de forma independente
- Separa a interface do objeto de sua implementação
### Exemplos de uso
- Quando queremos ocultar os detalhes de implementação do cliente
- Quando queremos evitar o forte acoplamento entre a abstração e a implementação
- Quando queremos alterar a implementação sem compilar a abstração
- Quando queremos compartilhar uma implementação entre vários objetos e isso deve ser escondido do cliente
### Vantagens
- Estimula o uso de um código fracamente acoplado
- Aumenta a capacidade de manutenção e reutilização do código e reduz a duplicação de código
- Ajuda a promover o princípio Aberto/Fechado (Open/Closed Principle)
- Facilita a extensibilidade
### Desvantagens
- Aumenta a complexidade do código, pois introduz mais classes e interfaces

## Composite
- Compõe objetos em estrtuturas semelhantes a uma árvore para representar hierarquias parte-todo
- Permite que os clientes tratem objetos individuais(leafs) e composições de objetos(composites) de maneira uniforme(como um único objeto)
- Recursividade
### Estrutura
- Component: é uma interface que descreve operações comuns a elementos simples ou complexos da árvore
- Leaf: é um único objeto que não possui subelementos
- Composite: é um objeto que possui subelementos(leafs ou outros compostos)
### Exemplos de uso
- Precisarmos criar uma estrutura em árvore para resolver um problema
- Precisarmos representar hierarquias parte-todo de objetos
- Queremos que os clientes ignorem a diferença entre composições de objetos e objetos individuais
### Vantagens
- Ajuda a alcançar a uniformidade(uso de funções semelhantes) em toda a hierarquia de objetos que contém tipos de objetos primitivos e compostos
- Torna mais fácil para o cliente atingir a funcionalidade desejada sem se procupar com o tipo de objeto com o qual está lidando
### Desvantagens
- Pode se tornar muit genérico devido à sua uniformidade, tornando difícil restringir objetos que podem ser incluídos no grupo composto

## Decorator
- Atribui responsabilidades adicionais a um objeto de forma dinânica sem afetar o comportamento de outros objetos da mesma classe
- Fornece uma alteranativa flexível à herança para estender uma funcionalidade
- Permite estender(decorar) de forma dinâmica as características(propriedades e comportamentos) de uma classe qualquer
### Exemplos de uso
- Quando houver necessidade de anexar ou remover o comportamento de apenas algumas instâncias de uma classe, em vez de todas as instâncias da classe
- Quando a estensão através da herença não for possível
- Quando temos uma classe que não pode ser herdada por estarmos herdando de uma outra classe qualquer(herança simples)
- Queremos adicionar responsabilidades a objetos individuais de forma dinâmica e transparente, sem afetar outros objetos
- Quando não podemos usar herança(sealed)
### Vantagens
- É mais flexível que a herança pois adiciona responsabilidades em tempo de execução e não em tempo de compilação
- Podemos ter qualquer número de decoradores e em qualquer ordem
- Estende a funcionalidade do objeto sem afetar outros objetos
### Desvantagens
- Aumenta a complexidade do código e número de objetos

## Facade
- Fornece uma interface unificada para um conjunto de interfaces em um subsistema(biblioteca, framework, etc)
- Define uma interface de nível superior que torna o subsistema mais fácil de usar
- Fica no topo de um grupo de subsistemas e permite que eles se comuniquem de uma maneira unificada
### Exemplos de uso
- Quando queremos simplificar um sequência de operações complexas
- Quando queremos simplificar a interface com o usuário
- Quando queremos fornecer uma interface única e uniforme para diversas funcionalidades de um subsistema
- Quando queremos criar sistemas em camadas. Um facade provê o ponto de entrada para cada camada do subsistema
### Vantagens
- Facilita a portabilidade do sistema e sua interação com o subsistema
- Isola os clientes dos componentes do subsistema reduzindo o número de objetos com os quais o cliente tem que lidar
- Promove um acoplamento fraco entre o subsistema e o clientes
### Desvantagens
- Introduz uma camada adicional entre o cliente e o subsistema, que contribui para a complexidade do código
- Cria uma dependência entre vários subsistemas, pois vários métodos são chamados a partir deles para servir o cliente

## Flyweight
- Usado para criar um grande número de objetos relacionados sem invocar muito trabalho de sobrecarga ao fazer isso, otimizando o consumo de memória e 
melhorando a performance
- Ele consegui isso compartilhando partes do estado do objeto entre vários objetos, assim, ele economiza mémoria armazenando em cache os mesmos dados
usados por objetos diferentes
- Cada objeto é chamado de Flyweight e é composto por dois tipos de estados:
  - Estado Intrínseco: É o estado compartilhado entre os objetos Flyweight. Ele é imutável e não pode ser alterado
  - Estado Extrínseco: É o estado que varia entre os objetos Flyweight. Ele é passado como parâmetro para os métodos do Flyweight
### Exemplos de uso
- Quando muitos objetos semelhantes serão usados e o custo de armazenamento for alto
- Quando pudermos compartilhar estado entre objetos e precisar criar muitos desses objetos
- Quando alguns objetos compartilhados facilmente substituiriam muitos objetos não compartilhados
- Quando precisarmos economizar memória 
### Vantagens
- Reduz o uso de memória compartilhando objetos pesados
- Favorece o Cache de dados permitindo um maior tempo de resposta
- Aumenta o desempenho reduzindo o número de objetos pesados na memória
### Desvantagens
- O objetos flyweights podem introduzir custos de tempo de execução associados à transferência, localização e/ou computação do estado extrínseco,
especialmente se ele foi anteriormente armazenado como estado intrínseco
- A aplicação do padrão possui escopo reduzido e de acordo com o GoF 5 condições devem ser atendidas:
  - O número de objetos que serão criados é grande
  - O custo de criação de um objeto é alto
  - A maioria dos estados dos objetos Flyweight são compartilhados
  - O estado extrínseco pode ser calculado ou armazenado em cache

## Proxy
- Fornece um objeto que atua como um substituto para um objeto de serviço real que é usado por um cliente para controlar o acesso a este objeto
- Permite encapsular a instância de uma classe complexa usando uma instância de outra classe que possui a mesma interface
- Um proxy é um objeto wrapper(empacotador) que está sendo chamando pelo cliente para acessar o objeto de serviço real, nos bastidores
- Proxy significa 'no lugar de' ou 'em nome de'(procurador)
- *Proxy Virtual*: É um espaço reservado para objetos que consomem muitos recursos para serem criados. Neste contexto o objeto real só é criado quando
um cliente primeiro solicita ou acessa o objeto
- *Proxy Remoto*: Fornece representação local para um objeto que reside em um espaço de endereço diferente
- *Proxy de Proteção*: Controla o acesso a um objeto principal. Aqui o objeto de proxy verifica se o chamador tem as permissões de acesso necessárias
antes de encaminhar a solicitação
### Exemplos de uso
- Quando você deseja fornecer um substituto para outro objeto
- Quando precisarmos de criar objetos sob demanda quando suas operações forem solicitadas
- Quando temos uma classe com dados sensíveis(que deveriam ser de acesso restrito) e é necessário fornecer o controle de acesso para o objeto original
- Quando temos que usar classes onde a criação dos objetos é muito demorada e consome muitos recursos
- Quando devemos permitir o acesso a um objeto remoto usando um objeto local(referenciando o objeto remoto)
### Vantagens
- *Proxy Virtual*: permite que você instancie objetos caros no último momento possível
- *Proxy Remoto*: permite que você faça chamadas de método para objetos que residem em domínios de aplicativo ou serviços totalmente diferentes
- *Proxy de Proteção*: permite que você controle o acesso a objetos sensíveis
### Desvantagens
- Introduz outra camada de abstração que às vezes pode ser um problema se o código do RealSubject for acessado por alguns dos clientes diretamente e
alguns deles puderem acessar as classes Proxy

---

# Padrões Comportamentais
Os padrões de projetos comportamentais focam na interação e comunicação entre objetos, definindo como eles colaboram para realizar tarefas e 
distribuir responsabilidades. Eles ajudam a tornar o sistema mais flexível, desacoplado e fácil de manter, organizando o fluxo de controle e o 
comportamento dos objetos.

## Chain of Responsibility
- Evita acoplar o remetente de uma solicitação a seu receptor, dando a mais de um objeto a chance de lidar com a solicitação
- Encadeia os objetos receptores e passa a solicitação ao longo da cadeia ate que um objeto a trate
- Simplifica as interconexões de objetos
- Evita a dependência entre um objeto recepetor e um objeto solicitante ou destinatário
### Exemplos de uso
- Quando tivermos mais de um manipulador para uma solicitação
- Quando tivermos motivos pelos quais um gerenciador deve passar uma solitação para outra na cadeia
- Quando tivermos um conjunto de manipuladores que variam de forma dinâmica
- Quando desejarmos manter a flexibilidade na atribuição de solicitações e manipuladores
- Quando tivermos uma cadeia muito lógica de manipuladores que devem ser executados em ordem repetidas vezes
### Vantagens
- Você pode controlar a ordem de tratamento de solicitações
- Você pode desacoplar classes que invocam operações de classes que as executam(SRP)
- Você pode introduzir novos manipuladores no aplicativo sem quebrar o código do cliente existente(Open/Closed Principle)
### Desvantagens
- Algumas solicitações podem não serem tratadas dificultando em observar as características em tempo de execução

## Command
- Encapsula uma requisição como um objeto, permitindo que clientes parametrizem diferentes requisições, filas ou logs, como a reverter as operações
- Converte solicitações ou operações simples em objetos
- Precisa emitir solicitações para objetos sem saber nada sobre a operação solicitada ou o receptor da solicitação
### Exemplos de uso
- Parametrizar objetos por uma ação a ser executada
- Especificar, enfileirar e executar solicitações em tempos diferentes
- Dar suporte para desfazer operações
- Estruturar um sistema em torno de operações de alto nível(transações)
- Reduzir acoplamento entre as requisiçÕes dos clientes e os objetos que as executam
- Facilitar a implementação de novas operações e tornar mais simples a manutenção das operações
### Vantagens
- Desacopla o objeto que invoca a operação daquele que sabe como executá-la
- Reduz o acoplamento entre os objetos que chama a operação e os objetos que a executam
- Os comandos são objetos de primeira classe, ou seja, podem ser manipulados e estendidos como qualquer outro objeto
- Um comando pode ser composto por outros commandos e é fácil acrescentar novos comandos(sem mudar classes existentes)
### Desvantagens
- O códgo pode se tornar complexo com o aumento no número de classes criadas para cada comando, dos métodos Action e das muitas associações

## Interpreter
- Dada uma linguagem, o padrão define uma representação para sua gramática junto com um intérprete que usa a representação para interpretar frases
na linguagem
- Usado para avaliar e interpretar as instruções escritas em uma gramática de linguagem ou notações. Ele envolve a implementação de uma interface de
expressão que diz para interpretar um contexto específico
- Fornece uma maneira de avaliar a gramática ou expressões da linguagem e pode ser usado em análise SQL, mecanismos de processamento de símbolos, em
compiladores, etc
### Exemplos de uso
- Pode ser usado quando houver uma linguagem para interpretar. Funciona melhorar quando:
	- Gramática é simples
	- A eficiência não é uma preocupação crítica
- Quando puder representar sentenças da linguagem como árvores sintáticas abstratas
### Vantagens
- É fácil mudar e estender a gramática. Como o padrão usa classes para representar regras gramaticais, você pode usar herança para alterar ou estender
a gramática. As expressões existentes podem ser modificadas de forma incremental e as novas expressões podem ser definidas como variações das antigas
- Implementar a gramática também é fácil. As classes que definme nós na ávores de sintaxe abstrata tem implementações semelhantes. Essas classes são
fáceis de escrever e, muitas vezes, sua geração pode ser automatizada com um compilador ou gerador de analisador
### Desvantagens
- Gramáticas complexas são difíceis de manter. O padrão define pelo menos uma classe para cada regra da gramática. Desta forma, gramáticas contendo
muitas regras podem ser difíceis de gerenciar e manter

## Iterator
- Fornece uma maneira de acessar os elementos de um objeto agregado(coleção) sequencialmente sem expor sua representação subjacente
- Permite o acesso sequencia a elementos de uma coleção sem expor a lógica interna
- A ideia principal deste padrão é extrair o comportamento transversal de uma coleção para um objeto seperado chamado de Iterador
### Exemplos de uso
- Quando sua coleção tiver uma estrutura de dados complexa e você deseja ocultar sua complexidade dos clientes
- Para reduzir a duplicação do código usada para percorrer coleções no seu aplicativo
- Quando quiser que seu código seja capaz de percorrer diferentes estruturas de dados ou quando os tipos dessas estruturas forem desconhecidos
### Vantagens
- Fornece suporte a iteração para estruturas de dados que originalmente não a possui
- Permite definir mais de um tipo de iterador
- Simplifica o código para acessar diferentes tipos de coleções
- Trata variáveis de todos os tipos, tamanhos e formos uniformemente, cabendo na memória ou não
- Segue os principios SRP e Open/Closed
### Desvantagens
- É menos eficiente ao percorrer elementos de algumas coleções especializadas, usando mais memória do que acesso direto ao elemento
- Não é recomendado para coleções simples