# Qual importância do Design System?
- Escolhas certas para a sua necessidade
- Entender as limitações/trade-offs da sua arquitetura
- Redução de complexidade ou complexidade consciente
- Facilitar ou não a manutenção e evolução do software
- Auxilia na modernização/refatoração da arquitetura
- Aumento de desempenho, resiliência e disponibilidade
- Conhecer o que já funciona sem precisar criar algo novo para testar
- Eficiência na solução de problemas
- Boas práticas de desenvolvimento

# Large Scale Architecture
- Dividir para conquistar
- Projetadas para suportar sistemas que operam em um nível extenso em volume de dados, número de usuários ou ambos
- Caracterizada pela necessidade de alta disponibilidade, desempenho e eficacia durante picos
- Envolve diferentes tecnologias e arquiteturas
- Monitoramento, alertas e logs e gerenciamento de recurso automatizados
- Overengineering

# Complex Architectures
- Múltiplas camadas
- Componentes interdependentes
- Variedade de tecnologias
- Quantidade de comunicação e tipos de comunicação
- Regras de negócio complexas
- Overthinking

# Principios de sucesso em uma arquitetura de software
- **Planejamento de capacidade**: Previsão de demanda e planejamento de capacidade. Estar pronto para momentos de pico
(escalabilidade). Entregar no mesmo tempo de resposta independente do tráfego.
- **Observabilidade**: Ter métricas, alarmes, logs e trace de todo o fluxo de usuário, mensagem, request...
- **Release Engineering**: Ter capacidade de atualizar ambiente produtivo com o mínimo de impacto possível. Ter testes
automatizados e monitoramento de desempenho.
- **Segurança**: Criptografia, normals, certificados, OWASP, protocolos seguros, mecanismos contra DDoS, XSS e outros.
- **Otimização de custos**: Depende de todos os outros pilares, porém quão frugal você estar.
- **Confiabilidade**: Capacidade de estar acima do SLA de disponibilidade, ser resiliente, estratégia de backup/restore,
estratégia de disaster recovery.
- **Operações**: Como todas as outras habilidades devem ser usadas sem comprometer a eficiência das operações? MTTR,
automações, control planes