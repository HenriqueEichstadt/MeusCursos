﻿using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return dbSet
                .Where(ip => ip.Id == itemPedidoId)
                .SingleOrDefault();
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            var item = GetItemPedido(itemPedidoId);
            dbSet.Remove(item);
            
        }
    }
}