﻿using restaurant.Core.enties;
using restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }
        public List<Client> Get()
        {
            return _context.clients.ToList();
        }
        public Client Get(int id)
        {
            var index = _context.clients.ToList().FindIndex(x => x.Id == id);
            return _context.clients.ToList()[index];
        }
        public Client Post(Client client)
        {
            _context.clients.Add(client);
            return client;
        }
        public Client Put(int id, Client client)
        {
            int index = _context.clients.ToList().FindIndex(c => c.Id == id);
            _context.clients.ToList()[index].Name = client.Name;
            _context.clients.ToList()[index].Phone = client.Phone;
            return _context.clients.ToList()[index];
        }
        public void Delete(int id)
        {
            var index = _context.clients.ToList().FindIndex(_ => _.Id == id);
            _context.clients.ToList().RemoveAt(index);
        }
    }
}
