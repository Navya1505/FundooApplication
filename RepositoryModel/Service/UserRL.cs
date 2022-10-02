using CommonLayer;
using RepositoryModel.Context;
using RepositoryModel.Entity;
using RepositoryModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Service
{
    public class UserRL:IUserRL
    {
        private readonly FundooContext fundooContext;
        public UserRL(FundooContext fundooContext)
        {
            this.fundooContext = fundooContext;
        }
      public UserEntity Registration(UserRegistrationModel userRegistrationModel)
        {
            try
            {
                UserEntity userEntity = new UserEntity();
                userEntity.FirstName = userRegistrationModel.FirstName; 
                userEntity.LastName = userRegistrationModel.LastName;
                userEntity.EmailID=userRegistrationModel.EmailID;
                userEntity.Password= userRegistrationModel.Password;
                fundooContext.UserTable.Add(userEntity);
                int result=fundooContext.SaveChanges();
                if (result > 0)
                {
                    return userEntity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
