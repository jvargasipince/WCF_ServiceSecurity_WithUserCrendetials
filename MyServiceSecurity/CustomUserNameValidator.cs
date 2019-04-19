using System;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace MyServiceSecurity
{
    public class CustomUserNameValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("User and Password can not be empty.");
            }

            if (!(userName.Equals("jvargas", StringComparison.InvariantCultureIgnoreCase) 
                && password.Equals("mypassword", StringComparison.InvariantCultureIgnoreCase)))
            {
                // This throws an informative fault to the client.
                throw new FaultException("Unknown Username or Incorrect Password");
                // When you do not want to throw an infomative fault to the client,
                // throw the following exception.
                // throw new SecurityTokenException("Unknown Username or Incorrect Password");
            }
        }
    }
}