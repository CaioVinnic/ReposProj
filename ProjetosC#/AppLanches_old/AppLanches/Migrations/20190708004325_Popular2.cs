using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLanches.Migrations
{
    public partial class Popular2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES ('13','Pão, Hamburger, ovo, presunto, queijo, batata palha','Delicioso pao de hamburguer com ovo, presunto, queijo e bata palha','1','http://www.macoratti.net/Imagens/Lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/Lanches/cheesesalada1.jpg','0','Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES ('13','Pão, presunto, mussarela e tomate','Delicioso pao francês quentinho na chapa com presunto, mussarela e tomate','1','http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/Lanches/mistoquente4.jpg','1','Misto Quente', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES ('13','Pão, Hamburger, presunto, mussarela, batata palha','Pão de hamburger especial com presunto, mussarela e batata palha','1','http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/Lanches/cheeseburger1.jpg','0','Cheese Burger', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES ('14','Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru, cenoura ralada com alface e iogurte','1','http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg','1','Peito Peru', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES ('14','Pão Integral, queijo branco, atum, cenoura, alface, iogurte','Pão integral natural com queijo branco, atum cenoura ralada com alface e iogurte','1','http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/Lanches/lanchenatural.jpg','0','Atum', 12.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
