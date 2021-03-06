﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraWebApp.Models.ViewModels;
using AluraWebApp.Repositories;
using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AluraWebApp.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;


        public PedidoController(IProdutoRepository produtoRepository,
            IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
                pedidoRepository.AddItem(codigo);

            var pedido = pedidoRepository.GetPedido().Itens;

            var carrinhoViewModel = new CarrinhoViewModel(pedido);

            return View(carrinhoViewModel);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }

        [HttpPost]
        public void UpdateQuantidade([FromBody]ItemPedido itemPedido)
        {
            itemPedidoRepository.UpdateQuantidade(itemPedido);
        }

    }
}
