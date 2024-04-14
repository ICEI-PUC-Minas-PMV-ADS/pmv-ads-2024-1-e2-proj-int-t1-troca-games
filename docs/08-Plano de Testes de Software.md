# Plano de Testes de Software

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste**	| **CT-01 – Cadastrar perfil**	|
| :---:	| :---:	|
|	Requisito Associado 	| RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Clicar no botão "Cadastro";<br> 3 - Preencher os campos obrigatórios;<br> 4. Clicar no botão "Cadastro". |
|Critério de Êxito | As informações devem ser salvas no sistema para o cadastro ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login na aplicação. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Preencher os campos obrigatórios;<br> 3 - Clicar no botão "Entrar". |
|Critério de Êxito | As informações preenchidas devem ser iguais as informações fornecidas no cadastro para o login ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Editar perfil**	|
|Requisito Associado | RF-002 - O sistema deve permitir que um usuário edite suas próprias informações de usuário. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar suas informações. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Meus perfil" na barra de navegação;<br> 4 - Clicar no ícone de editar;<br> 5 - Preencher o campo obrigatório;<br> 6 - Clicar no botão "Confirmar". |
|Critério de Êxito | As informações editadas devem ser salvas e modificadas no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Apagar perfil**	|
|Requisito Associado | RF-003 - O sistema deve permitir que o usuário apague sua conta. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue apagar sua conta na aplicação.<br> 2. Verificar se o perfil apagado ainda aparece na aplicação. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Meus perfil" na barra de navegação;<br> 4 - Clicar no botão "Deletar conta";<br> 5 - Clicar no botão "Confirmar". |
|Critério de Êxito | A conta deve ser deletada do sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Visualizar lista de itens disponíveis**	|
|Requisito Associado | RF-004 - O sistema deve apresentar uma lista com todos os itens disponíveis. |
| Objetivo do Teste 	| Verificar se os itens disponíveis estão aparecendo na aplicação.  |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação. |
|Critério de Êxito | Uma lista com todos os itens disponíveis devem aparecer na página principal. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Visualizar item**	|
|Requisito Associado | RF-005 - O sistema deve permitir que qualquer usuário visualize todas as informações de um item selecionado na lista. |
| Objetivo do Teste 	| Verificar se as informações do item estão aparecendo corretamente. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Clicar no item desejado. |
|Critério de Êxito | As informações do item devem ser exibidas corretamente. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Visualizar disponibilidade de um item**	|
|Requisito Associado | RF-006 - O sistema deve permitir que um usuário alugue um item que não esteja alugado ainda.<br> RF-012 - O sistema deve permitir que um usuário compre um item. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue selecionar um item que está disponível.<br> 2. Verificar se após selecionar o item, ele fica indisponível. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Clicar no item desejado;<br> 4 - Clicar no botão "Adicionar ao carrinho" ou "Finalizar compra". |
|Critério de Êxito | Os itens alugados ou comprados não devem ficar disponíveis no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Cadastrar item** 	|
|Requisito Associado | RF-007 - 	O sistema deve permitir que usuários cadastrem novos itens. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o cadastro de itens. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Meus itens" na barra de navegação;<br> 4 - Clicar no ícone de adicionar;<br> 5 - Preencher os campos obrigatórios;<br> 6 - Clicar no botão "Adicionar". |
|Critério de Êxito | As informações devem ser salvas no sistema para o cadastro do item ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Editar item**	|
|Requisito Associado | RF-008 - O sistema deve permitir que um usuário atualize informações dos seus itens. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar informações dos itens cadastrados. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Meus itens" na barra de navegação;<br> 4 - Clicar no ícone de editar;<br> 5 - Preencher os campos obrigatórios;<br> 6 - Clicar no botão "Editar". |
|Critério de Êxito | As informações editadas do item devem ser salvas e modificadas no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Apagar item** 	|
|Requisito Associado | RF-009 - O sistema deve permitir que um usuário apague itens da sua biblioteca. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue apagar os itens cadastrados.<br> 2. Verificar se os itens apagados ainda aparecem na aplicação. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Acessar a página "Meus itens" na barra de navegação;<br> 4 - Clicar no ícone de deletar;<br> 5. Clicar no botão "Deletar". |
|Critério de Êxito | O item deve ser deletado do sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-11 – Adicionar aos favoritos**	|
|Requisito Associado | RF-010 - O sistema deve permitir que o usuário adicione um item à sua lista de favoritos. |
| Objetivo do Teste 	| Verificar se a lista de favoritos do usuário fica salvo no sistema. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Clicar no item desejado;<br> 4 - Clicar no botão "Favoritar";<br> 5 - Acessar a página "Meus favoritos" na barra de navegação. |
|Critério de Êxito | Os itens selecionados devem aparecer corretamente na página "Meus favoritos". |
|  	|  	|
| **Caso de Teste** 	| **CT-12 – Filtro de pesquisa** 	|
|Requisito Associado | RF-011 - 	O sistema deve permitir que o usuário busque por itens. |
| Objetivo do Teste 	| Verificar se o filtro da barra de pesquisa está funcionando corretamente. |
| Passos 	| 1 - Acessar a página principal da aplicação;<br> 2 - Realizar o login na aplicação;<br> 3 - Escrever o nome do item na barra de pesquisa. |
|Critério de Êxito | O filtro de pesquisa deve funcionar corretamente. |
