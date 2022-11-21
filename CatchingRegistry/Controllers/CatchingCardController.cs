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
        private CatchingAct catchingAct;
        private BindingList<Animal> animalsList;
        public CatchingCardController(int cardID)
        {
            if (cardID < 0)
                //TODO: обработать открытие формы для создания новой карточки
                throw new NotImplementedException();
            else
            {
                catchingAct = EntityService<CatchingAct>.GetByID(cardID);
                EntityService.GetContext().Animals.Load();
                animalsList = catchingAct.Animals.ToBindingList();
            }
        }

        public BindingListView<Animal> GetAnimalSource()
        {
            return new BindingListView<Animal>(animalsList);
        }

        public void AddAnimal(Animal animal)
        {
            if (animalsList.FirstOrDefault(x => x.ID == animal.ID) != null)
                throw new Exception("Животное с этим номером чипа уже добавлено");
            animal.CatchingActID = catchingAct.ID;
            animalsList.Add(animal);
        }

        public void EditAnimal(Animal animal)
        {
            var listItem = animalsList.FirstOrDefault(x => x.ID == animal.ID);
            animal.CatchingActID = catchingAct.ID;
            animalsList[animalsList.IndexOf(listItem)] = animal;
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
