using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TableStatusBusiness : IBusiness<TableStatus>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public TableStatusBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(TableStatus item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Masa Adı boş Geçilemez |TableStatus #Add +002 ");

                _uof.TableStatusRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi Başırılı");
                else
                    throw new Exception("Kayıt Yapılamadı");
            }
            return _boolResult;
        }

        public TableStatus Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID giriniz |TableStatus #Remove +002");
            return _uof.TableStatusRepository.GetByID(id);
        }

        public ICollection<TableStatus> GetAll()
        {
            return _uof.TableStatusRepository.GetAll();
        }

        public bool Remove(TableStatus item)
        {
            if (item != null)
            {
                _uof.TableStatusRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlmei Başırıyla yapıldı");
                else
                    throw new Exception("Silme işlemi yapılamadı");
            }
            else
                throw new Exception("Silmek için seçim yapmalısınız");
        }

        public bool Update(TableStatus item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Masa Id si boş geçilemez |TableStatus #Update +002");

                if (string.IsNullOrWhiteSpace(item.Name))
                    throw new Exception("Masa Adı boş Geçilemez |TableStatus #Update +002 ");

                _uof.TableStatusRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi Başırılı");
                else
                    throw new Exception("Update Yapılamadı");
            }
            return _boolResult;
        }
    }
}
