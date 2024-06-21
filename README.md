
## Configurando o projeto

Faça o clone ou download do repositório, altere as configurações de acesso ao banco de dados `MySql` no arquivo `appsetting.json` na raiz do projeto.
> Alterar o valor de usuário `**SEU USUARIO AQUI**`
> Alterar o valor de senha `**SEU SENHA AQUI**`

Agora no terminal, na raiz do projeto, rode o comando `dotnet ef database update`, assim as migrações serão criadas com alguns produtos já cadastrados como exemplo.
