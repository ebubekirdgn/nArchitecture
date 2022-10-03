using Application.Features.Auths.Dtos;
using Application.Features.Auths.Rules;
using Application.Services.Repositories;
using Core.Security.Dtos;
using MediatR;

namespace Application.Features.Auths.Commands.Register
{
    public class RegisterCommand :IRequest<RegisterDto>
    {
        public UserForRegisterDto UserForRegisterDto { get; set; }
        public string IpAddress{ get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterDto>
        {
            private readonly AuthBusinessRules _authBusinessRules;
            private readonly IUserRepository _userRepository;
          
            public Task<RegisterDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
