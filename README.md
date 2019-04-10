# ProjetoVendasOrientacaoObjeto
Project related to object orientation class


Passo a passo para banco de dados

1 - Instalar o Entity Framework
	Install-Package EntityFramework
2 - Criar a classe que herda as informacoes do EF
3 - Fazer os ajustes nas classes de modelo
4 - Declarar as classes que vao virar tabela no banco no contexto
5 - Habilita migracao
6 - Criar uma migracao e atualizar o banco

    //Console
    //-------------------------------------------------
    //Install-Package EntityFramework - 1ª vez
    //Uninstall-Package EntityFramework
    //Enable-Migrations - 1ª vez
    //Add-Migration Nome
    //Update-Database
    //Rodar os comandos ao mesmo tempo
    //clear; echo "Criando migração"; Add-Migration CriarBanco; Update-Database -verbose
