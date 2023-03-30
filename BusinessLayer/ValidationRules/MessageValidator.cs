using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz.");
            RuleFor(x => x.MessageContent).MaximumLength(1000).WithMessage("Lütfen 1000 karakterden fazla değer girişi yapmayın.");
            RuleFor(x => x.MessageContent).MinimumLength(3).WithMessage("Lütfen 3 karakterden az değer girişi yapmayın.");
        }
    }
}
