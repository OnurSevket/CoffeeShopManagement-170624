using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryBusiness : IBusiness<Category>
    {
       
        UnitOfWork _uof;
        Category _category;

        public CategoryBusiness()
        {
            _uof = new UnitOfWork();
        }

        public CategoryBusiness(Category category)
        {

            _category = category;
            _uof = new UnitOfWork();

        }



        // burdan sonrası tamamlandı
        bool _boolResult; 
        public bool Add(Category item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |CategoryBusiness #Update +002");
                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Description Alanı boş geçilemez |CategoryBusiness #Update +002");

                _uof.CategoryRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("kayıt işlemi başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi Hatası !!!!");
            }
            return _boolResult;
        }

        public Category Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID degeri giriniz");

            return _uof.CategoryRepository.GetByID(id);
        }

        public ICollection<Category> GetAll()
        {
            return _uof.CategoryRepository.GetAll();
        }

        public bool Remove(Category item)
        {
            if (item != null)
            {
                _uof.CategoryRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Silme işlemi Başarıyla yapıldı");
                else
                    throw new Exception("Silme işlemi Başarısız");

            }
            else
                throw new Exception("ID seçmelisiniz!!");
        }

        public bool Update(Category item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("ID alanı boş geçilemez |CategoryBusiness #Update +002");
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Name alanı boş geçilemez |CategoryBusiness #Update +002");
                if (string.IsNullOrWhiteSpace(item.Description))
                    throw new Exception("Description Alanı boş geçilemez |CategoryBusiness #Update +002");

                _uof.CategoryRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi başarıyla yapıldı");
                else
                    throw new Exception("Update işlemi Hatası !!!!");
            }
            return _boolResult;
        }
    }
}
