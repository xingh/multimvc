﻿using System;
using BA.MultiMVC.Framework.Core.MultiMVC.Sample.Models.Domain;

namespace BA.MultiMVC.Framework.Core.MultiMVC.Sample.Models.Infrastructure
{
    public class UserRepository:IUserRepository 
    {
        string _client;

        #region public method

        public void Init(string client)
        {
            _client = client;
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        public void Load(string userName)
        {
            throw new NotImplementedException();
        }

        #endregion

        public string ConnectionString { get; set; }
    }
}
