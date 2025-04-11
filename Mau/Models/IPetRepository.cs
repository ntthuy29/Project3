﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mau.Models
{
    internal interface IPetRepository
    {
        void Add(PetModel petModel);
        void Edit(PetModel petModel);
        void Delete(int id);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value);//Searchs
    }
}
