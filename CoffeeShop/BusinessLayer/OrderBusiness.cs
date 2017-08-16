using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderBusiness : IBusiness<Order>
    {
        UnitOfWork _uof;
        bool _boolResult;
        public OrderBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(Order item)
        {
            if (item !=null)
            {
                if (item.UserID < 0)
                    throw new Exception("Geçerli bir UserID giriniz |ORderBusiness #Add +002");
                if (item.ProductID < 0)
                    throw new Exception("Geçerli bir ProductID giriniz |ORderBusiness #Add +002");

                _uof.OrderRepository.Add(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("kayıt işlemi Başarıyla yapıldı");
                else
                    throw new Exception("Kayıt işlemi Hatası!!!");

            }
            return _boolResult;
        }

        public Order Get(int id)
        {
            if (id < 0)
                throw new Exception("Geçerli Bir ID degğeri giriniz.!");

            return _uof.OrderRepository.GetByID(id);
        }

        public ICollection<Order> GetAll()
        {
            return _uof.OrderRepository.GetAll();
        }

        public bool Remove(Order item)
        {
            if (item != null)
            {
                _uof.OrderRepository.Remove(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Silme işlemi başarıyla yapıldı");
                else
                    throw new Exception("Silme işlemi yapılamadı");
            }
            else
                throw new Exception("ID değeri Giriniz!!");
        }

        public bool Update(Order item)
        {
            if (item != null)
            {
                if (item.ID < 0)
                    throw new Exception("Geçerli bir rID giriniz |ORderBusiness #Update +002");
                if (item.UserID < 0)
                    throw new Exception("Geçerli bir UserID giriniz |ORderBusiness #Update +002");
                if (item.ProductID < 0)
                    throw new Exception("Geçerli bir ProductID giriniz |ORderBusiness #Update +002");

                _uof.OrderRepository.Update(item);
                _boolResult = _uof.ApplyChanges();

                if (_boolResult == true)
                    throw new Exception("Update işlemi Başarıyla yapıldı");
                else
                    throw new Exception("Update işlemi Hatası!!!");

            }
            return _boolResult;
        }
    }
}
