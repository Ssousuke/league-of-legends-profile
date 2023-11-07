# League of legends busca de perfil

Pesquise o jogador pelo nick name e veja todos as informações do perfil publico dele.

- Rank (Flex / Solo Duo)
- Vitorias / Derrotas
- Nível
 
## Funcionalidades

- Buscar Perfil
- Buscar Conta

## Próximas funcionalidades
- Historico de partidas
- Maestria de campeões

## Fluxo de requisição
**1. Cliente**
 - Envia requisição à API Rest

**2. API Rest**
 - É feito uma busca na base de dados, caso o player pesquisado já esteja inserido no banco de dados, então é retornado para o cliente.
 - Caso contrário é feito uma requisição para RIOT API.

**3.  Faz requisição para outro serviço**
 - A requisição é feita e caso seja encontrado o player, então essas informações são salvas no banco de dados.  
 - Caso contrário é retornado um erro para o cliente, o player não existe.



## Desenvolvimento

Foi utilizado a [RIOT API](https://developer.riotgames.com/), para obter os dados do jogador. E além disso foi utilizado as seguintes tecnologias:

- C# .NET 7
- Docker
- SQL Server
- Arquitetura em camadas

