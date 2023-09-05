using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRoles
{
    public class RoomValidator:AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(x => x.RoomName).NotEmpty().WithMessage("Bu alan boş geçilemez...");
        }
    }
}
