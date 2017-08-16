using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FormulaBusiness : IBusiness<Formula>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public FormulaBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Formula item)
        {
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(item.UnitsInFormula))
                    throw new Exception("isim alanı boş geçilemez |FormulaBusiness #Add +002");
                if (item.RawID < 0)
                    throw new Exception("RawId boş geçilemez |FormulaBusiness #Add +002");
                if (item.ProductID < 0)
                    throw new Exception("ProductID boş Geçilemez |FormulaBusiness #Add +002");

                _uof.FormulaRepository.Add(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("kayır başarıyşa yapıldı");
                else
                    throw new Exception("kayıt yapılamadı");
            }
            return _boolResult;
        }

        public Formula Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli bir ID giriniz");
            return _uof.FormulaRepository.GetByID(id);
        }

        public ICollection<Formula> GetAll()
        {
            return _uof.FormulaRepository.GetAll();
        }

        public bool Remove(Formula item)
        {
            if (item != null)
            {
                _uof.FormulaRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                else
                    throw new Exception("silme işlemi yapılamadı");
            }
            else
                throw new Exception("ID seçiniz !!");
        }

        public bool Update(Formula item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("ID alanı boş geçilemez |FormulaBusiness #Update +002 ");
                if (string.IsNullOrWhiteSpace(item.UnitsInFormula))
                    throw new Exception("isim alanı boş geçilemez |FormulaBusiness #Update +002");
                if (item.RawID < 0)
                    throw new Exception("RawId boş geçilemez |FormulaBusiness #Update +002");
                if (item.ProductID < 0)
                    throw new Exception("ProductID boş Geçilemez |FormulaBusiness #Update +002");

                _uof.FormulaRepository.Update(item);
                _boolResult = _uof.ApplyChanges();
                if (_boolResult == true)
                    throw new Exception("Update başarıyşa yapıldı");
                else
                    throw new Exception("Update yapılamadı");
            }
            return _boolResult;
        }
    }
}
