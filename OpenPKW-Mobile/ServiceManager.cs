﻿using OpenPKW_Mobile.Entities;
using OpenPKW_Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPKW_Mobile
{
    /// <summary>
    /// Menadżer usług udostępnionych przez zewnętrzne aplikacje.
    /// </summary>
    class ServiceManager
    {
        #region Singleton
        private static ServiceManager _instance = null;
        public static ServiceManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServiceManager();
                return _instance;
            }
        }

        private ServiceManager()
        {

        }
        #endregion

        /// <summary>
        /// Udostępnienie serwisu logowania.
        /// </summary>
        private ILoginService _login = null;
        public ILoginService Login
        {
            get
            {
                if (_login == null)
                    _login = ServiceFactory.Login;
                return _login;
            }
        }

        /// <summary>
        /// Udostępnienie serwisu głosowania.
        /// </summary>
        private IVotingService _voting = null;
        public IVotingService Voting
        {
            get
            {
                if (_voting == null)
                    _voting = ServiceFactory.Voting;
                return _voting;
            }
        }

        /// <summary>
        /// Udostępnienie serwisu obsługi zdjęć.
        /// </summary>
        private IPhotoService _photo = null;
        public IPhotoService Photo
        {
            get
            {
                if (_photo == null)
                    _photo = ServiceFactory.Photo;
                return _photo;
            }
        }

        /// <summary>
        /// Bieżący użytkownik aplikacji.
        /// </summary>
        public UserEntity CurrentUser { get; set; }
    }
}
