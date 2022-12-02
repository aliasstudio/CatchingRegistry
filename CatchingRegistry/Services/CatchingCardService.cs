﻿using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CatchingRegistry.Services
{
    public class CatchingCardService
    {
        public static CatchingCardService instance;
        private static ApplicationContext ctx;

        public static CatchingCardService GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardService();
            ctx = new();
            return instance;
        }

        public CatchingAct? GetBy(Expression<Func<CatchingAct, bool>> predicate)
            => new ApplicationContext().CatchingActs.FirstOrDefault(predicate);

        public CatchingAct? GetByID(int actID)
            => new ApplicationContext().CatchingActs
                .Include(x => x.MunicipalContract)
                .Include(x => x.Animals)
                .Include(x => x.Files)
                .FirstOrDefault(x => x.ID == actID);

        public void Delete(int actID)
        {
            ctx.CatchingActs.Remove(GetByID(actID));
            ctx.SaveChanges();
        }

        public void Save(CatchingAct catchingAct)
        {
            if (ctx.CatchingActs.Contains(catchingAct))
                ctx.CatchingActs.Update(catchingAct);
            else
                ctx.CatchingActs.Add(catchingAct);
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения акта. {ex}");
            }
        }

        public void RemoveFile(CatchingAct catchingAct, AttachedFile attachedFile)
        {
            //Bug
            ctx.Files.Remove(attachedFile);
            catchingAct.Files.Remove(attachedFile);
        }
    }
}
