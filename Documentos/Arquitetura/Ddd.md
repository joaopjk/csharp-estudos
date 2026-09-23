# DDD
Domain-Driven Design é uma abordagem para desenvolvimento de software que foca em modelar o domínio do negócio de forma fiel, usando conceitos e estruturas que refletem as regras de negócio e necessidades reais
## Linguagem Ubíqua
- Uma linguagem comum, compartilhada entre desenvolvedores e especialistas do negócio
- Usada em código, documentação e conversas, evitando ambiguidades e facilitando a comunicação
## Entidade
- Objeto de domínio com identidade própria, que persisti ao longo do tempo, mesmo que seus atributos sejam alterados
## Objeto de Valor
- Objeto sem identidade, definido apenas por seus atributos
- Imútavel e usada para representar conceitos como cpf e dinheiro
## Agregado
- Conjunto de entidades e objetos de valor que formam uma unidade de consistência
- Possui uma raiz(Aggregate Root) que controla o acesso e as regras de integridade do agregado
- Exemplo: Pedido(raiz) com itens do pedido(entidade)
## Raiz do Agregado
- Entidade principal de um agregado
- Todas as interações externas com o agregado devem passar pela raiz
## Repositório
- Abstração para acesso e persistência de agregados
- Permite baixar, salvar e remover agregados sem expor detalhes de infraestrutura
## Serviço de Domínio
- Encapsula operações e regras de negócio que não pertencem a uma entidade ou objeto de valor especifíco
## Fábrica
- Responsável por criar instâncias complexas de entidades ou agregados
- Centraliza lógica de criação, especialmente quando envolve múltiplos passos ou validações
## Contexto Delimitado(Bounded Context)
- Delimita o significado dos termos e modelos em diferentes partes do sistema
- Cada contexto pode ter sua própria linguagem ubíqua e modelo de domínio
- Ajuda a evitar ambiguidades e conflitos em sistemas grandes
## Mapa de Contexto
- Descreve relações e integrações entre diferentes contextos delimitados
- Define contratos, integrações, traduções e depedências entre os contextos
## Camada de Domínio
- Núcleo do sistema, onde ficam as entidades, objetos de valor e agregados, serviços de domínio e regras de negócios puras
## Camada da Aplicação
- Orquestra casos de uso, coordena o fluxo entre domínio e interfaces externas
- Não contem lógica de negócio, apenas fluxo e coordenação
## Camada de Infraestrutura
- Implementa detalhes técnicos como persistência, comunicação com sistemas externos e etc
- Fornece a implementação para interfaces definidas nas camadas externas 
## Camada de Apresentação
- Interface com o usuário ou Apis públicas
- Responsável por receber requisições, validar dados e repassar para a camada de aplicação
## Event Sourcing
- Técnica onde mudanças de estado são armazenadas como uma sequência de eventos
- Permite reverter o estado de um agregado para um estado anterior
## Domain Event
- Representa algo importante que acontece no domínio
- Pode ser usada para integração entre contextos ou acionar processos assíncronos
## ACL
- Camada de proteção entre contextos diferentes, evitando que mudanças em um contexto corrompam outros
- Implementa adaptadores, tradutores e mapeamentos
## Specification
- Encapsula regra de negócios complexas em objetos reutilizáveis e combináveis
- Facilita validação e consulta
## Policy
- Define regra de negócio que podem ser aplicadas em diferentes partes do sistema, podendo ser implementadas como serviços ou objetos de domínio
## Modulo
- Agrupamento lógico de classes e objetos relacionados, facilitando organização e manutenção do código