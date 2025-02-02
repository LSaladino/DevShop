﻿using Compartilhado;
using Compartilhado.Model;
using Microsoft.AspNetCore.Mvc;

namespace Cadastrador.Controllers
{
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        public async Task PostAsync([FromBody] Pedido pedido)
        {
            pedido.id = Guid.NewGuid().ToString();
            pedido.DataCriacao = DateTime.Now;

            await pedido.SalvarAsync();

            Console.WriteLine($"Pedido salvo com sucesso: id {pedido.id}");
        }
    }
}
