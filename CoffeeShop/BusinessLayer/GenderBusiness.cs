using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GenderBusiness : IBusiness<Gender>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public GenderBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Gender item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |GenderBusiness #Add +002");

                _uof.GenderRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi yapılamadı");
            }
            return _boolResult;
        }

        public Gender Get(int id)
        {
            if (id < 0)
                throw new Exception("Bir ID değeri seçmelisin");
            return _uof.GenderRepository.GetByID(id);
        }

        public ICollection<Gender> GetAll()
        {
            return _uof.GenderRepository.GetAll();
        }

        public bool Remove(Gender item)
        {
            if (item != null)
            {
                _uof.GenderRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("silme işlmei başarıyla yaıldı");
                else
                    throw new Exception("silme işlemi yapılamadı");
            }
            else
                throw new Exception("Bir ID seçmelisiniz");
        }

        public bool Update(Gender item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("ID degeri Boş geçilemez |GenderBusiness #Update +002");
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |GenderBusiness #Update +002");

                _uof.GenderRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başarıyla yapıldı");
                else
                    throw new Exception("Update işlemi yapılamadı");
            }
            return _boolResult;
        }
    }
}
