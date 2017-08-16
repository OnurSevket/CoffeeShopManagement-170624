using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness : IBusiness<Product>
    {
        UnitOfWork _uof;
        bool _boolResult;

        public ProductBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Product item)
        {
            if(item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("isim alanı boşgeçilemez |ProductBusiness #Add +002 ");
                if(string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Description alanı boşgeçilemez |ProductBusiness #Add +002 ");
                if(item.CategoryID <0)
                    throw new Exception("CategoryID alanı boşgeçilemez |ProductBusiness #Add +002 ");
                if(item.Price < 0)
                    throw new Exception("Ücret alanı boşgeçilemez |ProductBusiness #Add +002 ");

                _uof.ProductRepository.Add(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi  yapılamadı");

            }
            return _boolResult;
        }

        public Product Get(int id)
        {
            if (id < 0)
                throw new Exception("ID Boş geçilemez");

            return _uof.ProductRepository.GetByID(id);
        }

        public ICollection<Product> GetAll()
        {
            return _uof.ProductRepository.GetAll();
        }

        public bool Remove(Product item)
        {
            if (item != null)
            {
                _uof.ProductRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarılı");
                else
                    throw new Exception("Silme işlemi yapılamadı");
            }
            else
                throw new Exception("ID seçmelisiniz");
        }

        public bool Update(Product item)
        {
            if (item != null)
            {
                if(item.ID <0)
                    throw new Exception("ID alanı boşgeçilemez |ProductBusiness #Update +002 ");
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("isim alanı boşgeçilemez |ProductBusiness #Update +002 ");
                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Description alanı boşgeçilemez |ProductBusiness #Update +002 ");
                if (item.CategoryID < 0)
                    throw new Exception("CategoryID alanı boşgeçilemez |ProductBusiness #Update +002 ");
                if (item.Price < 0)
                    throw new Exception("Ücret alanı boşgeçilemez |ProductBusiness #Update +002 ");

                _uof.ProductRepository.Update(item);
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
