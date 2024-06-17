# Plano de Testes de Software

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste** | CT-01 – Cadastrar perfil |
|:---:|---|
| **Requisito Associado** | RF-001 - O sistema deve permitir novos usuários se cadastrarem. |
| **Objetivo do Teste** | Verificar se o usuário consegue se cadastrar na aplicação. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Clicar no botão "Cadastrar". 3-Preencher os campos obrigatórios. 4-Clicar no botão "Cadastrar". |
| **Critério de Êxito** | As informações devem ser salvas no sistema para o cadastro ser concluído com sucesso. |

| **Caso de Teste** | CT-02 – Efetuar login |
|:---:|---|
| **Requisito Associado** | RF-002 - O sistema deve permitir que os usuários efetuarem login para acessar suas funcionalidades. |
| **Objetivo do Teste** | Verificar se o usuário consegue realizar login na aplicação. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Clicar no botão "Login". 3-Preencher os campos obrigatórios. 4-Clicar no botão "Entrar". |
| **Critério de Êxito** | As informações preenchidas devem ser iguais às informações fornecidas no cadastro para o login ser concluído com sucesso. |

| **Caso de Teste** | CT-03 – Editar perfil |
|:---:|---|
| **Requisito Associado** | RF-003 - O sistema deve permitir que um usuário edite suas próprias informações. |
| **Objetivo do Teste** | Verificar se o usuário consegue editar suas informações. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Clicar no seu nome de usuário para acessar a página "Minha Conta". 4-Clicar no botão "Editar". 5-Preencher o campo obrigatório. 6-Clicar no botão "Salvar". |
| **Critério de Êxito** | As informações editadas devem ser salvas e modificadas no sistema. | |

| **Caso de Teste** |  |
|:---:|---|
| **Requisito Associado** |  |
| **Objetivo do Teste** |  |
| **Passos** |  |
| **Critério de Êxito** |  |

| CT-04 – Apagar perfil | RF-004 - O sistema deve permitir que o usuário apague sua conta. | Verificar se o usuário consegue apagar sua conta na aplicação. | 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Clicar no seu nome de usuário para acessar a página "Minha Conta";<br> 4 - Clicar no botão "Deletar";<br> 5 - Clicar no botão "Deletar" para confirmar. | A conta deve ser deletada do sistema. |

| **Caso de Teste** |  |
|:---:|---|
| **Requisito Associado** |  |
| **Objetivo do Teste** |  |
| **Passos** |  |
| **Critério de Êxito** |  |

| CT-05 – Visualizar lista dos itens | RF-005 - O sistema deve apresentar uma lista com todos os itens. | Verificar se todos os itens estão aparecendo na aplicação. | 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Jogos" na barra de navegação. | Uma lista com todos os itens cadastrados deve aparecer na página principal. |

| **Caso de Teste** |  |
|:---:|---|
| **Requisito Associado** |  |
| **Objetivo do Teste** |  |
| **Passos** |  |
| **Critério de Êxito** |  |

| CT-06 – Visualizar item | RF-006 - O sistema deve permitir o usuário visualize todas as informações de um item. | Verificar se as informações do item estão aparecendo corretamente. | 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Jogos" na barra de navegação;<br> 4 - Clicar no botão "Detalhes" do item desejado. | As informações do item devem ser exibidas corretamente. |

| **Caso de Teste** | CT-07 – Filtro de pesquisa |
|:---:|---|
| **Requisito Associado** |  RF-007 - O sistema deve permitir que o usuário busque por jogos. |
| **Objetivo do Teste** | Verificar se o filtro da barra de pesquisa está funcionando corretamente. |
| **Passos** | 1-Acessar a página principal da aplicação;<br> 2-Realizar o login na aplicação;<br> 3-Acessar a página "Jogos" na barra de navegação;<br> 4-Escrever o nome do item na barra de pesquisa. |
| **Critério de Êxito** |  |

| CT-07 – Filtro de pesquisa | RF-007 - O sistema deve permitir que o usuário busque por itens. | Verificar se o filtro da barra de pesquisa está funcionando corretamente. | 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Jogos" na barra de navegação;<br> 4 - Escrever o nome do item na barra de pesquisa. | O filtro de pesquisa deve funcionar corretamente. |

| **Caso de Teste** | CT-08 – Reservar jogo |
|:---:|---|
| **Requisito Associado** | RF-008 - O sistema deve permitir que um usuário reserve um jogo que não esteja reservado ainda. |
| **Objetivo do Teste** | Verificar se o usuário consegue reservar um jogo que está disponível. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Jogos" na barra de navegação. 4-Clicar no botão "Detalhes" do item desejado. 5-Clicar no botão "Reservar". 6-Clicar no botão "Reservar Jogo" para confirmar. |
| **Critério de Êxito** | Os jogos reservados devem ficar como indisponíveis no sistema e aparecer na página de "Jogos Reservados". |

| **Caso de Teste** | CT-09 – Cancelar reserva |
|:---:|---|
| **Requisito Associado** | RF-009 - O sistema deve permitir que um usuário cancele a reserva de um jogo. |
| **Objetivo do Teste** | Verificar se o usuário consegue cancelar a reserva de um jogo. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Jogos Reservados" na barra de navegação. 4-Clicar no botão "Detalhes" do item desejado. 5-Clicar no botão "Cancelar Reserva". 6-Clicar no botão "Cancelar Reserva" para confirmar. |
| **Critério de Êxito** | Os jogos cancelados devem ficar como disponíveis no sistema e desaparecer da página de "Jogos Reservados". |

| **Caso de Teste** | CT-10 – Cadastrar jogo |
|:---:|---|
| **Requisito Associado** | RF-010 - O sistema deve permitir que usuários cadastrem novos jogos. |
| **Objetivo do Teste** | Verificar se o usuário consegue realizar o cadastro de jogos. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Meus jogos" na barra de navegação. 4-Clicar no botão "Adicionar novo Jogo". 5-Preencher os campos obrigatórios. 6-Clicar no botão "Adicionar Jogo". |
| **Critério de Êxito** | As informações devem ser salvas no sistema para o cadastro do jogo ser concluído com sucesso. |

| **Caso de Teste** | CT-11 – Editar jogo |
|:---:|---|
| **Requisito Associado** | RF-011 - O sistema deve permitir que um usuário atualize informações dos seus jogos. |
| **Objetivo do Teste** | Verificar se o usuário consegue editar informações dos jogos cadastrados. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Meus Jogos" na barra de navegação. 4-Clicar no botão "Detalhes" do item desejado. 5-Clicar no botão "Editar". 6-Preencher os campos obrigatórios. 7-Clicar no botão "Salvar". |
| **Critério de Êxito** | As informações editadas do jogo devem ser salvas e modificadas no sistema. |

| **Caso de Teste** | CT-12 – Apagar jogo |
|:---:|---|
| **Requisito Associado** | RF-012 - O sistema deve permitir que um usuário apague jogos da sua biblioteca. |
| **Objetivo do Teste** |  Verificar se o usuário consegue apagar os jogos cadastrados. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Meus jogos" na barra de navegação. 4-Clicar no botão "Detalhes" do item desejado. 5-Clicar no botão "Deletar". 6-Clicar no botão "Deletar Jogo" para confirmar. |
| **Critério de Êxito** | O jogo deve ser deletado do sistema. |

| **Caso de Teste** | CT-13 – Adicionar desejo |
|:---:|---|
| **Requisito Associado** | RF-013 - O sistema deve permitir que o usuário adicione um jogo à sua lista de desejos. |
| **Objetivo do Teste** | Verificar se o usuário consegue adicionar um jogo à sua lista de desejos. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Jogos" na barra de navegação. 4-Clicar no botão "Detalhes" do item desejado. 5-Clicar no botão "Adicionar à lista de desejos". 6-Acessar a página "Meus Desejos" na barra de navegação. |
| **Critério de Êxito** | Os jogos adicionados devem aparecer corretamente na página "Meus Desejos". | |

| **Caso de Teste** | CT-14 – Deletar desejo |
|:---:|---|
| **Requisito Associado** | RF-014 - O sistema deve permitir que o usuário apague um jogo da sua lista de desejos. |
| **Objetivo do Teste** | Verificar se o usuário consegue apagar um jogo da sua lista de desejos. |
| **Passos** | 1-Acessar a página principal da aplicação. 2-Realizar o login na aplicação. 3-Acessar a página "Meus Desejos" na barra de navegação. 4-Clicar no botão "Deletar" do item desejado. 5-Clicar no botão "Deletar da lista de desejos" para confirmar. |
| **Critério de Êxito** | Os jogos deletados devem desaparecer da página "Meus Desejos". |
