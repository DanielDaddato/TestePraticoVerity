function ProdutosIndex()
{
    chamadaSimples('/Produtos/Index');
}

function ProdutosAdicionar()
{
    chamadaSimples('/Produtos/Adicionar',ProdutosAdicionarCallback);
}

function ProdutosAdicionarCallback(data) {
    $("#principal").html(data);
}

function GravarProdutos(data)
{
    chamadaSimplesPost('/Produtos/Gravar',data, GravarProdutosCallback());
}


function CategoriaIndex() {
    chamadaSimples('/Categoria/Index');
}

function CategoriaAdicionar() {
    chamadaSimples('/Categoria/Adicionar');
}

function GravarCategoria(data) {
    chamadaSimplesPost('../Categoria/GravarProdutos', data, GravarCategoriaCallback());
}

