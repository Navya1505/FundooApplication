using CommonLayer;
using RepositoryModel.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModel.Interface
{
    public interface IUserRL
    {
        public UserEntity Registration(UserRegistrationModel userRegistrationModel);
    }
}
