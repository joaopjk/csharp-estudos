# CleanCode

## Nomes significativos
- O nome de uma variável, função ou classe deve responder porque existe, o que faz e como é usado.
- Existem palavras cujo significado podem se desviar do que elas representam.
- Evite palavras com nomes parecidos ou sejam muito comuns.
- Se os nomes precisam ser diferentes, seus significados também devem ser diferentes.
- Palavras muito comuns são outra forma de distinção que nada expressam.
- Crie nome pronunciáveis
- Nome de classes não devem ser verbos.
- Nome de métodos devem ser verbos.
- Quando os construtores estiverem sobrecarregados, use métodos de fábrica estáticos com nome que descrevam o que eles fazem.
- Escolha uma palavra por cada conceito.
- Não use a mesma palavra para dois conceitos diferentes.

## Funções
- Funções devem ser pequenas
- Blocos de instrução devem ter apenas uma linha 
- As funções devem fazer apenas uma coisa
- Para saber se a função faz mais de uma coisa, extrai outra função dela a partir de seu nome que não seja apenas uma reformulação de sua implementação
- Verificar se todas as instruções numa função estejam no mesmo nível de abstração
- Evite o uso do switch
- Use nomes descritivos
- Quantidade ideal de paramêtros é zero. Se necessário, crie um objeto para encapsular os parâmetros
- Evite funções com parâmetros de saída
- Funções devem fazer ou responder algo, apenas
- Prefira exceções ao retorno de erros
- Evite repetição

## Comentários
- São um mal necessário
- O uso adequado de comentários é para compensar nosso fracasso em nos expressar no código
- Não gaste esforço no comentário, e sim em refatorar o código
- Troque o nome da função para expressar o mesmo que você deseja colocar no comentário.
- Use comentários de esclarecimento para o código não é possível alterar
- Pode se usar comentários para se alertar sobre consequências
- Pode se usar comentários para algo que parece irrelevante, mas não é
- Qualquer comentário que fação você analisar outro módulo do sistema falhou em lhe transmitir a mensagem
- Evite comentário se é possível utilizar função ou nome de variável
- Nunca deixa código comentado
- Não adicione informações excessivais ao comentário
- Caso o comentário precise ser explicado, o mesmo não deveria existir

## Formatação
- Escolha um padrão de formatação, alinhe com a equipe e siga este padrão
- A elegibilidade de seu código terá um grande efeito em todas as mudanças que seram feitas
- Use nome descritivos

## Objetos e estruturas de dados
- Os objetos expoem as ações e ocultam os dados. Isso facilita a adição de novos tipos de objetos sem precisar modificar os objetos já existentes
- As estrutura de dados expoem os dados e não possuem ações significativas. Isso facilita a adição de novas ações as estruturas de dados existentes e dificulta a adição de novas estruturas de dados
- Às vezes, desejamos flexibilidade para adicionar novos tipos, optamos por objetos. Outras vezes, desejamos flexibilidade para adicionar ações, optamos por estruturas de dados.

## Tratamentos de Erros
- É melhor lançar uma exceção do que um código de erro
- Verificar exceções é a violação do princípio aberto-fechado
- Exceções verificadas são uteis se você estiver criando uma biblioteca de terceiros. Mas, no geral, os custos de dependência superam as vantagens
- Cada exceção lançada deve contem informações o suficiente para determinar a fonte e a localização do erro
- Wrappers: Empacotar Apis de terceiros é a melhor prática que existe
- Use classes diferentes apenas se houver casos em que você queira capturar uma exceção e permitir que outro passe normalmente
- Special Case Pattern: Crie métodos de modo que ele trate um caso especial
- Não retorno null, prefira objetos vazios
- Não passe null

## Limites
- Devemos integrar de forma limpa os códigos de terceiros
- Use código de terceiros atráves de interfaces, para não criar acoplamento
- Crie testes unitários para as libs de terceiros (testes de aprendizagem)
- Crie interfaces para libs de terceiros, assim quebrando o acoplamento com o mesmo

## Teste de unidade
- Os testes são tão importantes quanto o código de produção
- Os testes de unidades que mantem a flexibilidade de um código
- Testes devem ser legivéis
- First:
  - Fast: Testes devem ser rápidos
  - Independentes: Testes devem ser independentes
  - Repeatable: Testes devem ser repetíveis
  - Self-Contained: Testes devem ser auto-contidos
  - Verbose: Testes devem ser verbosos
  - Timely: Testes devem ser executados rapidamente

## Classes
- Sempre buscamos uma forma de manter a privacidade. Perder o encapsulamento sempre é o último recurso
- Classes devem ser pequenas
- O nome de uma classe deve descrever quais responsabilidades ela tem
- SRP
- Coesão
- OCP
- Baixo acoplamento

## Emergência
- Efetuar todos os testes 
- Sem duplicação de código
- Expressar o propósito do programador
- Minimizar o número de classes e métodos

- Clareza e legibilidade
- Código auto explicativo
- Evite números mágicos
- Nomes significativos
- Organização e estrutura
- Funções pequenas
- Evite funções longas e complexas
- Consistência
- Evite duplicação
- Remova código morto
- Evite parâmetros booleanos. Prefira métodos separados com funções distintas
- Prefira composição a herança: use composição para reutilização de código quando possível
- Reduza o escopo da variável
- Código testável
- Evite dependências desnecessárias
- Mantenha o código simples
- Evite otimização prematura
- Documentação mínima e útil
- Padronização
- Refatoração contínua
- Utilize testes automatizados
- Prefira imutabilidade
- Evite abreviações e siglas obscuras
- Mantenha o código limpo