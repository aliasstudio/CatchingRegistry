using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatchingRegistry.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }

        /*        public string[] roleNames = {
                    "Подписант приюта",
                    "Подписант по отлову",
                    "Подписант ОМСУ",
                    "Подписант ВетСлужбы",
                    "Оператор приюта",
                    "Оператор ОМСУ",
                    "Оператор ВетСлужбы",
                    "Куратор приюта",
                    "Куратор по отлову",
                    "Куратор ОМСУ",
                    "Куратор ВетСлужбы",
                    "Оператор по отлову"
                };*/

    }
}
