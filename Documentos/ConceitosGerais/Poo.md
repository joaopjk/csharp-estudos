# POO
## Objeto
É uma entidade que comina dados(atributos) e comportamentos(métodos).
## Classe
É um modelo ou blueprint para criar objetos. Define os atributos e métodos que todos os objetos daquela classe terão.
## Atributos
São as características ou propriedades de um objeto.
## Métodos
São as ações ou funções que um objeto pode executar.
## Encapsulamento
Protege os dados de um objeto, escondendo os detalhes de implementação e expondo apenas uma interface para interagir com o objeto.
## Herança
Permite que uma classe herde atributos e métodos de outra classe, promovendo a reutilização de código e a criação de hierarquia de objetos
## Polimorfismo
Permite que diferentes classes possam ser tratadas de maneira uniforme, desde que compartilhem uma interface ou classe base comum.
## Interfaces e Classes Abstratas
Interfaces e classes abstratas são mecanismos de abstração em C# que permitem definir contratos e modelos genéricos para diferentes implementações. Elas ajudam a criar sistemas flexíveis, desacoplados e fáceis de manter.
### Interfaces
- Definem apenas contratos(assinatura de métodos, propriedades e eventos) sem implementação
- Uma classe pode implementar várias interfaces
- Usadas para garantir que diferentes classes ofereçam comportamentos comuns
- Não podem conter campos, construtores ou lógica interna
### Classes abstratas
- Podem definir membros com ou sem impelmentação
- Não podem ser instanciadas diretamente
- Permitem compartilhar código comum entre subclasses
- Usadas quando há uma relação "é um" e parte do comportamento pode ser definido na base 
Use interfaces para definir contratos genéricos e garantir que diferentes classes ofereçam comportamentos comuns, sem se preocupar com sua implementação. Use classes abstratas quando há código compartilhado e uma hierarquia clara, permitindo definir comportamento na base.
### Dependency Injection
É um padrão de design que consist em fornecer as dependências de um objeto de fora, ao invés de criá-los internamente. O objetivo é reduzir o acoplamento, facilitar os testes, promover flexibilidade e tornar o código mais limpo e fácil de manter.
- Reduzir o acoplamento entre classes
- Facilitar testes unitários (mock de dependências)
- Permitir trocar implementações facilmente
- Centraliza configuração de dependências
### Tipo Valor x Referência
#### Tipo Valor
- Exemplos int, double, bool, struct, enum
- Armazenados na stack
- Quando atribuídos a uma nova variável ou passados como paramêtro, uma cópia é feita
#### Tipo Referência
- Exemplos: string, array, class, delegate
- Armazenados na heap, mas a variável contém uma referência(endereço) para o objeto
- Ao atribuir a uma nova variavél ou passar como parâmetro, penas a referência é copiada
- Alterações feitas por uma referência afetam o objeto original
### Shallow Copy
Cópia Superficial: Copia apenas as referências dos campos dos objetos. Se o objeto tiver campos que também são tipos por referência, ambos os objetos apontaram para os mesmos endereços. Se o objeto possuir campos do tipo valor, esses campos são copiados, ou seja, um novo objeto tera seus próprios valores independentes.
### Deep Copy
Cópia Profunda: Copia o objetoe todos os objetos referenciados por ele, criando novas instâncias para cada subobjeto. Assim, os objetos ficam totalmente independentes.