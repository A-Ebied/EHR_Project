using AutoMapper;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Login;
using EHR_API.Entities.DTOs.UserDataDTOs.AuthDTOs.Registration;
using EHR_API.Entities.Models.UsersData;
using EHR_API.Repositories.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
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

        public async Task<IdentityResult> RegisterUser(RegistrationDataCreateDTO registrationDataDTO)
        {
            var user = _mapper.Map<RegistrationData>(registrationDataDTO); 
            var result = await _userManager.CreateAsync(user, registrationDataDTO.Password); 
            
            if (result.Succeeded)
            {
                await _userManager.AddToRolesAsync(user, registrationDataDTO.Roles); 
            }

            return result;
        }

        public async Task<RegistrationData> ValidateUser(LoginRequestDTO loginRequestDTO)
        {
            _user = await _userManager.FindByEmailAsync(loginRequestDTO.Email); 
            var result = (_user != null && await _userManager.CheckPasswordAsync(_user, loginRequestDTO.Password));

            if (!result)
            {
                _user = null;
            }
            return _user;
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

        public async Task<List<RegistrationData>> GetAllAsync(Expression<Func<RegistrationData, bool>> expression = null, string includeProperties = null, int pageNumber = 1, int pageSize = 0)
        {
            IQueryable<RegistrationData> entities = _userManager.Users;
            entities = expression != null ? entities.Where(expression) : entities;

            if (pageSize > 0)
            {
                entities = entities.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
            }

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entities = entities.Include(item);
                }
            }

            return await entities.ToListAsync(); 
        }

        public async Task<RegistrationData> GetAsync(Expression<Func<RegistrationData, bool>> expression, string includeProperties = null)
        {
            IQueryable<RegistrationData> entity = _userManager.Users;
            entity = expression != null ? entity.Where(expression) : entity;

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    entity = entity.Include(item);
                }
            }

            return await entity.SingleOrDefaultAsync();
        }

        public async Task<RegistrationData> UpdateAsync(RegistrationDataUpdateDTO entity)
        {
            var newEntity = _mapper.Map<RegistrationData>(entity);
            await _userManager.UpdateAsync(newEntity);
            return newEntity;
        }
    }
}
