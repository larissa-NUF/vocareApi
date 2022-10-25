﻿using Vocare.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vocare.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetAll();
        public void Add(Usuario usuario);
        public Usuario GetById(int id);
        Usuario GetByLogin(string login);
        Task<List<Perfil>> GetTypesById(int[] idsTipo);
    }
}
