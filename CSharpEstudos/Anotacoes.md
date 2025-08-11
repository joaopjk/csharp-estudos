# Padr�es Criacionais

S�o padr�es de design que lidam com mecanismos de cria��o de objetos
- *Encapsulamento*: Reduz a complexidade e promovem a reutiliza��o de c�digo.
- *Flexibilidade*: Facilitam a adi��o de novos tipos de objetos
- *Desacoplamento*: Reduzem a depend�ncia entre classes e permitem isolar mudan�as
- *Manuten��o e testabilidade*: A cria��o dos objetos est� centralizada, facilitando a manuten��o e o desenvolvimento de testes
- *Consist�ncia*: Os objetos s�o criados da mesma forma em todo o sistema, promovendo, por exemplo, standardiza��o entre a equipe de desenvolvimento
- *Efici�ncia*: Padr�es como o Singleton podem ajudar a otimizar recursos e reduzir potenciais bugs

## Factory Method
- Factory � um objeto que � usado para criar outros objetos
- No padr�o Factory, criamos um objeto sem expor a l�gica de cria��o ao cliente e referimos ao objeto rec�m-criado usando uma interface comum
- Tipos de Factory:
  - Simple Factory: mais usado, por�m n�o est� no cat�logo GoF
  - Factory Method
  - Abstract Factory

## Simple Factory
- Cria objetos sem expor a l�gica de cria��o ao cliente
- Refere-se ao objeto rec�m-criado usando uma interface comum

## Factory Method
- Define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar
- O Factory Method permite que uma classe adie a instancia��o que ela usa para as subclasses
- O padr�o usa heren�a e depdente de uma subclasse para lidar com a instancia��o do objeto desejado
- Usado para criar objetos sem expor a l�gica de cria��o ao cliente

## Abstract Factory
- Fornece uma interface para a cria��o de fam�lias de objetos relacionados ou dependentes sem especificar suas classes concretas
- A interface fornecida define os m�todos e cada m�todo cria um objeto
- O padr�o cria objetos por meio da composi��o e produz fam�lias de produtos onde as f�bricas concretas implementam os m�todos para criar produtos

## Builder
- Permite a separa��o da constru��o de um objeto complexo da sua representa��o, de forma que o mesmo processo de constru��o possa criar diferentes
representa��es
- Pode produzir diferentes tipos e representa��es de um objeto usando o mesmo c�digo de constru��o
- Constr�i um objeto complexo usando muitos objetos simples e uma abordagem passo a passo

## Fluent Builder
- Fluent builder � um estilo de codifica��o que for�a o desenvolvedor a criar o objeto em sequ�ncia, chamando cada m�todo setter, um ap�s o outro, at�
que todos os atributos necess�rios sejam configurados
- Este padr�p fornece uma interface flu�da o que torna o c�digo muito mais f�cil de ler
- A Fluent interface � uma API orientada a objetos cujo design se baseia no encadeamento de m�todos cujo objetivo � aumentar a legibilidade do c�digo
criando uma linguagem espec�fica do dom�nio
- LINQ � um tipo de programa��o fluente

## Prototype
- Especificar os tipos de objetos a serem criados usando uma inst�ncia prot�tipo e criar novos objetos copiando este prot�tipo
- Permite copiar objetos existentes sem tornar seu c�digo dependente de suas classes
- Delega o processo de clonagem para o pr�prio objeto que est� sendo clonado
- Oferece uma maneira de criar novos objetos a partir da inst�ncia existente do objeto
- Evita criar um novo objeto utilizando a palavra-chave new, o que diminui o custo de mem�ria
- Evita que as subclasses que criam objetos funcionem como o padr�o abstract factory
- � �til quando a inicializa��o do objeto � cara e possui par�metros de inicializa��o. Nesse contexto, o prototype pode evitar a cria��o do zedo que �
custosa e suportar clonagem barata de um prot�tipo pr�-criado
- � o �nico entre os outros padr�es de cria��o, pois n�o requer uma classe apenas um objeto
- N�o requer o uso de subclases mais precisa de uma inicializa��o
- A clonagem de objetos complexos que contenham refer�ncias circulares pode ser problem�tica

## Singleton
- Garante que uma classe tenha somente uma inst�ncia fornecendo um ponto de acesso global a ela
- Thread-safe sem lock: Criar a classe como static e ela s� ser� executada com a propriedade instance apenas quando for chamada pela primeira vez

---

# Padr�es Estruturais

Padr�es estruturais s�o padr�es de design que tratam da composi��o de classes e objetos para formar estruturas maiores e mais flex�veis. Eles 
facilitam o design ao identificar maneiras simples de realizar relacionamentos entre entidades, promovendo reutiliza��o, desacoplamento e organiza��o
do c�digo.

## Adapter
- Adapta uma interface em outra de acordo com a expectativa do cliente
- Permite a colabora��o de objetos com interfaces incompat�veis
- Conhecido como Inv�lucro (Wrapper)
- Converte a interface de uma clsse em outra
- Envolver (Wrap) uma classe existente com uma nova interface
- Introduzir um componente legado em um novo sistema
- *Adaptador de Objeto*: Essa implementa��o usa o princ�pio de composi��o de objetos. O adaptador implemente a interface de um objeto e encobre o outro
- *Adaptador de Classe*: Essa implementa��o usa a heran�a: o adaptador herda interfaces de ambos os objetos ao mesmo tempo
### Exemplos de uso
- Quando um objeto precisa usar uma classe existente com uma interface incompat�vel
- Quando voc� deseja criar uma classe reutiliz�vel que coopere como classes que n�o possuem interfaces compat�veis
### Vantagens
- Aumenta a reutiliza��o de c�digo
- Voc� pode usar c�digo entre plataformas diferentes
- Permite a intera��o de dois ou mais objetos incompat�veis
### Desvantagens
- A complexidade geral do c�digo aumenta porque voc� precisa introduzir um conjunto de novas interfaces e classes

## Bridge
- Desacopla uma abstra��o de sua implementa��o para que as duas possam variar de forma independente
- Divide a l�gica de neg�cio (uma classe maior) em hierarquias de classes separadas que podem ser desenvolvidas de forma independente
- Separa a interface do objeto de sua implementa��o
### Exemplos de uso
- Quando queremos ocultar os detalhes de implementa��o do cliente
- Quando queremos evitar o forte acoplamento entre a abstra��o e a implementa��o
- Quando queremos alterar a implementa��o sem compilar a abstra��o
- Quando queremos compartilhar uma implementa��o entre v�rios objetos e isso deve ser escondido do cliente
### Vantagens
- Estimula o uso de um c�digo fracamente acoplado
- Aumenta a capacidade de manuten��o e reutiliza��o do c�digo e reduz a duplica��o de c�digo
- Ajuda a promover o princ�pio Aberto/Fechado (Open/Closed Principle)
- Facilita a extensibilidade
### Desvantagens
- Aumenta a complexidade do c�digo, pois introduz mais classes e interfaces

## Composite
- Comp�e objetos em estrtuturas semelhantes a uma �rvore para representar hierarquias parte-todo
- Permite que os clientes tratem objetos individuais(leafs) e composi��es de objetos(composites) de maneira uniforme(como um �nico objeto)
- Recursividade
### Estrutura
- Component: � uma interface que descreve opera��es comuns a elementos simples ou complexos da �rvore
- Leaf: � um �nico objeto que n�o possui subelementos
- Composite: � um objeto que possui subelementos(leafs ou outros compostos)
### Exemplos de uso
- Precisarmos criar uma estrutura em �rvore para resolver um problema
- Precisarmos representar hierarquias parte-todo de objetos
- Queremos que os clientes ignorem a diferen�a entre composi��es de objetos e objetos individuais
### Vantagens
- Ajuda a alcan�ar a uniformidade(uso de fun��es semelhantes) em toda a hierarquia de objetos que cont�m tipos de objetos primitivos e compostos
- Torna mais f�cil para o cliente atingir a funcionalidade desejada sem se procupar com o tipo de objeto com o qual est� lidando
### Desvantagens
- Pode se tornar muit gen�rico devido � sua uniformidade, tornando dif�cil restringir objetos que podem ser inclu�dos no grupo composto

## Decorator
- Atribui responsabilidades adicionais a um objeto de forma din�nica sem afetar o comportamento de outros objetos da mesma classe
- Fornece uma alteranativa flex�vel � heran�a para estender uma funcionalidade
- Permite estender(decorar) de forma din�mica as caracter�sticas(propriedades e comportamentos) de uma classe qualquer
### Exemplos de uso
- Quando houver necessidade de anexar ou remover o comportamento de apenas algumas inst�ncias de uma classe, em vez de todas as inst�ncias da classe
- Quando a estens�o atrav�s da heren�a n�o for poss�vel
- Quando temos uma classe que n�o pode ser herdada por estarmos herdando de uma outra classe qualquer(heran�a simples)
- Queremos adicionar responsabilidades a objetos individuais de forma din�mica e transparente, sem afetar outros objetos
- Quando n�o podemos usar heran�a(sealed)
### Vantagens
- � mais flex�vel que a heran�a pois adiciona responsabilidades em tempo de execu��o e n�o em tempo de compila��o
- Podemos ter qualquer n�mero de decoradores e em qualquer ordem
- Estende a funcionalidade do objeto sem afetar outros objetos
### Desvantagens
- Aumenta a complexidade do c�digo e n�mero de objetos

## Facade
- Fornece uma interface unificada para um conjunto de interfaces em um subsistema(biblioteca, framework, etc)
- Define uma interface de n�vel superior que torna o subsistema mais f�cil de usar
- Fica no topo de um grupo de subsistemas e permite que eles se comuniquem de uma maneira unificada
### Exemplos de uso
- Quando queremos simplificar um sequ�ncia de opera��es complexas
- Quando queremos simplificar a interface com o usu�rio
- Quando queremos fornecer uma interface �nica e uniforme para diversas funcionalidades de um subsistema
- Quando queremos criar sistemas em camadas. Um facade prov� o ponto de entrada para cada camada do subsistema
### Vantagens
- Facilita a portabilidade do sistema e sua intera��o com o subsistema
- Isola os clientes dos componentes do subsistema reduzindo o n�mero de objetos com os quais o cliente tem que lidar
- Promove um acoplamento fraco entre o subsistema e o clientes
### Desvantagens
- Introduz uma camada adicional entre o cliente e o subsistema, que contribui para a complexidade do c�digo
- Cria uma depend�ncia entre v�rios subsistemas, pois v�rios m�todos s�o chamados a partir deles para servir o cliente

## Flyweight
- Usado para criar um grande n�mero de objetos relacionados sem invocar muito trabalho de sobrecarga ao fazer isso, otimizando o consumo de mem�ria e 
melhorando a performance
- Ele consegui isso compartilhando partes do estado do objeto entre v�rios objetos, assim, ele economiza m�moria armazenando em cache os mesmos dados
usados por objetos diferentes
- Cada objeto � chamado de Flyweight e � composto por dois tipos de estados:
  - Estado Intr�nseco: � o estado compartilhado entre os objetos Flyweight. Ele � imut�vel e n�o pode ser alterado
  - Estado Extr�nseco: � o estado que varia entre os objetos Flyweight. Ele � passado como par�metro para os m�todos do Flyweight
### Exemplos de uso
- Quando muitos objetos semelhantes ser�o usados e o custo de armazenamento for alto
- Quando pudermos compartilhar estado entre objetos e precisar criar muitos desses objetos
- Quando alguns objetos compartilhados facilmente substituiriam muitos objetos n�o compartilhados
- Quando precisarmos economizar mem�ria 
### Vantagens
- Reduz o uso de mem�ria compartilhando objetos pesados
- Favorece o Cache de dados permitindo um maior tempo de resposta
- Aumenta o desempenho reduzindo o n�mero de objetos pesados na mem�ria
### Desvantagens
- O objetos flyweights podem introduzir custos de tempo de execu��o associados � transfer�ncia, localiza��o e/ou computa��o do estado extr�nseco,
especialmente se ele foi anteriormente armazenado como estado intr�nseco
- A aplica��o do padr�o possui escopo reduzido e de acordo com o GoF 5 condi��es devem ser atendidas:
  - O n�mero de objetos que ser�o criados � grande
  - O custo de cria��o de um objeto � alto
  - A maioria dos estados dos objetos Flyweight s�o compartilhados
  - O estado extr�nseco pode ser calculado ou armazenado em cache

## Proxy
- Fornece um objeto que atua como um substituto para um objeto de servi�o real que � usado por um cliente para controlar o acesso a este objeto
- Permite encapsular a inst�ncia de uma classe complexa usando uma inst�ncia de outra classe que possui a mesma interface
- Um proxy � um objeto wrapper(empacotador) que est� sendo chamando pelo cliente para acessar o objeto de servi�o real, nos bastidores
- Proxy significa 'no lugar de' ou 'em nome de'(procurador)
- *Proxy Virtual*: � um espa�o reservado para objetos que consomem muitos recursos para serem criados. Neste contexto o objeto real s� � criado quando
um cliente primeiro solicita ou acessa o objeto
- *Proxy Remoto*: Fornece representa��o local para um objeto que reside em um espa�o de endere�o diferente
- *Proxy de Prote��o*: Controla o acesso a um objeto principal. Aqui o objeto de proxy verifica se o chamador tem as permiss�es de acesso necess�rias
antes de encaminhar a solicita��o
### Exemplos de uso
- Quando voc� deseja fornecer um substituto para outro objeto
- Quando precisarmos de criar objetos sob demanda quando suas opera��es forem solicitadas
- Quando temos uma classe com dados sens�veis(que deveriam ser de acesso restrito) e � necess�rio fornecer o controle de acesso para o objeto original
- Quando temos que usar classes onde a cria��o dos objetos � muito demorada e consome muitos recursos
- Quando devemos permitir o acesso a um objeto remoto usando um objeto local(referenciando o objeto remoto)
### Vantagens
- *Proxy Virtual*: permite que voc� instancie objetos caros no �ltimo momento poss�vel
- *Proxy Remoto*: permite que voc� fa�a chamadas de m�todo para objetos que residem em dom�nios de aplicativo ou servi�os totalmente diferentes
- *Proxy de Prote��o*: permite que voc� controle o acesso a objetos sens�veis
### Desvantagens
- Introduz outra camada de abstra��o que �s vezes pode ser um problema se o c�digo do RealSubject for acessado por alguns dos clientes diretamente e
alguns deles puderem acessar as classes Proxy

---

# Padr�es Comportamentais
Os padr�es de projetos comportamentais focam na intera��o e comunica��o entre objetos, definindo como eles colaboram para realizar tarefas e 
distribuir responsabilidades. Eles ajudam a tornar o sistema mais flex�vel, desacoplado e f�cil de manter, organizando o fluxo de controle e o 
comportamento dos objetos.

## Chain of Responsibility
- Evita acoplar o remetente de uma solicita��o a seu receptor, dando a mais de um objeto a chance de lidar com a solicita��o
- Encadeia os objetos receptores e passa a solicita��o ao longo da cadeia ate que um objeto a trate
- Simplifica as interconex�es de objetos
- Evita a depend�ncia entre um objeto recepetor e um objeto solicitante ou destinat�rio
### Exemplos de uso
- Quando tivermos mais de um manipulador para uma solicita��o
- Quando tivermos motivos pelos quais um gerenciador deve passar uma solita��o para outra na cadeia
- Quando tivermos um conjunto de manipuladores que variam de forma din�mica
- Quando desejarmos manter a flexibilidade na atribui��o de solicita��es e manipuladores
- Quando tivermos uma cadeia muito l�gica de manipuladores que devem ser executados em ordem repetidas vezes
### Vantagens
- Voc� pode controlar a ordem de tratamento de solicita��es
- Voc� pode desacoplar classes que invocam opera��es de classes que as executam(SRP)
- Voc� pode introduzir novos manipuladores no aplicativo sem quebrar o c�digo do cliente existente(Open/Closed Principle)
### Desvantagens
- Algumas solicita��es podem n�o serem tratadas dificultando em observar as caracter�sticas em tempo de execu��o

## Command
- Encapsula uma requisi��o como um objeto, permitindo que clientes parametrizem diferentes requisi��es, filas ou logs, como a reverter as opera��es
- Converte solicita��es ou opera��es simples em objetos
- Precisa emitir solicita��es para objetos sem saber nada sobre a opera��o solicitada ou o receptor da solicita��o
### Exemplos de uso
- Parametrizar objetos por uma a��o a ser executada
- Especificar, enfileirar e executar solicita��es em tempos diferentes
- Dar suporte para desfazer opera��es
- Estruturar um sistema em torno de opera��es de alto n�vel(transa��es)
- Reduzir acoplamento entre as requisi��es dos clientes e os objetos que as executam
- Facilitar a implementa��o de novas opera��es e tornar mais simples a manuten��o das opera��es
### Vantagens
- Desacopla o objeto que invoca a opera��o daquele que sabe como execut�-la
- Reduz o acoplamento entre os objetos que chama a opera��o e os objetos que a executam
- Os comandos s�o objetos de primeira classe, ou seja, podem ser manipulados e estendidos como qualquer outro objeto
- Um comando pode ser composto por outros commandos e � f�cil acrescentar novos comandos(sem mudar classes existentes)
### Desvantagens
- O c�dgo pode se tornar complexo com o aumento no n�mero de classes criadas para cada comando, dos m�todos Action e das muitas associa��es

## Interpreter
- Dada uma linguagem, o padr�o define uma representa��o para sua gram�tica junto com um int�rprete que usa a representa��o para interpretar frases
na linguagem
- Usado para avaliar e interpretar as instru��es escritas em uma gram�tica de linguagem ou nota��es. Ele envolve a implementa��o de uma interface de
express�o que diz para interpretar um contexto espec�fico
- Fornece uma maneira de avaliar a gram�tica ou express�es da linguagem e pode ser usado em an�lise SQL, mecanismos de processamento de s�mbolos, em
compiladores, etc
### Exemplos de uso
- Pode ser usado quando houver uma linguagem para interpretar. Funciona melhorar quando:
	- Gram�tica � simples
	- A efici�ncia n�o � uma preocupa��o cr�tica
- Quando puder representar senten�as da linguagem como �rvores sint�ticas abstratas
### Vantagens
- � f�cil mudar e estender a gram�tica. Como o padr�o usa classes para representar regras gramaticais, voc� pode usar heran�a para alterar ou estender
a gram�tica. As express�es existentes podem ser modificadas de forma incremental e as novas express�es podem ser definidas como varia��es das antigas
- Implementar a gram�tica tamb�m � f�cil. As classes que definme n�s na �vores de sintaxe abstrata tem implementa��es semelhantes. Essas classes s�o
f�ceis de escrever e, muitas vezes, sua gera��o pode ser automatizada com um compilador ou gerador de analisador
### Desvantagens
- Gram�ticas complexas s�o dif�ceis de manter. O padr�o define pelo menos uma classe para cada regra da gram�tica. Desta forma, gram�ticas contendo
muitas regras podem ser dif�ceis de gerenciar e manter

## Iterator
- Fornece uma maneira de acessar os elementos de um objeto agregado(cole��o) sequencialmente sem expor sua representa��o subjacente
- Permite o acesso sequencia a elementos de uma cole��o sem expor a l�gica interna
- A ideia principal deste padr�o � extrair o comportamento transversal de uma cole��o para um objeto seperado chamado de Iterador
### Exemplos de uso
- Quando sua cole��o tiver uma estrutura de dados complexa e voc� deseja ocultar sua complexidade dos clientes
- Para reduzir a duplica��o do c�digo usada para percorrer cole��es no seu aplicativo
- Quando quiser que seu c�digo seja capaz de percorrer diferentes estruturas de dados ou quando os tipos dessas estruturas forem desconhecidos
### Vantagens
- Fornece suporte a itera��o para estruturas de dados que originalmente n�o a possui
- Permite definir mais de um tipo de iterador
- Simplifica o c�digo para acessar diferentes tipos de cole��es
- Trata vari�veis de todos os tipos, tamanhos e formos uniformemente, cabendo na mem�ria ou n�o
- Segue os principios SRP e Open/Closed
### Desvantagens
- � menos eficiente ao percorrer elementos de algumas cole��es especializadas, usando mais mem�ria do que acesso direto ao elemento
- N�o � recomendado para cole��es simples