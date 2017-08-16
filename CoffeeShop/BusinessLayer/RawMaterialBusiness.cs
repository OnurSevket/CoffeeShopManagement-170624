using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RawMaterialBusiness : IBusiness<RawMaterial>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public RawMaterialBusiness()
        {
            _uof = new UnitOfWork();
        }


        public bool Add(RawMaterial item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |RawMaterialBusiness #Add +002");
                if (item.UnitsInStock < 0)
                    throw new Exception("geçerli bir değer Giriniz |RawMaterialBusiness #Add +002 ");
                if (item.RecorderedLevel < 0)
                    throw new Exception("geçerli bir değer Giriniz |RawMaterialBusiness #Add +002 ");
                if (item.SupplierID < 0)
                    throw new Exception("geçerli bir ID Giriniz |RawMaterialBusiness #Add +002 ");

                _uof.RawMaterialRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi Başarılı");
                else
                    throw new Exception("Kayıt işlemi Hatası !!");
            }
            return _boolResult;
        }

        public RawMaterial Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli ID değeri giriniz!!");

            return _uof.RawMaterialRepository.GetByID(id);
        }

        public ICollection<RawMaterial> GetAll()
        {
            return _uof.RawMaterialRepository.GetAll();
        }

        public bool Remove(RawMaterial item)
        {
            if (item != null)
            {
                _uof.RawMaterialRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Silme işlemi hatası");
            }
            else
                throw new Exception("ID değeri Giriniz!!");
        }

        public bool Update(RawMaterial item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("geçerli bir ID Giriniz |RawMaterialBusiness #Update +002 ");
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |RawMaterialBusiness #Update +002");
                if (item.UnitsInStock < 0)
                    throw new Exception("geçerli bir değer Giriniz |RawMaterialBusiness #Update +002 ");
                if (item.RecorderedLevel < 0)
                    throw new Exception("geçerli bir değer Giriniz |RawMaterialBusiness #Update +002 ");
                if (item.SupplierID < 0)
                    throw new Exception("geçerli bir ID Giriniz |RawMaterialBusiness #Update +002 ");

                _uof.RawMaterialRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi Başarılı");
                else
                    throw new Exception("Update işlemi Hatası !!");
            }
            return _boolResult;
        }
    }
}
