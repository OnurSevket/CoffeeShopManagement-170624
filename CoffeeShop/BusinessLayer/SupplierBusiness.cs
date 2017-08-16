using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SupplierBusiness : IBusiness<Supplier>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public SupplierBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Supplier item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.CompanyName))
                    throw new Exception("Şirket Adı Boş Geçilemez |Supplier #Add +002");

                if (string.IsNullOrWhiteSpace(item.ContactName))
                    throw new Exception("Contact Name Boş geçilemez |Supplier #Add +002 ");
                if (string.IsNullOrWhiteSpace(item.Phone))
                    throw new Exception("Phone Number Boş Geçilemez |Supplier #Add +002");
                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email Boş Geçilemez |Supplier #Add +002");

                _uof.SupplierRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("kayıt işlemi başırı ile tamamlandı");
                else
                    throw new Exception("Kayıt işlemi yapılamadı");

            }
            return _boolResult;
        }

        public Supplier Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir id numarası giriniz");

            return _uof.SupplierRepository.GetByID(id);
        }

        public ICollection<Supplier> GetAll()
        {
            return _uof.SupplierRepository.GetAll();
        }

        public bool Remove(Supplier item)
        {
            if (item != null)
            {
                _uof.SupplierRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("silme işlemi başarılı");
                else
                    throw new Exception("silme işlemi yapılmadı ");
            }
            else
                throw new Exception("Silmek için seçim yapınız");
        }

        public bool Update(Supplier item)
        {
            if (item != null)
            {
                if (item.ID < 1)
                    throw new Exception("Geçerli bir İd değeri Giriniz |Supplier#Update +002  ");

                if (string.IsNullOrWhiteSpace(item.CompanyName))
                    throw new Exception("Şirket Adı Boş Geçilemez |Supplier #Update +002");

                if (string.IsNullOrWhiteSpace(item.ContactName))
                    throw new Exception("Contact Name Boş geçilemez |Supplier#Update +002 ");
                if (string.IsNullOrWhiteSpace(item.Phone))
                    throw new Exception("Phone Number Boş Geçilemez |Supplier #Update +002");
                if (string.IsNullOrWhiteSpace(item.Email))
                    throw new Exception("Email Boş Geçilemez |Supplier #Update +002");

                _uof.SupplierRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başırı ile tamamlandı");
                else
                    throw new Exception("Update işlemi yapılamadı");

            }
            return _boolResult;
        }
    }
}
