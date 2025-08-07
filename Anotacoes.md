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

### Simple Factory
- Cria objetos sem expor a l�gica de cria��o ao cliente
- Refere-se ao objeto rec�m-criado usando uma interface comum

### Factory Method
- Define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar
- O Factory Method permite que uma classe adie a instancia��o que ela usa para as subclasses
- O padr�o usa heren�a e depdente de uma subclasse para lidar com a instancia��o do objeto desejado
- Usado para criar objetos sem expor a l�gica de cria��o ao cliente

### Abstract Factory
- Fornece uma interface para a cria��o de fam�lias de objetos relacionados ou dependentes sem especificar suas classes concretas
- A interface fornecida define os m�todos e cada m�todo cria um objeto
- O padr�o cria objetos por meio da composi��o e produz fam�lias de produtos onde as f�bricas concretas implementam os m�todos para criar produtos