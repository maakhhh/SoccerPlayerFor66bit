using System.ComponentModel.DataAnnotations;

namespace SoccerPlayers.Models
{
    public class SoccerPlayer
    {
        
        public int Id { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }
        [Display(Name = "Пол")]
        public Gender Gender { get; set; }
        [Display(Name = "Страна")]
        public Countries Country { get; set; }
        [Display(Name = "Название команды")]
        public string CommandName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "День рождения")]
        public DateTime Birthday { get; set; }
    }

}
