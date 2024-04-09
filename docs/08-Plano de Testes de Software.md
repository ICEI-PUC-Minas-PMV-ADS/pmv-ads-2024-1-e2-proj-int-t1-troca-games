# Plano de Testes de Software

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| **Caso de Teste**	| **CT-01 – Cadastrar perfil**	|
| :---:	| :---:	|
|	Requisito Associado 	| RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a página principal da aplicação<br> - Clicar no botão "Cadastrar"<br> - Preencher os campos obrigatórios<br> - Clicar no botão "Cadastrar" |
|Critério de Êxito | O cadastro deve ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-001 - O sistema deve permitir novos usuários se cadastrarem e efetuarem login para acessar suas funcionalidades. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login na aplicação. |
| Passos 	|  - Acessar a página principal da aplicação<br> - Clicar no botão "Login"<br> - Preencher os campos de e-mail e senha<br> - Clicar no botão "Entrar" |
|Critério de Êxito | O login deve ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Editar perfil**	|
|Requisito Associado | RF-002 - O sistema deve permitir que um usuário edite suas próprias informações de usuário. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar suas informações. |
| Passos 	| - Realizar o login na aplicação<br> - Acessar a página do perfil<br> - Clicar no botão "Editar perfil"<br> - Preencher os campos obrigatórios<br> - Clicar no botão "Confirmar"<br> |
|Critério de Êxito | As informações editadas devem ser salvas no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Apagar perfil**	|
|Requisito Associado | RF-003 - O sistema deve permitir que o usuário apague sua conta. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue apagar sua conta na aplicação.<br> 2. Verificar se o perfil apagado ainda aparece na aplicação. | |
| Passos 	| - Realizar o login na aplicação<br> - Acessar a página do perfil<br> - Clicar no botão "Deletar conta"<br> - Clicar no botão "Confirmar"<br> |
|Critério de Êxito | A conta deve ser deletada do sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Visualizar lista**	|
|Requisito Associado | RF-004 - O sistema deve apresentar uma lista com todos os itens disponíveis. |
| Objetivo do Teste 	| Verificar se os itens disponíveis estão aparecendo na lista. |
| Passos 	| - |
|Critério de Êxito | - |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Visualizar item**	|
|Requisito Associado | RF-005 - O sistema deve permitir que qualquer usuário visualize todas as informações de um jogo selecionado na lista. |
| Objetivo do Teste 	| Verificar se as informações do item estão aparecendo corretamente. |
| Passos 	| - Acessar a página principal da aplicação<br> - Clicar no item desejado<br> |
|Critério de Êxito | As informações do item devem ser exibidas corretamente. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Visualizar disponibilidade de um item**	|
|Requisito Associado | RF-006 - O sistema deve permitir que um usuário alugue um jogo que não esteja alugado ainda.<br> RF-013 - O sistema deve permitir que um usuário compre um item. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue selecionar um item que está disponível.<br> 2. Verificar se após selecionar o item, ele fica indisponível. |
| Passos 	| - Acessar a página principal da aplicação<br> - Clicar no item desejado<br> Clicar no botão "Alugar" ou "Comprar"<br> |
|Critério de Êxito | Os itens alugados ou comprados não devem ficar disponíveis no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Cadastrar item** 	|
|Requisito Associado | RF-007 - 	O sistema deve permitir que usuários cadastrem novos itens. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o cadastro de itens. |
| Passos 	|  - Realizar o login na aplicação<br> - Acessar a página do perfil<br> - Clicar no botão "Adicionar"<br> - Preencher os campos obrigatórios<br> - Clicar no botão "Adicionar"<br> |
|Critério de Êxito | O cadastro do item deve ser concluído com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Editar item**	|
|Requisito Associado | RF-008 - O sistema deve permitir que um usuário atualize informações dos seus itens. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar informações dos itens cadastrados. |
| Passos 	|  - Realizar o login na aplicação<br> - Acessar a página do perfil<br> - Acessar a página do item<br> - Clicar no botão "Editar"<br> - Preencher os campos obrigatórios<br> - Clicar no botão "Confirmar"<br> |
|Critério de Êxito | As informações editadas do item devem ser salvas no sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Apagar item** 	|
|Requisito Associado | RF-009 - O sistema deve permitir que um usuário apague itens da sua biblioteca. |
| Objetivo do Teste 	| 1. Verificar se o usuário consegue apagar os itens cadastrados.<br> 2. Verificar se os itens apagados ainda aparecem na aplicação. |
| Passos 	|  - Realizar o login na aplicação<br> - Acessar a página do perfil<br> - Acessar a página do item<br> - Clicar no botão "Deletar"<br> - Clicar no botão "Confirmar"<br> |
|Critério de Êxito | O item deve ser deletado do sistema. |
|  	|  	|
| **Caso de Teste** 	| **CT-11 – Adicionar lista de desejo**	|
|Requisito Associado | RF-011 - O sistema deve permitir que o usuário adicione um item à sua lista de desejo. |
| Objetivo do Teste 	| Verificar se a lista de desejo do usuário fica salvo no sistema. |
| Passos 	|  - Realizar o login na aplicação<br> - Acessar a página principal da aplicação<br> - Clicar no item desejado<br> - Clicar no botão "Adicionar Lista de desejos"<br> - Acessar a página do perfil<br> - Acessar a página lista de desejos<br> |
|Critério de Êxito | Os itens selecionados devem aparecer corretamente na página lista de desejos. |
|  	|  	|
| **Caso de Teste** 	| **CT-12 – Filtro de pesquisa** 	|
|Requisito Associado | RF-012 - 	O sistema deve permitir que o usuário busque por itens. |
| Objetivo do Teste 	| Verificar se o filtro da barra de pesquisa está funcionando corretamente. |
| Passos 	| - Acessar a página principal da aplicação<br> - Escrever o nome do item na barra de psquisa |
|Critério de Êxito | O filtro de pequisa deve funcionar corretamente. |
