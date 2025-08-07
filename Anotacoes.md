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

### Simple Factory
- Cria objetos sem expor a lógica de criação ao cliente
- Refere-se ao objeto recém-criado usando uma interface comum

### Factory Method
- Define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar
- O Factory Method permite que uma classe adie a instanciação que ela usa para as subclasses
- O padrão usa herença e depdente de uma subclasse para lidar com a instanciação do objeto desejado
- Usado para criar objetos sem expor a lógica de criação ao cliente

### Abstract Factory
- Fornece uma interface para a criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas
- A interface fornecida define os métodos e cada método cria um objeto
- O padrão cria objetos por meio da composição e produz famílias de produtos onde as fábricas concretas implementam os métodos para criar produtos