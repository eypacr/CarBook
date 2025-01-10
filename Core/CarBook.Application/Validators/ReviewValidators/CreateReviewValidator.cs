using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using FluentValidation;

namespace CarBook.Application.Validators.ReviewValidators;

public class CreateReviewValidator : AbstractValidator<CreateReviewCommand>
{
    public CreateReviewValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Ad bilgisi boş geçilemez.").MinimumLength(3).WithMessage("Ad bilgisi en az 3 karakter olmak zorundadır.");
        RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad bilgisi boş geçilemez.").MinimumLength(3).WithMessage("Soyadı bilgisi en az 3 karakter olmak zorundadır.");
        RuleFor(x => x.Text).NotEmpty().WithMessage("Yorum bilgisi boş geçilemez.").MinimumLength(50).WithMessage("Yorum bilgisi en az 50 karakter olmak zorundadır.").MaximumLength(500).WithMessage("Yorum bilgisi en fazla 500 karakter olabilir.");
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email bilgisi boş geçilemez.").EmailAddress().WithMessage("Doğru e-posta adresi formatı kullanın.");

    }
}
