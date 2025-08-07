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