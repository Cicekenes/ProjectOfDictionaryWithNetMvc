using FluentValidation;
using ProjectOfDictionaryWithNetMvc.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfDictionaryWithNetMvc.Business.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı maili boş geçilemez!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz!");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı boş geçilemez!").EmailAddress().WithMessage("Geçerli bir mail adresi gerekli!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("100 karakterden fazla konu girişi yapılamaz!");
        }
    }
}
