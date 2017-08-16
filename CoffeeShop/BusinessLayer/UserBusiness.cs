using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusiness : IBusiness<User>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public UserBusiness()
        {
            _uof = new UnitOfWork();
        }


        public bool Add(User item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.FirstName))
                    throw new Exception("İsim Boşgeçilemez |User #Add +002");
                if (string.IsNullOrWhiteSpace(item.LastName))
                    throw new Exception("Soyisim Boş geçilemez |User #Add +002");
                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email alanı bpş geçilemez |User #Add +002");
                if (item.DateOfBirth == null)
                    throw new Exception("Dopum tarihi boş geçilemez |User #Add +002");
                if (item.GenderID < 0)
                    throw new Exception("Cinsiyet Boş geçilemez |User #Add +002 ");
                if (item.TitleID < 0)
                    throw new Exception("Title Id Boş geçilemez |User #Add +002");
                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("UserName alanı Boş geçilemez |User #Add +002");
                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Password alanı Boş geçilemez |User #Add +002");

                _uof.UserRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi  yapılamadı");

            }
            return _boolResult;
        }

        public User Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID degeri girmediniz!!");

            return _uof.UserRepository.GetByID(id);
        }

        public ICollection<User> GetAll()
        {
            return _uof.UserRepository.GetAll();
        }

        public bool Remove(User item)
        {
            if (item != null)
            {
                _uof.UserRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Silme İşlemi Yapılamadı");
            }
            else
                throw new Exception("Silmek için ID seçmelisin");
        }

        public bool Update(User item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Bir ID seçiniz |User #Update +002");
                if (string.IsNullOrWhiteSpace(item.FirstName))
                    throw new Exception("İsim Boşgeçilemez |User #Update +002");
                if (string.IsNullOrWhiteSpace(item.LastName))
                    throw new Exception("Soyisim Boş geçilemez |User #Update +002");
                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email alanı bpş geçilemez |User #Update +002");
                if (item.DateOfBirth == null)
                    throw new Exception("Dopum tarihi boş geçilemez |User #Update +002");
                if (item.GenderID < 0)
                    throw new Exception("Cinsiyet Boş geçilemez |User #Update +002 ");
                if (item.TitleID < 0)
                    throw new Exception("Title Id Boş geçilemez |User #Update +002");
                if (string.IsNullOrWhiteSpace(item.UserName))
                    throw new Exception("UserName alanı Boş geçilemez |User #Update +002");
                if (string.IsNullOrWhiteSpace(item.Password))
                    throw new Exception("Password alanı Boş geçilemez |User #Update +002");

                _uof.UserRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başarıyla yapıldı");
                else
                    throw new Exception("Update işlemi  yapılamadı");

            }
            return _boolResult;
        }


        //Parola ve Username için alan
        public User GetUserByPassword(string userName, string password)
        {
            ICollection<User> userList = GetAll();

            var userLi = (from u in userList
                          where userName == u.UserName && password == u.Password
                          select u).SingleOrDefault();
            //TODO:Boş gelirse kontrolu ?
            if (userLi!=null)
            {
                return userLi;
            }
            else
            {
                throw new Exception("Kullanıcı Adı veya Parola'nızı Hatalı girdiniz");
            }


        }
    }
}
