using FluentValidation;

namespace WebApi.Application.OrderOperations.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(command => command.Model.PurchasingCustomer).GreaterThan(0);
            RuleFor(command => command.Model.PurchasedMovie).GreaterThan(0);
            RuleFor(command => command.Model.Price).GreaterThanOrEqualTo(0);
        }
    }
}
