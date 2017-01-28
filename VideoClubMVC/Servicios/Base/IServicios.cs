﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubMVC.Servicios.Base
{
    public interface IServicios<TModel>
    {
        Task Add(TModel modelo);
        Task Update(TModel modelo);
        Task Delete(int id);
        List<TModel> Get();
        TModel Get(int id);
        List<TModel> Get(Dictionary<String, String> args);
    }
}
