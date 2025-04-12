# Workflows do Projeto LockGen

Este arquivo descreve os principais fluxos de trabalho utilizados no projeto LockGen.

## Fluxos de Trabalho Principais

### Desenvolvimento de Funcionalidades

1. **Criação de Branch**: 
   - Crie uma nova branch para cada funcionalidade que for desenvolver.
   - Nome da branch: `feature/nome-da-funcionalidade`.

2. **Commit e Push**:
   - Adicione, comite e faça o push das alterações para o repositório remoto.
   - Utilize mensagens de commit claras e objetivas.

3. **Pull Request (PR)**:
   - Crie uma Pull Request (PR) para revisão.
   - A PR deve ser revisada por pelo menos uma pessoa antes de ser mesclada na branch principal.

### Testes

- Teste sempre a funcionalidade no ambiente local antes de realizar o push.
- Certifique-se de que todos os testes unitários estão passando.

### Implantação

1. **Revisão do Código**:
   - Após a aprovação da PR, mescle na branch `main`.

2. **Deploy**:
   - O deploy será feito automaticamente após a mesclagem, utilizando o pipeline CI/CD configurado.

### Pós-Implantação

- Monitore o sistema para detectar possíveis falhas ou bugs.
- Caso haja algum problema, correções rápidas devem ser feitas.

## Ferramentas Utilizadas

- **CI/CD**: GitHub Actions.
- **Monitoramento**: [Nome da ferramenta de monitoramento].

Este arquivo serve para manter todos os envolvidos no projeto alinhados quanto aos fluxos de trabalho principais.
