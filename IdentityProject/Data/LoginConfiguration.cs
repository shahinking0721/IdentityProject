
using IdentityProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;



	public class LoginConfiguration : IEntityTypeConfiguration<LoginViewModel>
	{
		public void Configure(EntityTypeBuilder<LoginViewModel> builder)
		{
			builder.HasData
			(
				new LoginViewModel
                {
					Username = "omid",
					Password = "1234",
					RememberMe = true,
					ReturnUrl="index"
				},
				new LoginViewModel
                {
                    Username = "ali",
                    Password = "1234",
                    RememberMe = true,
                    ReturnUrl = "index"
                }
			);
		}
	}

