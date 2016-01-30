using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Dtos
{
    public class GroupDto
    {
        public GroupDto()
        {
            
        }

        public GroupDto(Group group)
        {
            this.Id = group.Id;
            this.Name = group.Name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}