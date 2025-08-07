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