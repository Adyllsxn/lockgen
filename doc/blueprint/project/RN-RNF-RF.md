## 🧠 Regras de Negócio (RB)

- **RB01**: A aplicação **não deve permitir autenticação ou cadastro de usuários**.
- **RB02**: O sistema **não deve armazenar nenhuma senha gerada**, nem dados de entrada do usuário.
- **RB03**: Cada vez que o usuário clicar para gerar uma senha, **uma nova senha aleatória e diferente** deve ser gerada.

---

## ⚙️ Requisitos Funcionais (RF)

- **RF01**: O sistema deve permitir que o usuário **defina o comprimento da senha** por meio de um input numérico ou slider.
- **RF02**: O sistema deve **gerar uma senha aleatória** ao clicar no botão “Gerar senha”.
- **RF03**: A **senha gerada deve ser exibida** na interface de forma clara e destacada.
- **RF04**: O sistema deve oferecer um botão para **copiar a senha gerada** para a área de transferência.
- **RF05**: O sistema deve **validar se o comprimento da senha está entre 6 e 64 caracteres** antes de gerá-la.

---

## 🚀 Requisitos Não Funcionais (RNF)

- **RNF01 – Performance**: A senha deve ser gerada **instantaneamente**, sem atrasos perceptíveis.
- **RNF02 – Usabilidade**: A interface deve ser **simples, intuitiva e responsiva**, funcionando bem em desktop e mobile.
- **RNF03 – Segurança**: **Nenhuma senha gerada deve ser armazenada** no servidor ou em qualquer base de dados.
- **RNF04 – Privacidade**: A aplicação **não deve coletar nenhum dado pessoal** do usuário.
- **RNF05 – Acessibilidade**: A interface deve ser **compatível com leitores de tela** e **navegável via teclado**.
