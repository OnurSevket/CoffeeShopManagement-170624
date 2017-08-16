using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TableBusiness : IBusiness<Table>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public TableBusiness()
        {
            _uof = new UnitOfWork();
        }
        public bool Add(Table item)
        {
            if (item != null)
            {
                if (item.TableStatusID < 0)
                    throw new Exception("TableStatus  ID boş geçilemez |Table #Add +002 ");

                _uof.TableRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Kayıt işlemi Başarılı");
                else
                    throw new Exception("Kayıt yapılamadı");
            }
            return _boolResult;
        }

        public Table Get(int id)
        {
            if (id < 0)
                throw new Exception("geçerli bir id Giriniz.");

            return _uof.TableRepository.GetByID(id);
        }

        public ICollection<Table> GetAll()
        {
            return _uof.TableRepository.GetAll();
        }

        public bool Remove(Table item)
        {
            if (item != null)
            {
                _uof.TableRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlmei başarılı");
                else
                    throw new Exception("Silme işlmei yapılamadı");
            }
            else
                throw new Exception("Silmek için Seçim Yapmalısın");
        }

        public bool Update(Table item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Table Id Boş geçilemez |Table #Update +002");

                if (item.TableStatusID < 0)
                    throw new Exception("TableStatus  ID boş geçilemez |Table #Update +002 ");

                _uof.TableRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi Başarılı");
                else
                    throw new Exception("Update yapılamadı");
            }
            return _boolResult;
        }
    }
}
