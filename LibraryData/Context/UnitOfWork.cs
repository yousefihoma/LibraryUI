using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryData.Repository.RepositoryImp;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryData.Context
{
    public class UnitOfWork
    {
        Library1Entities db = new Library1Entities();

        private GenericRepositoryLibrary<Members> _memberRepository;
        public GenericRepositoryLibrary<Members> MemberRepository
        {
            get
            {
                if (_memberRepository == null)
                {
                    _memberRepository = new GenericRepositoryLibrary<Members>(db);
                }

                return _memberRepository;
            }
        }
        //****************************************************************
        private GenericRepositoryLibrary<Users> _loginRepository;

        public GenericRepositoryLibrary<Users> LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new GenericRepositoryLibrary<Users>(db);
                }

                return _loginRepository;
            }
        }

        //  ---------------------------------------------------------
        private GenericRepositoryLibrary<Books> _bookRepository;
        public GenericRepositoryLibrary<Books> BookRepository
        {
            get
            {
                if (_bookRepository == null)
                {
                    _bookRepository = new GenericRepositoryLibrary<Books>(db);
                }

                return _bookRepository;
            }
        }

        private GenericRepositoryLibrary<Borrow> _borrowRepository;
        public GenericRepositoryLibrary<Borrow> BorrowRepository
        {
            get
            {
                if (_borrowRepository == null)
                {
                    _borrowRepository = new GenericRepositoryLibrary<Borrow>(db);
                }

                return _borrowRepository;
            }
        }




        private GenericRepositoryLibrary<UserPermissions> _userPermission;
        public GenericRepositoryLibrary<UserPermissions> UserPermission
        {
            get
            {
                if (_userPermission == null)
                {
                    _userPermission = new GenericRepositoryLibrary<UserPermissions>(db);
                }

                return _userPermission;
            }
        }



        private GenericRepositoryLibrary<Permissions> _permission;
        public GenericRepositoryLibrary<Permissions> Permission
        {
            get
            {
                if (_permission == null)
                {
                    _permission = new GenericRepositoryLibrary<Permissions>(db);
                }

                return _permission;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }
    }
}
