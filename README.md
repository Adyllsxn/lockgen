# LockGen
LockGen é um gerador e analisador de senhas desenvolvido em C# e Blazor WebAssembly. Ele permite criar senhas seguras e verificar sua força com base em critérios personalizados.
---

## Funcionalidades
### Gerador de senhas aleatórias
    - Definir o tamanho da senha
    - Escolher se incluirá letras maiúsculas, números e caracteres especiais

### Analisador de força da senha
#### Classificação visual com cores:
    - Vermelho: Muito Fraca
    - Laranja: Fraca
    - Amarelo: Razoável
    - Verde-claro: Forte
    - Verde: Muito Forte
#### Sugestões de senhas caso a inserida seja fraca
---

## Tecnologias Utilizadas

### Frontend
1. **Blazor Wasm**: Framework para desenvolvimento do frontend interativo e moderno.
2. **MudBlazor**: Biblioteca de componentes para Blazor.
3. **JavaScript**: Para integração com bibliotecas e funcionalidades adicionais.
4. **HTML**: Para a estrutura das páginas.
5. **CSS**: Para estilização e personalização da interface.
6. **Google Fonts**: Para incorporar fontes customizadas ao design.
7. **Bootstrap Icons**: Conjunto de ícones para usar na interface.

### Testes
1. **xUnit**: Framework para criação de teste de unidade.

---

## Configuração do Ambiente

### Requisitos

#### SDKs e Ferramentas
1. **.NET SDK 6.0** ou superior.
2. **Visual Studio** ou **Visual Studio Code** (com extensão C#).

#### Pacotes NuGet
1. `MudBlazor`.

---

## Estrutura do Projeto
```plaintext
LockGen/
├── src/                          # Código-fonte principal
│   ├── LockGen.Web/              # Interface do usuário (Blazor)
│  
├── test/                            # Projetos de testes
│   ├── LockGen.UnitTest/            # Testes de unidade
│   
├── docs/                       # Documentação adicional do projeto
│   ├── Detalhes.md             # Detalhes sobre a arquitetura do projeto
│
├── .github/                       # Configuração para GitHub Actions e workflows
│   ├── workflows/                 # Automatização (ex: GitHub Pages, CI/CD)
│
├── README.md                    # Documentação principal do projeto
├── LockGen.sln                  # Solução do projeto


---




## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](./LICENSE) para mais detalhes.