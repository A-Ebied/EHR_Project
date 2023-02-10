using AutoMapper;
using EHR_API.Entities.DTOs.UserDataDTOs;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EHR_API.Repositories.Implementation
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly IMapper _mapper; 
        private readonly UserManager<RegistrationData> _userManager; 
        private readonly IConfiguration _configuration;
        private RegistrationData _user;

        public AuthenticationRepository(IMapper mapper, UserManager<RegistrationData> userManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterUser(RegistrationDataDTO registrationDataDTO)
        {
            var user = _mapper.Map<RegistrationData>(registrationDataDTO); 
            var result = await _userManager.CreateAsync(user, registrationDataDTO.Password); 
            
            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, registrationDataDTO.Roles); 
            }

            return result;
        }

        public async Task<bool> ValidateUser(LoginRequestDTO loginRequestDTO)
        {
            _user = await _userManager.FindByEmailAsync(loginRequestDTO.Email); 
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, loginRequestDTO.Password)); 
            
            return result;
        }

        public async Task<string> CreateToken() 
        { 
            var signingCredentials = GetSigningCredentials(); 
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims); 
            
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions); 
        }

        private SigningCredentials GetSigningCredentials() 
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JwtSettings:Secret")); 
            var secret = new SymmetricSecurityKey(key); 
            
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256); 
        }

        private async Task<List<Claim>> GetClaims() 
        { 
            var claims = new List<Claim> 
            { 
                new Claim(ClaimTypes.Name, _user.UserName) 
            };
            
            var roles = await _userManager.GetRolesAsync(_user); 
            foreach (var role in roles)
            { 
                claims.Add(new Claim(ClaimTypes.Role, role)); 
            } 
            
            return claims; 
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        { 
            var jwtSettings = _configuration.GetSection("JwtSettings"); 
            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["validIssuer"], 
                audience: jwtSettings["validAudience"], 
                claims: claims, 
                expires: DateTime.Now.AddDays(Convert.ToDouble(jwtSettings["expires"])), 
                signingCredentials: signingCredentials
                ); 
            
            return tokenOptions; 
        }
    }
}
