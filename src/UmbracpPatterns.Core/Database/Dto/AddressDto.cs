using NPoco;

namespace UmbracoPatterns.Core.Database.Dto
{
    [TableName(DatabaseTableNames.UmbracoPatternsAddress)]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class AddressDto
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? StudentId { get; set; }
    }
}