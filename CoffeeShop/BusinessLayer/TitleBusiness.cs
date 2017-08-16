using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TitleBusiness : IBusiness<Title>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public TitleBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Title item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Title Name Boş geçilemez |TitleBusiness #Add +002");

                _uof.TitleRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt İşlemi Başarılı");
                else
                    throw new Exception("Kayıt işlemi yapılamadı");

            }
            return _boolResult;
        }

        public Title Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli Bir ID girmediniz");

            return _uof.TitleRepository.GetByID(id);
        }

        public ICollection<Title> GetAll()
        {
            return _uof.TitleRepository.GetAll();
        }

        public bool Remove(Title item)
        {
            if (item != null)
            {
                _uof.TitleRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı |TitleBusiness #Remove +002");
                else
                    throw new Exception("Silme işlemi yapılamadı |TitleBusiness #Remove +002");
            }
            else
                throw new Exception("Silmek için seçim yapmalısın");
        }

        public bool Update(Title item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Title ID degeri boş geçilemez |TitleBusiness #Update +002");

                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Title Name Boş geçilemez |TitleBusiness #Update +002");

                _uof.TitleRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update İşlemi Başarılı");
                else
                    throw new Exception("Update işlemi yapılamadı");

            }
            return _boolResult;
        }
    }
}
