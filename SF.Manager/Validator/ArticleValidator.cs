using FluentValidation;
using SF.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Manager.Validator
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotNull().NotEmpty().MinimumLength(5).MaximumLength(200);
            RuleFor(x => x.Summary).NotNull().NotEmpty().MinimumLength(20).MaximumLength(200);
            RuleFor(x => x.Featured).NotNull().NotEmpty().WithMessage("Utilize 'true' para artigo em destaque");

        }

     
    }
}
