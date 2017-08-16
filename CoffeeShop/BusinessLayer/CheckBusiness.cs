using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CheckBusiness : IBusiness<Check>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public CheckBusiness()
        {
            _uof = new UnitOfWork();
        }


        public bool Add(Check item)
        {
            if (item != null)
            {
                if (item.Fee < 0)
                    throw new Exception("geçerli bir para degeri Giriniz |CheckBusiness #Add +002");
                if (item.TableID < 0)
                    throw new Exception("Masa ID si giriniz |CheckBusiness #Add +002");

                _uof.CheckRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarılı ");
                else
                    throw new Exception("kayıt Yapılamadı");
            }
            return _boolResult;
        }

        public Check Get(int id)
        {
            if (id < 0)
                throw new Exception("geçerli bir ID giriniz");
            return _uof.CheckRepository.GetByID(id);
        }

        public ICollection<Check> GetAll()
        {
            return _uof.CheckRepository.GetAll();
        }

        public bool Remove(Check item)
        {
            if (item != null)
            {
                _uof.CheckRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi Başarıyla yapıldı");
                else
                    throw new Exception("Kayıt yapılamadı");
            }
            else
                throw new Exception("ID değeri giriniz");
        }

        public bool Update(Check item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Geçerli bir ID değeri giriniz");
                if (item.Fee < 0)
                    throw new Exception("geçerli bir para degeri Giriniz |CheckBusiness #Update +002");
                if (item.TableID < 0)
                    throw new Exception("Masa ID si giriniz |CheckBusiness #Update +002");

                _uof.CheckRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başarılı ");
                else
                    throw new Exception("Update Yapılamadı");
            }
            return _boolResult;
        }
    }
}
