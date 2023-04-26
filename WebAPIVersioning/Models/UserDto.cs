namespace WebAPIVersioning.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserDtoV1  
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserDtoV2 //Updated Name to Username
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
