namespace Users.Logic.DTO
{
    public class PaginationDataDto
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
    
    public class UserFilterDto : PaginationDataDto
    {
        public int? OrganisationId { get; set; }
    }
}