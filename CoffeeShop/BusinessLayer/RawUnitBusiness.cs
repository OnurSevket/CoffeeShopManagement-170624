using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RawUnitBusiness : IBusiness<RawUnit>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public RawUnitBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(RawUnit item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name Alanı Boş geçilemez |RawUnitBusiness #Add +002");

                _uof.RawUnitRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi  yapılamadı");
            }
            return _boolResult;
        }

        public RawUnit Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID değeri giriniz |RawUnitBusiness #remove +002");

            return _uof.RawUnitRepository.GetByID(id);
        }

        public ICollection<RawUnit> GetAll()
        {
            return _uof.RawUnitRepository.GetAll();
        }

        public bool Remove(RawUnit item)
        {
            if (item != null)
            {
                _uof.RawUnitRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Silme İşlemi başarıyla yapıldı");
                else
                    throw new Exception("silme işlmei yapılamadı");
            }
            else
                throw new Exception("Geçerli bir ID seçmediniz");

        }

        public bool Update(RawUnit item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("ID değeri Boş geçilemez |RawUnitBusiness #Update +002 ");

                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name Alanı Boş geçilemez |RawUnitBusiness #Update +002");

                _uof.RawUnitRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başarıyla yapıldı");
                else
                    throw new Exception("Update işlemi  yapılamadı");
            }
            return _boolResult;
        }
    }
}
