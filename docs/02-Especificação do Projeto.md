# Especificações do Projeto

As informações que fundamentaram as histórias do projeto foram coletadas na internet, onde realizamos análises e tiramos conclusões sobre o tema. A definição das personas foi realizada por discussões em equipe, com base nas pesquisas realizadas.

## Personas

Agora serão apresentadas nos quadros a seguir as personas levantadas durante o processo de entendimento do problema.

| <img width="450" alt="MaristelaFerreira" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e0ae3a78-874b-4869-b099-740ff9bbede5"> | `Maristela Ferreira`<br> Idade: 58 anos<br> Ocupação: Servidora Pública |
|  --------------  | -------------- |
| Aplicativos| <ul> <li> Facebook <li> Instagram |
| Motivações | <ul> <li> Em busca de jogos antigos <li> Em busca de momentos de lazer |
| Frustações | <ul> <li> Dificuldade de encontrar jogos <li> Dificuldade em jogar jogos modernos |
| Hobbies | <ul> <li> Trabalhar <li> Jogar <li> Viajar |
|    |    |
| <img width="450" alt="RenataOliveira" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/29492b93-35ff-4efd-80d4-3546330ff047"> | `Renata Oliveira` <br> Idade: 35 anos<br> Ocupação: Advogada |
| Aplicativos| * Facebook<br> * Instagram<br> * Youtube |
| Motivações | * Em busca de jogos para seus filhos<br> * Proporcionar momentos em família |
| Frustações | Dificuldade de encontrar jogos infantis |
| Hobbies | * Shopping<br> * Cinema<br> * Academia<br> * Viajar |
|    |    |
| <img width="450" alt="OdaraFranca" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/fc733bbe-e1bb-45c3-92da-8425b2d461c4"> | `Odara Franca` <br> Idade: 21 anos<br> Ocupação: Streamer |
| Aplicativos| * Instagram<br> * Steam<br> * Youtube<br> * Twitch |
| Motivações | * Conhecer mais jogos<br> * Jogar jogos recomendados pelos amigos |
| Frustações | * Dificuldade de achar jogos autênticos<br> * Preço dos jogos novos |
| Hobbies | * Ir a exposições<br> * Sair com amigas<br> * Praticar esportes<br> * Jogar |
|    |    |
| <img width="450" alt="IgorPereira" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/6a9c0b58-f31c-471f-93c0-7e11d78aff02"> | `Igor Pereira` <br> Idade: 15 anos<br> Ocupação: Estudante |
| Aplicativos| * Instagram<br> * Tiktok<br> * Youtube<br> * Steam |
| Motivações | Buscando conexões com a comunidade e novos jogos |
| Frustações | * Dificuldade em achar jogos legais<br> * Não ter dinheiro para comprar |
| Hobbies | * Jogar basquete<br> * Assistir filmes |
|    |    |
| <img width="450" alt="MarceloCampos" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/9a5075a2-1f2e-4a18-8fc9-bf382fd6f39d"> | `Marcelo Campos` <br> Idade: 30 anos<br> Ocupação: Desenvolvedor de jogos |
| Aplicativos| * Youtube<br> * Instagram<br> * Linkedin<br> * Twitter |
| Motivações | * Acompanhar a demanda de compras dos jogo<br> * Entusiasmado por jogos retrô |
| Frustações | Não ter uma noção de demandas que sua categoria de jogos está tendo |
| Hobbies | * Conhecer novos restaurantes<br> * Viajar<br> * Jogar jogos RPG |

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Maristela Ferreira  | facilidade de procura              | conseguir achar o jogo desejado        |
|Maristela Ferreira  | ter acesso a uma lista de jogos    | conseguir ver os que estão disponíveis |
|Renata Oliveira     | poder realizar uma procura por categoria | conseguir achar com facilidade o tema desejado |
|Renata Oliveira     | poder alugar jogos                 | não precisar comprar muitos jogos |
|Odara Franca        | conseguir achar novos jogos        | expandir o repertório de jogos transmitidos em live |
|Odara Franca        | adquirir jogos com preço acessível | os jogos atuais estão caros |
|Igor Pereira        | encontrar novos jogos e se conectar com a comunidade gamer |  conseguir trocar e vender seus jogos que nunca jogou |
|Igor Pereira        | conseguir trocar jogos com outros usuários | tenho muitos títulos parados e quero poder conhecer novos jogos |
|Marcelo Campos      | entender como está a demanda dos jogos na categoria que está desenvolvendo | conseguir aplicar em seus jogos a demanda que o público atualmente mais compra |
|Marcelo Campos      | completar minhas coleções de jogos antigos | são parte da minha infância e material de estudo para meu trabalho |

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais, que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade de entrega de cada um deles.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir novos usuários se cadastrarem. | ALTA | 
|RF-002| O sistema deve permitir que os usuários efetuarem login para acessar suas funcionalidades. | ALTA | 
|RF-003| O sistema deve permitir que um usuário edite suas próprias informações. | BAIXA |
|RF-004| O sistema deve permitir que o usuário apague sua conta. | BAIXA |
|RF-005| O sistema deve apresentar uma lista com todos os itens. | ALTA |
|RF-006| O sistema deve permitir o usuário visualize todas as informações de um item. | ALTA |
|RF-007| O sistema deve permitir que o usuário busque por itens. | MÉDIA |
|RF-008| O sistema deve permitir que um usuário reserve um item que não esteja reservado ainda. | MÉDIA |
|RF-009| O sistema deve permitir que um usuário cancele a reserva de um item. | MÉDIA |
|RF-010| O sistema deve permitir que usuários cadastrem novos itens. | ALTA |
|RF-011| O sistema deve permitir que um usuário atualize informações dos seus itens. | ALTA |
|RF-012| O sistema deve permitir que um usuário apague itens da sua biblioteca. | ALTA |
|RF-013| O sistema deve permitir que o usuário adicione um item à sua lista de desejos. | MÉDIA |
|RF-014| O sistema deve permitir que o usuário apague um item da sua lista de desejos. | MÉDIA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser compatível com os principais navegadores do mercado. | ALTA | 
|RNF-002| O sistema deve ser responsivo. | MÉDIA | 
|RNF-003| O sistema deve ser permitir que somente usuários cadastrados tenham acesso as funcionalidades. | ALTA | 
|RNF-004| O sistema deve estar alinhado com as normas de privacidade do cliente. | ALTA | 
|RNF-005| O sistema deverá informar ao usuário quando o mesmo estiver em manutenção e/ou fora do ar. | MÉDIA | 
|RNF-006| O sistema deverá ter uma fácil usabilidade para o usuário. | MÉDIA | 

## Restrições

Restrições de gestão são fatores internos que limitam a capacidade da loja de operar de forma eficiente. Restrições de negócio são fatores externos que afetam o mercado da loja e sua capacidade de competir.

### Restrições de Gestão

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| Verificação de usuários: verificar perfis usando métodos como e-mail, para evitar perfis falsos e garantir a confiabilidade dos usuários. |
|RE-02| Interface simples: facilitando o uso da plataforma por parte dos usuários. |
|RE-03| Política de qualidade: critérios para aluguel e venda dos jogos para garantir que os jogos estejam completos e em boas condições de funcionamento. |
|RE-04| Conteúdo proibido: venda e aluguel de jogos falsificados não serão permitidos na plataforma. |
|RE-05| Plataforma personalizada: o usuário que vende ou aluga define o valor, a quantidade e as fotos do produto. |
|RE-06| Suporte ao cliente: para fornecer assistência e esclarecer dúvidas aos usuários quando necessário. |

### Restrições de Negócios

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| Negociação direta entre usuário: permitir que os usuários negociem diretamente entre si os preços e condições da venda ou aluguel. |
|RE-02| Cada etapa do projeto deverá ser entregue no prazo estabelecido. |
|RE-03| Integração nas redes sociais, aumentando a capacidade de alcançar novos usuários. |
|RE-04| A aplicação não pode ser desenvolvida sem um módulo backend. |
|RE-05| Gestão de devoluções, política de devolução clara e transparente, que inclua prazos e condições para devoluções. |

## Diagrama de Casos de Uso

![Diagrama de caso de uso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/c1dabeb1-df53-4d9c-93b5-5e1947e2a5d9)






