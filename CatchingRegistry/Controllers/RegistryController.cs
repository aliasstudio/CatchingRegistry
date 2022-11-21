﻿using CatchingRegistry.Services;
using CatchingRegistry.Models;
using System.Data;
using System.ComponentModel;
using Equin.ApplicationFramework;
using Microsoft.EntityFrameworkCore;


namespace CatchingRegistry.Controllers
{
    public class RegistryController
    {
        public BindingListView<CatchingAct> GetDataSource()
        {
            EntityService.GetContext().CatchingActs.Load();
            return EntityService<CatchingAct>.GetDataSource();
        }

        public void Delete(int ID)
        {
            EntityService<CatchingAct>.Delete(ID);
        }

        public void NextPage()
        {

        }

        public void PreviosPage()
        {

        }
    }
}
