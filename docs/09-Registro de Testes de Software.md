# Registro de Testes de Software

Para cada caso de teste definido no Plano de Testes de Software, foi realizado o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado, ou não.

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-01 – Cadastrar perfil | RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/54c08ce7-e0ec-4ad3-9003-6e370335b839

**Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/94fd2288-aea9-4ad6-859e-7881ec24ac1a

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-02 – Efetuar login | RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. | Não houve falhas. | Não foi necessária nenhuma ação. |

**Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/07e35d32-3862-4fc3-8344-d483f794f53b

**Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e8454bdd-c969-4627-989a-cbc48ede0972

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-03 – Editar perfil | RF-002 - O sistema deve permitir que um usuário edite suas próprias informações de usuário. | Teste 1: Há falhas quando o usuário tenta editar sua conta.<br> Teste 2: Não houve falhas. | Teste 1: Será corrigida na próxima etapa.<br> Teste 2: Foi encontrado uma falha no "MinhaContaController" onde o "return RedirectToAction" estava sem. |

**Teste 1: Projeto Incompleto**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/bc4f55a8-880a-4b46-b92b-ba51343c902b

**Teste 2: Projeto Finalizado**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/37e95527-7604-4a96-83a8-ef21dbe929e7

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-04 – Apagar perfil | RF-003 - O sistema deve permitir que o usuário apague sua conta. | Teste 1: Há falhas quando o usuário tenta deletar sua conta.<br> Teste 2: Não houve falhas. | Teste 1: Será corrigida na próxima etapa.<br> Teste 2: Foi encontrado uma falha no "MinhaContaController" onde foi esquecido de colocar "return RedirectToAction("ContaDeletada")", então o sistema não conseguia encontrar a página que do usuário deletado. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e51bfd5e-9049-4ab8-976e-d65490ee7a4f

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/e25a3f84-0025-4048-b4e5-60051e2672ee

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-05 – Visualizar lista de itens disponíveis | RF-004 - O sistema deve apresentar uma lista com todos os itens disponíveis. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/cd8e7460-12d4-4eea-a4ce-8446b48c7315

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-06 – Visualizar item | RF-005 - O sistema deve permitir que qualquer usuário visualize todas as informações de um item selecionado na lista. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/a0f265e7-3794-40d2-bcf3-b8bb782579bc

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-07 –  Visualizar disponibilidade de um item | RF-006 - O sistema deve permitir que um usuário reserve um item que não esteja reservado ainda. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/888920f7-ecbc-49c0-8e3c-ba12dd577132

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-08 – Cadastrar item | RF-007 - O sistema deve permitir que usuários cadastrem novos itens. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/980bad6f-26e0-43d5-9f25-ea814ce2a23f

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/d8e42829-4e0a-4f95-8ebc-bdf404af8d0b



| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-09 – Editar item | RF-008 - O sistema deve permitir que um usuário atualize informações dos seus itens. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/6164bef9-2ebd-4bd4-aabe-9314a1baa14b

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/99baef80-7295-4aa3-8260-28b57671f1a4

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-10 – Apagar item | RF-009 - O sistema deve permitir que um usuário apague itens da sua biblioteca. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

**Teste 1 (projeto incompleto)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/0cd19a99-4705-4fa5-a2f3-ce0c64ce5de1

**Teste 2 (projeto finalizado)**

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/49b511b9-634e-4b8d-9c25-f06f86b65099

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-11 – Adicionar à lista de desejos | RF-010 - O sistema deve permitir que o usuário adicione um item à sua lista de desejos. | Não houve falhas. | Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/9d714b85-bed3-4646-8437-afe88fcea054

| **Caso de Teste** | **Requisito Associado** | **Resultados** | **Ação** |
|:---: |:---: |:---: |:---: |
| CT-12 – Filtro de pesquisa | RF-011 - O sistema deve permitir que o usuário busque por itens. | Teste 1: Não houve falhas. <br> Teste 2: Não houve falhas. | Teste 1: Não foi necessária nenhuma ação.<br> Teste 2: Não foi necessária nenhuma ação. |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t1-troca-games/assets/145761508/ad6ec702-7e6b-41e8-9945-6d7b1afc5128

## Avaliação

Os resultados dos testes foram satisfatórios, houve algumas falhas que já estão sendo trabalhadas para evitar futuros problemas.
A maioria das falhas foram em relação ao CRUD do Usuário, mas precisamente no "editar conta" e "deletar conta".
