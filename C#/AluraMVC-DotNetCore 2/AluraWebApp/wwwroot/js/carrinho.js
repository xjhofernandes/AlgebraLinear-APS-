class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
        debugger;
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        if(data.Quantidade > 0)
            data.Quantidade--;
        this.postQuantidade(data);
        debugger;
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]')
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtde = $(linhaDoItem).find('input').val();
        console.log(itemId);

        return {
            Id: itemId,
            Quantidade: novaQtde,
        }
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);
    }


    postQuantidade(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function(response) {

        });
    }
}

var carrinho = new Carrinho();

