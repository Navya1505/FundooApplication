using BusinessLayer.Interface;
using CommonLayer;
using RepositoryModel.Entity;
using RepositoryModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class UserBL:IUserBL
    {
        private readonly IUserRL userRL;
        public UserBL(IUserRL userRL )
        {
            this.userRL = userRL;
        }
        public UserEntity Registration(UserRegistrationModel userRegistrationModel)
        {
            try
            {
                return userRL.Registration(userRegistrationModel);

            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
