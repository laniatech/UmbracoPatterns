using NPoco;

namespace UmbracoPatterns.Core.Database.Dto
{
    [TableName(DatabaseTableNames.UmbracoPatternsAddress)]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public AddressDto Address { get; set; }
    }
}
