using NArchitecture.Core.Application.Responses;

namespace Application.Features.LibraryStaffs.Commands.Update;

public class UpdatedLibraryStaffResponse : IResponse
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BirthDate { get; set; }
}