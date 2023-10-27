using Business.Models.Request.Functional;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Core.Constants;
using Core.Results;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models.Request.Create;

namespace Business.Services
{
	public class UserService : BaseService<User, int, UserProfileDto>, IUserService
	{
		IHashingHelper _hashingHelper;

		public UserService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper, IHashingHelper hashingHelper) : base(unitOfWork, unitOfWork.Users, mapperHelper)
		{
			_hashingHelper = hashingHelper;
		}

		public async Task<Result> CreateUserAsync(CreateUserDto userDto)
		{
			var user=new User();
			user.FullName=userDto.FullName;
			user.Email=userDto.Email;
			_hashingHelper.CreatePasswordHash(userDto.Password, out var passwordHash, out var passwordSalt);

			user.PasswordHash = passwordHash;

			user.PasswordSalt = passwordSalt;

			if (userDto != null&& user!=null)
			{	
				_unitOfWork.Users.AddAsync(user);

				int a= await _unitOfWork.CommitAsync();
				if (a > 0)
				{
					return new Result(Messages.Success, ResultStatus.Ok);
				}
				else
				{
					return new Result(Messages.Error, ResultStatus.Error);
				}
			}
			else
			{
				return new Result(Messages.Error, ResultStatus.Error);
			}

		}
		public async Task<Result> ChangeBalanceAsync(ChangeBalanceDto balanceDto)
		{
			User? user=await _unitOfWork.Users.FirstOrDefaultAsync(u=>u.Id==balanceDto.Id);
			if (user != null)
			{
				user.Balance = user.Balance + balanceDto.AmountOfMoney;

				int a = await _unitOfWork.CommitAsync();
				if (a > 0)
				{
					return new Result(Messages.Success, ResultStatus.Ok);
				}
				else
				{
					return new Result(Messages.Error, ResultStatus.Error);
				}
			}
			return new Result(Messages.Error, ResultStatus.Error);
		}
		public async Task<Result> ChangePasswordAsync(ChangePasswordDto passwordDto)
		{

			User? user = await _unitOfWork.Users.FirstOrDefaultAsync(u => u.Email == passwordDto.Email);
			if (user != null && passwordDto.Password.Length > 7)
			{

				_hashingHelper.CreatePasswordHash(passwordDto.Password, out var passwordHash, out var passwordSalt);

				user.PasswordHash = passwordHash;

				user.PasswordSalt = passwordSalt;

				_unitOfWork.Users.Update(user);

				int a = await _unitOfWork.CommitAsync();
				if (a > 0)
				{
					return new Result(Messages.Success, ResultStatus.Ok);
				}
				else
				{
					return new Result(Messages.Error, ResultStatus.Error);
				}


			}
			return new Result(Messages.Error, ResultStatus.Error);
		}
	}
}
