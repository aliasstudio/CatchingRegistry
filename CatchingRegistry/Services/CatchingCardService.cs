using CatchingRegistry.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CatchingRegistry.Services
{
    public class CatchingCardService
    {
        public static CatchingCardService instance;
        ApplicationContext actContext = new();
        public static CatchingCardService GetInstance()
        {
            if (instance == null)
                instance = new CatchingCardService();
            return instance;
        }

        public CatchingAct? GetByID(int actID)
        {
            actContext = new ApplicationContext();
            return actContext.CatchingActs
                        .Include(x => x.MunicipalContract)
                        .Include(x => x.Animals)
                        .Include(x => x.Files)
                        .FirstOrDefault(x => x.ID == actID);
        }

        public void Delete(int actID)
        {
            using var ctx = new ApplicationContext();
            var act = ctx.CatchingActs.Find(actID);
            ctx.CatchingActs.Remove(act);
            ctx.SaveChanges();
        }

        public void Save(CatchingAct catchingAct)
        {
            if (!actContext.CatchingActs.Contains(catchingAct))
                actContext.CatchingActs.Add(catchingAct);
            try
            {
                actContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения акта. {ex}");
            }
        }

        public List<Animal> GetAllAnimals()
            => new ApplicationContext().Animals.ToList();

        public List<AttachedFile> GetAttachedFiles(CatchingAct catchingAct)
            => new ApplicationContext().CatchingActs.Include(x => x.Files).FirstOrDefault(x => x.ID == catchingAct.ID).Files;

        public void RemoveFile(CatchingAct catchingAct, AttachedFile attachedFile)
            => new ApplicationContext().Files.Remove(attachedFile);

        public void AddFile(CatchingAct catchingAct, string fileName)
        {
            var file = new AttachedFile()
            {
                Name = fileName,
                CatchingActID = catchingAct.ID
            };
            catchingAct.Files.Add(file);
            LoggerService.Add(file);
        }
    }
}
