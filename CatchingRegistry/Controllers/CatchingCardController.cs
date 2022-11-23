using Microsoft.EntityFrameworkCore;
using CatchingRegistry.Models;
using Equin.ApplicationFramework;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchingRegistry.Services;
using System.ComponentModel;

namespace CatchingRegistry.Controllers
{
    public class CatchingCardController
    {
        ApplicationContext catchingActContext;
        EntityService<CatchingAct> entityService;

        private CatchingAct catchingAct;
        private BindingList<Animal> animalsList;
        public CatchingCardController(int cardID)
        {
            catchingActContext = new();
            entityService = new(catchingActContext);

            if (cardID < 0)
                //TODO: обработать открытие формы для создания новой карточки
                throw new NotImplementedException();
            else
            {
                catchingAct = entityService.GetByID(cardID);
                animalsList = catchingAct.Animals.ToBindingList();
            }
        }

        public BindingListView<Animal> GetAnimalSource()
        {
            return new BindingListView<Animal>(animalsList);
        }


        public Animal GetAnimalData(int animalID)
        {
            return animalsList.FirstOrDefault(x => x.ID == animalID);
        }
        public MunicipalContract GetMunicipalData() => catchingAct.MunicipalContract;

        public CatchingAct GetCatchingActData() => catchingAct;

        public void AddAnimal(Animal animal)
        {
            if (animalsList.FirstOrDefault(x => x.ID == animal.ID) != null)
                throw new Exception("Животное с этим номером чипа уже добавлено");
            animal.CatchingActID = catchingAct.ID;
            animalsList.Add(animal);
        }

        public void EditAnimal(int animalID, Animal editedAnimal)
        {
            var listItem = animalsList.FirstOrDefault(x => x.ID == animalID);
            editedAnimal.CatchingActID = catchingAct.ID;
            animalsList[animalsList.IndexOf(listItem)] = editedAnimal;
        }


        public void DeleteAnimal(int ID)
        {
            var listItem = animalsList.FirstOrDefault(x => x.ID == ID);
            animalsList.Remove(listItem);
        }

        public void AddFile()
        {

        }

        public void DeleteFile()
        {

        }

        public void ExportToWord()
        {

        }
    }
}
