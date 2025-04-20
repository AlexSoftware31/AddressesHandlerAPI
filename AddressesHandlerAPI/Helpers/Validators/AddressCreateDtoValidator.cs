using FluentValidation;
using WebApi.Aplication.Dtos;

namespace AddressesHandlerAPI.Helpers.Validators
{
    public class AddressCreateDtoValidator : AbstractValidator<AddressCreateDto>
    {
        public AddressCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .MaximumLength(50).WithMessage("Name must not exceed 50 characters."); ;
            RuleFor(x => x.Street).NotEmpty().WithMessage("Street is required")
                .MaximumLength(100).WithMessage("Street must not exceed 100 characters.");
            RuleFor(x => x.References).MaximumLength(50).WithMessage("References must not exceed 50 characters.");
            RuleFor(x => x.NoHouse).MaximumLength(30).WithMessage("NoHouse must not exceed 30 characters.");
            RuleFor(x => x.Apartment).MaximumLength(50).WithMessage("Aparment must not exceed 30 characters.");
            RuleFor(x => x.IdCountry).GreaterThan(0).WithMessage("A valid country must be selected");
            RuleFor(x => x.IdProvince).GreaterThan(0).WithMessage("A valid province must be selected");
            RuleFor(x => x.IdMunicipality).GreaterThan(0).WithMessage("A valid municipality must be selected");
            RuleFor(x => x.IdDistrict).GreaterThan(0).WithMessage("A valid district must be selected");
            RuleFor(x => x.IdSector).GreaterThan(0).WithMessage("A valid sector must be selected");
            RuleFor(x => x.IdNeighborhood).GreaterThan(0).WithMessage("A valid neighborhood must be selected");
        }
    }
}
