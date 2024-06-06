# Registro de Testes de Software

Para cada caso de teste definido no Plano de Testes de Software, foi realizado o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado, ou não.

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-01 – Cadastrar perfil | RF-001 - O sistema deve permitir novos usuários se cadastrarem. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/54c08ce7-e0ec-4ad3-9003-6e370335b839

**Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/94fd2288-aea9-4ad6-859e-7881ec24ac1a

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-02 – Efetuar login | RF-002 - O sistema deve permitir que os usuários efetuarem login para acessar suas funcionalidades. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/07e35d32-3862-4fc3-8344-d483f794f53b

**Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e8454bdd-c969-4627-989a-cbc48ede0972

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-03 – Editar perfil | RF-003 - O sistema deve permitir que um usuário edite suas próprias informações. | Teste 1: Há falhas quando o usuário tenta editar sua conta.<br> Teste 2: Não houve falhas. | Teste 1: Será corrigida na próxima etapa.<br> Teste 2: Foi encontrado uma falha no "MinhaContaController" onde o sistema não estava salvando as informações editadas. |

**Teste 1: Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/bc4f55a8-880a-4b46-b92b-ba51343c902b

**Teste 2: Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/37e95527-7604-4a96-83a8-ef21dbe929e7

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-04 – Apagar perfil | RF-004 - O sistema deve permitir que o usuário apague sua conta. | Teste 1: Há falhas quando o usuário tenta deletar sua conta.<br> Teste 2: Não houve falhas. | Teste 1: Será corrigida na próxima etapa.<br> Teste 2: Foi encontrado uma falha no "MinhaContaController" onde foi esquecido de colocar "return RedirectToAction("ContaDeletada")", então o sistema não conseguia encontrar a página do usuário deletado. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e51bfd5e-9049-4ab8-976e-d65490ee7a4f

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e25a3f84-0025-4048-b4e5-60051e2672ee

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-05 – Visualizar lista dos itens | RF-004 - O sistema deve apresentar uma lista com todos os itens disponíveis. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/cd8e7460-12d4-4eea-a4ce-8446b48c7315

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-06 – Visualizar item | RF-005 - O sistema deve apresentar uma lista com todos os itens. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/a0f265e7-3794-40d2-bcf3-b8bb782579bc

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-07 –  Visualizar disponibilidade de um item | RF-006 - O sistema deve permitir que um usuário reserve um item que não esteja reservado ainda. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/888920f7-ecbc-49c0-8e3c-ba12dd577132







| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-11 – Adicionar à lista de desejos | RF-010 - O sistema deve permitir que o usuário adicione um item à sua lista de desejos. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/9d714b85-bed3-4646-8437-afe88fcea054

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-12 – Filtro de pesquisa | RF-011 - O sistema deve permitir que o usuário busque por itens. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/2f027e77-264e-4747-a65c-c8ada05a5e24


| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-08 – Reservar item | RF-008 - O sistema deve permitir que um usuário reserve um item que não esteja reservado ainda. | Não houve falhas. | Não foi necessária nenhuma ação. |

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-09 – Cancelar reserva | RF-009 - O sistema deve permitir que um usuário cancele a reserva de um item. | Não houve falhas. | Não foi necessária nenhuma ação. |




| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-10 – Cadastrar item | RF-010 - O sistema deve permitir que usuários cadastrem novos itens. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/1898aa5f-b834-44c2-bc39-a5f2f73ff881

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/6af7a4b4-c214-4c16-8e80-c3afb1cfdd40

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-11 – Editar item | RF-011 - O sistema deve permitir que um usuário atualize informações dos seus itens. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/04634122-d54f-466b-9e0b-9558fc3dc7e7

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/44bb2b46-3759-4076-81b7-de9cdf450c71

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-12 – Apagar item | RF-012 - O sistema deve permitir que um usuário apague itens da sua biblioteca. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/ce5f3032-03b1-45d9-b188-e194f69883d6

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/67d24125-207c-4d88-8c7c-51926ece7bbd

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-13 – Adicionar desejo | RF-013 - O sistema deve permitir que o usuário adicione um item à sua lista de desejos. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/4d5a20e3-17e9-408b-bc9c-2978d8c625ef

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-14 – Deletar desejo | RF-014 - O sistema deve permitir que o usuário apague um item da sua lista de desejos. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/daa298af-2ea8-4dcb-a167-43a1e645dffa

## Avaliação

Os resultados dos testes foram satisfatórios, houve algumas falhas que já estão sendo trabalhadas para evitar futuros problemas.
A maioria das falhas foram em relação ao CRUD do Usuário, mas precisamente no "editar conta" e "deletar conta".
