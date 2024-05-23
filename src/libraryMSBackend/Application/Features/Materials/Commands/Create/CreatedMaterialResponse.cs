using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Materials.Commands.Create;

public class CreatedMaterialResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public MaterialTypes MaterialType { get; set; }
    public int ReleaseDate { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
}